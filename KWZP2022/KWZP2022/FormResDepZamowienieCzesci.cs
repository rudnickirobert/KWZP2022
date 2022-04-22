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
    public partial class FormResDepZamowienieCzesci : Form
    {
        KWZPEntities db;
        public FormResDepZamowienieCzesci(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvZamowienieCzesci.DataSource = db.v_Zamowienia_czesci_w_trakcie.ToList();
            dgvZamowienieCzesci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
