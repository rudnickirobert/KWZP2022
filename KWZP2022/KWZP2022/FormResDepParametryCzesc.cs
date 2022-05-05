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
    public partial class FormResDepParametryCzesc : Form
    {
        KWZPEntities db;
        public FormResDepParametryCzesc(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
            cmbCzesc.DataSource = db.Czesc.ToList();
            cmbCzesc.DisplayMember = "Nazwa_czesc";
            cmbCzesc.ValueMember = "ID_czesc";
            cmbParametr.DataSource = db.v_Rodzaj_parametr.ToList();
            cmbParametr.DisplayMember = "Parametr";
            cmbParametr.ValueMember = "ID_rodzaj_parametr";
        }
        private void initDataGridView()
        {
            dgvParametrCzesc.DataSource = db.v_Parametry_czesc.ToList();
            dgvParametrCzesc.Columns[0].Visible = false;
            dgvParametrCzesc.Columns[1].Visible = false;
            dgvParametrCzesc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvParametrCzesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
                    Parametr_czesc parametrCzesc = new Parametr_czesc();
                    parametrCzesc.ID_czesc = (int)cmbCzesc.SelectedValue;
                    parametrCzesc.ID_rodzaj_parametr = (int)cmbParametr.SelectedValue;
                    parametrCzesc.Zakres_gora = Convert.ToDecimal(txtZakresGora.Text);
                    parametrCzesc.Zakres_dol = Convert.ToDecimal(txtZakresDol.Text);
                    db.Parametr_czesc.Add(parametrCzesc);
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
            string czesc = cmbCzesc.SelectedValue.ToString();
            int czescID = int.Parse(czesc);
            List<v_Parametry_czesc> parametryCzesc = db.v_Parametry_czesc.Where(a => a.ID_czesc == czescID).ToList();
            if (parametryCzesc.Count() > 0)
            {
                dgvParametrCzesc.DataSource = parametryCzesc;
                dgvParametrCzesc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć parametr: " + this.dgvParametrCzesc.CurrentRow.Cells[3].Value + "?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string currentParametr = this.dgvParametrCzesc.CurrentRow.Cells[1].Value.ToString();
                int currentParametrINT = int.Parse(currentParametr);
                Parametr_czesc parametrCzesc = db.Parametr_czesc.Single(a => a.ID_rodzaj_parametr == currentParametrINT);
                this.db.Parametr_czesc.Remove(parametrCzesc);
                db.SaveChanges();
                initDataGridView();
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            try
            { 
                if (this.dgvParametrCzesc.CurrentRow.Cells[0].Value != null)
                {
                    if (txtZakresGora.Text == null || txtZakresDol.Text == null || Convert.ToDecimal(txtZakresGora.Text) < Convert.ToDecimal(txtZakresDol.Text))
                    {
                        MessageBox.Show("Wpisz poprawny zakres", "Błąd", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int parametrCzesc = int.Parse(this.dgvParametrCzesc.CurrentRow.Cells[1].Value.ToString());
                        Parametr_czesc parametrCzescRP = this.db.Parametr_czesc.Single(a => a.ID_rodzaj_parametr == parametrCzesc);
                        parametrCzescRP.ID_rodzaj_parametr = (int)cmbParametr.SelectedValue;
                        parametrCzescRP.ID_czesc = (int)cmbCzesc.SelectedValue;
                        parametrCzescRP.Zakres_gora = Convert.ToDecimal(txtZakresGora.Text);
                        parametrCzescRP.Zakres_dol = Convert.ToDecimal(txtZakresDol.Text);
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
            cmbCzesc.DataSource = db.Czesc.ToList();
            cmbCzesc.DisplayMember = "Nazwa_czesc";
            cmbCzesc.ValueMember = "ID_czesc";
            cmbParametr.DataSource = db.v_Rodzaj_parametr.ToList();
            cmbParametr.DisplayMember = "Parametr";
            cmbParametr.ValueMember = "ID_rodzaj_parametr";
        }
    }
}
