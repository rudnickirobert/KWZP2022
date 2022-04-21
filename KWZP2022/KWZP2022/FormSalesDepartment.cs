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
    public partial class FormSalesDepartment : Form
    {
        KWZPEntities db;
        public FormSalesDepartment(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentSales formSalesDepartmentSales = new FormSalesDepartmentSales(db);
            formSalesDepartmentSales.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentClient formSalesDepartmentClient = new FormSalesDepartmentClient(db);
            formSalesDepartmentClient.ShowDialog(); 
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentOrders formSalesDepartmentOrders = new FormSalesDepartmentOrders(db);
            formSalesDepartmentOrders.ShowDialog();
        }
    }
}
