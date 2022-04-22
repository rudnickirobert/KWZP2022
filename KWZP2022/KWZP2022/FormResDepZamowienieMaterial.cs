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
    public partial class FormResDepZamowienieMaterial : Form
    {
        KWZPEntities db;
        public FormResDepZamowienieMaterial(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void btnDodajMaterial_Click(object sender, EventArgs e)
        {
            FormResDepMaterial materialFrom = new FormResDepMaterial(db);
            materialFrom.ShowDialog();
        }
        private void initDataGridView()
        {
            dgvZamowienieMaterial.DataSource = db.v_Zamowienia_materialy_w_trakcie.ToList();
            dgvZamowienieMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
