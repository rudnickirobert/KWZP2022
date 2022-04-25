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
            ComboBox();
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

        private void ComboBox()
        {
            cbWyksztalcenie.DataSource = this.db.Wyksztalcenie.ToList();
            cbWyksztalcenie.ValueMember = "ID_wyksztalcenie";
            cbWyksztalcenie.DisplayMember = "Nazwa";
        }
        private void btnAddnewworker_Click(object sender, EventArgs e)
        {
            if (tbPracownikNazwisko.Text.Length > 0 && tbPracownikImie.Text.Length > 0 && tbNrdowodu.Text.Length > 0 && tbPesel.Text.Length > 0 && tbMiejscowosc.Text.Length > 0 && tbUlica.Text.Length > 0 && tbBudynek.Text.Length > 0 && tblokal.Text.Length > 0 && tbNumer.Text.Length > 0 && tbEmail.Text.Length > 0)
            {
                Pracownik pracownik = new Pracownik();
                pracownik.Nazwisko = tbPracownikNazwisko.Text;
                pracownik.Imie = tbPracownikImie.Text;
                pracownik.Nr_dowodu = tbNrdowodu.Text;
                pracownik.Pesel = tbPesel.Text;
                int selectedwyksztalcenie = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
                pracownik.ID_wyksztalcenie = selectedwyksztalcenie;
                Dane_adresowe_pracownik daneAdresowePracownik = new Dane_adresowe_pracownik();
                daneAdresowePracownik.Miejscowosc = tbMiejscowosc.Text;
                daneAdresowePracownik.Ulica = tbUlica.Text;
                daneAdresowePracownik.Nr_budynku = tbBudynek.Text;               
                daneAdresowePracownik.Nr_lokalu = tblokal.Text;                
                daneAdresowePracownik.Data_od = dpracownikod.Value;
                if (cbDataDo.Checked is true)
                {
                    daneAdresowePracownik.Data_do = dpracownikdo.Value;
                }
                Nr_telefon_pracownik nrTelefonPracownik = new Nr_telefon_pracownik();
                nrTelefonPracownik.Numer = tbNumer.Text;
                nrTelefonPracownik.Data_od = dnrod.Value;
                if (cbNrTelefonuDataDo.Checked is true)
                {
                    nrTelefonPracownik.Data_do = dnrdo.Value;
                }
                Email_pracownik emailPracownik = new Email_pracownik();
                emailPracownik.Email = tbNumer.Text;
                emailPracownik.Data_od = demailod.Value;
                if (cbEmailDataDo.Checked is true)
                {
                    emailPracownik.Data_do = demaildo.Value;
                }
                db.Pracownik.Add(pracownik);
                db.Dane_adresowe_pracownik.Add(daneAdresowePracownik);
                db.Nr_telefon_pracownik.Add(nrTelefonPracownik);
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
    }
}
