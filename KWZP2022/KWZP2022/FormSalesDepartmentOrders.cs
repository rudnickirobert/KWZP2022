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
    public partial class FormSalesDepartmentOrders : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentOrders(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showDgvOrders();
        }
        private void cleanTextBox()
        {
            textBox1Name.Clear();
            textBox2Name.Clear();
            textBoxTypeOrder.Clear();
            textBox2NameE.Clear();
            textBox1NameE.Clear();
            textBoxIdOrder.Clear();
        }
        private void messageBox()
        {
            MessageBox.Show("Wyszukiwany numer zamówienia nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK);
        }
        private void msgClearShowData()
        {
            messageBox();
            cleanTextBox();
            showDgvOrders();
        }

        private void showDgvOrders()
        {
            this.dgvOrders.AutoGenerateColumns = true;
            this.dgvOrders.DataSource = db.v_Oferta_handlowa.ToList();
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void enterSurname()
        {
            System.Linq.IQueryable vClientSurname = db.v_Zamowienie.Where(a => a.Nazwisko_klienta == textBox2Name.Text);
            int vClientSurnameInt = vClientSurname.Cast<v_Zamowienie>().Count();
            if (vClientSurnameInt > 0)
            {
                this.dgvOrders.DataSource = vClientSurname.Cast<v_Zamowienie>().ToList();
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgClearShowData();
            }
        }
        private void enterName()
        {
            System.Linq.IQueryable vClientName = db.v_Zamowienie.Where(a => a.Imię_klienta == textBox1Name.Text);
            int vClientNameInt = vClientName.Cast<v_Zamowienie>().Count();
            if (vClientNameInt > 0)
            {
                this.dgvOrders.DataSource = vClientName.Cast<v_Zamowienie>().ToList();
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgClearShowData();
            }
        }
        private void enterIdOrder()
        {
            try
            {
                string idOrder = textBoxIdOrder.Text;
                int idOrderInt = int.Parse(idOrder);
                System.Linq.IQueryable vOrderId = db.v_Zamowienie.Where(a => a.Nr_zamówienia == idOrderInt);
                int vOrderIdInt = vOrderId.Cast<v_Zamowienie>().Where(a => a.Nr_zamówienia > 0).Count();
                if (vOrderIdInt > 0)
                {
                    this.dgvOrders.DataSource = vOrderId.Cast<v_Zamowienie>().ToList();
                    cleanTextBox();
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
        private void enterSurnameE()
        {
            System.Linq.IQueryable vSurnameE = db.v_Zamowienie.Where(a => a.Nazwisko_pracownika == textBox2NameE.Text);
            int vSurnameEInt = vSurnameE.Cast<v_Zamowienie>().Count();
            if (vSurnameEInt > 0)
            {
                this.dgvOrders.DataSource = vSurnameE.Cast<v_Zamowienie>().ToList();
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgClearShowData();
            }
        }
        private void enterNameE()
        {
            System.Linq.IQueryable vNameE = db.v_Zamowienie.Where(a => a.Imię_pracownika == textBox1NameE.Text);
            int vNameEInt = vNameE.Cast<v_Zamowienie>().Count();
            if (vNameEInt > 0)
            {
                this.dgvOrders.DataSource = vNameE.Cast<v_Zamowienie>().ToList();
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgClearShowData();
            }
        }
        private void enterTypeOrder()
        {
            System.Linq.IQueryable vTypeOrder = db.v_Zamowienie.Where(a => a.Typ_zamówienia == textBoxTypeOrder.Text);
            int vTypeOrderInt = vTypeOrder.Cast<v_Zamowienie>().Count();
            if (vTypeOrderInt > 0)
            {
                this.dgvOrders.DataSource = vTypeOrder.Cast<v_Zamowienie>().ToList();
                this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
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
        private void btnOrders_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (textBox2Name.Text.Length > 0)
                choose = "Surname";
            if (textBox1Name.Text.Length > 0)
                choose = "Name";
            if (textBoxIdOrder.Text.Length > 0)
                choose = "IdOrder";
            if (textBox2NameE.Text.Length > 0)
                choose = "SurnameE";
            if (textBox1NameE.Text.Length > 0)
                choose = "NameE";
            if (textBoxTypeOrder.Text.Length > 0)
                choose = "TypeOrder";
            switch (choose)
            {
                case "Surname":
                    enterSurname();
                    break;
                case "Name":
                    enterName();
                    break;
                case "IdOrder":
                    enterIdOrder();
                    break;
                case "SurnameE":
                    enterSurnameE();
                    break;
                case "NameE":
                    enterNameE();
                    break;
                case "TypeOrder":
                    enterTypeOrder();
                    break;
                default:
                    wrongData();
                    break;
            }
        }
        private void btnOrders_Click_1(object sender, EventArgs e)
        {
            string choose = "";
            if (textBox2Name.Text.Length > 0)
                choose = "Surname";
            if (textBox1Name.Text.Length > 0)
                choose = "Name";
            if (textBoxIdOrder.Text.Length > 0)
                choose = "IdOrder";
            if (textBox2NameE.Text.Length > 0)
                choose = "SurnameE";
            if (textBox1NameE.Text.Length > 0)
                choose = "NameE";
            if (textBoxTypeOrder.Text.Length > 0)
                choose = "TypeOrder";
            switch (choose)
            {
                case "Surname":
                    enterSurname();
                    break;
                case "Name":
                    enterName();
                    break;
                case "IdOrder":
                    enterIdOrder();
                    break;
                case "SurnameE":
                    enterSurnameE();
                    break;
                case "NameE":
                    enterNameE();
                    break;
                case "TypeOrder":
                    enterTypeOrder();
                    break;
                default:
                    wrongData();
                    break;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showDgvOrders();
            cleanTextBox();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentDetailsOrder formSalesDepartmentDetailsOrder = new FormSalesDepartmentDetailsOrder(db);
            formSalesDepartmentDetailsOrder.ShowDialog();
        }
        private void btnOffers_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentOffersOrder formSalesDepartmentOffersOrder = new FormSalesDepartmentOffersOrder(db);
            formSalesDepartmentOffersOrder.ShowDialog();
        }
    }
}
