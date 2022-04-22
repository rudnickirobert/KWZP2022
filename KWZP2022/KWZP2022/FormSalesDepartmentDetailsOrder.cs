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
    public partial class FormSalesDepartmentDetailsOrder : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentDetailsOrder(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            Data();
        }
        private void Data()
        {
            this.dgvDetails.AutoGenerateColumns = true;
            this.dgvDetails.DataSource = db.v_Zamowienie_szczegol.ToList();
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void clearTextBox()
        {
            textBoxDetails.Clear();
        }
        private void messageBox()
        {
            MessageBox.Show("Wyszukiwany numer sprzedaży nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK);
        }
        private void msgCleanShowData()
        {
            messageBox();
            clearTextBox();
            Data();
        }
        private void enterIdOrder()
        {
            try
            {
                string idOrder = textBoxDetails.Text;
                int idOrderInt = int.Parse(idOrder);
                System.Linq.IQueryable vOrderId = db.v_Zamowienie_szczegol.Where(a => a.Nr_zamówienia == idOrderInt);
                int vOrderIdInt = vOrderId.Cast<v_Zamowienie_szczegol>().Where(a => a.Nr_zamówienia > 0).Count();
                if (vOrderIdInt > 0)
                {
                    this.dgvDetails.DataSource = vOrderId.Cast<v_Zamowienie_szczegol>().ToList();

                    clearTextBox();
                }
                else
                {
                    msgCleanShowData();
                }
            }
            catch (Exception)
            {
                msgCleanShowData();
            }
        }
        private void btnDetails_Click_1(object sender, EventArgs e)
        {
            if (textBoxDetails.Text.Length > 0)
            {
                enterIdOrder();
            }
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            Data();
            clearTextBox();
        }
    }
}