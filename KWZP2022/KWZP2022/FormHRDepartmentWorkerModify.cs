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
    public partial class FormHRDepartmentWorkerModify2 : Form
    {
        KWZPEntities db;
        public FormHRDepartmentWorkerModify2(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            comboBox();
            showData();
        }

        private void showData()
        {
            this.dgvpracownik.DataSource = this.db.v_Pracownik.ToList();
            this.dgvpracownik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cleanTextBox()
        {
            tbPracownikNazwisko.Clear();
            tbPracownikImie.Clear();
            tbNrdowodu.Clear();
            tbPesel.Clear();
            tbMiejscowosc.Clear();
            tbUlica.Clear();
            tbBudynek.Clear();
            tblokal.Clear();
            tbNumer.Clear();
            tbEmail.Clear();
        }

        private void comboBox()
        {
            cbWyksztalcenie.DataSource = this.db.Wyksztalcenie.ToList();
            cbWyksztalcenie.ValueMember = "ID_wyksztalcenie";
            cbWyksztalcenie.DisplayMember = "Nazwa";
        }

        private void dgvpracownik_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int dane = int.Parse(dgvpracownik.CurrentRow.Cells[0].Value.ToString());

            Pracownik pracownik = this.db.Pracownik.Single(a => a.ID_pracownik == dane);
            tbPracownikNazwisko.Text = selectedWorkerForModify.Nazwisko;
            tbPracownikImie.Text = selectedWorkerForModify.Imie;
            tbNrdowodu.Text = selectedWorkerForModify.Nr_dowodu;
            tbPesel.Text = selectedWorkerForModify.Pesel.ToString();
            int selectedWyksztalcenie = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
            selectedWorkerForModify.ID_wyksztalcenie = selectedWyksztalcenie;
            Dane_adresowe_pracownik daneAdresowePracownik = this.db.Dane_adresowe_pracownik.Single(b => b.ID_pracownik == selectedWorkerForModify.ID_pracownik);
            tbMiejscowosc.Text = daneAdresowePracownik.Miejscowosc;
            tbUlica.Text = daneAdresowePracownik.Ulica;
            tbBudynek.Text = daneAdresowePracownik.Nr_budynku;
            tblokal.Text = daneAdresowePracownik.Nr_lokalu;
            tbKod.Text = daneAdresowePracownik.Kod_pocztowy;
            dpracownikod.Value = daneAdresowePracownik.Data_od;
            if (daneAdresowePracownik.Data_do != null)
            {
                cbDataDo.Checked = true;
                dpracownikdo.Value = daneAdresowePracownik.Data_do.Value;
            }
            else
            {
                cbDataDo.Checked = false;
                dpracownikdo.Value = DateTime.Now;
            }
            Nr_telefon_pracownik nrTelefonPracownik = this.db.Nr_telefon_pracownik.Single(c => c.ID_pracownik == selectedWorkerForModify.ID_pracownik);

            tbNumer.Text = nrTelefonPracownik.Numer;
            dnrod.Value = nrTelefonPracownik.Data_od;
            if (nrTelefonPracownik.Data_do != null)
            {
                cbDataDoNrTelefonu.Checked = true;
                dnrod.Value = nrTelefonPracownik.Data_do.Value;
            }
            else
            {
                cbDataDoNrTelefonu.Checked = false;
                dnrod.Value = DateTime.Now;
            }
            Email_pracownik emailPracownik = this.db.Email_pracownik.Single(d => d.ID_pracownik == selectedWorkerForModify.ID_pracownik);
            tbEmail.Text = emailPracownik.Email;
            demailod.Value = emailPracownik.Data_od;
            if (emailPracownik.Data_do != null)
            {
                cbDataDoEmail.Checked = true;
                demailod.Value = emailPracownik.Data_do.Value;
            }
            else
            {
                cbDataDoEmail.Checked = false;
                demailod.Value = DateTime.Now;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvpracownik.CurrentRow.Cells[0].Value != null)
            {
                int dane = int.Parse(dgvpracownik.CurrentRow.Cells[0].Value.ToString());
                Pracownik pracownik = (Pracownik)db.Pracownik.Where(a => a.ID_pracownik == dane).First();
                tbPracownikNazwisko.Text = pracownik.Nazwisko;
                tbPracownikImie.Text = pracownik.Imie;
                tbNrdowodu.Text = pracownik.Nr_dowodu;
                tbPesel.Text = pracownik.Pesel.ToString();
                int selectedWyksztalcenie = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
                selectedWyksztalcenie = pracownik.ID_wyksztalcenie;
                Dane_adresowe_pracownik daneAdresowePracownik = (Dane_adresowe_pracownik)db.Dane_adresowe_pracownik.Single(a => a.ID_pracownik == pracownik.ID_pracownik);
                pracownik.ID_pracownik = daneAdresowePracownik.ID_pracownik;
                tbMiejscowosc.Text = daneAdresowePracownik.Miejscowosc;
                tbUlica.Text = daneAdresowePracownik.Ulica;
                tbBudynek.Text = daneAdresowePracownik.Nr_budynku;
                tblokal.Text = daneAdresowePracownik.Nr_lokalu;
                tbKod.Text = daneAdresowePracownik.Kod_pocztowy;
                dpracownikod.Value = daneAdresowePracownik.Data_od;
                if (cbDataDo.Checked)
                {
                    dpracownikdo.Value = (DateTime)daneAdresowePracownik.Data_do;
                }
                else
                {
                    daneAdresowePracownik.Data_do = null;
                }
                Nr_telefon_pracownik nrTelefonPracownik = (Nr_telefon_pracownik)db.Nr_telefon_pracownik.Single(a => a.ID_pracownik == pracownik.ID_pracownik);
                pracownik.ID_pracownik = nrTelefonPracownik.ID_pracownik;
                tbNumer.Text = nrTelefonPracownik.Numer;
                dnrod.Value = nrTelefonPracownik.Data_od;
                if (cbDataDoNrTelefonu.Checked)
                {
                    dnrdo.Value = (DateTime)nrTelefonPracownik.Data_do;
                }
                else
                {
                    nrTelefonPracownik.Data_do = null;
                }
                Email_pracownik emailPracownik = (Email_pracownik)db.Email_pracownik.Single(a => a.ID_pracownik == pracownik.ID_pracownik);
                pracownik.ID_pracownik = emailPracownik.ID_pracownik;
                tbEmail.Text = emailPracownik.Email;
                demailod.Value = emailPracownik.Data_od;
                if (cbDataDoEmail.Checked)
                {
                    demaildo.Value = (DateTime)emailPracownik.Data_do;
                }
                else
                {
                    emailPracownik.Data_do = null;
                }
                db.SaveChanges();
                cleanTextBox();
                showData();
                MessageBox.Show("Edytowano pracownika!", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nie wprowadzono danych.", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
