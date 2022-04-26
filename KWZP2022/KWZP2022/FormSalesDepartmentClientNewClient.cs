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
            MessageBox.Show("Nie wprowadzono danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cleanTextBox()
        {
            textBoxName.Clear();
            textBoxSurame.Clear();
            textBoxCity.Clear();
            textBoxEmail.Clear();
            textBoxNIP.Clear();
            textBoxBuildingNumber.Clear();
            textBoxApartmentNumber.Clear();
            textBoxPostCode.Clear();
            textBoxStreet.Clear();
            textBoxTel.Clear();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0 && textBoxSurame.Text.Length > 0 && textBoxCity.Text.Length > 0 && textBoxBuildingNumber.Text.Length > 0 
                && textBoxPostCode.Text.Length > 0 && textBoxStreet.Text.Length > 0 && textBoxEmail.Text.Length > 0 
                && dtpEmaiDate1.Value.ToString().Length > 0 && textBoxTel.Text.Length > 0 && dtpEmailDate2.Value.ToString().Length > 0)
            {
                List<Nr_telefon_klient> noTelClient = this.db.Nr_telefon_klient.Where(a => a.Numer == textBoxTel.Text).ToList();
                if(noTelClient.Count() > 0)
                {
                    MessageBox.Show("Podany numer telefonu już istnieje w bazie","Uwaga",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Klient klient = new Klient();
                    klient.Nazwisko = textBoxSurame.Text;
                    klient.Imie = textBoxName.Text;
                    klient.NIP = textBoxNIP.Text;
                    Dane_adresowe_klient dane_Adresowe_Klient = new Dane_adresowe_klient();
                    dane_Adresowe_Klient.Miejscowosc = textBoxCity.Text;
                    dane_Adresowe_Klient.Ulica = textBoxStreet.Text;
                    dane_Adresowe_Klient.Nr_budynek = int.Parse(textBoxBuildingNumber.Text);
                    if (textBoxApartmentNumber.Text.Length > 0)
                    {
                        dane_Adresowe_Klient.Nr_lokal = int.Parse(textBoxApartmentNumber.Text);
                    }
                    dane_Adresowe_Klient.Kod_pocztowy = textBoxPostCode.Text;
                    Nr_telefon_klient nr_Telefon_Klient = new Nr_telefon_klient();
                    nr_Telefon_Klient.Numer = textBoxTel.Text;
                    nr_Telefon_Klient.Data_od = dtpEmaiDate1.Value;
                    if (cbTelDate2.Checked is true)
                    {
                        nr_Telefon_Klient.Data_do = dtpEmailDate2.Value;
                    }
                    Email_klient email_Klient = new Email_klient();
                    email_Klient.Email = textBoxEmail.Text;
                    email_Klient.Data_od = dtpTelDate1.Value;
                    if (cbEmailDate2.Checked is true)
                    {
                        email_Klient.Data_do = dtpTelDate2.Value;
                    }
                    db.Klient.Add(klient);
                    db.Dane_adresowe_klient.Add(dane_Adresowe_Klient);
                    db.Nr_telefon_klient.Add(nr_Telefon_Klient);
                    db.Email_klient.Add(email_Klient);
                    db.SaveChanges();
                    cleanTextBox();
                    MessageBox.Show("Dodano noewgo klienta!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                messageBox();
            }
        }
    }
}
