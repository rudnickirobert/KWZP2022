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
    public partial class FormResDepZamowienia : Form
    {
        KWZPEntities db;
        public FormResDepZamowienia(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnOrder_czesc_Click(object sender, EventArgs e)
        {
            FormResDepZamowienieCzesci zamowienieCzesc = new FormResDepZamowienieCzesci(db);
            zamowienieCzesc.ShowDialog();
        }

        private void btnOrder_material_Click(object sender, EventArgs e)
        {
            FormResDepZamowienieMaterial zamowieniaCzesci = new FormResDepZamowienieMaterial(db);
            zamowieniaCzesci.ShowDialog();
        }
    }
}
