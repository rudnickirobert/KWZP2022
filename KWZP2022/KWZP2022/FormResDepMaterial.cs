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
            dgvMaterial.DataSource = db.Material.ToList();
            for (int i = 0; i < dgvMaterial.Columns.Count; i++)
            {
                dgvMaterial.Columns[i].Visible = false;
            }
            dgvMaterial.Columns["ID_material"].Visible = true;
            dgvMaterial.Columns[0].HeaderText = "ID";
            dgvMaterial.Columns["ID_rodzaj_material"].Visible = true;
            dgvMaterial.Columns["Nazwa_material"].Visible = true;
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
            txtNazwaMaterial.Clear();
        }
        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            this.dgvMaterial.CurrentRow.Cells[1].Value = (int)cmbRodzajMaterial.SelectedValue;
            this.dgvMaterial.CurrentRow.Cells[2].Value = txtNazwaMaterial.Text;
            db.SaveChanges();
            initDataGridView();
        }

        private void dgvMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.dgvMaterial.Rows[e.RowIndex];
                txtNazwaMaterial.Text = row.Cells[2].Value.ToString();
                cmbRodzajMaterial.SelectedValue = row.Cells[1].Value;
            }
        }
    }
}
