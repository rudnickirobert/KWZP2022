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
            refreshComboboxes();
            refreshScreen();
        }

        private void refreshScreen()
        {
            initDataGridViewWytwarzaniePolprodukt();
            initDataGridViewWytwarzanieProdukt();
            dtpCzasOd.ShowUpDown = true;
            dtpCzasDo.ShowUpDown = true;
        }

        private void refreshComboboxes()
        {
            initComboboxPracowicyProdukcji();
            initComboboxStanowisko();
            initComboboxZamowienie();
        }

        private void initDataGridViewWytwarzaniePolprodukt()
        {
            dgvWytwarzaniePolprodukt.DataSource = db.v_Proces_wytwarzanie_polprodukt.ToList();
            dgvWytwarzaniePolprodukt.Columns["Czynność_produkcyjna"].Visible = false;
            dgvWytwarzaniePolprodukt.Columns["Szacowany_czas__min_"].Visible = false;
            dgvWytwarzaniePolprodukt.Columns["Stanowisko"].HeaderText = "Stanowisko";
            dgvWytwarzaniePolprodukt.Columns["Data_rozpoczęcia"].HeaderText = "Rozpoczęcie";
            dgvWytwarzaniePolprodukt.Columns["Data_zakończenia"].HeaderText = "Zakończenie";
            this.dgvWytwarzaniePolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewWytwarzanieProdukt()
        {
            dgvWytwarzanieProdukt.DataSource = db.v_Proces_wytwarzanie_produkt.ToList();
            dgvWytwarzanieProdukt.Columns["Szacowany_czas__min_"].Visible = false;
            dgvWytwarzanieProdukt.Columns["Czynność_produkcyjna"].Visible = false;
            dgvWytwarzanieProdukt.Columns["Stanowisko"].HeaderText = "Stanowisko";
            dgvWytwarzanieProdukt.Columns["Data_rozpoczęcia"].HeaderText = "Rozpoczęcie";
            dgvWytwarzanieProdukt.Columns["Data_zakończenia"].HeaderText = "Zakończenie";
            this.dgvWytwarzanieProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            int vProduktIdInt = vProdukt.Cast<v_Proces_produkt_czynnosc>().Where(a => a.ID_Produktu > 0).Count();
            if (vProduktIdInt > 0)
            {
                dgvProcesProdukt.DataSource = vProdukt.Cast<v_Proces_produkt_czynnosc>().ToList();
                this.dgvProcesProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                refreshScreen();
                
            }
            else
            {
                refreshScreen();
            }

            System.Linq.IQueryable vPolprodukt = db.v_Proces_polprodukt_czynnosc.Where(a => a.ID_Produktu == produktIDint);
            int vPolproduktIdInt = vPolprodukt.Cast<v_Proces_polprodukt_czynnosc>().Where(a => a.ID_Produktu > 0).Count();
            if (vProduktIdInt > 0)
            {
                dgvProcesPolprodukt.DataSource = vPolprodukt.Cast<v_Proces_polprodukt_czynnosc>().ToList();
                dgvProcesPolprodukt.Columns["ID_produktu"].Visible = false;
                this.dgvProcesPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                refreshScreen();
            }
            else
            {
                refreshScreen();
            }

            refreshComboboxes();
        }

        private void dgvProcesProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWybranyID.Text = dgvProcesProdukt.CurrentRow.Cells[0].Value.ToString();
            txtWybrany.Text = dgvProcesProdukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvProcesPolprodukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWybranyID.Text = dgvProcesPolprodukt.CurrentRow.Cells[0].Value.ToString();
            txtWybrany.Text = dgvProcesPolprodukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            Wytwarzanie wytwarzanie = new Wytwarzanie();
            wytwarzanie.ID_pracownik = int.Parse(cbPracownik.SelectedValue.ToString());

            if (dgvZamowienieSzczegol.Rows.Count == 0)
            {
                MessageBox.Show("Wybierz zamówienie dla którego chcesz opracować proces produkcyjny");
            }
            else
            {
                wytwarzanie.ID_zamowienie_szczegol = int.Parse(dgvZamowienieSzczegol.CurrentRow.Cells[4].Value.ToString());
                wytwarzanie.Czas_od = dtpDataOd.Value.Date + dtpCzasOd.Value.TimeOfDay;
                wytwarzanie.Czas_do = dtpDataDo.Value.Date + dtpCzasDo.Value.TimeOfDay;
                db.Wytwarzanie.Add(wytwarzanie);
                db.SaveChanges();

                int wytwarzanieID = (from n in db.Wytwarzanie orderby n.ID_wytwarzanie descending select n.ID_wytwarzanie).FirstOrDefault();
                if (txtWybrany.Text == dgvProcesProdukt.CurrentRow.Cells[1].Value.ToString())
                {
                    Proces_wytwarzanie_produkt wytwarzanieProdukt = new Proces_wytwarzanie_produkt();
                    wytwarzanieProdukt.ID_wytwarzanie = wytwarzanieID;
                    wytwarzanieProdukt.ID_proces_produkt = int.Parse(dgvProcesProdukt.CurrentRow.Cells[3].Value.ToString());
                    wytwarzanieProdukt.ID_stanowisko_produkcyjne = int.Parse(cbStanowisko.SelectedValue.ToString());

                    db.Proces_wytwarzanie_produkt.Add(wytwarzanieProdukt);
                    db.SaveChanges();
                    refreshScreen();
                    MessageBox.Show("Poprawnie dodano Proces wytwarzania dla PRODUKTU.");

                }
                else if (txtWybrany.Text == dgvProcesPolprodukt.CurrentRow.Cells[1].Value.ToString())
                {
                    Proces_wytwarzanie_polprodukt wytwarzaniePolprodukt = new Proces_wytwarzanie_polprodukt();
                    wytwarzaniePolprodukt.ID_wytwarzanie = wytwarzanieID;
                    wytwarzaniePolprodukt.ID_proces_polprodukt = int.Parse(dgvProcesPolprodukt.CurrentRow.Cells[4].Value.ToString());
                    wytwarzaniePolprodukt.ID_stanowisko_produkcyjne = int.Parse(cbStanowisko.SelectedValue.ToString());

                    db.Proces_wytwarzanie_polprodukt.Add(wytwarzaniePolprodukt);
                    db.SaveChanges();
                    refreshScreen();
                    MessageBox.Show("Poprawnie dodano proces wytwarzania dla PÓŁPRODUKTU.");
                }
                else
                {
                    MessageBox.Show("Wybierz produkt lub półprodukt");
                }
            }
            refreshComboboxes();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            refreshScreen();
            refreshComboboxes();
        }
    }
}
