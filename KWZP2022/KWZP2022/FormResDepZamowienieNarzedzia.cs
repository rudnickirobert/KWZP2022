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
    public partial class FormResDepZamowienieNarzedzia : Form
    {
        KWZPEntities db;
        public FormResDepZamowienieNarzedzia(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initComboBoxes();
            initDataGridView();
        }

        private void initComboBoxes()
        {
            cmbPracownik.DataSource = db.v_Pracownik_zasoby.ToList();
            cmbPracownik.DisplayMember = "Pracownik";
            cmbPracownik.ValueMember = "ID_pracownik";
            cmbDostawca.DataSource = db.Dostawca.ToList();
            cmbDostawca.DisplayMember = "Nazwa_dostawca";
            cmbDostawca.ValueMember = "ID_dostawca";
            cmbNarzedzie.DataSource = db.Narzedzie.ToList();
            cmbNarzedzie.DisplayMember = "Nazwa_narzedzie";
            cmbNarzedzie.ValueMember = "ID_narzedzie";
            cmbProducent.DataSource = db.Producent.ToList();
            cmbProducent.DisplayMember = "Nazwa_producenta";
            cmbProducent.ValueMember = "ID_producent";
        }
        private void initDataGridView()
        {
            this.db = new KWZPEntities();
            dgvZamowienieNarzedzia.DataSource = db.v_Zamowienia_narzedzia_w_trakcie.ToList();
            dgvZamowienieNarzedzia.Columns[6].Visible = false;
            dgvZamowienieNarzedzia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = txtCena.Text.IndexOf(',');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 &&
                        dotIndex < txtCena.SelectionStart &&
                        txtCena.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                    e.Handled = e.KeyChar != ',' ||
                    dotIndex != -1 ||
                    txtCena.Text.Length == 0 ||
                    txtCena.SelectionStart + 2 < txtCena.Text.Length;
            }
        }
        private void btnDodajNarzedzie_Click(object sender, EventArgs e)
        {
            FormResDepNarzedzie narzedzieForm = new FormResDepNarzedzie(db);
            narzedzieForm.ShowDialog();
        }

        private void btnDodajZamowienie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCena.Text) || numSztuk.Value <= 0)
            {
                MessageBox.Show("Wprowadź poprawne dane!");
            }
            else
            {
                Zamowienie_narzedzie zamowienieNarzedzie = new Zamowienie_narzedzie();
                zamowienieNarzedzie.ID_pracownik = (int)cmbPracownik.SelectedValue;
                zamowienieNarzedzie.Data_zamowienia = System.DateTime.Now;
                zamowienieNarzedzie.ID_dostawca = (int)cmbDostawca.SelectedValue;
                db.Zamowienie_narzedzie.Add(zamowienieNarzedzie);
                db.SaveChanges();
                int zamowienieID = zamowienieNarzedzie.ID_zamowienie_narzedzie;
                Szczegoly_zamowienie_narzedzie szZamowienieNarzedzie = new Szczegoly_zamowienie_narzedzie();
                szZamowienieNarzedzie.ID_zamowienie_narzedzie = zamowienieID;
                szZamowienieNarzedzie.ID_narzedzie = (int)cmbNarzedzie.SelectedValue;
                szZamowienieNarzedzie.ID_producent = (int)cmbProducent.SelectedValue;
                szZamowienieNarzedzie.Sztuk = (int)numSztuk.Value;
                szZamowienieNarzedzie.Cena = Convert.ToDecimal(txtCena.Text);
                db.Szczegoly_zamowienie_narzedzie.Add(szZamowienieNarzedzie);
                db.SaveChanges();
                Stan_realizacji_zamowienie_narzedzie stRealizacjaNarzedzie = new Stan_realizacji_zamowienie_narzedzie();
                stRealizacjaNarzedzie.ID_zamowienie_narzedzie = zamowienieID;
                stRealizacjaNarzedzie.ID_status_zamowienie = 1;
                stRealizacjaNarzedzie.Data_stan = System.DateTime.Now;
                stRealizacjaNarzedzie.ID_pracownik = (int)cmbPracownik.SelectedValue;
                db.Stan_realizacji_zamowienie_narzedzie.Add(stRealizacjaNarzedzie);
                db.SaveChanges();
                initDataGridView();
                MessageBox.Show("Poprawnie dodano zamówienie do bazy danych");
            }
        }
        private void btnDodajDostawca_Click(object sender, EventArgs e)
        {
            FormResDepDostawca dostawcaForm = new FormResDepDostawca(db);
            dostawcaForm.ShowDialog();
        }

        private void btnDodajProducenta_Click(object sender, EventArgs e)
        {
            FormResDepProducent producentForm = new FormResDepProducent(db);
            producentForm.ShowDialog();
        }
        private void btnAktualizujStatus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zmienić status zamówienia: " + this.dgvZamowienieNarzedzia.CurrentRow.Cells[0].Value + "?", "Zmiana Statusu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Stan_realizacji_zamowienie_narzedzie stRealizacjaNerzedzie = new Stan_realizacji_zamowienie_narzedzie();
                stRealizacjaNerzedzie.ID_zamowienie_narzedzie = (int)dgvZamowienieNarzedzia.CurrentRow.Cells[0].Value;
                stRealizacjaNerzedzie.ID_status_zamowienie = (int)dgvZamowienieNarzedzia.CurrentRow.Cells[6].Value + 1;
                stRealizacjaNerzedzie.Data_stan = System.DateTime.Now;
                stRealizacjaNerzedzie.ID_pracownik = (int)cmbPracownik.SelectedValue;
                db.Stan_realizacji_zamowienie_narzedzie.Add(stRealizacjaNerzedzie);
                db.SaveChanges();
                MessageBox.Show("Zmieniono status zamówienia dla:" + dgvZamowienieNarzedzia.CurrentRow.Cells[1].Value.ToString());
                initDataGridView();
            }
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
            initComboBoxes();
        }
    }
}
