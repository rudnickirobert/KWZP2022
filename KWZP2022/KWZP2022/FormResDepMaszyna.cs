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
    public partial class FormResDepMaszyna : Form
    {
        KWZPEntities db;
        public FormResDepMaszyna(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbRodzajMaszyna.DataSource = db.Rodzaj_maszyna.ToList();
            cmbRodzajMaszyna.DisplayMember = "Nazwa_rodzaj_maszyna";
            cmbRodzajMaszyna.ValueMember = "ID_rodzaj_maszyna";
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvMaszyna.DataSource = db.Maszyna.ToList();
            for (int i = 0; i < dgvMaszyna.Columns.Count; i++)
            {
                dgvMaszyna.Columns[i].Visible = false;
            }
            dgvMaszyna.Columns["ID_maszyna"].Visible = true;
            dgvMaszyna.Columns[0].HeaderText = "ID";
            dgvMaszyna.Columns["Nazwa_maszyna"].Visible = true;
            dgvMaszyna.Columns["ID_rodzaj_maszyna"].Visible = true;
            dgvMaszyna.Columns["Koszt_RBG"].Visible = true;
            dgvMaszyna.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvMaszyna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void txtKosztRBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = txtKosztRBG.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 &&
                        dotIndex < txtKosztRBG.SelectionStart &&
                        txtKosztRBG.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                    e.Handled = e.KeyChar != '.' ||
                    dotIndex != -1 ||
                    txtKosztRBG.Text.Length == 0 ||
                    txtKosztRBG.SelectionStart + 2 < txtKosztRBG.Text.Length;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNazwaMaszyna.Text))
                {
                    MessageBox.Show("Wpisz nazwę maszyny!");
                }
                else
                {
                    Maszyna maszyna = new Maszyna();
                    maszyna.Nazwa_maszyna = txtNazwaMaszyna.Text;
                    maszyna.ID_rodzaj_maszyna = (int)cmbRodzajMaszyna.SelectedValue;
                    maszyna.Koszt_RBG = Convert.ToDecimal(txtKosztRBG.Text);
                    db.Maszyna.Add(maszyna);
                    db.SaveChanges();
                    initDataGridView();
                    MessageBox.Show("Poprawnie dodano " + maszyna.Nazwa_maszyna + " do bazy danych");
                }
            }
            catch
            {
                MessageBox.Show("Nie można dodać materiału.");
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            this.dgvMaszyna.CurrentRow.Cells[1].Value = txtNazwaMaszyna.Text;
            this.dgvMaszyna.CurrentRow.Cells[2].Value = (int)cmbRodzajMaszyna.SelectedValue;
            db.SaveChanges();
            initDataGridView();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć maszynę: " + this.dgvMaszyna.CurrentRow.Cells[1].Value + "?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string current_maszyna = this.dgvMaszyna.CurrentRow.Cells[0].Value.ToString();
                    int daneINT = int.Parse(current_maszyna);
                    Maszyna danaMaszyna = db.Maszyna.Single(a => a.ID_maszyna == daneINT);
                    this.db.Maszyna.Remove(danaMaszyna);
                    db.SaveChanges();
                    initDataGridView();
                    txtNazwaMaszyna.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Nie można usunąć maszyny, ponieważ jest obecnie wykorzystywana.");
            }
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
            txtNazwaMaszyna.Clear();
            txtKosztRBG.Clear();
        }

        private void dgvMaszyna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMaszyna.Rows[e.RowIndex];
                txtNazwaMaszyna.Text = row.Cells[1].Value.ToString();
                cmbRodzajMaszyna.SelectedValue = row.Cells[2].Value;
            }
        }
    }
}
