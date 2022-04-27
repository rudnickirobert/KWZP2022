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
    public partial class FormSalesDepartmentOrderDetails : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentOrderDetails(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDetails();
        }
        private void initDetails()
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
            MessageBox.Show("Wyszukiwany numer zamówienia nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK);
        }
        private void msgClearShowData()
        {
            messageBox();
            clearTextBox();
            initDetails();
        }
        private void searchNoOrder()
        {
            try
            {
                int noOrderToInt = int.Parse(textBoxDetails.Text);
                List<v_Zamowienie_szczegol> noOrder = this.db.v_Zamowienie_szczegol.Where(a => a.Nr_zamówienia == noOrderToInt).ToList();
                if (noOrder.Count() > 0)
                {
                    this.dgvDetails.DataSource = noOrder;

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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (textBoxDetails.Text.Length > 0)
            {
                searchNoOrder();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            initDetails();
            clearTextBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
