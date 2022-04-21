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
            textBoxIdOrder.Clear();
        }
        private void messageBox()
        {
            MessageBox.Show("Wyszukiwany numer zamówienia nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK);
        }
        private void msgCleanShowData()
        {
            messageBox();
            cleanTextBox();
            showDgvOrders();
        }

        private void showDgvOrders()
        {
            var datavOrders = from v_Zamowienie in db.v_Zamowienie
                              select new
                              {
                                  v_Zamowienie.Data_przyjęcia,
                                  v_Zamowienie.Nr_zamówienia,
                                  v_Zamowienie.Nazwisko_klienta,
                                  v_Zamowienie.Imię_klienta,
                                  v_Zamowienie.Typ_zamówienia,
                                  v_Zamowienie.Nazwisko_pracownika,
                                  v_Zamowienie.Imię_pracownika,
                              };
            this.dgvOrders.DataSource = datavOrders.ToList();
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void enterIdOrder()
        {
            try
            {
                string idOrder = textBoxIdOrder.Text;
                int idOrderInt = int.Parse(idOrder);
                System.Linq.IQueryable vOrderId = db.v_Zamowienie.Cast<v_Zamowienie>().Where(a => a.Nr_zamówienia == idOrderInt);
                int vOrderIdInt = vOrderId.Cast<v_Zamowienie>().Where(a => a.Nr_zamówienia > 0).Count();
                if (vOrderIdInt > 0)
                {
                    this.dgvOrders.DataSource = vOrderId.Cast<v_Zamowienie>().ToList();
                    cleanTextBox();
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
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK);
            showDgvOrders();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (textBoxIdOrder.Text.Length > 0)
                choose = "IdOrder";
            {
                    enterIdOrder();
            }
        }
    }
}

