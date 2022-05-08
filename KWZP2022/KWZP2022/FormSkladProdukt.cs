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
    public partial class FormSkladProdukt : Form
    {
        KWZPEntities db;
        public FormSkladProdukt(KWZPEntities db)
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
        }

        private void initDataGridViewSkladProdukt()
        {
            dgvSkladProdukt.DataSource = db.v_Sklad_produkt.ToList();
            this.dgvSkladProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void refreshScreen()
        {
            txtNazwaProdukt.Text = "";
            txtPolprodukt.Text = "";
            txtIlosc.Text = "";
            txtPolprodukt.Enabled = true;
            initDataGridViewProdukt();
            initDataGridViewPolprodukt();
            initDataGridViewSkladProdukt();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {            
            if (String.IsNullOrEmpty(txtNazwaProdukt.Text) || String.IsNullOrEmpty(txtPolprodukt.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Slownik_polprodukt polprodukt = new Slownik_polprodukt();
                bool found = false;
                foreach (DataGridViewRow item in dgvPolprodukt.Rows)
                {
                    if (item.Cells[1].Value != null && item.Cells[1].Value.ToString() == txtPolprodukt.Text)
                    {
                        found = true;
                        break;
                    }
                    else
                    {
                        found = false;
                    }
                }

                if (found)
                {
                    if (txtPolprodukt.Enabled == false)
                    {
                        MessageBox.Show("Półprodukt istnieje już w bazie danych.");
                    }
                }
                else
                {
                    polprodukt.Nazwa = txtPolprodukt.Text;
                    db.Slownik_polprodukt.Add(polprodukt);
                    db.SaveChanges();
                    MessageBox.Show("Poprawnie dodano półprodukt '" + polprodukt.Nazwa + "' do słownika");
                    initDataGridViewPolprodukt();

                    DialogResult polproduktResult = MessageBox.Show("Czy chcesz dodać parametr półproduktu?", "Question", MessageBoxButtons.YesNo);
                    if (polproduktResult == DialogResult.Yes)
                    {                      
                        FormParametrPolprodukt parametrPolprodukt = new FormParametrPolprodukt(db);
                        parametrPolprodukt.ShowDialog();          
                    }

                }


                Sklad_produkt skladProdukt = new Sklad_produkt();
                skladProdukt.ID_produkt = int.Parse(this.dgvProdukt.CurrentRow.Cells[0].Value.ToString());

                if (txtPolprodukt.Enabled == false)
                {
                    skladProdukt.ID_polprodukt = int.Parse(this.dgvPolprodukt.CurrentRow.Cells[0].Value.ToString());
                }
                else
                {
                    int numRows = dgvPolprodukt.Rows.Count;
                    skladProdukt.ID_polprodukt = int.Parse(this.dgvPolprodukt.Rows[numRows - 1].Cells[0].Value.ToString());
                }

                skladProdukt.Liczba = int.Parse(txtIlosc.Text);
                db.Sklad_produkt.Add(skladProdukt);
                db.SaveChanges();

                MessageBox.Show("Poprawnie powiązano półprodukt '" + txtPolprodukt.Text + "' z produktem '" + this.dgvProdukt.CurrentRow.Cells[1].Value.ToString() + "'.");
                refreshScreen();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaProdukt.Text) || String.IsNullOrEmpty(txtPolprodukt.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Nie wybrałeś obiektu do usunięcia");
            }
            else if (txtPolprodukt.Enabled == false)
            {
                DialogResult polprodukDeleteResult = MessageBox.Show("Czy na pewno chcesz usunąć półprodukt '" + txtPolprodukt.Text + "'?", "Question", MessageBoxButtons.YesNo);

                if (polprodukDeleteResult == DialogResult.Yes)
                {
                    try
                    {
                        int currentPolproduktID = int.Parse(this.dgvPolprodukt.CurrentRow.Cells[0].Value.ToString());
                        db.Slownik_polprodukt.Remove(db.Slownik_polprodukt.Where(polprodukt => polprodukt.ID_polprodukt == currentPolproduktID).First());
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie możesz usunąć półproduktu powiązanego z produktem");
                    }

                }
            }
            else if (txtPolprodukt != null && txtNazwaProdukt != null && txtIlosc.Text != null)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć powiązanie między produktem '" + this.dgvSkladProdukt.CurrentRow.Cells[3].Value + "', a półproduktem '" + this.dgvSkladProdukt.CurrentRow.Cells[4].Value + "'?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int currentSkladID = int.Parse(this.dgvSkladProdukt.CurrentRow.Cells[0].Value.ToString());
                    db.Sklad_produkt.Remove(db.Sklad_produkt.Where(skladProdukt => skladProdukt.ID_sklad_produkt == currentSkladID).First());
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Poprawnie usunięto.");
            refreshScreen();

        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            refreshScreen();
        }

        private void btnSkladPolprodukt_Click(object sender, EventArgs e)
        {
            FormSkladPolprodukt skladPolproduktu = new FormSkladPolprodukt(db);
            skladPolproduktu.ShowDialog();
        }

        private void dgvPolprodukt_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtPolprodukt.Text = this.dgvPolprodukt.CurrentRow.Cells[1].Value.ToString();
            txtPolprodukt.Enabled = false;
        }

        private void dgvProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaProdukt.Text = this.dgvProdukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvSkladProdukt_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaProdukt.Text = this.dgvSkladProdukt.CurrentRow.Cells[3].Value.ToString();
            txtPolprodukt.Text = this.dgvSkladProdukt.CurrentRow.Cells[4].Value.ToString();
            txtIlosc.Text = this.dgvSkladProdukt.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
