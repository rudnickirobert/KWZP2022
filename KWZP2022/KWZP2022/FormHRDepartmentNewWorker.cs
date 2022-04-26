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
            comboBox();
            showData();
        }
        private void showData()
        {
            this.dgvpracownik.DataSource = this.db.v_Pracownik.ToList();
            this.dgvpracownik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewWorker()
        { 
            if (tbPracownikNazwisko.Text.Length > 0 && tbPracownikImie.Text.Length > 0 && tbNrdowodu.Text.Length > 0 && tbPesel.Text.Length > 0 && tbNumer.Text.Length > 0 && tbEmail.Text.Length > 0)// && tbMiejscowosc.Text.Length > 0 && tbUlica.Text.Length > 0 && tbBudynek.Text.Length > 0 && tblokal.Text.Length > 0)
            {
                Pracownik pracownik = new Pracownik();
                pracownik.Nazwisko = tbPracownikNazwisko.Text;
                pracownik.Imie = tbPracownikImie.Text;
                pracownik.Nr_dowodu = tbNrdowodu.Text;
                pracownik.Pesel = int.Parse(tbPesel.Text);
                int selectedwyksztalcenie = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
                pracownik.ID_wyksztalcenie = selectedwyksztalcenie;
                db.Pracownik.Add(pracownik);
                db.SaveChanges();
                Dane_adresowe_pracownik daneAdresowePracownik = new Dane_adresowe_pracownik();
                daneAdresowePracownik.ID_pracownik = pracownik.ID_pracownik;
                daneAdresowePracownik.Miejscowosc = tbMiejscowosc.Text;
                daneAdresowePracownik.Ulica = tbUlica.Text;
                daneAdresowePracownik.Nr_budynku = tbBudynek.Text;
                daneAdresowePracownik.Nr_lokalu = tblokal.Text;
                daneAdresowePracownik.Data_od = dpracownikod.Value;
                daneAdresowePracownik.Kod_pocztowy = tbKod.Text;
                if (cbDataDo.Checked)
                {
                    daneAdresowePracownik.Data_do = dpracownikdo.Value;
                }
                db.Dane_adresowe_pracownik.Add(daneAdresowePracownik);
                db.SaveChanges();
                Nr_telefon_pracownik nrTelefonPracownik = new Nr_telefon_pracownik();
                nrTelefonPracownik.ID_pracownik = pracownik.ID_pracownik;
                nrTelefonPracownik.Numer = tbNumer.Text;
                nrTelefonPracownik.Data_od = dnrod.Value;
                if (cbNrTelefonuDataDo.Checked)
                {
                    nrTelefonPracownik.Data_do = dnrdo.Value;
                }
                db.Nr_telefon_pracownik.Add(nrTelefonPracownik);
                db.SaveChanges();
                Email_pracownik emailPracownik = new Email_pracownik();
                emailPracownik.ID_pracownik = pracownik.ID_pracownik;
                emailPracownik.Email = tbEmail.Text;
                emailPracownik.Data_od = demailod.Value;
                if (cbEmailDataDo.Checked)
                {
                    emailPracownik.Data_do = demaildo.Value;
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
