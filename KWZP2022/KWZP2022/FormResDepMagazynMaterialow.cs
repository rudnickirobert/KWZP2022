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
    public partial class FormResDepMagazynMaterialow : Form
    {
        KWZPEntities db;
        public FormResDepMagazynMaterialow(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }
        private void btnDodajMaterial_Click(object sender, EventArgs e)
        {
            FormResDepZamowienieMaterial materialForm = new FormResDepZamowienieMaterial(db);
            materialForm.ShowDialog();
        }
        private void initDataGridView()
        {
            dgvMagazynMaterial.DataSource = db.v_Magazyn_material_aktualny.ToList();
            dgvMagazynMaterial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvMagazynMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMagazynMaterial.Columns[0].Visible = false;
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
        }
        private void dgvMagazynMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int wybranyMaterial = int.Parse(this.dgvMagazynMaterial.CurrentRow.Cells[0].Value.ToString());
            Material wybranyMaterialDGV = this.db.Material.Single(a => a.ID_material == wybranyMaterial);
            FormResDepHistoriaZamowienMaterial formResDepHisZamMat = new FormResDepHistoriaZamowienMaterial(db, wybranyMaterialDGV);
            formResDepHisZamMat.ShowDialog();
        }
    }
}
