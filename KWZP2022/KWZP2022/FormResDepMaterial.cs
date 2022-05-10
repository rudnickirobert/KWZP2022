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
    public partial class FormResDepMaterial : Form
    {
        KWZPEntities db;
        public FormResDepMaterial(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbRodzajMaterial.DataSource = db.Rodzaj_material.ToList();
            cmbRodzajMaterial.DisplayMember = "Nazwa_rodzaj_material";
            cmbRodzajMaterial.ValueMember = "ID_rodzaj_material";
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvMaterial.DataSource = db.v_Material.ToList();
            dgvMaterial.Columns[0].Visible = false;
            dgvMaterial.Columns[1].Visible = false;
            dgvMaterial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNazwaMaterial.Text))
                {
                    MessageBox.Show("Wpisz nazwę materiału!");
                }
                else
                {
                    Material material = new Material();
                    material.Nazwa_material = txtNazwaMaterial.Text;
                    material.ID_rodzaj_material = (int)cmbRodzajMaterial.SelectedValue;
                    db.Material.Add(material);
                    db.SaveChanges();
                    initDataGridView();
                    MessageBox.Show("Poprawnie dodano " + material.Nazwa_material + " do bazy danych");
                }
            }
            catch
            {
                MessageBox.Show("Nie można dodać materiału.");
            }
        }
        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć material: " + this.dgvMaterial.CurrentRow.Cells[2].Value + "?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string current_material = this.dgvMaterial.CurrentRow.Cells[0].Value.ToString();
                    int daneINT = int.Parse(current_material);
                    Material danyMaterial = db.Material.Single(a => a.ID_material == daneINT);
                    this.db.Material.Remove(danyMaterial);
                    db.SaveChanges();
                    initDataGridView();
                    txtNazwaMaterial.Text = "";
                }
            }
            catch 
            {
                MessageBox.Show("Nie można usunąć materiału, ponieważ jest obecnie wykorzystywany.");
            }
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
            cmbRodzajMaterial.DataSource = db.Rodzaj_material.ToList();
            cmbRodzajMaterial.DisplayMember = "Nazwa_rodzaj_material";
            cmbRodzajMaterial.ValueMember = "ID_rodzaj_material";
            txtNazwaMaterial.Clear();
        }
        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterial.CurrentRow.Cells[0].Value != null)
            {
                int daneMaterial = int.Parse(this.dgvMaterial.CurrentRow.Cells[0].Value.ToString());
                Material daneMaterialID = this.db.Material.Single(a => a.ID_material == daneMaterial);
                daneMaterialID.Nazwa_material = txtNazwaMaterial.Text;
                daneMaterialID.ID_rodzaj_material = (int)cmbRodzajMaterial.SelectedValue;
                db.SaveChanges();
                initDataGridView();
                MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nie zaznaczono materiału!", "Błąd", MessageBoxButtons.OK);
            }
        }
        private void dgvMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.dgvMaterial.Rows[e.RowIndex];
                txtNazwaMaterial.Text = row.Cells[3].Value.ToString();
                cmbRodzajMaterial.SelectedValue = row.Cells[1].Value;
            }
        }
        private void btnDodajParametr_Click(object sender, EventArgs e)
        {
            FormResDepParametryMaterial parametrMaterial = new FormResDepParametryMaterial(db);
            parametrMaterial.ShowDialog();  
        }

        private void btnDodajRodzaj_Click(object sender, EventArgs e)
        {
            FormResDepDodajMaterial rodzajMaterial = new FormResDepDodajMaterial(db);
            rodzajMaterial.ShowDialog();
        }
    }
}
