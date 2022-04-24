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

        private void btnGeneruj_Click(object sender, EventArgs e)
        {

            int pracownikID = int.Parse(cbPracownik.SelectedValue.ToString());
            var czasOd = dtpCzasOd.Value.Date;
            var czasDo = dtpCzasDo.Value.Date;

            System.Linq.IQueryable vProcWytPolprodukt = db.v_Proces_wytwarzanie_polprodukt_ewidencja.Where(a => a.ID_pracownik == pracownikID && a.Data_rozpoczęcia >= czasOd && a.Data_zakończenia <= czasDo);
            int vPracownikIdIntPro = vProcWytPolprodukt.Cast<v_Proces_wytwarzanie_polprodukt_ewidencja>().Where(a => a.ID_pracownik > 0).Count();
            if (vPracownikIdIntPro > 0)
            {
                dgvWytwarzaniePolprodukt.DataSource = vProcWytPolprodukt.Cast<v_Proces_wytwarzanie_polprodukt_ewidencja>().ToList();
                dgvWytwarzaniePolprodukt.Columns["ID"].Visible = false;
                dgvWytwarzaniePolprodukt.Columns["ID_pracownik"].Visible = false;
                dgvWytwarzaniePolprodukt.Columns["Pracownik"].Visible = false;
                dgvWytwarzaniePolprodukt.Columns["Szacowany_czas__min_"].Visible = false;
                dgvWytwarzaniePolprodukt.Columns["Czynność_produkcyjna"].HeaderText = "Czynność";
                dgvWytwarzaniePolprodukt.Columns["Data_rozpoczęcia"].HeaderText = "Rozpoczęcie";
                dgvWytwarzaniePolprodukt.Columns["Data_zakończenia"].HeaderText = "Zakończenie";
                dgvWytwarzaniePolprodukt.Columns["Czas_pracy"].HeaderText = "Czas";
                this.dgvWytwarzaniePolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                refreshScreen();

            }
            else
            {
                MessageBox.Show("Pracownik nie wykonywał procesu produkcyjnego na półprodukcie w tym okresie czasu.");
                refreshScreen();
            }
            
            System.Linq.IQueryable vProcWytProdukt = db.v_Proces_wytwarzanie_produkt_ewidencja.Where(a => a.ID_pracownik == pracownikID && a.Data_rozpoczęcia >= czasOd && a.Data_zakończenia <= czasDo);
            int vPracownikIdIntPol = vProcWytProdukt.Cast<v_Proces_wytwarzanie_produkt_ewidencja>().Where(a => a.ID_pracownik > 0).Count();
            if (vPracownikIdIntPol > 0)
            {
                dgvWytwarzanieProdukt.DataSource = vProcWytProdukt.Cast<v_Proces_wytwarzanie_produkt_ewidencja>().ToList();
                dgvWytwarzanieProdukt.Columns["ID"].Visible = false;
                dgvWytwarzanieProdukt.Columns["ID_pracownik"].Visible = false;
                dgvWytwarzanieProdukt.Columns["Pracownik"].Visible = false;
                dgvWytwarzanieProdukt.Columns["Szacowany_czas__min_"].Visible = false;
                dgvWytwarzanieProdukt.Columns["Czynność_produkcyjna"].HeaderText = "Czynność";
                dgvWytwarzanieProdukt.Columns["Data_rozpoczęcia"].HeaderText = "Rozpoczęcie";
                dgvWytwarzanieProdukt.Columns["Data_zakończenia"].HeaderText = "Zakończenie";
                dgvWytwarzanieProdukt.Columns["Czas_pracy"].HeaderText = "Czas";
                this.dgvWytwarzanieProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                refreshScreen();

            }
            else
            {
                MessageBox.Show("Pracownik nie wykonywał procesu produkcyjnego na produkcie w tym okresie czasu.");
                refreshScreen();
            }


        }
    }
}
