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
    public partial class FormResDepParametryNarzedzie : Form
    {
        KWZPEntities db;
        public FormResDepParametryNarzedzie(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
            cmbNarzedzie.DataSource = db.Narzedzie.ToList();
            cmbNarzedzie.DisplayMember = "Nazwa_narzedzie";
            cmbNarzedzie.ValueMember = "ID_narzedzie";
            cmbParametr.DataSource = db.v_Rodzaj_parametr.ToList();
            cmbParametr.DisplayMember = "Parametr";
            cmbParametr.ValueMember = "ID_rodzaj_parametr";
        }
        private void initDataGridView()
        {
            dgvParametrNarzedzie.DataSource = db.v_Parametry_narzedzie.ToList();
            dgvParametrNarzedzie.Columns[0].Visible = false;
            dgvParametrNarzedzie.Columns[1].Visible = false;
            dgvParametrNarzedzie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvParametrNarzedzie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtZakresGora.Text == null || txtZakresDol.Text == null || Convert.ToDecimal(txtZakresGora.Text) < Convert.ToDecimal(txtZakresDol.Text))
                {
                    MessageBox.Show("Wpisz poprawny zakres", "Błąd", MessageBoxButtons.OK);
                }
                else
                {
                    Parametr_narzedzie parametrNarzedzie = new Parametr_narzedzie();
                    parametrNarzedzie.ID_narzedzie = (int)cmbNarzedzie.SelectedValue;
                    parametrNarzedzie.ID_rodzaj_parametr = (int)cmbParametr.SelectedValue;
                    parametrNarzedzie.Zakres_gora = Convert.ToDecimal(txtZakresGora.Text);
                    parametrNarzedzie.Zakres_dol = Convert.ToDecimal(txtZakresDol.Text);
                    db.Parametr_narzedzie.Add(parametrNarzedzie);
                    db.SaveChanges();
                    initDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Powtórzono parametr", "Błąd", MessageBoxButtons.OK);
            }
        }

        private void btnWczytajParametr_Click(object sender, EventArgs e)
        {
            {
                string narzedzie = cmbNarzedzie.SelectedValue.ToString();
                int narzedzieID = int.Parse(narzedzie);
                List<v_Parametry_narzedzie> parametryNarzedzie = db.v_Parametry_narzedzie.Where(a => a.ID_narzedzie == narzedzieID).ToList();
                if (parametryNarzedzie.Count() > 0)
                {
                    dgvParametrNarzedzie.DataSource = parametryNarzedzie;
                    dgvParametrNarzedzie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć parametr: " + this.dgvParametrNarzedzie.CurrentRow.Cells[3].Value + "?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string currentParametr = this.dgvParametrNarzedzie.CurrentRow.Cells[1].Value.ToString();
                int currentParametrINT = int.Parse(currentParametr);
                Parametr_narzedzie parametrNarzedzie = db.Parametr_narzedzie.Single(a => a.ID_rodzaj_parametr == currentParametrINT);
                this.db.Parametr_narzedzie.Remove(parametrNarzedzie);
                db.SaveChanges();
                initDataGridView();
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvParametrNarzedzie.CurrentRow.Cells[0].Value != null)
                {
                    if (txtZakresGora.Text == null || txtZakresDol.Text == null || Convert.ToDecimal(txtZakresGora.Text) < Convert.ToDecimal(txtZakresDol.Text))
                    {
                        MessageBox.Show("Wpisz poprawny zakres", "Błąd", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int parametrNarzedzie = int.Parse(this.dgvParametrNarzedzie.CurrentRow.Cells[1].Value.ToString());
                        Parametr_narzedzie parametrNarzedzieRP = this.db.Parametr_narzedzie.Single(a => a.ID_rodzaj_parametr == parametrNarzedzie);
                        parametrNarzedzieRP.ID_rodzaj_parametr = (int)cmbParametr.SelectedValue;
                        parametrNarzedzieRP.ID_narzedzie = (int)cmbNarzedzie.SelectedValue;
                        parametrNarzedzieRP.Zakres_gora = Convert.ToDecimal(txtZakresGora.Text);
                        parametrNarzedzieRP.Zakres_dol = Convert.ToDecimal(txtZakresDol.Text);
                        db.SaveChanges();
                        initDataGridView();
                        MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Powtórzono parametr", "Błąd", MessageBoxButtons.OK);
            }
        }        
        private void txtZakresDol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = txtZakresDol.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 &&
                        dotIndex < txtZakresDol.SelectionStart &&
                        txtZakresDol.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                    e.Handled = e.KeyChar != '.' ||
                    dotIndex != -1 ||
                    txtZakresDol.Text.Length == 0 ||
                    txtZakresDol.SelectionStart + 2 < txtZakresDol.Text.Length;
            }
        }
        private void txtZakresGora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = txtZakresGora.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 &&
                        dotIndex < txtZakresGora.SelectionStart &&
                        txtZakresGora.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                    e.Handled = e.KeyChar != '.' ||
                    dotIndex != -1 ||
                    txtZakresGora.Text.Length == 0 ||
                    txtZakresGora.SelectionStart + 2 < txtZakresGora.Text.Length;
            }
        }

        private void btnNowyParametr_Click(object sender, EventArgs e)
        {
            FormResDepDodajParametr dodajNowyParamter = new FormResDepDodajParametr(db);
            dodajNowyParamter.ShowDialog();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
            cmbNarzedzie.DataSource = db.Narzedzie.ToList();
            cmbNarzedzie.DisplayMember = "Nazwa_narzedzie";
            cmbNarzedzie.ValueMember = "ID_narzedzie";
            cmbParametr.DataSource = db.v_Rodzaj_parametr.ToList();
            cmbParametr.DisplayMember = "Parametr";
            cmbParametr.ValueMember = "ID_rodzaj_parametr";
        }
    }
}
