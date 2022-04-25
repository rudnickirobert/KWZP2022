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
    public partial class FormSalesHRDepartmentNewWorker: Form
    {
        KWZPEntities db;
        public FormSalesHRDepartmentNewWorker(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            ComboBox();
            showData();
        }
        private void showData()
        {
            this.dgvpracownik.DataSource = this.db.v_Pracownik.ToList();
            this.dgvpracownik.AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            AddNewWorker();
        }
        private void AddNewWorker()
        {
            if (tbPracownikNazwisko.Text.Length > 0 && tbPracownikImie.Text.Length > 0 && tbNrdowodu.Text.Length > 0 && tbPesel.Text.Length > 0 && tbMiejscowosc.Text.Length > 0 && tbUlica.Text.Length > 0 && tbBudynek.Text.Length > 0 && tblokal.Text.ToString().Length > 0 && tbNumer.Text.Length > 0 && tbEmail.Text.Length > 0)
            {
                Pracownik pracownik = new Pracownik();
                pracownik.Nazwisko = tbPracownikNazwisko.Text;
                pracownik.Imie = tbPracownikImie.Text;
                pracownik.Nr_dowodu = tbNrdowodu.Text;
                pracownik.Pesel = tbPesel.Text;
                int selectedwyksztalcenie = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
                pracownik.ID_wyksztalcenie = selectedwyksztalcenie;
                Dane_adresowe_pracownik dane_adresowe_pracownik = new Dane_adresowe_pracownik();
                dane_adresowe_pracownik.Miejscowosc = tbMiejscowosc.Text;
                dane_adresowe_pracownik.Ulica = tbUlica.Text;
                dane_adresowe_pracownik.Nr_budynku = tbBudynek.Text;
                if (tblokal.Text.Length > 0)
                {
                    dane_adresowe_pracownik.Nr_lokalu = tblokal.Text;
                }
                dane_adresowe_pracownik.Data_od = dpracownikod.Value;
                if (cbDataDo.Checked is true)
                {
                    dane_adresowe_pracownik.Data_do = dpracownikdo.Value;
                }
                Nr_telefon_pracownik nr_telefon_pracownik = new Nr_telefon_pracownik();
                nr_telefon_pracownik.Numer = tbNumer.Text;
                nr_telefon_pracownik.Data_od = dnrod.Value;
                if (cbNrTelefonuDataDo.Checked is true)
                {
                    nr_telefon_pracownik.Data_do = dnrdo.Value;
                }
                Email_pracownik email_pracownik = new Email_pracownik();
                email_pracownik.Email = tbNumer.Text;
                email_pracownik.Data_od = demailod.Value;
                if (cbEmailDataDo.Checked is true)
                {
                    email_pracownik.Data_do = demaildo.Value;
                }
                db.Pracownik.Add(pracownik);
                db.Dane_adresowe_pracownik.Add(dane_adresowe_pracownik);
                db.Nr_telefon_pracownik.Add(nr_telefon_pracownik);
                db.Email_pracownik.Add(email_pracownik);
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
