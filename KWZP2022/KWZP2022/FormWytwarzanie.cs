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
    public partial class FormWytwarzanie : Form
    {
        KWZPEntities db;
        public FormWytwarzanie(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initComboboxPracowicyProdukcji();
            initComboboxStanowisko();
            initComboboxZamowienie();
            refreshScreen();
        }

        private void refreshScreen()
        {
            initDataGridViewWytwarzaniePolprodukt();
            initDataGridViewWytwarzanieProdukt();
            initDataGridViewProcesPolprodukt();
        }

        private void initDataGridViewWytwarzaniePolprodukt()
        {
            dgvWytwarzaniePolprodukt.DataSource = db.v_Proces_wytwarzanie_polprodukt.ToList();
            dgvWytwarzaniePolprodukt.Columns["Czynność_produkcyjna"].Visible = false;
            dgvWytwarzaniePolprodukt.Columns["Szacowany_czas__min_"].Visible = false;
            dgvWytwarzaniePolprodukt.Columns["ID_stanowisko_produkcyjne"].HeaderText = "Stanowisko";
            dgvWytwarzaniePolprodukt.Columns["Data_rozpoczęcia"].HeaderText = "Rozpoczęcie";
            dgvWytwarzaniePolprodukt.Columns["Data_zakończenia"].HeaderText = "Zakończenie";
            this.dgvWytwarzaniePolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewWytwarzanieProdukt()
        {
            dgvWytwarzanieProdukt.DataSource = db.v_Proces_wytwarzanie_produkt.ToList();
            dgvWytwarzanieProdukt.Columns["Szacowany_czas__min_"].Visible = false;
            dgvWytwarzanieProdukt.Columns["Czynność_produkcyjna"].Visible = false;
            dgvWytwarzanieProdukt.Columns["ID_stanowisko_produkcyjne"].HeaderText = "Stanowisko";
            dgvWytwarzanieProdukt.Columns["Data_rozpoczęcia"].HeaderText = "Rozpoczęcie";
            dgvWytwarzanieProdukt.Columns["Data_zakończenia"].HeaderText = "Zakończenie";
            this.dgvWytwarzanieProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewZamowienieSzczegol()
        {
            dgvZamowienieSzczegol.DataSource = db.v_Zamowienie_szczegol_produkcja.ToList();
 
            this.dgvWytwarzanieProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewProcesPolprodukt()
        {
            dgvProcesPolprodukt.DataSource = db.v_Proces_polprodukt_czynnosc.ToList();
            this.dgvProcesPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewProcesProdukt()
        {
            dgvProcesProdukt.DataSource = db.v_Proces_produkt_czynnosc.ToList();
            this.dgvProcesProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initComboboxPracowicyProdukcji()
        {
            cbPracownik.DataSource = db.v_Pracownik_produkcja.ToList();
            cbPracownik.ValueMember = "ID_pracownik";
            cbPracownik.DisplayMember = "Pracownik";

        }

        private void initComboboxStanowisko()
        {
            cbStanowisko.DataSource = db.v_Stanowiska_do_uzycia.ToList();
            cbStanowisko.ValueMember = "ID_stanowisko_produkcyjne";
            cbStanowisko.DisplayMember = "Nazwa";
            
        }

        private void initComboboxZamowienie()
        {
            cbZamowienie.DataSource = db.v_Zamowienie_produkcja.ToList();
            cbZamowienie.ValueMember = "ID";
            cbZamowienie.DisplayMember = "Klient";

        }

        private void enterIdOrder()
        {
            string zamowienie = cbZamowienie.SelectedValue.ToString();
            int zamowienieID = int.Parse(zamowienie);
            System.Linq.IQueryable vOrderId = db.v_Zamowienie_szczegol_produkcja.Where(a => a.ID == zamowienieID);
            int vOrderIdInt = vOrderId.Cast<v_Zamowienie_szczegol_produkcja>().Where(a => a.ID > 0).Count();
            if (vOrderIdInt > 0)
            {
                dgvZamowienieSzczegol.DataSource = vOrderId.Cast<v_Zamowienie_szczegol_produkcja>().ToList();

                refreshScreen();
            }
            else
            {
                refreshScreen();
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            enterIdOrder();
        }


        private void dgvZamowienieSzczegol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSzukanyProduktID.Text = dgvZamowienieSzczegol.CurrentRow.Cells[1].Value.ToString();
            txtSzukanyProduktNazwa.Text = dgvZamowienieSzczegol.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            string produktID = txtSzukanyProduktID.Text;
            int produktIDint = int.Parse(produktID);

            System.Linq.IQueryable vProdukt = db.v_Proces_produkt_czynnosc.Where(a => a.ID_Produktu == produktIDint);
            int vOrderIdInt = vProdukt.Cast<v_Proces_produkt_czynnosc>().Where(a => a.ID_Produktu > 0).Count();
            if (vOrderIdInt > 0)
            {
                dgvProcesProdukt.DataSource = vProdukt.Cast<v_Proces_produkt_czynnosc>().ToList();

                refreshScreen();
            }
            else
            {
                refreshScreen();
            }
        }
    }
}
