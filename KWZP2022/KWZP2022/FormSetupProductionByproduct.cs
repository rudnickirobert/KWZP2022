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
    public partial class FormSetupProductionByproduct : Form
    {
        KWZPEntities db;
        public FormSetupProductionByproduct(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            ComboBox();
        }
        private void showData()
        {
            dtbDataStart.DataSource = db.v_Proces_wytwarzanie_produkt.ToList();
            this.dtbDataStart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ComboBox()
        {
            cbPolprodukt.DataSource = this.db.Produkt.ToList();
            cbPolprodukt.ValueMember = "Nazwa_produkt";
            cbPolprodukt.DisplayMember = "Nazwa_produkt";
            cbCzynnoscProdukcyjna.DataSource = this.db.Czynnosc_produkcyjna.ToList();
            cbCzynnoscProdukcyjna.ValueMember = "Nazwa";
            cbCzynnoscProdukcyjna.DisplayMember = "Nazwa";
            cbPracownik.DataSource = this.db.Pracownik.ToList();
            cbPracownik.ValueMember = "Nazwisko";
            cbPracownik.DisplayMember = "Nazwisko";
            cbStanowiskoProdukcyjne.DataSource = this.db.Slownik_stanowisko.ToList();
            cbStanowiskoProdukcyjne.ValueMember = "Nazwa_stanowiska";
            cbStanowiskoProdukcyjne.DisplayMember = "Nazwa_stanowiska";
            cbSzacowanyCzas.DataSource = this.db.Proces_produkt_czynnosc.ToList();
            cbSzacowanyCzas.ValueMember = "Czas_trwania";
            cbSzacowanyCzas.DisplayMember = "Czas_trwania";
        }
        private void btnDodajPrcoes_Click(object sender, EventArgs e)
        {
            if (cbPolprodukt.Text.Length > 0 && cbCzynnoscProdukcyjna.Text.Length > 0 && cbPracownik.Text.Length > 0 && cbPracownik.Text.Length > 0 && cbStanowiskoProdukcyjne.Text.Length > 0 && cbSzacowanyCzas.Text.Length > 0 && dtbDataRozpoczecia.Text.Length > 0)
            {
                Produkt produkt = new Produkt();
                produkt.Nazwa_produkt = cbPolprodukt.Text;

                Czynnosc_produkcyjna czynnosc_produkcyjna = new Czynnosc_produkcyjna();
                czynnosc_produkcyjna.Nazwa = cbCzynnoscProdukcyjna.Text;
                Pracownik pracownik = new Pracownik();
                pracownik.Nazwisko = cbPracownik.Text;
                Slownik_stanowisko slownik_stanowisko = new Slownik_stanowisko();
                slownik_stanowisko.Nazwa_stanowiska = cbStanowiskoProdukcyjne.Text;
                Proces_produkt_czynnosc proces = new Proces_produkt_czynnosc();
                proces.Czas_trwania = Int32.Parse(cbSzacowanyCzas.Text);
                Wytwarzanie wytwarzanie = new Wytwarzanie();
                wytwarzanie.Czas_od = dtbDataRozpoczecia.Value;
                wytwarzanie.Czas_do = dtbDataEnd.Value;
                if (dtbDataEnd.Checked)
                {
                    wytwarzanie.Czas_do = dtbDataEnd.Value;
                }
                db.Produkt.Add(produkt);
                db.Czynnosc_produkcyjna.Add(czynnosc_produkcyjna);
                db.Slownik_stanowisko.Add(slownik_stanowisko);
                db.Proces_produkt_czynnosc.Add(proces);
                db.Wytwarzanie.Add(wytwarzanie);
                db.SaveChanges();
                db.Pracownik.Add(pracownik);
                MessageBox.Show("Dodano nowego klienta!", "Informacja", MessageBoxButtons.OK);
            }
        }







    }
}
