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
    public partial class FormResDepHistoriaZamowienCzesci : Form
    {
        KWZPEntities db;
        Czesc wybranaCzescDGV;
        public FormResDepHistoriaZamowienCzesci(KWZPEntities db, Czesc wybranaCzescDGV)
        {
            InitializeComponent();
            this.db = db;
            this.wybranaCzescDGV = wybranaCzescDGV;
            initDataGridView();
        }
        private void initDataGridView()
        {
            int wybranaCzesc = wybranaCzescDGV.ID_czesc;
            List<v_Zamowienia_czesci_w_trakcie_wszystko> czescZamowienie = db.v_Zamowienia_czesci_w_trakcie_wszystko.Where(a => a.ID_czesc == wybranaCzesc && a.StatusID == 4).ToList();
            dgvHistoria.DataSource = czescZamowienie;
            dgvHistoria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvHistoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoria.Columns[0].Visible = false;
            dgvHistoria.Columns[7].Visible = false;
            dgvHistoria.Columns[8].Visible = false;
        }
        private void btnNoweZam_Click(object sender, EventArgs e)
        {
            FormResDepZamowienieCzesci formResDepZamCzesc = new FormResDepZamowienieCzesci(db);
            formResDepZamCzesc.ShowDialog();
        }
    }
}
