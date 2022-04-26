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
    public partial class FormSetupProductionByproduct : Form
    {
        KWZPEntities db;
        public FormSetupProductionByproduct(KWZPEntities db)
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
