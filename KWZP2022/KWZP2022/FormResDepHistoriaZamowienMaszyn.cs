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
    public partial class FormResDepHistoriaZamowienMaszyn : Form
    {
        KWZPEntities db;
        Maszyna wybranaMaszynalDGV;
        public FormResDepHistoriaZamowienMaszyn(KWZPEntities db, Maszyna wybranaMaszynalDGV)
        {
            InitializeComponent();
            this.db = db;
            this.wybranaMaszynalDGV = wybranaMaszynalDGV;
            initDataGridView();
        }
        private void initDataGridView()
        {
            int wybranaMaszyna = wybranaMaszynalDGV.ID_maszyna;
            List<v_Zamowienia_maszyny_w_trakcie_wszystko> maszynaZamowienie = db.v_Zamowienia_maszyny_w_trakcie_wszystko.Where(a => a.ID_maszyna == wybranaMaszyna && a.StatusID == 4).ToList();
            dgvHistoria.DataSource = maszynaZamowienie;
            dgvHistoria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvHistoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoria.Columns[0].Visible = false;
            dgvHistoria.Columns[7].Visible = false;
            dgvHistoria.Columns[8].Visible = false;
        }

        private void btnNoweZam_Click(object sender, EventArgs e)
        {
            FormResDepZamowienieMaszyny formResDepZamMasz = new FormResDepZamowienieMaszyny(db);
            formResDepZamMasz.ShowDialog();
        }
    }
}
