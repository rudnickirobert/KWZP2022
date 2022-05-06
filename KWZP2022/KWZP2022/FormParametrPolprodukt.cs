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
    public partial class FormParametrPolprodukt : Form
    {
        KWZPEntities db;
        public FormParametrPolprodukt(KWZPEntities db)
        {
            this.db = db;
            InitializeComponent();
            initDataGridViewPolprodukt();
            initDataGridViewPolproduktParametr();
            initDataGridViewParametrPolprodukt();
        }

        private void initDataGridViewPolprodukt()
        {
            dgvPolprodukt.DataSource = db.Slownik_polprodukt.ToList();
            this.dgvPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPolprodukt.Columns["Parametr_polprodukt"].Visible = false;
            dgvPolprodukt.Columns["Proces_polprodukt_czynnosc"].Visible = false;
            dgvPolprodukt.Columns["Sklad_polprodukt"].Visible = false;
            dgvPolprodukt.Columns["Sklad_produkt"].Visible = false;            
            dgvPolprodukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewParametrPolprodukt()
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

        private void initDataGridViewPolproduktParametr()
        {
            dgvvParametrPolprodukt.DataSource = db.v_Parametry_polprodukt.ToList();
            this.dgvvParametrPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvvParametrPolprodukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void refreshScreen()
        {
            txtPolprodukt.Text = "";
            txtParametrPolprodukt.Text = "";
            txtZakresDolny.Text = "";
            txtZakresGorny.Text = "";
            initDataGridViewPolprodukt();
            initDataGridViewParametrPolprodukt();
            initDataGridViewPolproduktParametr();
        }

        private void dgvPolprodukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPolprodukt.Text = this.dgvPolprodukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvRodzajParametr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtParametrPolprodukt.Text = this.dgvRodzajParametr.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtParametrPolprodukt.Text) || String.IsNullOrEmpty(txtPolprodukt.Text) || String.IsNullOrEmpty(txtZakresDolny.Text) || String.IsNullOrEmpty(txtZakresGorny.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                Parametr_polprodukt parametr_polprodukt = new Parametr_polprodukt();
                parametr_polprodukt.ID_polprodukt = int.Parse(this.dgvPolprodukt.CurrentRow.Cells[0].Value.ToString());
                int numRows = dgvPolprodukt.Rows.Count;
                parametr_polprodukt.ID_rodzaj_parametr = int.Parse(this.dgvPolprodukt.CurrentRow.Cells[0].Value.ToString());
                parametr_polprodukt.Zakres_dol = decimal.Parse(txtZakresDolny.Text);
                parametr_polprodukt.Zakres_gora = decimal.Parse(txtZakresGorny.Text);
                if (parametr_polprodukt.Zakres_gora < parametr_polprodukt.Zakres_dol)
                {
                    MessageBox.Show("Zakres górny musi być większy lub równy dolnemu");
                }
                else
                {
                    db.Parametr_polprodukt.Add(parametr_polprodukt);
                    db.SaveChanges();
                    MessageBox.Show("Poprawnie dodano parametr: " + txtParametrPolprodukt.Text + Environment.NewLine + "dla produktu: " + txtPolprodukt.Text + Environment.NewLine + "do bazy danych");
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
            if (String.IsNullOrEmpty(txtParametrPolprodukt.Text) || String.IsNullOrEmpty(txtPolprodukt.Text) || String.IsNullOrEmpty(txtZakresDolny.Text) || String.IsNullOrEmpty(txtZakresGorny.Text))
            {
                MessageBox.Show("Nie wybrałeś parametru do usunięcia");
            }
            else if (txtPolprodukt.Enabled == false)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć parametr: " + txtParametrPolprodukt.Text + Environment.NewLine + "dla półroduktu: " + txtPolprodukt.Text, "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int current_parametrID = int.Parse(this.dgvvParametrPolprodukt.CurrentRow.Cells[0].Value.ToString());
                        db.Parametr_polprodukt.Remove(db.Parametr_polprodukt.Where(parametrID => parametrID.ID_parametr_polprodukt == current_parametrID).First());
                        db.SaveChanges();
                        MessageBox.Show("Poprawnie usunięto.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie możesz usunąć parametru!");
                    }                    
                    refreshScreen();
                }
            }
        }

        private void dgvvParametrPolprodukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPolprodukt.Text = this.dgvvParametrPolprodukt.CurrentRow.Cells[1].Value.ToString();
            txtParametrPolprodukt.Text = this.dgvvParametrPolprodukt.CurrentRow.Cells[2].Value.ToString();
            txtZakresDolny.Text = this.dgvvParametrPolprodukt.CurrentRow.Cells[3].Value.ToString();
            txtZakresGorny.Text = this.dgvvParametrPolprodukt.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtParametrPolprodukt.Text) || String.IsNullOrEmpty(txtZakresDolny.Text) || String.IsNullOrEmpty(txtZakresGorny.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            { 
                int currentID = int.Parse(dgvvParametrPolprodukt.CurrentRow.Cells[0].Value.ToString());
                int newZD = (int)decimal.Parse(txtZakresDolny.Text);
                int newZG = (int)decimal.Parse(txtZakresGorny.Text);
                Parametr_polprodukt result = db.Parametr_polprodukt.SingleOrDefault(b => b.ID_parametr_polprodukt == currentID);
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
