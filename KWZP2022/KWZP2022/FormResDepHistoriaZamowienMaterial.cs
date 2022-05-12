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
    public partial class FormResDepHistoriaZamowienMaterial : Form
    {
        KWZPEntities db;
        Material wybranyMaterialDGV;
        public FormResDepHistoriaZamowienMaterial(KWZPEntities db, Material wybranyMaterialDGV)
        {
            InitializeComponent();
            this.db = db;
            this.wybranyMaterialDGV = wybranyMaterialDGV;
            initDataGridView();
        }
        private void initDataGridView()
        {
            int wybranyMaterial = wybranyMaterialDGV.ID_material;
            List<v_Zamowienia_materialy_w_trakcie_wszystko> materialZamowienie =db.v_Zamowienia_materialy_w_trakcie_wszystko.Where(a => a.ID_material == wybranyMaterial && a.StatusID==4).ToList();
            dgvHistoria.DataSource = materialZamowienie;
            dgvHistoria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvHistoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoria.Columns[0].Visible = false;
            dgvHistoria.Columns[1].Visible = false;
            dgvHistoria.Columns[7].Visible = false;
            dgvHistoria.Columns[8].Visible = false;
            dgvHistoria.Columns[4].HeaderText = "Masa (g)";
        }
        private void btnNoweZam_Click(object sender, EventArgs e)
        {
            FormResDepZamowienieMaterial formResDepZamMat = new FormResDepZamowienieMaterial(db);
            formResDepZamMat.ShowDialog();
        }
    }
}
