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
    public partial class PolproduktForm : Form
    {
        KWZPEntities db;
        public PolproduktForm(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;

            initDataGridViewProdukt();
            initDataGridViewPolprodukt();
            initDataGridViewSkladProdukt();
        }

        private void initDataGridViewPolprodukt()
        {
            dgvPolprodukt.DataSource = db.Slownik_polprodukt.ToList();
            this.dgvPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPolprodukt.Columns["Parametr_polprodukt"].Visible = false;
            dgvPolprodukt.Columns["Proces_polprodukt_czynnosc"].Visible = false;
            dgvPolprodukt.Columns["Sklad_polprodukt"].Visible = false;
            dgvPolprodukt.Columns["Sklad_produkt"].Visible = false;


        }

        private void initDataGridViewProdukt()
        {

            dgvProdukt.DataSource = db.Produkt.ToList();
            this.dgvProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdukt.Columns["Parametr_produkt"].Visible = false;
            dgvProdukt.Columns["Proces_produkt_czynnosc"].Visible = false;
            dgvProdukt.Columns["Sklad_produkt"].Visible = false;
            dgvProdukt.Columns["Sklad_produkt_material"].Visible = false;
            dgvProdukt.Columns["Szczegoly_sprzedaz"].Visible = false;
            dgvProdukt.Columns["Zamowienie_szczegol"].Visible = false;
            dgvProdukt.Columns["Zwrot"].Visible = false;
            dgvProdukt.Columns["Kontrola_jakosci_produkt"].Visible = false;
            dgvProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewSkladProdukt()
        {
            dgvSkladProdukt.DataSource = db.v_Sklad_produkt.ToList();
            this.dgvSkladProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSkladProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Sklad_produkt skladProdukt = new Sklad_produkt();
            Slownik_polprodukt polprodukt = new Slownik_polprodukt();
            polprodukt.Nazwa = txtPolprodukt.Text;
            db.Slownik_polprodukt.Add(polprodukt);
            db.SaveChanges();

            skladProdukt.ID_produkt = int.Parse(this.dgvProdukt.CurrentRow.Cells[0].Value.ToString());

            int numRows = dgvPolprodukt.Rows.Count;
            skladProdukt.ID_polprodukt = int.Parse(this.dgvPolprodukt.Rows[numRows - 1].Cells[0].Value.ToString());
            skladProdukt.Liczba = int.Parse(txtIlosc.Text);
            db.Sklad_produkt.Add(skladProdukt);
            db.SaveChanges();

            initDataGridViewPolprodukt();
            initDataGridViewSkladProdukt();
            MessageBox.Show("Poprawnie dodano " + polprodukt.Nazwa + " do bazy danych");
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {

            this.dgvSkladProdukt.CurrentRow.Cells[1].Value = txtPolprodukt.Text;
            this.dgvSkladProdukt.CurrentRow.Cells[2].Value = int.Parse(txtIlosc.Text);
            db.SaveChanges();
            initDataGridViewSkladProdukt();


        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć produkt: " + this.dgvPolprodukt.CurrentRow.Cells[1].Value, "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string current_polprodukt = this.dgvSkladProdukt.CurrentRow.Cells[1].Value.ToString();
                db.Produkt.Remove(db.Produkt.Where(product => product.Nazwa_produkt == current_polprodukt).First());
                db.SaveChanges();

                initDataGridViewPolprodukt();
                initDataGridViewSkladProdukt();
                txtNazwaProdukt.Text = "";
            }
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            txtNazwaProdukt.Text = "";
            txtPolprodukt.Text = "";
            txtIlosc.Text = "";
            initDataGridViewProdukt();
            initDataGridViewPolprodukt();
            initDataGridViewSkladProdukt();
        }


        private void dgvProdukt_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaProdukt.Text = this.dgvProdukt.CurrentRow.Cells[1].Value.ToString();

        }

        private void dgvSkladProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaProdukt.Text = this.dgvSkladProdukt.CurrentRow.Cells[0].Value.ToString();
            txtPolprodukt.Text = this.dgvSkladProdukt.CurrentRow.Cells[1].Value.ToString();
            txtIlosc.Text = this.dgvSkladProdukt.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvPolprodukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
