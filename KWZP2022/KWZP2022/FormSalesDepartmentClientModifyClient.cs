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
        public FormSalesDepartmentClientModifyClient(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cleanTextBox();
            showData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showData()
        {
            var dane = from klient in db.Klients
                       select new
                       {
                           klient.ID_klient,
                           klient.Nazwisko,
                           klient.Imie,
                           klient.NIP
                       };
            this.dgvClientID.DataSource = dane.ToList();
        }
        private void cleanTextBox()
        {
            textBox1Name.Clear();
            textBox2Name.Clear();
            textBoxCity.Clear();
            textBoxEmail.Clear();
            textBoxNIP.Clear();
            textBoxNo1.Clear();
            textBoxNo2.Clear();
            textBoxPostCode.Clear();
            textBoxStreet.Clear();
            textBoxTel.Clear();
        }
        private void dgvClientID_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int daneKlient = int.Parse(this.dgvClientID.CurrentRow.Cells[0].Value.ToString());
            Klient daneKlientKlient = this.db.Klients.Single(a => a.ID_klient == daneKlient);
            Dane_adresowe_klient daneKlientDaneAdresowe = this.db.Dane_adresowe_klient.Single(a => a.ID_klient == daneKlient);
            Nr_telefon_klient daneKlientNrTel = this.db.Nr_telefon_klient.Single(a => a.ID_klient == daneKlient);
            Email_klient daneKlientEmail = this.db.Email_klient.Single(a => a.ID_klient == daneKlient);
            textBox2Name.Text = daneKlientKlient.Nazwisko;
            textBox1Name.Text = daneKlientKlient.Imie;
            textBoxNIP.Text = daneKlientKlient.NIP;
            textBoxCity.Text = daneKlientDaneAdresowe.Miejscowosc;
            textBoxStreet.Text = daneKlientDaneAdresowe.Ulica;
            textBoxNo1.Text = daneKlientDaneAdresowe.Nr_budynek.ToString();
            textBoxNo2.Text = daneKlientDaneAdresowe.Nr_lokal.ToString();
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
            if (this.dgvClientID.CurrentRow.Cells[0].Value != null)
            {
                try
                {
                    int daneKlient = int.Parse(this.dgvClientID.CurrentRow.Cells[0].Value.ToString());
                    Klient daneKlientKlient = this.db.Klients.Single(a => a.ID_klient == daneKlient);
                    daneKlientKlient.Nazwisko = textBox2Name.Text;
                    daneKlientKlient.Imie = textBox1Name.Text;
                    daneKlientKlient.NIP = textBoxNIP.Text;
                    Dane_adresowe_klient daneKlientDaneAdresowe = this.db.Dane_adresowe_klient.Single(a => a.ID_klient == daneKlient);
                    daneKlientDaneAdresowe.Miejscowosc = textBoxCity.Text;
                    daneKlientDaneAdresowe.Ulica = textBoxStreet.Text;
                    daneKlientDaneAdresowe.Nr_budynek = int.Parse(textBoxNo1.Text);
                    if (textBoxNo2.Text != "")
                    {
                        daneKlientDaneAdresowe.Nr_lokal = int.Parse(textBoxNo2.Text);
                    }
                    else
                    {
                        daneKlientDaneAdresowe.Nr_lokal = null;
                    }
                    daneKlientDaneAdresowe.Kod_pocztowy = textBoxPostCode.Text;
                    Nr_telefon_klient daneKlientNrTel = this.db.Nr_telefon_klient.Single(a => a.ID_klient == daneKlient);
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
                    Email_klient daneKlientEmail = this.db.Email_klient.Single(a => a.ID_klient == daneKlient);
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
                    MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Źle wprowadzono dane!", "Błąd", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono klienta!", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
