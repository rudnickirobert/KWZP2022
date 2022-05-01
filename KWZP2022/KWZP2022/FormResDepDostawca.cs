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
    public partial class FormResDepDostawca : Form
    {
        KWZPEntities db;
        public FormResDepDostawca(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvDostawca.DataSource = db.v_Dostawcy.ToList();
            dgvDostawca.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvDostawca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNazwa.Text))
                {
                    MessageBox.Show("Wpisz nazwę dostawcy!");
                }
                else
                {
                    Dostawca dostawca = new Dostawca();
                    dostawca.Nazwa_dostawca = txtNazwa.Text;
                    db.Dostawca.Add(dostawca);
                    db.SaveChanges();
                    Dane_adresowe_dostawca daneDostawca = new Dane_adresowe_dostawca();
                    daneDostawca.ID_dostawca = dostawca.ID_dostawca;
                    daneDostawca.Miejscowosc = txtMiejscowosc.Text;
                    daneDostawca.Ulica = txtUlica.Text;
                    daneDostawca.Nr_budynku = (int)numNrbudynku.Value;
                    daneDostawca.Kod_pocztowy = mtxtKodPocztowy.Text;
                    db.Dane_adresowe_dostawca.Add(daneDostawca);
                    db.SaveChanges();
                    initDataGridView();
                    MessageBox.Show("Poprawnie dodano " + dostawca.Nazwa_dostawca + " do bazy danych");
                }
            }
            catch
            {
                MessageBox.Show("Nie można dodać dostawcy.");
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            int daneDostawca = int.Parse(this.dgvDostawca.CurrentRow.Cells[0].Value.ToString());
            Dostawca daneDostawcaID = this.db.Dostawca.Single(a => a.ID_dostawca == daneDostawca);
            daneDostawcaID.Nazwa_dostawca = txtNazwa.Text;
            Dane_adresowe_dostawca daneDostawcaDaneAdresowe = this.db.Dane_adresowe_dostawca.Single(a => a.ID_dostawca == daneDostawca);
            daneDostawcaDaneAdresowe.Miejscowosc = txtMiejscowosc.Text;
            daneDostawcaDaneAdresowe.Ulica = txtUlica.Text;
            daneDostawcaDaneAdresowe.Nr_budynku = (int)numNrbudynku.Value;
            daneDostawcaDaneAdresowe.Kod_pocztowy = mtxtKodPocztowy.Text;
            db.SaveChanges();
            initDataGridView();
            MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
        }
        private void dgvDostawca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDostawca.Rows[e.RowIndex];
                txtNazwa.Text = row.Cells[1].Value.ToString();
                txtMiejscowosc.Text = row.Cells[2].Value.ToString();
                txtUlica.Text = row.Cells[3].Value.ToString();
                numNrbudynku.Value = (int)row.Cells[4].Value;
                if (row.Cells[5].Value != null)
                {
                    dgvDostawca.CurrentRow.Selected = true;
                    mtxtKodPocztowy.Text = row.Cells[5].Value.ToString();
                }
                else
                {
                    mtxtKodPocztowy.Clear();
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć dostawcę: " + this.dgvDostawca.CurrentRow.Cells[1].Value + "?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string currentDostawca = this.dgvDostawca.CurrentRow.Cells[0].Value.ToString();
                    int daneINT = int.Parse(currentDostawca);
                    Dostawca danyDostawca = db.Dostawca.Single(a => a.ID_dostawca == daneINT);
                    Dane_adresowe_dostawca daneDostawcy = db.Dane_adresowe_dostawca.Single(b => b.ID_dostawca == daneINT);
                    this.db.Dostawca.Remove(danyDostawca);
                    this.db.Dane_adresowe_dostawca.Remove(daneDostawcy);
                    db.SaveChanges();
                    initDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Nie można usunąć dostawcy, ponieważ jest obecnie wykorzystywany.");
            }
        }
    }
}
