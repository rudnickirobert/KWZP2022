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
    public partial class FormSalesDeprartmentOrders : Form
    {
        KWZPEntities db;
        public FormSalesDeprartmentOrders(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showDgvOrders();
        }
        private void clearTextBox()
        {
            textBoxNameClient.Clear();
            textBoxSurnameClient.Clear();
            textBoxTypeOrder.Clear();
            textBoxSurnameEmployee.Clear();
            textBoxNameEmployee.Clear();
            textBoxIdOrder.Clear();
        }
        private void messageBox()
        {
            MessageBox.Show("Wyszukiwany numer zamówienia nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK);
        }
        private void msgClearShowData()
        {
            messageBox();
            clearTextBox();
            showDgvOrders();
        }
        private void showDgvOrders()
        {
            this.dgvOrders.AutoGenerateColumns = true;
            this.dgvOrders.DataSource = this.db.v_Oferta_handlowa.ToList();
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void searchSurname()
        {
            List<v_Zamowienie> clientSurname = this.db.v_Zamowienie.Where(a => a.Nazwisko_klienta == textBoxSurnameClient.Text).ToList();
            if (clientSurname.Count() > 0)
            {
                this.dgvOrders.DataSource = clientSurname;
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                clearTextBox();
            }
            else
            {
                msgClearShowData();
            }
        }
        private void searchName()
        {
            List<v_Zamowienie> clientName = this.db.v_Zamowienie.Where(a => a.Imię_klienta == textBoxNameClient.Text).ToList();
            if (clientName.Count() > 0)
            {
                this.dgvOrders.DataSource = clientName;
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                clearTextBox();
            }
            else
            {
                msgClearShowData();
            }
        }
        private void searchIdOrder()
        {
            try
            {
                int idOrderInt = int.Parse(textBoxIdOrder.Text);
                List<v_Zamowienie> orderNumber = this.db.v_Zamowienie.Where(a => a.Nr_zamówienia == idOrderInt).ToList();
                if (orderNumber.Count() > 0)
                {
                    this.dgvOrders.DataSource = orderNumber;
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
        private void searchEmployeeSurname()
        {
            List<v_Zamowienie> employeeSurname = this.db.v_Zamowienie.Where(a => a.Nazwisko_pracownika == textBoxSurnameEmployee.Text).ToList();
            if (employeeSurname.Count() > 0)
            {
                this.dgvOrders.DataSource = employeeSurname;
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                clearTextBox();
            }
            else
            {
                msgClearShowData();
            }
        }
        private void searchEmployeeName()
        {
            List<v_Zamowienie> employeeName = this.db.v_Zamowienie.Where(a => a.Imię_pracownika == textBoxNameEmployee.Text).ToList();
            if (employeeName.Count() > 0)
            {
                this.dgvOrders.DataSource = employeeName;
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                clearTextBox();
            }
            else
            {
                msgClearShowData();
            }
        }
        private void searchOrderType()
        {
            List<v_Zamowienie> orderType = this.db.v_Zamowienie.Where(a => a.Typ_zamówienia == textBoxTypeOrder.Text).ToList();
            if (orderType.Count() > 0)
            {
                this.dgvOrders.DataSource = orderType;
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                clearTextBox();
            }
            else
            {
                msgClearShowData();
            }
        }
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK);
            showDgvOrders();
        }
        private void btnOrders_Click_1(object sender, EventArgs e)
        {
            string choose = "";
            if (textBoxSurnameClient.Text.Length > 0)
                choose = "Surname";
            if (textBoxNameClient.Text.Length > 0)
                choose = "Name";
            if (textBoxIdOrder.Text.Length > 0)
                choose = "IdOrder";
            if (textBoxSurnameEmployee.Text.Length > 0)
                choose = "SurnameE";
            if (textBoxNameEmployee.Text.Length > 0)
                choose = "NameE";
            if (textBoxTypeOrder.Text.Length > 0)
                choose = "TypeOrder";
            switch (choose)
            {
                case "Surname":
                    searchSurname();
                    break;
                case "Name":
                    searchName();
                    break;
                case "IdOrder":
                    searchIdOrder();
                    break;
                case "SurnameE":
                    searchEmployeeSurname();
                    break;
                case "NameE":
                    searchEmployeeName();
                    break;
                case "TypeOrder":
                    searchOrderType();
                    break;
                default:
                    wrongData();
                    break;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showDgvOrders();
            clearTextBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDetails_Click_1(object sender, EventArgs e)
        {
            FormSalesDepartmentOrderDetails formSalesDepartmentOrderDetails = new FormSalesDepartmentOrderDetails(db);
            formSalesDepartmentOrderDetails.ShowDialog();
        }
    }
}
