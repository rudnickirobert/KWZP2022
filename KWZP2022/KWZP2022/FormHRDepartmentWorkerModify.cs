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
    public partial class FormHRDepartmentWorkerModify : Form
    {
        KWZPEntities db;
        public FormHRDepartmentWorkerModify(KWZPEntities db)
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
                cbWyksztalcenie.DataSource = this.db.Wyksztalcenies.ToList();
                cbWyksztalcenie.ValueMember = "ID_wyksztalcenie";
                cbWyksztalcenie.DisplayMember = "Nazwa";
            }
            private void dgvpracownik_MouseDoubleClick(object sender, MouseEventArgs e)
            {        
            int dane = int.Parse(dgvpracownik.CurrentRow.Cells[0].Value.ToString());

                    Pracownik pracownik = this.db.Pracowniks.Single(a=>a.ID_pracownik == dane);
                    tbPracownikNazwisko.Text = pracownik.Nazwisko;
                    tbPracownikImie.Text = pracownik.Imie;
                    tbNrdowodu.Text = pracownik.Nr_dowodu;            
                    tbPesel.Text = pracownik.Pesel.ToString();
                    int selectedwyksztalcenie = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
                    pracownik.ID_wyksztalcenie = selectedwyksztalcenie;
                    Dane_adresowe_pracownik dane_adresowe_pracownik = this.db.Dane_adresowe_pracownik.Single(b => b.ID_pracownik == dane);
                    tbMiejscowosc.Text = dane_adresowe_pracownik.Miejscowosc;
                    tbUlica.Text = dane_adresowe_pracownik.Ulica;
                    tbBudynek.Text = dane_adresowe_pracownik.Nr_budynku;
                    tblokal.Text = dane_adresowe_pracownik.Nr_lokalu;
                    dpracownikod.Value = dane_adresowe_pracownik.Data_od;
                    if (dane_adresowe_pracownik.Data_do != null)
                    {
                    checkBox1.Checked = true;
                    dpracownikdo.Value = dane_adresowe_pracownik.Data_do.Value;
                      }
                     else
                     {
                      checkBox1.Checked = false;
                      dpracownikdo.Value = DateTime.Now;
                     }
                    Nr_telefon_pracownik nr_telefon_pracownik = this.db.Nr_telefon_pracownik.Single(c => c.ID_pracownik == dane);

            tbNumer.Text = nr_telefon_pracownik.Numer;
            dnrod.Value = nr_telefon_pracownik.Data_od;
            if (nr_telefon_pracownik.Data_do != null)
            {
                checkBox2.Checked = true;
                dnrod.Value = nr_telefon_pracownik.Data_do.Value;
            }
            else
            {
                checkBox2.Checked = false;
                dnrod.Value = DateTime.Now;
            }
            Email_pracownik email_pracownik = this.db.Email_pracownik.Single(d => d.ID_pracownik == dane);
            tbNumer.Text = email_pracownik.Email;
            demailod.Value = email_pracownik.Data_od;
            if (email_pracownik.Data_do != null)
            {
                checkBox3.Checked = true;
                demailod.Value = email_pracownik.Data_do.Value;
            }
            else
            {
                checkBox3.Checked = false;
                demailod.Value = DateTime.Now;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvpracownik.CurrentRow.Cells[0].Value != null)
            {
                Pracownik pracownik = new Pracownik();
                pracownik.Nazwisko = tbPracownikNazwisko.Text;
                pracownik.Imie = tbPracownikImie.Text;
                pracownik.Nr_dowodu = tbNrdowodu.Text;
                pracownik.Pesel = int.Parse(tbPesel.Text);
                int selectedwyksztalcenie = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
                pracownik.ID_wyksztalcenie = selectedwyksztalcenie;
                Dane_adresowe_pracownik dane_adresowe_pracownik = new Dane_adresowe_pracownik();
                dane_adresowe_pracownik.Miejscowosc = tbMiejscowosc.Text;
                dane_adresowe_pracownik.Ulica = tbUlica.Text;
                dane_adresowe_pracownik.Nr_budynku = tbBudynek.Text;                
                dane_adresowe_pracownik.Nr_lokalu = tblokal.Text;                
                dane_adresowe_pracownik.Data_od = dpracownikod.Value;
                if (checkBox1.Checked is true)
                {
                    dane_adresowe_pracownik.Data_do = dpracownikdo.Value;
                }
                else
                {
                    dane_adresowe_pracownik.Data_do = null;
                }
                Nr_telefon_pracownik nr_telefon_pracownik = new Nr_telefon_pracownik();
                nr_telefon_pracownik.Numer = tbNumer.Text;
                nr_telefon_pracownik.Data_od = dnrod.Value;
                if (checkBox2.Checked is true)
                {
                    nr_telefon_pracownik.Data_do = dnrdo.Value;
                }
                else
                {
                    nr_telefon_pracownik.Data_do = null;
                }
                Email_pracownik email_pracownik = new Email_pracownik();
                email_pracownik.Email = tbNumer.Text;
                email_pracownik.Data_od = demailod.Value;
                if (checkBox3.Checked is true)
                {
                    email_pracownik.Data_do = demaildo.Value;
                }
                else
                {
                    email_pracownik.Data_do = null;
                }
                db.Pracowniks.Add(pracownik);
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

