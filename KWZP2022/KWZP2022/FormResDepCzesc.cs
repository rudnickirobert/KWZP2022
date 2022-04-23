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
    public partial class FormResDepCzesc : Form
    {
        KWZPEntities db;
        public FormResDepCzesc(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbRodzajCzesc.DataSource = db.Rodzaj_czesc.ToList();
            cmbRodzajCzesc.DisplayMember = "Nazwa_rodzaj_czesc";
            cmbRodzajCzesc.ValueMember = "ID_rodzaj_czesc";
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvCzesc.DataSource = db.Czesc.ToList();
            for (int i = 0; i < dgvCzesc.Columns.Count; i++)
            {
                dgvCzesc.Columns[i].Visible = false;
            }
            dgvCzesc.Columns["ID_czesc"].Visible = true;
            dgvCzesc.Columns[0].HeaderText = "ID";
            dgvCzesc.Columns["Nazwa_czesc"].Visible = true;
            dgvCzesc.Columns["ID_rodzaj_czesc"].Visible = true;
            dgvCzesc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvCzesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNazwaCzesc.Text))
                {
                    MessageBox.Show("Wpisz nazwę części!");
                }
                else
                {
                    Czesc czesc = new Czesc();
                    czesc.Nazwa_czesc = txtNazwaCzesc.Text;
                    czesc.ID_rodzaj_czesc = (int)cmbRodzajCzesc.SelectedValue;
                    db.Czesc.Add(czesc);
                    db.SaveChanges();
                    initDataGridView();
                    MessageBox.Show("Poprawnie dodano " + czesc.Nazwa_czesc + " do bazy danych");
                }
            }
            catch
            {
                MessageBox.Show("Nie można dodać materiału.");
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            this.dgvCzesc.CurrentRow.Cells[1].Value = txtNazwaCzesc.Text;
            this.dgvCzesc.CurrentRow.Cells[2].Value = (int)cmbRodzajCzesc.SelectedValue;
            db.SaveChanges();
            initDataGridView();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć część: " + this.dgvCzesc.CurrentRow.Cells[1].Value + "?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string current_czesc = this.dgvCzesc.CurrentRow.Cells[0].Value.ToString();
                    int daneINT = int.Parse(current_czesc);
                    Czesc danaCzesc = db.Czesc.Single(a => a.ID_czesc == daneINT);
                    this.db.Czesc.Remove(danaCzesc);
                    db.SaveChanges();
                    initDataGridView();
                    txtNazwaCzesc.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Nie można usunąć części, ponieważ jest obecnie wykorzystywany.");
            }
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
            txtNazwaCzesc.Clear();
        }

        private void dgvCzesc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCzesc.Rows[e.RowIndex];
                txtNazwaCzesc.Text = row.Cells[1].Value.ToString();
                cmbRodzajCzesc.SelectedValue = row.Cells[2].Value;
            }
        }
    }
}
