using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2022
{
    public partial class FormCzasPracyProdukcja : Form
    {
        KWZPEntities db;
        public FormCzasPracyProdukcja(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            refreshScreen();
        }

        private void refreshScreen()
        {
            initComboboxPracowicyProdukcji();
        }

        private void initComboboxPracowicyProdukcji()
        {
            cbPracownik.DataSource = db.v_Pracownik_produkcja.ToList();
            cbPracownik.ValueMember = "ID_pracownik";
            cbPracownik.DisplayMember = "Pracownik";

        }

        private void getHoursSum()
        {
            int polproduktSum = dgvWytwarzaniePolprodukt.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[9].Value));

            int produktSum = dgvWytwarzanieProdukt.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[9].Value));

            decimal finalSum = Math.Round((Convert.ToDecimal(polproduktSum + produktSum))/60,2);
            lblSum.Text = finalSum.ToString() + ' ' + 'h';
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {

            int pracownikID = int.Parse(cbPracownik.SelectedValue.ToString());
            dgvWytwarzaniePolprodukt.DataSource = null;
          
            List<v_Proces_wytwarzanie_polprodukt_ewidencja> procWytPolproduktList = db.v_Proces_wytwarzanie_polprodukt_ewidencja.Where(a => a.ID_pracownik == pracownikID && a.Data_rozpoczęcia >= dtpCzasOd.Value.Date && a.Data_zakończenia <= dtpCzasDo.Value.Date).ToList();
            int vPracownikIdIntPro = procWytPolproduktList.Where(a => a.ID_pracownik > 0).Count();
            if (vPracownikIdIntPro > 0)
            {
                dgvWytwarzaniePolprodukt.DataSource = procWytPolproduktList;
                dgvWytwarzaniePolprodukt.Columns["ID"].Visible = false;
                dgvWytwarzaniePolprodukt.Columns["ID_pracownik"].Visible = false;
                dgvWytwarzaniePolprodukt.Columns["Pracownik"].Visible = false;
                dgvWytwarzaniePolprodukt.Columns["Szacowany_czas__min_"].Visible = false;
                dgvWytwarzaniePolprodukt.Columns["Czynność_produkcyjna"].HeaderText = "Czynność";
                dgvWytwarzaniePolprodukt.Columns["Data_rozpoczęcia"].HeaderText = "Rozpoczęcie";
                dgvWytwarzaniePolprodukt.Columns["Data_zakończenia"].HeaderText = "Zakończenie";
                dgvWytwarzaniePolprodukt.Columns["Czas_pracy"].HeaderText = "Czas";
                this.dgvWytwarzaniePolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            }
            else
            {
                dgvWytwarzanieProdukt.DataSource = null;
                MessageBox.Show("Pracownik nie wykonywał procesu produkcyjnego na półprodukcie w tym okresie czasu.");
                refreshScreen();
            }

            dgvWytwarzanieProdukt.DataSource = null;
            List<v_Proces_wytwarzanie_produkt_ewidencja> procWytProduktList = db.v_Proces_wytwarzanie_produkt_ewidencja.Where(a => a.ID_pracownik == pracownikID && a.Data_rozpoczęcia >= dtpCzasOd.Value.Date && a.Data_zakończenia <= dtpCzasDo.Value.Date).ToList();
            int vPracownikIdIntPol = procWytProduktList.Where(a => a.ID_pracownik > 0).Count();
            if (vPracownikIdIntPol > 0)
            {
                dgvWytwarzanieProdukt.DataSource = procWytProduktList;
                dgvWytwarzanieProdukt.Columns["ID"].Visible = false;
                dgvWytwarzanieProdukt.Columns["ID_pracownik"].Visible = false;
                dgvWytwarzanieProdukt.Columns["Pracownik"].Visible = false;
                dgvWytwarzanieProdukt.Columns["Szacowany_czas__min_"].Visible = false;
                dgvWytwarzanieProdukt.Columns["Czynność_produkcyjna"].HeaderText = "Czynność";
                dgvWytwarzanieProdukt.Columns["Data_rozpoczęcia"].HeaderText = "Rozpoczęcie";
                dgvWytwarzanieProdukt.Columns["Data_zakończenia"].HeaderText = "Zakończenie";
                dgvWytwarzanieProdukt.Columns["Czas_pracy"].HeaderText = "Czas";
                this.dgvWytwarzanieProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            }
            else
            {
                dgvWytwarzanieProdukt.DataSource = null;
                MessageBox.Show("Pracownik nie wykonywał procesu produkcyjnego na żadnym produkcie w tym okresie czasu.");
                refreshScreen();
            }

            getHoursSum();


        }
    }
}
