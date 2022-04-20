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
    public partial class Parametr_polproduktForm : Form
    {
        KWZPEntities db;
        public Parametr_polproduktForm(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridViewPolprodukt_parametry();
            initDataGridPolprodukt();
        }

        private void initDataGridViewPolprodukt_parametry()
        {
            dgvPolprodukt_parametry.DataSource = db.v_Parametry_polprodukt.ToList();
            this.dgvPolprodukt_parametry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                  }
        private void initDataGridPolprodukt()
        {
            dgvPolprodukt.DataSource = db.Slownik_polprodukt.ToList();
            this.dgvPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPolprodukt.Columns["Parametr_polprodukt"].Visible = false;
            dgvPolprodukt.Columns["Proces_polprodukt_czynnosc"].Visible = false;
            dgvPolprodukt.Columns["Sklad_produkt"].Visible = false;
            dgvPolprodukt.Columns["Sklad_polprodukt"].Visible = false;
            dgvPolprodukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtNazwaPolprodukt_parametr_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void dgvPolprodukt_parametry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtNazwaPolprodukt_parametr.Text = this.dgvPolprodukt.CurrentRow.Cells[1].Value.ToString();
            //cBParametr_polprodukt.Text = this.dgvPolprodukt.CurrentRow.Cells[2].Value.ToString();
           
           // txtZakres_dolny_Polprodukt.Text = this.dgvPolprodukt.CurrentRow.Cells[3].Value.ToString();
           // txtZakre_gorny_polprodukt.Text = this.dgvPolprodukt.CurrentRow.Cells[4].Value.ToString();
            
            //cBJednostka.Text = this.dgvPolprodukt.CurrentRow.Cells[5].Value.ToString();
        }

        private void Parametr_polproduktForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'kWZPDataSet3.Jednostka' . Możesz go przenieść lub usunąć.
            this.jednostkaTableAdapter.Fill(this.kWZPDataSet3.Jednostka);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'kWZPDataSet.Rodzaj_parametr' . Możesz go przenieść lub usunąć.
            this.rodzaj_parametrTableAdapter.Fill(this.kWZPDataSet.Rodzaj_parametr);

        }

        private void dgvPolprodukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaPolprodukt_parametr.Text = this.dgvPolprodukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            {
                Parametr_polprodukt parametr_Polprodukt = new Parametr_polprodukt();                
                parametr_Polprodukt.Zakres_gora = int.Parse(txtZakre_gorny_polprodukt.Text);
                parametr_Polprodukt.Zakres_dol = int.Parse(txtZakres_dolny_Polprodukt.Text);
                db.Parametr_polprodukt.Add(parametr_Polprodukt);
                db.SaveChanges();
                initDataGridPolprodukt();
                initDataGridViewPolprodukt_parametry();
                MessageBox.Show("Poprawnie dodano " + parametr_Polprodukt.Slownik_polprodukt + " do bazy danych");
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            this.dgvPolprodukt_parametry.CurrentRow.Cells[1].Value = txtNazwaPolprodukt_parametr.Text;
            this.dgvPolprodukt_parametry.CurrentRow.Cells[2].Value = int.Parse(txtZakres_dolny_Polprodukt.Text);
            this.dgvPolprodukt_parametry.CurrentRow.Cells[3].Value = int.Parse(txtZakre_gorny_polprodukt.Text);
            db.SaveChanges();
            initDataGridViewPolprodukt_parametry();

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {

        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            txtNazwaPolprodukt_parametr.Text = "";            
            txtZakres_dolny_Polprodukt.Text = "";
            txtZakre_gorny_polprodukt.Text = "";
            initDataGridViewPolprodukt_parametry();
            initDataGridPolprodukt();
        }

        
    }
}
