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
    public partial class FormResDepProducent : Form
    {
        KWZPEntities db;
        public FormResDepProducent(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;  
            initDataGridView(); 
        }
        private void initDataGridView()
        {
            dgvProducent.DataSource = db.v_Producenci.ToList();
            dgvProducent.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvProducent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNazwa.Text))
                {
                    MessageBox.Show("Wpisz nazwę producenta!");
                }
                else
                {
                    Producent producent = new Producent();
                    producent.Nazwa_producenta = txtNazwa.Text;
                    db.Producent.Add(producent);
                    db.SaveChanges();
                    Dane_adresowe_producent daneProducent = new Dane_adresowe_producent();
                    daneProducent.ID_producent = producent.ID_producent;
                    daneProducent.Miejscowosc = txtMiejscowosc.Text;
                    daneProducent.Ulica = txtUlica.Text;
                    daneProducent.Nr_budynku = (int)numNrbudynku.Value;
                    daneProducent.Kod_pocztowy = mtxtKodPocztowy.Text;
                    db.Dane_adresowe_producent.Add(daneProducent);
                    db.SaveChanges();
                    initDataGridView();
                    MessageBox.Show("Poprawnie dodano " + producent.Nazwa_producenta + " do bazy danych");
                }
            }
            catch
            {
                MessageBox.Show("Nie można dodać producenta.");
            }
        }
        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            int daneProducent = int.Parse(this.dgvProducent.CurrentRow.Cells[0].Value.ToString());
            Producent daneProducentID = this.db.Producent.Single(a => a.ID_producent == daneProducent);
            daneProducentID.Nazwa_producenta = txtNazwa.Text;
            Dane_adresowe_producent daneProducentDaneAdresowe = this.db.Dane_adresowe_producent.Single(a => a.ID_producent == daneProducent);
            daneProducentDaneAdresowe.Miejscowosc = txtMiejscowosc.Text;
            daneProducentDaneAdresowe.Ulica = txtUlica.Text;
            daneProducentDaneAdresowe.Nr_budynku = (int)numNrbudynku.Value;
            daneProducentDaneAdresowe.Kod_pocztowy = mtxtKodPocztowy.Text;
            db.SaveChanges();
            initDataGridView();
            MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
        }
        private void dgvProducent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducent.Rows[e.RowIndex];
                txtNazwa.Text = row.Cells[1].Value.ToString();
                txtMiejscowosc.Text = row.Cells[2].Value.ToString();
                txtUlica.Text = row.Cells[3].Value.ToString();
                numNrbudynku.Value = (int)row.Cells[4].Value;
                if (row.Cells[5].Value != null)
                {
                    dgvProducent.CurrentRow.Selected = true;
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
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć producenta: " + this.dgvProducent.CurrentRow.Cells[1].Value + "?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string currentProducent = this.dgvProducent.CurrentRow.Cells[0].Value.ToString();
                    int daneINT = int.Parse(currentProducent);
                    Producent danyProducent = db.Producent.Single(a => a.ID_producent == daneINT);
                    Dane_adresowe_producent daneProducent = db.Dane_adresowe_producent.Single(b => b.ID_producent == daneINT);
                    this.db.Producent.Remove(danyProducent);
                    this.db.Dane_adresowe_producent.Remove(daneProducent);
                    db.SaveChanges();
                    initDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Nie można usunąć producenta, ponieważ jest obecnie wykorzystywany.");
            }
        }
    }
}
