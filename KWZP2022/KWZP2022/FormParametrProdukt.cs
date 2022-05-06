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
    public partial class FormParametrProdukt : Form
    {
        KWZPEntities db;
        public FormParametrProdukt(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridViewProdukt();
            initDataGridViewParametrProdukt();
            initDataGridViewProduktParametr();
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
            dgvProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void initDataGridViewProduktParametr()
        {
            dgvvParametrProdukt.DataSource = db.v_Parametry_produkt.ToList();
            this.dgvvParametrProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;                   
            dgvvParametrProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewParametrProdukt()
        {
            dgvRodzajParametr.DataSource = db.Rodzaj_parametr.ToList();
            this.dgvRodzajParametr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRodzajParametr.Columns["ID_rodzaj_parametr"].HeaderText = "ID";
            dgvRodzajParametr.Columns["Nazwa_rodzaj_parametr"].HeaderText = "Rodzaj parametru";
            dgvRodzajParametr.Columns["ID_jednostka"].Visible = false;
            dgvRodzajParametr.Columns["Parametr_narzedzie"].Visible = false;
            dgvRodzajParametr.Columns["Parametr_produkt"].Visible = false;
            dgvRodzajParametr.Columns["Parametr_czesc"].Visible = false;
            dgvRodzajParametr.Columns["Parametr_maszyna"].Visible = false;
            dgvRodzajParametr.Columns["Jednostka"].Visible = false;
            dgvRodzajParametr.Columns["Parametr_material"].Visible = false;
            dgvRodzajParametr.Columns["Parametr_polprodukt"].Visible = false;
            dgvRodzajParametr.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void refreshScreen()
        {
            txtProdukt.Text = "";
            txtParametrProdukt.Text = "";
            txtZakresDolny.Text = "";
            txtZakresGorny.Text = "";
            initDataGridViewProdukt();
            initDataGridViewParametrProdukt();
            initDataGridViewProduktParametr();
        }

        private void dgvProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdukt.Text = this.dgvProdukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvRodzajParametr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtParametrProdukt.Text = this.dgvRodzajParametr.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtParametrProdukt.Text) || String.IsNullOrEmpty(txtProdukt.Text) || String.IsNullOrEmpty(txtZakresDolny.Text) || String.IsNullOrEmpty(txtZakresGorny.Text))
            {                
                    MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            { 
                Parametr_produkt parametr_produkt = new Parametr_produkt();
                parametr_produkt.ID_produkt = int.Parse(this.dgvProdukt.CurrentRow.Cells[0].Value.ToString());
                int numRows = dgvProdukt.Rows.Count;
                parametr_produkt.ID_rodzaj_parametr = int.Parse(this.dgvRodzajParametr.CurrentRow.Cells[0].Value.ToString());
                parametr_produkt.Zakres_dol = decimal.Parse(txtZakresDolny.Text);
                parametr_produkt.Zakres_gora = decimal.Parse(txtZakresGorny.Text);
                if (parametr_produkt.Zakres_gora < parametr_produkt.Zakres_dol)
                {
                    MessageBox.Show("Zakres górny musi być większy lub równy dolnemu");
                }
                else
                {                    
                    db.Parametr_produkt.Add(parametr_produkt);
                    db.SaveChanges();
                    MessageBox.Show("Poprawnie dodano parametr: " + txtParametrProdukt.Text + Environment.NewLine + "dla produktu: " + txtProdukt.Text + Environment.NewLine + "do bazy danych");
                    refreshScreen();
                }
            }            
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            refreshScreen();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtParametrProdukt.Text) || String.IsNullOrEmpty(txtProdukt.Text) || String.IsNullOrEmpty(txtZakresDolny.Text) || String.IsNullOrEmpty(txtZakresGorny.Text))
            {
                MessageBox.Show("Nie wybrałeś parametru do usunięcia");
            }
            else if (txtProdukt.Enabled == false)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć parametr: " + txtParametrProdukt.Text + Environment.NewLine + "dla produktu: " + txtProdukt.Text, "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int current_parametrID = int.Parse(this.dgvvParametrProdukt.CurrentRow.Cells[0].Value.ToString());
                        db.Parametr_produkt.Remove(db.Parametr_produkt.Where(parametrID => parametrID.ID_parametr_produkt == current_parametrID).First());
                        db.SaveChanges();
                        MessageBox.Show("Poprawnie usunięto.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie możesz usunąć parametru, produkt przeszedł już kontrolę!");
                    }
                    refreshScreen();
                }
            }
        }

        private void dgvvParametrProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdukt.Text = this.dgvvParametrProdukt.CurrentRow.Cells[2].Value.ToString();
            txtParametrProdukt.Text = this.dgvvParametrProdukt.CurrentRow.Cells[3].Value.ToString();
            txtZakresDolny.Text = this.dgvvParametrProdukt.CurrentRow.Cells[4].Value.ToString();
            txtZakresGorny.Text = this.dgvvParametrProdukt.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtParametrProdukt.Text) || String.IsNullOrEmpty(txtProdukt.Text) || String.IsNullOrEmpty(txtZakresDolny.Text) || String.IsNullOrEmpty(txtZakresGorny.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int currentID = int.Parse(dgvvParametrProdukt.CurrentRow.Cells[0].Value.ToString());
                int newZD = (int)decimal.Parse(txtZakresDolny.Text);
                int newZG = (int)decimal.Parse(txtZakresGorny.Text);
                Parametr_produkt result = db.Parametr_produkt.SingleOrDefault(b => b.ID_parametr_produkt == currentID);
                if (result != null)
                {
                    result.Zakres_dol = newZD;
                    result.Zakres_gora = newZG;
                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie zaktualizowano.");
                refreshScreen();
            }
        }

        private void btnNowyParametr_Click(object sender, EventArgs e)
        {
            FormResDepDodajParametr dodajParametr = new FormResDepDodajParametr(db);
            dodajParametr.ShowDialog();
        }
    }
}
