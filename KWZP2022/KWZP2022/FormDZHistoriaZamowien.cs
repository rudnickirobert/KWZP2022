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
    public partial class FormDZHistoriaZamowien : Form
    {
        KWZPEntities db;
        public FormDZHistoriaZamowien(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridViewHistoria();
        }
        private void initDataGridViewHistoria()
        {
            dgv_Historia_Zam.DataSource = db.v_Zamowienia_maszyny_w_trakcie_wszystko.ToList();
            this.dgv_Historia_Zam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Historia_Zam.Columns["StatusID"].Visible = false;

        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
