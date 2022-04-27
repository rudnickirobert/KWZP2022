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
            tbPracownikNazwisko.Text = pracownik.Nazwisko;
            tbPracownikImie.Text = pracownik.Imie;
            tbNrdowodu.Text = pracownik.Nr_dowodu;
            tbPesel.Text = pracownik.Pesel.ToString();
            int selectedWyksztalcenie = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
            selectedWyksztalcenie = pracownik.ID_wyksztalcenie;
            Dane_adresowe_pracownik daneAdresowePracownik = this.db.Dane_adresowe_pracownik.Single(b => b.ID_pracownik == pracownik.ID_pracownik);
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
            Nr_telefon_pracownik nrTelefonPracownik = this.db.Nr_telefon_pracownik.Single(c => c.ID_pracownik == pracownik.ID_pracownik);

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
            Email_pracownik emailPracownik = this.db.Email_pracownik.Single(d => d.ID_pracownik == pracownik.ID_pracownik);
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
                pracownik.Nazwisko = tbPracownikNazwisko.Text;
                pracownik.Imie = tbPracownikImie.Text;
                pracownik.Nr_dowodu = tbNrdowodu.Text;
                pracownik.Pesel = int.Parse(tbPesel.Text);
                int selectedWyksztalcenie = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
                pracownik.ID_wyksztalcenie = selectedWyksztalcenie;
                Dane_adresowe_pracownik daneAdresowePracownik = (Dane_adresowe_pracownik)db.Dane_adresowe_pracownik.Single(a => a.ID_pracownik == pracownik.ID_pracownik);
                daneAdresowePracownik.ID_pracownik = pracownik.ID_pracownik;
                daneAdresowePracownik.Miejscowosc = tbMiejscowosc.Text;
                daneAdresowePracownik.Ulica = tbUlica.Text;
                daneAdresowePracownik.Nr_budynku = tbBudynek.Text;
                daneAdresowePracownik.Nr_lokalu = tblokal.Text;
                daneAdresowePracownik.Kod_pocztowy = tbKod.Text;
                daneAdresowePracownik.Data_od = dpracownikod.Value;
                if (cbDataDo.Checked)
                {
                    daneAdresowePracownik.Data_do = dpracownikdo.Value;
                }
                else
                {
                    daneAdresowePracownik.Data_do = null;
                }
                Nr_telefon_pracownik nrTelefonPracownik = (Nr_telefon_pracownik)db.Nr_telefon_pracownik.Single(a => a.ID_pracownik == pracownik.ID_pracownik);
                nrTelefonPracownik.ID_pracownik = pracownik.ID_pracownik;
                nrTelefonPracownik.Numer = tbNumer.Text;
                nrTelefonPracownik.Data_od = dnrod.Value;
                if (cbDataDoNrTelefonu.Checked)
                {
                    nrTelefonPracownik.Data_do = dnrdo.Value;
                }
                else
                {
                    nrTelefonPracownik.Data_do = null;
                }
                Email_pracownik emailPracownik = (Email_pracownik)db.Email_pracownik.Single(a => a.ID_pracownik == pracownik.ID_pracownik);
                emailPracownik.ID_pracownik = pracownik.ID_pracownik; 
                emailPracownik.Email = tbEmail.Text;
                emailPracownik.Data_od = demailod.Value;
                if (cbDataDoEmail.Checked)
                {
                    emailPracownik.Data_do = demaildo.Value;
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
