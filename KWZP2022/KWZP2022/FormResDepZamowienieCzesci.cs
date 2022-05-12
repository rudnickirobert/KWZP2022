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
    public partial class FormResDepZamowienieCzesci : Form
    {
        KWZPEntities db;
        public FormResDepZamowienieCzesci(KWZPEntities db)
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
            cmbCzesc.DataSource = db.Czesc.ToList();
            cmbCzesc.DisplayMember = "Nazwa_czesc";
            cmbCzesc.ValueMember = "ID_czesc";
            cmbProducent.DataSource = db.Producent.ToList();
            cmbProducent.DisplayMember = "Nazwa_producenta";
            cmbProducent.ValueMember = "ID_producent";
        }
        private void initDataGridView()
        {
            dgvZamowienieCzesci.DataSource = db.v_Zamowienia_czesci_w_trakcie.ToList();
            dgvZamowienieCzesci.Columns[6].Visible = false;
            dgvZamowienieCzesci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

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
        private void btnDodajZamowienie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCena.Text) || numIlosc.Value <= 0)
            {
                MessageBox.Show("Wprowadź poprawne dane!");
            }
            else
            {
                Zamowienie_czesc zamowienieCzesc = new Zamowienie_czesc();
                zamowienieCzesc.ID_pracownik = (int)cmbPracownik.SelectedValue;
                zamowienieCzesc.Data_zamowienia = System.DateTime.Now;
                zamowienieCzesc.ID_dostawca = (int)cmbDostawca.SelectedValue;
                db.Zamowienie_czesc.Add(zamowienieCzesc);
                db.SaveChanges();
                int zamowienieID = zamowienieCzesc.ID_zamowienie_czesc;
                Szczegoly_zamowienie_czesc szZamowienieCzesc = new Szczegoly_zamowienie_czesc();
                szZamowienieCzesc.ID_zamowienie_czesc = zamowienieID;
                szZamowienieCzesc.ID_czesc = (int)cmbCzesc.SelectedValue;
                szZamowienieCzesc.ID_producent = (int)cmbProducent.SelectedValue;
                szZamowienieCzesc.Ilosc = (int)numIlosc.Value;
                szZamowienieCzesc.Cena = Convert.ToDecimal(txtCena.Text);
                db.Szczegoly_zamowienie_czesc.Add(szZamowienieCzesc);
                db.SaveChanges();
                Stan_realizacji_zamowienie_czesc stRealizacjaCzesc = new Stan_realizacji_zamowienie_czesc();
                stRealizacjaCzesc.ID_zamowienie_czesc = zamowienieID;
                stRealizacjaCzesc.ID_status_zamowienie = 1;
                stRealizacjaCzesc.Data_stan = System.DateTime.Now;
                stRealizacjaCzesc.ID_pracownik = (int)cmbPracownik.SelectedValue;
                db.Stan_realizacji_zamowienie_czesc.Add(stRealizacjaCzesc);
                db.SaveChanges();
                initDataGridView();
                MessageBox.Show("Poprawnie dodano zamówienie do bazy danych");
            }

        }
        private void btnDodajCzesc_Click(object sender, EventArgs e)
        {
            FormResDepCzesc czescForm = new FormResDepCzesc(db);
            czescForm.ShowDialog();
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
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zmienić status zamówienia: " + this.dgvZamowienieCzesci.CurrentRow.Cells[0].Value + "?", "Zmiana Statusu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Stan_realizacji_zamowienie_czesc stRealizacjaCzesc = new Stan_realizacji_zamowienie_czesc();
                stRealizacjaCzesc.ID_zamowienie_czesc = (int)dgvZamowienieCzesci.CurrentRow.Cells[0].Value;
                stRealizacjaCzesc.ID_status_zamowienie = (int)dgvZamowienieCzesci.CurrentRow.Cells[6].Value + 1;
                stRealizacjaCzesc.Data_stan = System.DateTime.Now;
                stRealizacjaCzesc.ID_pracownik = (int)cmbPracownik.SelectedValue;
                db.Stan_realizacji_zamowienie_czesc.Add(stRealizacjaCzesc);
                db.SaveChanges();
                MessageBox.Show("Zmieniono status zamówienia dla: " + dgvZamowienieCzesci.CurrentRow.Cells[1].Value.ToString());
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
