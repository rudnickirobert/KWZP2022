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
    public partial class FormResDepNarzedzie : Form
    {
        KWZPEntities db;
        public FormResDepNarzedzie(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvNarzedzie.DataSource = db.Narzedzie.ToList();
            for (int i = 0; i < dgvNarzedzie.Columns.Count; i++)
            {
                dgvNarzedzie.Columns[i].Visible = false;
            }
            dgvNarzedzie.Columns["ID_narzedzie"].Visible = true;
            dgvNarzedzie.Columns[0].HeaderText = "ID";
            dgvNarzedzie.Columns["Nazwa_narzedzie"].Visible = true;
            dgvNarzedzie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvNarzedzie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNazwaNarzedzie.Text))
                {
                    MessageBox.Show("Wpisz nazwę narzędzia!");
                }
                else
                {
                    Narzedzie narzedzie = new Narzedzie();
                    narzedzie.Nazwa_narzedzie = txtNazwaNarzedzie.Text;
                    db.Narzedzie.Add(narzedzie);
                    db.SaveChanges();
                    initDataGridView();
                    MessageBox.Show("Poprawnie dodano " + narzedzie.Nazwa_narzedzie + " do bazy danych");
                }
            }
            catch
            {
                MessageBox.Show("Nie można dodać narzędzia.");
            }
        }
        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć narzędzie: " + this.dgvNarzedzie.CurrentRow.Cells[1].Value + "?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string current_narzedzie = this.dgvNarzedzie.CurrentRow.Cells[0].Value.ToString();
                    int daneINT = int.Parse(current_narzedzie);
                    Narzedzie daneNarzedzie = db.Narzedzie.Single(a => a.ID_narzedzie == daneINT);
                    this.db.Narzedzie.Remove(daneNarzedzie);
                    db.SaveChanges();
                    initDataGridView();
                    txtNazwaNarzedzie.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Nie można usunąć narzędzia, ponieważ jest obecnie wykorzystywane.");
            }
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
            txtNazwaNarzedzie.Clear();
        }
        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            this.dgvNarzedzie.CurrentRow.Cells[1].Value = txtNazwaNarzedzie.Text;
            db.SaveChanges();
            initDataGridView();
        }
        private void dgvNarzedzie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNarzedzie.Rows[e.RowIndex];
                txtNazwaNarzedzie.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnDodajParametr_Click(object sender, EventArgs e)
        {
            FormResDepParametryNarzedzie parametrNarzedzie = new FormResDepParametryNarzedzie(db);
            parametrNarzedzie.ShowDialog();
        }
    }
}