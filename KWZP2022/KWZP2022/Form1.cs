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
    public partial class StartForm : Form
    {
        KWZPEntities db = new KWZPEntities();

        public StartForm()
        {
            InitializeComponent();

            this.lblDate.Text = DateTime.Now.ToLongDateString();
            this.lblTime.Text = DateTime.Now.ToShortTimeString();
            this.lblDate.BackColor = Color.Transparent;
            this.lblTime.BackColor = Color.Transparent;
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            Forms.FormDepartments formDepartments = new Forms.FormDepartments(db);
            formDepartments.ShowDialog();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            FormNewOrder formNewOrder = new FormNewOrder(db);
            formNewOrder.ShowDialog();
        }
    }
}
