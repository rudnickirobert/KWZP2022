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
    public partial class FormSetupProductionDepartment : Form
    {
        KWZPEntities db;
        public FormSetupProductionDepartment(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            cleanTextBox();
            //ComboBox();
        }
        private void showData()
        {
            dtbDataStart.DataSource = db.v_Proces_wytwarzanie_produkt.ToList();
            this.dtbDataStart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cleanTextBox()
        {
            txtCzynnoscProdukcyjna.Clear();
            txtPracownik.Clear();
            txtProdukt.Clear();
            txtStanowiskoProdukcyjne.Clear();
            txtSzacowanyCzas.Clear();
            dtbDataRozpoczecia.ResetText();
            dtbDataEnd.ResetText();
        }
        private void btnDodajPrcoes_Click(object sender, EventArgs e)
        {
            if (txtProdukt.Text.Length > 0 && txtCzynnoscProdukcyjna.Text.Length > 0 && txtPracownik.Text.Length > 0 && txtPracownik.Text.Length > 0 && txtStanowiskoProdukcyjne.Text.Length > 0 && txtSzacowanyCzas.Text.Length > 0 && dtbDataRozpoczecia.Text.Length > 0)
            {
                Produkt produkt = new Produkt();
                produkt.Nazwa_produkt = txtProdukt.Text;
                
                Czynnosc_produkcyjna czynnosc_produkcyjna = new Czynnosc_produkcyjna();
                czynnosc_produkcyjna.Nazwa = txtCzynnoscProdukcyjna.Text;
                Pracownik pracownik = new Pracownik();
                pracownik.Nazwisko = txtPracownik.Text;
                pracownik.Imie = txtImiePracownik.Text;
                //mergepracownik = pracownik.Nazwisko + "" + pracownik.Imie;
                Slownik_stanowisko slownik_stanowisko = new Slownik_stanowisko();
                slownik_stanowisko.Nazwa_stanowiska = txtStanowiskoProdukcyjne.Text;
                Proces_produkt_czynnosc proces = new Proces_produkt_czynnosc();
                proces.Czas_trwania = Int32.Parse(txtSzacowanyCzas.Text);
                Wytwarzanie wytwarzanie = new Wytwarzanie();
                wytwarzanie.Czas_od = dtbDataRozpoczecia.Value;
                wytwarzanie.Czas_do = dtbDataEnd.Value;
                if (dtbDataEnd.Checked)
                {
                    wytwarzanie.Czas_do = dtbDataEnd.Value;
                }
                db.Produkt.Add(produkt);
                db.Czynnosc_produkcyjna.Add(czynnosc_produkcyjna);
                //db.Pracownik.Add(mergepracownik);
                db.Slownik_stanowisko.Add(slownik_stanowisko);
                db.Proces_produkt_czynnosc.Add(proces);
                db.Wytwarzanie.Add(wytwarzanie);
                db.SaveChanges();
                cleanTextBox();
                MessageBox.Show("Dodano nowego klienta!", "Informacja", MessageBoxButtons.OK);
            }
        }



        //private void ComboBox()
        //{
        //    System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //}



    }
}