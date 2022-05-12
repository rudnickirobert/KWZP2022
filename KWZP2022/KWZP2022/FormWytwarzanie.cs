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
            cbStanowisko.DataSource = db.v_Stanowiska_produkcyjne.ToList();
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
            List<v_Zamowienie_szczegol_produkcja> vOrderId = db.v_Zamowienie_szczegol_produkcja.Where(a => a.ID == zamowienieID).ToList();
            int vOrderIdInt = vOrderId.Count();
            if (vOrderIdInt > 0)
            {
                dgvZamowienieSzczegol.DataSource = vOrderId;
                dgvZamowienieSzczegol.Columns["ID"].HeaderText = "ID zamówienia";

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
            txtGenerowanaIlosc.Text = dgvZamowienieSzczegol.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            string produktID = txtSzukanyProduktID.Text;
            try
            {
                int produktIDint = int.Parse(produktID);
                List<v_Proces_produkt_czynnosc> vProdukt = db.v_Proces_produkt_czynnosc.Where(a => a.ID_Produktu == produktIDint).ToList();
                int vProduktIdInt = vProdukt.Count();
                if (vProduktIdInt > 0)
                {
                    dgvProcesProdukt.DataSource = vProdukt;
                    this.dgvProcesProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                    refreshScreen();

                }
                else
                {
                    refreshScreen();
                }

                List<v_Proces_polprodukt_czynnosc> vPolprodukt = db.v_Proces_polprodukt_czynnosc.Where(a => a.ID_Produktu == produktIDint).ToList();
                int vPolproduktIdInt = vPolprodukt.Count();
                if (vProduktIdInt > 0)
                {
                    dgvProcesPolprodukt.DataSource = vPolprodukt;
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
            catch (Exception)
            {
                MessageBox.Show("Wybierz produkt, który chcesz wytwarzać.");
            }

           
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

        private void btnGenerujPolprodukt_Click(object sender, EventArgs e)
        {
            int iloscWytwarzanieProdukt = 0;
            int iloscWytwarzaniePolprodukt = 0;
            DateTime dateTimeNow = dtpDataOd.Value.Date + dtpCzasOd.Value.TimeOfDay;

            if (dgvZamowienieSzczegol.DataSource != null && dgvProcesPolprodukt.DataSource != null)
            {
                int iloscProduktZamowienie = int.Parse(txtGenerowanaIlosc.Text);
                int iloscWierszyDgvPolprodut = int.Parse(dgvProcesPolprodukt.RowCount.ToString());
                int obecnyProdukt = int.Parse(txtSzukanyProduktID.Text);

                for (int i = 0; i <= iloscWierszyDgvPolprodut - 1; i++)
                {
                    int obecnyPolprodukt = int.Parse(dgvProcesPolprodukt.Rows[i].Cells[0].Value.ToString());
                    List<v_Sklad_produkt> skladProdukt = db.v_Sklad_produkt.Where(a => a.ID_produkt == obecnyProdukt && a.ID_polprodukt == obecnyPolprodukt).ToList();
                    dgvCurrentPolprodukt.DataSource = skladProdukt;
                    int iloscPolproduktu = int.Parse(dgvCurrentPolprodukt.Rows[0].Cells[5].Value.ToString());
                    int liczbaIteracji = iloscProduktZamowienie * iloscPolproduktu;
                    for (int j = 0; j < liczbaIteracji; j++)
                    {
                        Random random = new Random();
                        int rndMinutes = random.Next(1, 120);
                        cbStanowisko.SelectedIndex = random.Next(cbStanowisko.Items.Count);
                        cbPracownik.SelectedIndex = random.Next(cbPracownik.Items.Count);

                        Wytwarzanie wytwarzanie = new Wytwarzanie();
                        wytwarzanie.ID_pracownik = int.Parse(cbPracownik.SelectedValue.ToString());
                        wytwarzanie.ID_zamowienie_szczegol = int.Parse(dgvZamowienieSzczegol.CurrentRow.Cells[4].Value.ToString());
                        wytwarzanie.Czas_od = dateTimeNow;
                        wytwarzanie.Czas_do = dateTimeNow.AddMinutes(rndMinutes);

                        db.Wytwarzanie.Add(wytwarzanie);
                        db.SaveChanges();
                        int wytwarzanieID = (from n in db.Wytwarzanie orderby n.ID_wytwarzanie descending select n.ID_wytwarzanie).FirstOrDefault();

                        Proces_wytwarzanie_polprodukt wytwarzaniePolprodukt = new Proces_wytwarzanie_polprodukt();
                        wytwarzaniePolprodukt.ID_wytwarzanie = wytwarzanieID;
                        wytwarzaniePolprodukt.ID_proces_polprodukt = int.Parse(dgvProcesPolprodukt.Rows[i].Cells[4].Value.ToString());
                        wytwarzaniePolprodukt.ID_stanowisko_produkcyjne = int.Parse(cbStanowisko.SelectedValue.ToString());
                        db.Proces_wytwarzanie_polprodukt.Add(wytwarzaniePolprodukt);
                        db.SaveChanges();
                        iloscWytwarzaniePolprodukt++;

                        dateTimeNow = dateTimeNow.AddMinutes(rndMinutes+1);
                    }
                    dgvCurrentPolprodukt.DataSource = 0;
                }

                int iloscWierszyDgvProdut = int.Parse(dgvProcesProdukt.RowCount.ToString());
                for (int i = 0; i <= iloscWierszyDgvProdut - 1; i++)
                {
                    for (int j = 0; j < iloscProduktZamowienie; j++)
                    {
                        Random random = new Random();
                        int rndMinutes = random.Next(1, 120);
                        cbStanowisko.SelectedIndex = random.Next(cbStanowisko.Items.Count);
                        cbPracownik.SelectedIndex = random.Next(cbPracownik.Items.Count);

                        Wytwarzanie wytwarzanie = new Wytwarzanie();
                        wytwarzanie.ID_pracownik = int.Parse(cbPracownik.SelectedValue.ToString());
                        wytwarzanie.ID_zamowienie_szczegol = int.Parse(dgvZamowienieSzczegol.CurrentRow.Cells[4].Value.ToString());
                        wytwarzanie.Czas_od = dateTimeNow;
                        wytwarzanie.Czas_do = dateTimeNow.AddMinutes(rndMinutes);

                        db.Wytwarzanie.Add(wytwarzanie);
                        db.SaveChanges();
                        int wytwarzanieID = (from n in db.Wytwarzanie orderby n.ID_wytwarzanie descending select n.ID_wytwarzanie).FirstOrDefault();

                        Proces_wytwarzanie_produkt wytwarzanieProdukt = new Proces_wytwarzanie_produkt();
                        wytwarzanieProdukt.ID_wytwarzanie = wytwarzanieID;
                        wytwarzanieProdukt.ID_proces_produkt = int.Parse(dgvProcesProdukt.Rows[i].Cells[3].Value.ToString());
                        wytwarzanieProdukt.ID_stanowisko_produkcyjne = int.Parse(cbStanowisko.SelectedValue.ToString());
                        db.Proces_wytwarzanie_produkt.Add(wytwarzanieProdukt);
                        db.SaveChanges();
                        iloscWytwarzanieProdukt++;

                        dateTimeNow = dateTimeNow.AddMinutes(rndMinutes+1);
                    }
                    dgvCurrentPolprodukt.DataSource = 0;
                }
                refreshScreen();
                MessageBox.Show("Pomyślnie wygenerowano " + iloscWytwarzaniePolprodukt + " procesów wytwarzania półproduktów oraz " + iloscWytwarzanieProdukt + " procesów wytwarzania produktów.");
            }
            else
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
        }
    }
}
        