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
    public partial class FormResDepMagazynMaszyn : Form
    {
        KWZPEntities db;
        public FormResDepMagazynMaszyn(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }
        private void btnDodajMaszyna_Click(object sender, EventArgs e)
        {
            FormResDepZamowienieMaszyny maszynaForm = new FormResDepZamowienieMaszyny(db);
            maszynaForm.ShowDialog();
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvMagazynMaszyna.DataSource = db.v_Magazyn_maszyn_nieuzywane.ToList();
            dgvMagazynMaszyna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMagazynMaszyna.Columns[2].Visible = false;
        }

        private void dgvMagazynMaszyna_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int wybranaMaszyna = int.Parse(this.dgvMagazynMaszyna.CurrentRow.Cells[2].Value.ToString());
            Maszyna wybranaMaszynaDGV = this.db.Maszyna.Single(a => a.ID_maszyna == wybranaMaszyna);
            FormResDepHistoriaZamowienMaszyn formResDepHisZamMasz = new FormResDepHistoriaZamowienMaszyn(db, wybranaMaszynaDGV);
            formResDepHisZamMasz.ShowDialog();
        }
    }
}
