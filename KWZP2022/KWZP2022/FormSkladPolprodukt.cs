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
    public partial class FormSkladPolprodukt : Form
    {
        KWZPEntities db;
        public FormSkladPolprodukt(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            refreshScreen();
        }

        private void refreshScreen()
        {
            initDataGridViewPolprodukt();
            initDataGridViewMaterial();
            initDataGridViewSkladPolprodukt();
            txtIlosc.Text = "";
            txtMaterial.Text = "";
            txtPolprodukt.Text = "";
        }

        private void initDataGridViewPolprodukt()
        {
            dgvPolprodukt.DataSource = db.Slownik_polprodukt.ToList();
            dgvPolprodukt.Columns["Parametr_polprodukt"].Visible = false;
            dgvPolprodukt.Columns["Proces_polprodukt_czynnosc"].Visible = false;
            dgvPolprodukt.Columns["Sklad_polprodukt"].Visible = false;
            dgvPolprodukt.Columns["Sklad_produkt"].Visible = false;
            this.dgvPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewMaterial()
        {
            dgvMaterial.DataSource = db.Material.ToList();
            dgvMaterial.Columns["ID_rodzaj_material"].Visible = false;
            dgvMaterial.Columns["Rodzaj_material"].Visible = false;
            dgvMaterial.Columns["Parametr_material"].Visible = false;
            dgvMaterial.Columns["Sklad_polprodukt"].Visible = false;
            dgvMaterial.Columns["Szczegoly_zamowienie_material"].Visible = false;
            dgvMaterial.Columns["Sklad_produkt_material"].Visible = false;
            this.dgvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void initDataGridViewSkladPolprodukt()
        {
            dgvSkladPolprodukt.DataSource = db.v_Sklad_polprodukt.ToList();
            this.dgvSkladPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvPolprodukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPolprodukt.Text = dgvPolprodukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaterial.Text = dgvMaterial.CurrentRow.Cells[2].Value.ToString();
        }
        private void dgvSkladPolprodukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPolprodukt.Text = dgvSkladPolprodukt.CurrentRow.Cells[1].Value.ToString();
            txtMaterial.Text = dgvSkladPolprodukt.CurrentRow.Cells[2].Value.ToString();
            txtIlosc.Text = dgvSkladPolprodukt.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPolprodukt.Text) || String.IsNullOrEmpty(txtMaterial.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
                
            }
            else
            {
                Sklad_polprodukt skladPolprodukt = new Sklad_polprodukt();
                skladPolprodukt.ID_polprodukt = int.Parse(dgvPolprodukt.CurrentRow.Cells[0].Value.ToString());
                skladPolprodukt.ID_material = int.Parse(dgvMaterial.CurrentRow.Cells[0].Value.ToString());
                skladPolprodukt.Liczba = int.Parse(txtIlosc.Text);

                db.Sklad_polprodukt.Add(skladPolprodukt);
                db.SaveChanges();
                MessageBox.Show("Poprawnie powiązano półprodukt " + txtPolprodukt.Text + " z materiałem " + txtMaterial.Text + ".");
                refreshScreen();                
            }

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPolprodukt.Text) || String.IsNullOrEmpty(txtMaterial.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult deleteResult = MessageBox.Show("Czy na pewno chcesz usunąć powiązanie między półproduktem '" + dgvSkladPolprodukt.CurrentRow.Cells[1].Value.ToString() + "',a materiałem '" + dgvSkladPolprodukt.CurrentRow.Cells[2].Value.ToString() + "'?", "Question", MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int currentSkladPolprodukt = int.Parse(dgvSkladPolprodukt.CurrentRow.Cells[0].Value.ToString());

                    db.Sklad_polprodukt.Remove(db.Sklad_polprodukt.Where(polprodukt => polprodukt.ID_sklad_polprodukt == currentSkladPolprodukt).First());
                    db.SaveChanges();
                    MessageBox.Show("Poprawnie usunięto.");
                    refreshScreen();
                }
            }
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            refreshScreen();
        }


        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPolprodukt.Text) || String.IsNullOrEmpty(txtMaterial.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int currentID = int.Parse(dgvSkladPolprodukt.CurrentRow.Cells[0].Value.ToString());
                int newValue = int.Parse(txtIlosc.Text);

                Sklad_polprodukt result = db.Sklad_polprodukt.SingleOrDefault(b => b.ID_sklad_polprodukt == currentID);
                if (result != null)
                {
                    result.Liczba = newValue;
                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie zaktualizowano.");
                refreshScreen();
            }            
        }
    }
}