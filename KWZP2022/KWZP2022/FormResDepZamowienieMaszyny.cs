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
    public partial class FormResDepZamowienieMaszyny : Form
    {
        KWZPEntities db;
        public FormResDepZamowienieMaszyny(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
            initComboBoxes();
        }
        private void initComboBoxes()
        {
            cmbPracownik.DataSource = db.v_Pracownik_zasoby.ToList();
            cmbPracownik.DisplayMember = "Pracownik";
            cmbPracownik.ValueMember = "ID_pracownik";
            cmbDostawca.DataSource = db.Dostawca.ToList();
            cmbDostawca.DisplayMember = "Nazwa_dostawca";
            cmbDostawca.ValueMember = "ID_dostawca";
            cmbMaszyna.DataSource = db.Maszyna.ToList();
            cmbMaszyna.DisplayMember = "Nazwa_maszyna";
            cmbMaszyna.ValueMember = "ID_maszyna";
            cmbProducent.DataSource = db.Producent.ToList();
            cmbProducent.DisplayMember = "Nazwa_producenta";
            cmbProducent.ValueMember = "ID_producent";
        }
        private void initDataGridView()
        {
            dgvZamowienieMaszyna.DataSource = db.v_Zamowienia_maszyny_w_trakcie.ToList();
            dgvZamowienieMaszyna.Columns[6].Visible = false;
            dgvZamowienieMaszyna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void btnDodajMaszyna_Click(object sender, EventArgs e)
        {
            FormResDepMaszyna maszynaForm = new FormResDepMaszyna(db);
            maszynaForm.ShowDialog();
        }
        private void btnDodajZamowienie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCena.Text) || numIlosc.Value <= 0)
            {
                MessageBox.Show("Wprowadź poprawne dane!");
            }
            else
            {
                Zamowienie_maszyna zamowienieMaszyna = new Zamowienie_maszyna();
                zamowienieMaszyna.ID_pracownik = (int)cmbPracownik.SelectedValue;
                zamowienieMaszyna.Data_zamowienia = System.DateTime.Now;
                zamowienieMaszyna.ID_dostawca = (int)cmbDostawca.SelectedValue;
                db.Zamowienie_maszyna.Add(zamowienieMaszyna);
                db.SaveChanges();
                int zamowienieID = zamowienieMaszyna.ID_zamowienie_maszyna;
                Szczegoly_zamowienie_maszyna szZamowienieMaszyna = new Szczegoly_zamowienie_maszyna();
                szZamowienieMaszyna.ID_zamowienie_maszyna = zamowienieID;
                szZamowienieMaszyna.ID_maszyna = (int)cmbMaszyna.SelectedValue;
                szZamowienieMaszyna.ID_producent = (int)cmbProducent.SelectedValue;
                szZamowienieMaszyna.Ilosc = (int)numIlosc.Value;
                szZamowienieMaszyna.Cena = Convert.ToDecimal(txtCena.Text);
                db.Szczegoly_zamowienie_maszyna.Add(szZamowienieMaszyna);
                db.SaveChanges();
                Stan_realizacji_zamowienie_maszyna stRealizacjaMaszyna = new Stan_realizacji_zamowienie_maszyna();
                stRealizacjaMaszyna.ID_zamowienie_maszyna = zamowienieID;
                stRealizacjaMaszyna.ID_status_zamowienie = 1;
                stRealizacjaMaszyna.Data_stan = System.DateTime.Now;
                stRealizacjaMaszyna.ID_pracownik = (int)cmbPracownik.SelectedValue;
                db.Stan_realizacji_zamowienie_maszyna.Add(stRealizacjaMaszyna);
                db.SaveChanges();
                initDataGridView();
                MessageBox.Show("Poprawnie dodano zamówienie do bazy danych");
            }
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
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zmienić status zamówienia: " + this.dgvZamowienieMaszyna.CurrentRow.Cells[0].Value + "?", "Zmiana Statusu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Stan_realizacji_zamowienie_maszyna stRealizacjaMaszyna = new Stan_realizacji_zamowienie_maszyna();
                stRealizacjaMaszyna.ID_zamowienie_maszyna = (int)dgvZamowienieMaszyna.CurrentRow.Cells[0].Value;
                stRealizacjaMaszyna.ID_status_zamowienie = (int)dgvZamowienieMaszyna.CurrentRow.Cells[6].Value + 1;
                stRealizacjaMaszyna.Data_stan = System.DateTime.Now;
                stRealizacjaMaszyna.ID_pracownik = (int)cmbPracownik.SelectedValue;
                db.Stan_realizacji_zamowienie_maszyna.Add(stRealizacjaMaszyna);
                db.SaveChanges();
                MessageBox.Show("Zmieniono status zamówienia dla: " + dgvZamowienieMaszyna.CurrentRow.Cells[1].Value.ToString());
                initDataGridView();
                if (stRealizacjaMaszyna.ID_status_zamowienie == 4)
                {
                    MessageBox.Show("Dodaj numer seryjny");
                    FormResDepNrSeryjny formResDepNrSeryjny = new FormResDepNrSeryjny(db);
                    formResDepNrSeryjny.ShowDialog();
                }
            }
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
            initComboBoxes();
        }
    }
}
