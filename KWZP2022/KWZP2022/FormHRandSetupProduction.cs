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
    public partial class FormHRandSetupProduction : Form
    {
            KWZPEntities db;
            public FormHRandSetupProduction(KWZPEntities db)
            {
                InitializeComponent();
                this.db = db;
            }

            private void btnHRDepartment_Click(object sender, EventArgs e)
            {
                FormHR formHR = new FormHR(db);
                formHR.ShowDialog();
            }

            private void btnSetupProduction_Click(object sender, EventArgs e)
            {
                FormSetupProduction formSetupProduction = new FormSetupProduction(db);
                formSetupProduction.ShowDialog();
            }
    }
}
