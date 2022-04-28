using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2022.Forms
{
    public partial class FormDepartments : Form
    {
        KWZPEntities db;
        public FormDepartments(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnSalesDepartment_Click(object sender, EventArgs e)
        {
            FormSalesDepartment formSalesDepartment = new FormSalesDepartment(db);
            formSalesDepartment.ShowDialog();
        }

        private void btnProductionDepartment_Click(object sender, EventArgs e)
        {
            FormProdukcja produkcjaFrom = new FormProdukcja(db);
            produkcjaFrom.ShowDialog();
        }

        private void btnResourceDeparment_Click(object sender, EventArgs e)
        {
            FormResourceDepartment produkcjaFrom = new FormResourceDepartment(db);
            produkcjaFrom.ShowDialog();
        }

        private void btnHumanRsDepartment_Click(object sender, EventArgs e)
        {
            FormHRandSetupProduction formHRandSetupProduction = new FormHRandSetupProduction(db);
            formHRandSetupProduction.ShowDialog();
        }
    }
}
