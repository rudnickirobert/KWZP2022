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
    public partial class ProduktForm : Form
    {
        KWZPEntities db;
        public ProduktForm(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            dgvProdukt.DataSource = db.Produkt.ToList();
            dgvProdukt.Columns["Parametr_produkt"].Visible = false;
            dgvProdukt.Columns["Proces_produkt_czynnosc"].Visible = false;
            dgvProdukt.Columns["Sklad_produkt"].Visible = false;
            dgvProdukt.Columns["Sklad_produkt_material"].Visible = false;
            dgvProdukt.Columns["Szczegoly_sprzedaz"].Visible = false;
            dgvProdukt.Columns["Zamowienie_szczegol"].Visible = false;
            dgvProdukt.Columns["Zwrot"].Visible = false;
            dgvProdukt.Columns["Kontrola_jakosci_produkt"].Visible = false;
            dgvProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt();
            produkt.Nazwa_produkt = txtNazwaProdukt.Text;
            db.Produkt.Add(produkt);
            db.SaveChanges();
            initDataGridView();
            MessageBox.Show("Poprawnie dodano " + produkt.Nazwa_produkt + " do bazy danych");
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć produkt: " + this.dgvProdukt.CurrentRow.Cells[1].Value, "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string current_product = this.dgvProdukt.CurrentRow.Cells[1].Value.ToString();
                db.Produkt.Remove(db.Produkt.Where(product => product.Nazwa_produkt == current_product).First());
                db.SaveChanges();
                initDataGridView();
                txtNazwaProdukt.Text = "";
            }

        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
            txtNazwaProdukt.Text = "";
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            this.dgvProdukt.CurrentRow.Cells[1].Value = txtNazwaProdukt.Text;
            db.SaveChanges();
            initDataGridView();

        }

        private void dgvProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaProdukt.Text = this.dgvProdukt.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
