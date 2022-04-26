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
    public partial class FormSetupProductionProduct : Form
    {
        KWZPEntities db;
        public FormSetupProductionProduct(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            FormSetupProductionActivity formSetupProductionActivity = new FormSetupProductionActivity(db);
            formSetupProductionActivity.ShowDialog();
        }
    }
}
