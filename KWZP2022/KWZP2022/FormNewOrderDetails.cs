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
        private void clearTextBoxAmount()
        {
            textBoxAmount.Clear();
        }
        private void showData()
        {
            this.db = new KWZPEntities();
            List<v_Zamowienie_szczegol> selectedOrder = this.db.v_Zamowienie_szczegol.Where(a => a.Nr_zamówienia == newOrder.ID_zamowienie).ToList();
            this.dgvOrderDetails.DataSource = selectedOrder;
            this.dgvOrderDetails.Columns["Nr_szczegółu"].HeaderText = "Nr szczegółu";
            this.dgvOrderDetails.Columns["Nr_zamówienia"].HeaderText = "Nr zamówienia";
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
            List<Zamowienie_szczegol> searchOrder = this.db.Zamowienie_szczegol.Where(a => a.ID_produkt == selectedProduct && a.ID_zamowienie == newOrder.ID_zamowienie).ToList();
            List< Oferta_handlowa > selectedOrder = this.db.Oferta_handlowa.Where(a => a.ID_zamowienie == newOrder.ID_zamowienie && a.ID_status_oferta == 1).ToList();
            if (selectedOrder.Count > 0)
            {
                MessageBox.Show("Nie można dodać szczegółów do sprzedanego zamówienia!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxAmount();
            }
            else if (searchOrder.Count > 0)
            {
                MessageBox.Show("Ten produkt został już dodany!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxAmount();
            }
            else
            {
                try
                {
                    Zamowienie_szczegol newZamowienie_Szczegol = new Zamowienie_szczegol();
                    newZamowienie_Szczegol.ID_zamowienie = this.newOrder.ID_zamowienie;
                    newZamowienie_Szczegol.ID_produkt = selectedProduct;
                    newZamowienie_Szczegol.Ilosc = int.Parse(textBoxAmount.Text);
                    this.db.Zamowienie_szczegol.Add(newZamowienie_Szczegol);
                    this.db.SaveChanges();
                    showData();
                    MessageBox.Show("Dodano szczegóły do zamówienia!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBoxAmount();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedProduct = int.Parse(comboBoxProduct.SelectedValue.ToString());
            List<Oferta_handlowa> selectedOrder = this.db.Oferta_handlowa.Where(a => a.ID_zamowienie == newOrder.ID_zamowienie && a.ID_status_oferta == 1).ToList();
            if(selectedOrder.Count > 0)
            {
                MessageBox.Show("Nie można usunąć szczegółów sprzedanego zamówienia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxAmount();
            }
            else
            {
                try
                {
                    int selectedOrderDetail = int.Parse(this.dgvOrderDetails.CurrentRow.Cells[0].Value.ToString());
                    Zamowienie_szczegol selectDetail = this.db.Zamowienie_szczegol.Single(a => a.ID_zamowienie_szczegol == selectedOrderDetail);
                    this.db.Zamowienie_szczegol.Remove(selectDetail);
                    this.db.SaveChanges();
                    this.showData();
                    MessageBox.Show("Usunięto szczegół!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBoxAmount();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć szczegółu, który należy do sprzedanego zamówienia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearTextBoxAmount();
                }
            }
        }
    }
}
