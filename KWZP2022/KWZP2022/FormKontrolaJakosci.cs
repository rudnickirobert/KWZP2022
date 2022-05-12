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
    public partial class FormKontrolaJakosci : Form
    {
        KWZPEntities db;
        public FormKontrolaJakosci(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            
            initComboboxPracownik();
            initComboboxRodzajKontrola();
            initDataGridViewKontrolaJakosciParametr();
            initComboboxZamowienie();
            refreshScreen();
            clearDgvs();
            
        }

        private void refreshScreen()
        {
            initComboboxPracownik();
            initComboboxRodzajKontrola();
            initDataGridViewKontrolaJakosciParametr();
            initDataGridViewKontrolaPozytywna();
            dTPCzasDo.ShowUpDown = true;
            dTPCzasOd.ShowUpDown = true;
        }

        private void clearDgvs()
        {
            dgvPozytywne.DataSource = 0;
            dgvvKontrolaJakosciKolejka.DataSource = 0;
            dgvvParametrProdukt.DataSource = 0;
            dgvRezultatKontroli.DataSource = 0;
            txtNazwa.Text = "";
            txtParametrProdukt.Text = "";
            txtWartosc.Text = "";
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            dgvvParametrProdukt.DataSource = 0;
            if (dgvvKontrolaJakosciKolejka.DataSource != null)
            {
                int produktID = int.Parse(dgvvKontrolaJakosciKolejka.CurrentRow.Cells[1].Value.ToString());                
                List<v_Parametry_produkt> parametrProduktList = db.v_Parametry_produkt.Where(a => a.ID_produkt == produktID).ToList();

                if (parametrProduktList.Count() > 0)
                {
                    dgvvParametrProdukt.DataSource = parametrProduktList;
                    dgvvParametrProdukt.Columns["ID_parametr_produkt"].Visible = false;
                    dgvvParametrProdukt.Columns["ID_produkt"].Visible = false;
                    this.dgvvParametrProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano produktu!");
            }        
        }

        private void dgvvParametrProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtParametrProdukt.Text = this.dgvvParametrProdukt.CurrentRow.Cells[3].Value.ToString();
        }

        private void initComboboxPracownik()
        {
            cBPracownik.DataSource = db.v_Pracownik_produkcja.ToList();
            cBPracownik.ValueMember = "ID_pracownik";
            cBPracownik.DisplayMember = "Pracownik";
        }
        private void initComboboxRodzajKontrola()
        {
            cBRodzajKontrola.DataSource = db.v_Rodzaj_kontrola.ToList();
            cBRodzajKontrola.ValueMember = "ID";
            cBRodzajKontrola.DisplayMember = "Rodzaj_kontroli";
        }
        private void initDataGridViewKontrolaJakosciParametr()
        {
            dgvvKontrolaProdukt.DataSource = db.v_Kontrola_jakosci_produkt.ToList();
            this.dgvvKontrolaProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvvKontrolaProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewWytworzoneProduktyZamowienie()
        {
            int wybraneZamowienie = int.Parse(cbZamowienie.SelectedValue.ToString());
            List<v_Wytworzone_produkty_zamowienie> wytworzoneProduktyZamowienie = db.v_Wytworzone_produkty_zamowienie.Where(a => a.ID_zamowienie == wybraneZamowienie).ToList();
            dgvvKontrolaJakosciKolejka.DataSource = wytworzoneProduktyZamowienie;
            dgvvKontrolaJakosciKolejka.Columns["ID"].HeaderText = "ID_wytwarzanie";
            dgvvKontrolaJakosciKolejka.Columns["ID_produkt"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Czynność_produkcyjna"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Pracownik"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Stanowisko"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Szacowany_czas__min_"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Data_rozpoczęcia"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Data_zakończenia"].Visible = false;
            this.dgvvKontrolaJakosciKolejka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvvKontrolaJakosciKolejka.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewKontrolaPozytywna()
        {
            dgvPozytywne.DataSource = 0;
            int wybraneZamowienie = int.Parse(cbZamowienie.SelectedValue.ToString());
            List<v_Kontrola_pozytywna> pozytywnaKontrola = db.v_Kontrola_pozytywna.Where(a => a.ID_zamowienie == wybraneZamowienie).ToList();
            dgvPozytywne.DataSource = pozytywnaKontrola;
            dgvPozytywne.Columns["Wynik_kontrola"].Visible = false;
            this.dgvPozytywne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPozytywne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewRezultatKontroli()
        {
            this.db = new KWZPEntities();
            int wybraneZamowienie = int.Parse(cbZamowienie.SelectedValue.ToString());
            List<v_Ilosc_kontrola_pozytywna> RezultatKontroli = db.v_Ilosc_kontrola_pozytywna.Where(a => a.ID_zamowienie == wybraneZamowienie).ToList();
            dgvRezultatKontroli.DataSource = RezultatKontroli;
            dgvRezultatKontroli.Columns["ID_zamowienie"].Visible = false;
            dgvRezultatKontroli.Columns["ID_produkt"].Visible = false;
            this.dgvRezultatKontroli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRezultatKontroli.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initComboboxZamowienie()
        {
            cbZamowienie.DataSource = db.v_Zamowienie_produkcja.ToList();
            cbZamowienie.ValueMember = "ID";
            cbZamowienie.DisplayMember = "Klient";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwa.Text) || String.IsNullOrEmpty(txtParametrProdukt.Text) || String.IsNullOrEmpty(cBPracownik.Text) || String.IsNullOrEmpty(cBRodzajKontrola.Text) || String.IsNullOrEmpty(txtWartosc.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            { 
                Kontrola_jakosci_produkt kontrolaProdukt = new Kontrola_jakosci_produkt();
                kontrolaProdukt.ID_wytwarzanie = int.Parse(this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[0].Value.ToString());
                kontrolaProdukt.ID_pracownik = int.Parse(cBPracownik.SelectedValue.ToString());
                kontrolaProdukt.ID_rodzaj_kontrola = int.Parse(cBRodzajKontrola.SelectedValue.ToString());
                kontrolaProdukt.Data_od = dTPDataOd.Value.Date + dTPCzasOd.Value.TimeOfDay;
                kontrolaProdukt.Data_do = dTPDataDo.Value.Date + dTPCzasDo.Value.TimeOfDay;
                kontrolaProdukt.Uwagi = txtUwagi.Text;
                db.Kontrola_jakosci_produkt.Add(kontrolaProdukt);
                db.SaveChanges();

                this.db = new KWZPEntities();

                Kontrola_parametr kontrolaParametr = new Kontrola_parametr();
                int numRows = dgvvKontrolaProdukt.Rows.Count;
                kontrolaParametr.ID_kontrola_jakosci_produkt = int.Parse(this.dgvvKontrolaProdukt.Rows[numRows - 1].Cells[0].Value.ToString()) + 1;
                kontrolaParametr.ID_parametr_produkt = int.Parse(this.dgvvParametrProdukt.CurrentRow.Cells[0].Value.ToString());
                kontrolaParametr.Wartosc = decimal.Parse(txtWartosc.Text);
                db.Kontrola_parametr.Add(kontrolaParametr);
                db.SaveChanges();
                MessageBox.Show("Poprawnie zarejestrowano kontrolę jakości.");
                refreshScreen();
            }      
            refreshScreen();
            txtParametrProdukt.Text = "";
            txtWartosc.Text = "";
        }

        private void dgvvKontrolaJakosciKolejka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwa.Text = this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[2].Value.ToString();
        }

        public double NextDouble(Random rand, double minValue, double maxValue)
        {
            return rand.NextDouble() * (maxValue - minValue) + minValue;
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            int iloscProduktowKontrola = 0;
            if (dgvvKontrolaJakosciKolejka.DataSource == null)
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                int iloscProduktowKolejka = 0;
                int startIndex = 0;

                if (String.IsNullOrEmpty(txtKontrolaIlosc.Text))
                {
                    iloscProduktowKolejka = int.Parse(dgvvKontrolaJakosciKolejka.RowCount.ToString());
                }
                else
                {
                    startIndex = int.Parse(dgvvKontrolaJakosciKolejka.RowCount.ToString()) - int.Parse(txtKontrolaIlosc.Text);
                    iloscProduktowKolejka = int.Parse(dgvvKontrolaJakosciKolejka.RowCount.ToString());
                }

                for (int i = startIndex; i < iloscProduktowKolejka; i++)
                {
                    int currentIdProdukt = int.Parse(dgvvKontrolaJakosciKolejka.Rows[i].Cells[1].Value.ToString());
                    List<v_Parametry_produkt> parametryProdukt = db.v_Parametry_produkt.Where(a => a.ID_produkt == currentIdProdukt).ToList();
                    dgvvParametrProdukt.DataSource = parametryProdukt;
                    dgvvParametrProdukt.Columns["ID_parametr_produkt"].Visible = false;
                    dgvvParametrProdukt.Columns["ID_produkt"].Visible = false;
                    this.dgvvParametrProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                    int iloscParametrow = int.Parse(dgvvParametrProdukt.RowCount.ToString());
                    iloscProduktowKontrola++;

                    for (int j = 0; j <= iloscParametrow-1; j++)
                    {
                        Kontrola_jakosci_produkt kontrolaProdukt = new Kontrola_jakosci_produkt();
                        kontrolaProdukt.ID_wytwarzanie = int.Parse(this.dgvvKontrolaJakosciKolejka.Rows[i].Cells[0].Value.ToString());
                        kontrolaProdukt.ID_pracownik = int.Parse(cBPracownik.SelectedValue.ToString());
                        kontrolaProdukt.ID_rodzaj_kontrola = int.Parse(cBRodzajKontrola.SelectedValue.ToString());
                        kontrolaProdukt.Data_od = dTPDataOd.Value.Date + dTPCzasOd.Value.TimeOfDay;
                        kontrolaProdukt.Data_do = dTPDataDo.Value.Date + dTPCzasDo.Value.TimeOfDay;
                        kontrolaProdukt.Uwagi = txtUwagi.Text;
                        db.Kontrola_jakosci_produkt.Add(kontrolaProdukt);
                        db.SaveChanges();

                        this.db = new KWZPEntities();

                        Kontrola_parametr kontrolaParametr = new Kontrola_parametr();
                        int numRows = dgvvKontrolaProdukt.Rows.Count;
                        kontrolaParametr.ID_kontrola_jakosci_produkt = int.Parse(this.dgvvKontrolaProdukt.Rows[numRows - 1].Cells[0].Value.ToString()) + 1;
                        kontrolaParametr.ID_parametr_produkt = int.Parse(this.dgvvParametrProdukt.Rows[j].Cells[0].Value.ToString());


                        Random rand = new Random();
                        double dolnyPrzedział = double.Parse(this.dgvvParametrProdukt.Rows[j].Cells[4].Value.ToString());
                        double gornyPrzedzial = double.Parse(this.dgvvParametrProdukt.Rows[j].Cells[5].Value.ToString());
                        decimal wartosc = Convert.ToDecimal(NextDouble(rand, dolnyPrzedział, gornyPrzedzial));

                        kontrolaParametr.Wartosc = wartosc;
                        db.Kontrola_parametr.Add(kontrolaParametr);
                        db.SaveChanges();
                    }
                    refreshScreen();
                }
                initDataGridViewRezultatKontroli();
                MessageBox.Show("Przeprowadzono kontrolę dla " + iloscProduktowKontrola + " produktów.");
            }           
        }

        private void btnWczytajZamowienie_Click(object sender, EventArgs e)
        {
            initDataGridViewWytworzoneProduktyZamowienie();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            clearDgvs();
        }

        private void btnGauss_Click(object sender, EventArgs e)
        {
            FormKontrolaJakosciGauss gauss = new FormKontrolaJakosciGauss(db);
            gauss.ShowDialog();
        }

        private void btnRezultat_Click(object sender, EventArgs e)
        {
            initDataGridViewRezultatKontroli();
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            if (this.dgvRezultatKontroli.SelectedRows.Count > 0)
            {
                if (this.dgvRezultatKontroli.CurrentRow != null)
                {
                    string produkt = this.dgvRezultatKontroli.CurrentRow.Cells[1].Value.ToString();
                    int ilosc = int.Parse(this.dgvRezultatKontroli.CurrentRow.Cells[2].Value.ToString());
                    int alertCountBefore = this.db.Alert.ToList().Count;
                    FormDodajAlert addAlert = new FormDodajAlert(db, produkt, ilosc);
                    addAlert.ShowDialog();
                    int alertCountAfter = this.db.Alert.ToList().Count;
                    if (alertCountBefore >= alertCountAfter)
                    {
                        MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int alertCountBefore = this.db.Alert.ToList().Count;
                    FormDodajAlert addAlert = new FormDodajAlert(db);
                    addAlert.ShowDialog();
                    int alertCountAfter = this.db.Alert.ToList().Count;
                    if (alertCountBefore >= alertCountAfter)
                    {
                        MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                string produkt = this.dgvRezultatKontroli.CurrentRow.Cells[1].Value.ToString();
                int ilosc = int.Parse(this.dgvRezultatKontroli.CurrentRow.Cells[2].Value.ToString());
                int alertCountBefore = this.db.Alert.ToList().Count;
                FormDodajAlert addAlert = new FormDodajAlert(db, produkt, ilosc);
                addAlert.ShowDialog();
                int alertCountAfter = this.db.Alert.ToList().Count;
                if (alertCountBefore >= alertCountAfter)
                {
                    MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
