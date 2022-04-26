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
    public partial class FormSalesDepartmentClientModifyClient : Form
    {
        KWZPEntities db;
        Klient selectedClientForModify;
        public FormSalesDepartmentClientModifyClient(KWZPEntities db, Klient selectedClientForModify)
        {
            InitializeComponent();
            this.db = db;
            this.selectedClientForModify = selectedClientForModify;
            cleanTextBox();
            showDataClient();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cleanTextBox()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxCity.Clear();
            textBoxEmail.Clear();
            textBoxNIP.Clear();
            textBoxBuildingNumber.Clear();
            textBoxApartmentNumber.Clear();
            textBoxPostCode.Clear();
            textBoxStreet.Clear();
            textBoxTel.Clear();
        }
        private void showDataClient()
        {
            Dane_adresowe_klient daneKlientDaneAdresowe = this.db.Dane_adresowe_klient.Single(a => a.ID_klient == selectedClientForModify.ID_klient);
            Nr_telefon_klient daneKlientNrTel = this.db.Nr_telefon_klient.Single(a => a.ID_klient == selectedClientForModify.ID_klient);
            Email_klient daneKlientEmail = this.db.Email_klient.Single(a => a.ID_klient == selectedClientForModify.ID_klient);
            textBoxSurname.Text = selectedClientForModify.Nazwisko;
            textBoxName.Text = selectedClientForModify.Imie;
            textBoxNIP.Text = selectedClientForModify.NIP;
            textBoxCity.Text = daneKlientDaneAdresowe.Miejscowosc;
            textBoxStreet.Text = daneKlientDaneAdresowe.Ulica;
            textBoxBuildingNumber.Text = daneKlientDaneAdresowe.Nr_budynek.ToString();
            textBoxApartmentNumber.Text = daneKlientDaneAdresowe.Nr_lokal.ToString();
            textBoxPostCode.Text = daneKlientDaneAdresowe.Kod_pocztowy;
            textBoxEmail.Text = daneKlientEmail.Email;
            dtpEmaiDate1.Value = daneKlientEmail.Data_od;
            if (daneKlientEmail.Data_do != null)
            {
                cbEmailDate2.Checked = true;
                dtpEmailDate2.Value = daneKlientEmail.Data_do.Value;
            }
            else
            {
                cbEmailDate2.Checked = false;
                dtpEmailDate2.Value = DateTime.Now;
            }
            textBoxTel.Text = daneKlientNrTel.Numer;
            dtpTelDate1.Value = daneKlientNrTel.Data_od;
            if (daneKlientNrTel.Data_do != null)
            {
                cbTelDate2.Checked = true;
                dtpTelDate2.Value = daneKlientNrTel.Data_do.Value;
            }
            else
            {
                cbTelDate2.Checked = false;
                dtpTelDate2.Value = DateTime.Now;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
                try
                {
                    selectedClientForModify.Nazwisko = textBoxSurname.Text;
                    selectedClientForModify.Imie = textBoxName.Text;
                    selectedClientForModify.NIP = textBoxNIP.Text;
                    Dane_adresowe_klient daneKlientDaneAdresowe = this.db.Dane_adresowe_klient.Single(a => a.ID_klient == selectedClientForModify.ID_klient);
                    daneKlientDaneAdresowe.Miejscowosc = textBoxCity.Text;
                    daneKlientDaneAdresowe.Ulica = textBoxStreet.Text;
                    daneKlientDaneAdresowe.Nr_budynek = int.Parse(textBoxBuildingNumber.Text);
                    if (textBoxApartmentNumber.Text != "")
                    {
                        daneKlientDaneAdresowe.Nr_lokal = int.Parse(textBoxApartmentNumber.Text);
                    }
                    else
                    {
                        daneKlientDaneAdresowe.Nr_lokal = null;
                    }
                    daneKlientDaneAdresowe.Kod_pocztowy = textBoxPostCode.Text;
                    Nr_telefon_klient daneKlientNrTel = this.db.Nr_telefon_klient.Single(a => a.ID_klient == selectedClientForModify.ID_klient);
                    daneKlientNrTel.Numer = textBoxTel.Text;
                    daneKlientNrTel.Data_od = dtpTelDate1.Value;
                    if (cbTelDate2.Checked is true)
                    {
                        daneKlientNrTel.Data_do = dtpTelDate2.Value;
                    }
                    else
                    {
                        daneKlientNrTel.Data_do = null;
                    }
                    Email_klient daneKlientEmail = this.db.Email_klient.Single(a => a.ID_klient == selectedClientForModify.ID_klient);
                    daneKlientEmail.Email = textBoxEmail.Text;
                    daneKlientEmail.Data_od = dtpEmaiDate1.Value;
                    if (cbEmailDate2.Checked is true)
                    {
                        daneKlientEmail.Data_do = dtpEmailDate2.Value;
                    }
                    else
                    {
                        daneKlientEmail.Data_do = null;
                    }
                    this.db.SaveChanges();
                    MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Źle wprowadzono dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
