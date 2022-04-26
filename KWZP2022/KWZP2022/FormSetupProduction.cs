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
    public partial class FormSetupProduction : Form
    {
        KWZPEntities db;
        public FormSetupProduction(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnSPDProduct_Click(object sender, EventArgs e)
        {
            FormSetupProductionProduct formSetupProductionProduct = new FormSetupProductionProduct(db);
            formSetupProductionProduct.ShowDialog();
        }

        private void btnSPDByproduct_Click(object sender, EventArgs e)
        {
            FormSetupProductionByproduct formSetupProductionByproduct = new FormSetupProductionByproduct(db);
            formSetupProductionByproduct.ShowDialog();
        }
    }
}
