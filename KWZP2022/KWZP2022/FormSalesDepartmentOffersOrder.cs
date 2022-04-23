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
    public partial class FormSalesDepartmentOffersOrder : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentOffersOrder(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDetails();
        }
        private void initDetails()
        {
            this.dgvOffers.AutoGenerateColumns = true;
            this.dgvOffers.DataSource = db.v_Oferta_handlowa.ToList();
            this.dgvOffers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void clearTextBox()
        {
            textBoxOffers.Clear();
        }
        private void messageBox()
        {
            MessageBox.Show("Wyszukiwany numer sprzedaży nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK);
        }
        private void msgClearShowData()
        {
            messageBox();
            clearTextBox();
            initDetails();
        }
        private void enterIdOrder()
        {
            try
            {
                string idOrder = textBoxOffers.Text;
                int idOrderInt = int.Parse(idOrder);
                System.Linq.IQueryable vOrderId = db.v_Oferta_handlowa.Where(a => a.Numer_zamówienia == idOrderInt);
                int vOrderIdInt = vOrderId.Cast<v_Oferta_handlowa>().Where(a => a.Numer_zamówienia > 0).Count();
                if (vOrderIdInt > 0)
                {
                    this.dgvOffers.DataSource = vOrderId.Cast<v_Oferta_handlowa>().ToList();
                    clearTextBox();
                }
                else
                {
                    msgClearShowData();
                }
            }
            catch (Exception)
            {
                msgClearShowData();
            }
        }
        private void btnOffers_Click_1(object sender, EventArgs e)
        {
            if (textBoxOffers.Text.Length > 0)
            {
                enterIdOrder();
            }
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            initDetails();
            clearTextBox();
        }
    }
}