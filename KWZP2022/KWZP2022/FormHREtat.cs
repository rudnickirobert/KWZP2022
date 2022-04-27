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
    public partial class FormHREtat : Form
    {
        KWZPEntities db;
        public FormHREtat(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            FormPosistionsAdd formPosistionsAdd = new FormPosistionsAdd(db);
            formPosistionsAdd.ShowDialog();

        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            FormDepartmentsAdd formDepartmentsAdd = new FormDepartmentsAdd(db);
            formDepartmentsAdd.ShowDialog();
        }
    }
}
