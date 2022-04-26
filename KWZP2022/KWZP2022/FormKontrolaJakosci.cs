﻿using System;
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
            initDataGridViewNazwa();
            initComboboxPracownik();
            initComboboxRodzajKontrola();
            initDataGridViewKontrolaJakosciParametr();
            initDataGridViewKontrolaPozytywna();
        }

        private void refreshScreen()
        {
            initDataGridViewNazwa();
            initComboboxPracownik();
            initComboboxRodzajKontrola();
            initDataGridViewKontrolaJakosciParametr();
            initDataGridViewKontrolaPozytywna();
        }

        private void initDataGridViewNazwa()
        {
            dgvvKontrolaJakosciKolejka.DataSource = db.v_Wytworzone_produkty.ToList();
            dgvvKontrolaJakosciKolejka.Columns["ID"].HeaderText = "ID_wytwarzanie";
            dgvvKontrolaJakosciKolejka.Columns["Czynność_produkcyjna"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Pracownik"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Stanowisko"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Szacowany_czas__min_"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Data_rozpoczęcia"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Data_zakończenia"].Visible = false;
            this.dgvvKontrolaJakosciKolejka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvvKontrolaJakosciKolejka.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }               

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            int produktID = int.Parse(dgvvKontrolaJakosciKolejka.CurrentRow.Cells[1].Value.ToString());
            dgvvParametrProdukt.DataSource = 0;
            List<v_Parametry_produkt> parametrProduktList = db.v_Parametry_produkt.Where(a => a.ID_produkt == produktID).ToList();
            
            if (parametrProduktList.Count() > 0)
            {
                dgvvParametrProdukt.DataSource = parametrProduktList;
                this.dgvvParametrProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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

        private void initDataGridViewKontrolaPozytywna()
        {
            dgvPozytywne.DataSource = db.v_Kontrola_pozytywna.ToList();
            this.dgvPozytywne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPozytywne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
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

            Kontrola_parametr kontrolaParametr = new Kontrola_parametr();
            int numRows = dgvvKontrolaProdukt.Rows.Count;
            kontrolaParametr.ID_kontrola_jakosci_produkt = int.Parse(this.dgvvKontrolaProdukt.Rows[numRows - 1].Cells[0].Value.ToString());
            kontrolaParametr.ID_parametr_produkt = int.Parse(this.dgvvParametrProdukt.CurrentRow.Cells[0].Value.ToString());
            kontrolaParametr.Wartosc = decimal.Parse(txtWartosc.Text);
            db.Kontrola_parametr.Add(kontrolaParametr);
            db.SaveChanges();
            MessageBox.Show("Poprawnie przeprowadzono kontrole");
            refreshScreen();
        }

        private void dgvvKontrolaJakosciKolejka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwa.Text = this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            int iloscProduktowKolejka = int.Parse(dgvvKontrolaJakosciKolejka.RowCount.ToString());

            for (int i = 0; i <= iloscProduktowKolejka - 1; i++)
            {
                int iloscParametrow = int.Parse(dgvvParametrProdukt.RowCount.ToString());

                for (int j = 0; j <= iloscParametrow - 1; j++)
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

                    Kontrola_parametr kontrolaParametr = new Kontrola_parametr();
                    int numRows = dgvvKontrolaProdukt.Rows.Count;
                    kontrolaParametr.ID_kontrola_jakosci_produkt = int.Parse(this.dgvvKontrolaProdukt.Rows[numRows - 1].Cells[0].Value.ToString());
                    kontrolaParametr.ID_parametr_produkt = int.Parse(this.dgvvParametrProdukt.Rows[j].Cells[0].Value.ToString());


                    decimal dolnyPrzedział = decimal.Parse(this.dgvvParametrProdukt.Rows[j].Cells[4].Value.ToString()) - 0.05m * decimal.Parse(this.dgvvParametrProdukt.Rows[j].Cells[4].Value.ToString());
                    decimal gornyPrzedzial = decimal.Parse(this.dgvvParametrProdukt.Rows[j].Cells[5].Value.ToString()) + 0.05m * decimal.Parse(this.dgvvParametrProdukt.Rows[j].Cells[4].Value.ToString());

                }

                

            }

        }
    }
}
