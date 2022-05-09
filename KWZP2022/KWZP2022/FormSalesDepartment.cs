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

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentComplaint formSalesDepartmentComplaint = new FormSalesDepartmentComplaint(db);
            formSalesDepartmentComplaint.ShowDialog();
        }

        private void btnOffertsForConsideration_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentOffersForConsideration formSalesDepartmentOffersForConsideration = new FormSalesDepartmentOffersForConsideration(db);
            formSalesDepartmentOffersForConsideration.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormSalesDeprartmentOrders formSalesDeprartmentOrders = new FormSalesDeprartmentOrders(db);
            formSalesDeprartmentOrders.ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentSalesStatistics formSalesDepartmentSalesStatistics = new FormSalesDepartmentSalesStatistics(db);
            formSalesDepartmentSalesStatistics.ShowDialog();
        }

        private void btnSalesAgreement_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentSalesAgreement formSalesDepartmentSalesAgreement = new FormSalesDepartmentSalesAgreement(db);
            formSalesDepartmentSalesAgreement.ShowDialog();
        }

        private void btnNewCommercialOffers_Click(object sender, EventArgs e)
        {
            FormNewCommertialOffer formNewCommertialOffer = new FormNewCommertialOffer(db);
            formNewCommertialOffer.ShowDialog();
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentAlert formSalesDepartmentAlert = new FormSalesDepartmentAlert(db);
            formSalesDepartmentAlert.ShowDialog();
        }
    }
}
