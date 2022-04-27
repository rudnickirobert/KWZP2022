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
    public partial class FormHRDepartmentNewWorker : Form
    {
        KWZPEntities db;
        public FormHRDepartmentNewWorker(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            comboBoxAddValue();
            showData();
        }
        private void showData()
        {
            this.dgvpracownik.DataSource = this.db.v_Pracownik.ToList();
            this.dgvpracownik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cleanTextBox()
        {
            tbWorkerSurname.Clear();
            tbWorkerName.Clear();
            tbIdNumber.Clear();
            tbPesel.Clear();
            tbCity.Clear();
            tbStreet.Clear();
            tbBuildingNumber.Clear();
            tbApartmentNumber.Clear();
            tbNumber.Clear();
            tbEmail.Clear();
        }

        private void comboBoxAddValue()
        {
            cbEducation.DataSource = this.db.Wyksztalcenie.ToList();
            cbEducation.ValueMember = "ID_wyksztalcenie";
            cbEducation.DisplayMember = "Nazwa";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkIfTextBoxesNotEmpty()
        {
            return tbWorkerSurname.Text.Length > 0 && tbWorkerName.Text.Length > 0 && tbIdNumber.Text.Length > 0 && tbPesel.Text.Length > 0 && tbNumber.Text.Length > 0 && tbEmail.Text.Length > 0;
        }
        private void AddNewWorker()
        { 
            if (checkIfTextBoxesNotEmpty())
            {
                Pracownik pracownik = new Pracownik();
                pracownik.Nazwisko = tbWorkerSurname.Text;
                pracownik.Imie = tbWorkerName.Text;
                pracownik.Nr_dowodu = tbIdNumber.Text;
                pracownik.Pesel = int.Parse(tbPesel.Text);
                int selectedwyksztalcenie = int.Parse(cbEducation.SelectedValue.ToString());
                pracownik.ID_wyksztalcenie = selectedwyksztalcenie;
                db.Pracownik.Add(pracownik);
                db.SaveChanges();
                Dane_adresowe_pracownik daneAdresowePracownik = new Dane_adresowe_pracownik();
                daneAdresowePracownik.ID_pracownik = pracownik.ID_pracownik;
                daneAdresowePracownik.Miejscowosc = tbCity.Text;
                daneAdresowePracownik.Ulica = tbStreet.Text;
                daneAdresowePracownik.Nr_budynku = tbBuildingNumber.Text;
                daneAdresowePracownik.Nr_lokalu = tbApartmentNumber.Text;
                daneAdresowePracownik.Data_od = dWorkerFrom.Value;
                daneAdresowePracownik.Kod_pocztowy = tbZIPCode.Text;
                if (cbDataDo.Checked)
                {
                    daneAdresowePracownik.Data_do = dWorkerTo.Value;
                }
                db.Dane_adresowe_pracownik.Add(daneAdresowePracownik);
                db.SaveChanges();
                Nr_telefon_pracownik nrTelefonPracownik = new Nr_telefon_pracownik();
                nrTelefonPracownik.ID_pracownik = pracownik.ID_pracownik;
                nrTelefonPracownik.Numer = tbNumber.Text;
                nrTelefonPracownik.Data_od = dNumberFrom.Value;
                if (cbNrTelefonuDataDo.Checked)
                {
                    nrTelefonPracownik.Data_do = dNumberTo.Value;
                }
                db.Nr_telefon_pracownik.Add(nrTelefonPracownik);
                db.SaveChanges();
                Email_pracownik emailPracownik = new Email_pracownik();
                emailPracownik.ID_pracownik = pracownik.ID_pracownik;
                emailPracownik.Email = tbEmail.Text;
                emailPracownik.Data_od = dEmailFrom.Value;
                if (cbEmailDataDo.Checked)
                {
                    emailPracownik.Data_do = dEmailTo.Value;
                }
                db.Email_pracownik.Add(emailPracownik);
                db.SaveChanges();
                cleanTextBox();
                showData();
                MessageBox.Show("Dodano nowego pracownika!", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nie wprowadzono danych.", "Błąd", MessageBoxButtons.OK);
            }
        }
        private void btnAddnewworker_Click(object sender, EventArgs e)
        {
            AddNewWorker();
        }
    }
}
