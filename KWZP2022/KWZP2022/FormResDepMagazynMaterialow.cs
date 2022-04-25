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
            dgvMagazynMaterial.DataSource = db.v_Zamowienia_czesci_w_trakcie.ToList();
            dgvMagazynMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            dgvMagazynMaterial.Refresh();
        }
    }
}
