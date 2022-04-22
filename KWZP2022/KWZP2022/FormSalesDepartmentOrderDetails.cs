
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;namespace KWZP2022
{
    public partial class FormSalesDepartmentOrderDetails : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentOrderDetails(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            Data();
            
        }
        private void Data()
        {
            this.dgvOD.AutoGenerateColumns = true;
            this.dgvOD.DataSource = db.v_Zamowienie_szczegol.ToList();
        }
        private void ClearTextBox()
        {
            textBoxOD.Clear();
        }
        private void messageBox()
        {
            MessageBox.Show("Wyszukiwany numer zamówienia nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK);
        }
        private void msgClearShowData()
        {
            messageBox();
            cleanTextBox();
            Data();
        }
        private void enterIdOrder()
        {
            try
            {
                string idOrder = textBoxOD.Text;
                int idOrderInt = int.Parse(idOrder);
                System.Linq.IQueryable vOrderId = db.v_Zamowienie_szczegol.Cast<v_Zamowienie_szczegol>().Where(a => a.Nr_zamówienia == idOrderInt);
                int vOrderIdInt = vOrderId.Cast<v_Zamowienie_szczegol>().Where(a => a.Nr_zamówienia > 0).Count();
                if (vOrderIdInt > 0)
                {
                    this.dgvOD.DataSource = vOrderId.Cast<v_Zamowienie_szczegol>().ToList(); cleanTextBox();
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
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (textBoxOD.Text.Length > 0)
            {
                enterIdOrder();
            }
        }
        private void FormSalesDepartmentDetailsOrder_Load(object sender, EventArgs e)
        { }
    }
}

