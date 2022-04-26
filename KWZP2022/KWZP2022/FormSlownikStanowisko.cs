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
    public partial class FormSlownikStanowisko : Form
    {
        KWZPEntities db;
        public FormSlownikStanowisko(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            dgvStanowisko.DataSource = db.Slownik_stanowisko.ToList();
            dgvStanowisko.Columns["ID_nazwa_stanowiska"].HeaderText = "ID";
            dgvStanowisko.Columns["Nazwa_stanowiska"].HeaderText = "Nazwa";
            dgvStanowisko.Columns["Stanowisko_produkcyjne"].Visible = false;
            dgvStanowisko.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Slownik_stanowisko slownikStanowisko = new Slownik_stanowisko();
            slownikStanowisko.Nazwa_stanowiska = txtNazwaStanowisko.Text;
            db.Slownik_stanowisko.Add(slownikStanowisko);
            db.SaveChanges();
            initDataGridView();
            MessageBox.Show("Poprawnie dodano " + slownikStanowisko.Nazwa_stanowiska + " do słownika");
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            this.dgvStanowisko.CurrentRow.Cells[1].Value = txtNazwaStanowisko.Text;
            db.SaveChanges();
            txtNazwaStanowisko.Text = "";
            initDataGridView();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć: " + this.dgvStanowisko.CurrentRow.Cells[1].Value, "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string current_stanowisko = this.dgvStanowisko.CurrentRow.Cells[1].Value.ToString();
                db.Slownik_stanowisko.Remove(db.Slownik_stanowisko.Where(stanowisko => stanowisko.Nazwa_stanowiska == current_stanowisko).First());
                db.SaveChanges();
                initDataGridView();
                txtNazwaStanowisko.Text = "";
            }
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
            txtNazwaStanowisko.Text = "";
        }

        private void dgvStanowisko_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaStanowisko.Text = this.dgvStanowisko.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodajStanowisko_Click(object sender, EventArgs e)
        {
            FormSkladStanowisko skladStanowisko = new FormSkladStanowisko(db);
            skladStanowisko.ShowDialog();
        }
    }
}
