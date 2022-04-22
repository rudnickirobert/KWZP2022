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
    public partial class FormNewOrderDetails : Form
    {
        KWZPEntities db;
        Zamowienie newOrder;
        public FormNewOrderDetails(KWZPEntities db, Zamowienie newOrder)
        {
            InitializeComponent();
            this.db = db;
            this.newOrder = newOrder;
            showData();
            comboBoxProductData();
        }
        private void showData()
        {
            this.dgvOrderDetails.DataSource = this.db.v_Zamowienie_szczegol.ToList();
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxProductData()
        {
            comboBoxProduct.DataSource = this.db.Produkt.ToList();
            comboBoxProduct.ValueMember = "ID_produkt";
            comboBoxProduct.DisplayMember = "Nazwa_produkt";
        }
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            int selectedProduct = int.Parse(comboBoxProduct.SelectedValue.ToString());
            Zamowienie_szczegol newZamowienie_Szczegol = new Zamowienie_szczegol();
            newZamowienie_Szczegol.ID_zamowienie = this.newOrder.ID_zamowienie;
            newZamowienie_Szczegol.ID_produkt = selectedProduct;
            newZamowienie_Szczegol.Ilosc = int.Parse(textBoxAmount.Text);
            this.db.Zamowienie_szczegol.Add(newZamowienie_Szczegol);
            this.db.SaveChanges();
            showData();
            MessageBox.Show("Dodano szczegóły do zamówienia!","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedOrderDetail = int.Parse(this.dgvOrderDetails.CurrentRow.Cells[0].Value.ToString());
            Zamowienie_szczegol selectDetail = this.db.Zamowienie_szczegol.Single(a => a.ID_zamowienie == selectedOrderDetail);
            this.db.Zamowienie_szczegol.Remove(selectDetail);
            this.db.SaveChanges();
        }
    }
}
