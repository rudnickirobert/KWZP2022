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
    public partial class FormSalesDepartmentClientNewClient : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentClientNewClient(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
        private void messageBox()
        {
            MessageBox.Show("Nie wprowadzono danych.", "Błąd", MessageBoxButtons.OK);
        }
        private void cleanTextBox()
        {
            textBox1Name.Clear();
            textBox2Name.Clear();
            textBoxCity.Clear();
            textBoxEmail.Clear();
            //textBoxEmailDate1.Clear();
            //textBoxEmailDate2.Clear();
            textBoxNIP.Clear();
            textBoxNo1.Clear();
            textBoxNo2.Clear();
            textBoxPostCode.Clear();
            textBoxStreet.Clear();
            textBoxTel.Clear();
            //textBoxTelDate1.Clear();
            //textBoxTelDate2.Clear();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            //if (textBox1Name.Text.Length > 0 && textBox2Name.Text.Length > 0 && textBoxCity.Text.Length > 0 && textBoxNIP.Text.Length > 0 && textBoxNo1.Text.Length > 0 && textBoxNo2.Text.Length > 0 && textBoxPostCode.Text.Length > 0 && textBoxStreet.Text.Length > 0 && textBoxEmail.Text.Length > 0 && textBoxEmailDate1.Text.Length > 0 && textBoxTel.Text.Length > 0 && textBoxTelDate1.Text.Length > 0)
            //{
            //    Klient klient = new Klient();
            //    klient.Nazwisko = textBox2Name.Text;
            //    klient.Imie = textBox1Name.Text;
            //    klient.NIP = textBoxNIP.Text;
            //    Dane_adresowe_klient dane_Adresowe_Klient = new Dane_adresowe_klient();
            //    dane_Adresowe_Klient.Miejscowosc = textBoxCity.Text;
            //    dane_Adresowe_Klient.Ulica = textBoxStreet.Text;
            //    dane_Adresowe_Klient.Nr_budynek = int.Parse(textBoxNo1.Text);
            //    dane_Adresowe_Klient.Nr_lokal = int.Parse(textBoxNo2.Text);
            //    dane_Adresowe_Klient.Kod_pocztowy = textBoxPostCode.Text;
            //    Nr_telefon_klient nr_Telefon_Klient = new Nr_telefon_klient();
            //    nr_Telefon_Klient.Numer = textBoxTel.Text;
            //    nr_Telefon_Klient.Data_od = textBoxTelDate1;
            //}
            //else
            //{
            //    messageBox();
            //    cleanTextBox();
            //}
        }
    }
}
