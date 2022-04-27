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
    public partial class FormHR : Form
    {
        KWZPEntities db;
        public FormHR(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnHRWorkes_Click(object sender, EventArgs e)
        {
            FormHRDepartment formHRDepartment = new FormHRDepartment(db);
            formHRDepartment.ShowDialog(); 
        }

        private void btnEtat_Click(object sender, EventArgs e)
        {
            FormHREtat formHREtat = new FormHREtat(db);
            formHREtat.ShowDialog();
        }
    }
}
