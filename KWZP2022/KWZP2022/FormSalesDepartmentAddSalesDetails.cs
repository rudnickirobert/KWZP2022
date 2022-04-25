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
    public partial class FormSalesDepartmentAddSalesDetails : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentAddSalesDetails(KWZPEntities db)
        {
            InitializeComponent(); 
            this.db = db;
            showData();
            comboBoxNoSaleData();
            comboBoxTaxData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showData()
        {
            this.dgvSalesDetails.DataSource = this.db.v_Zamowienie_szczegol.ToList();
            this.dgvSalesDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void comboBoxNoSaleData()
        {
            comboBoxNoSale.DataSource = this.db.Sprzedaz.ToList();
            comboBoxNoSale.ValueMember = "ID_sprzedaz";
            comboBoxNoSale.DisplayMember = "Nr_sprzedaz";
        }
        private void comboBoxProductData()
        {
            int selectedNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
            List<v_Dodaj_szczegol_sprzedaz> selectedRow = this.db.v_Dodaj_szczegol_sprzedaz.Where(a => a.Numer_sprzedaży == selectedNoSale).ToList();
            comboBoxProduct.DataSource = selectedRow;
            comboBoxProduct.ValueMember = "Produkt";
            comboBoxProduct.DisplayMember = "Nazwa_produkt";
        }
        private void comboBoxTaxData()
        {
            comboBoxTax.DataSource = this.db.Podatek.ToList();
            comboBoxTax.ValueMember = "ID_podatek";
            comboBoxTax.DisplayMember = "Procent";
        }
        private void textBoxPriceData()
        {
            int selectedNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
            string selectedProduct = comboBoxProduct.SelectedValue.ToString();
            v_Dodaj_szczegol_sprzedaz selectedRow = this.db.v_Dodaj_szczegol_sprzedaz.Single(a => (a.Produkt == selectedProduct && a.Numer_sprzedaży == selectedNoSale));
            textBoxPrice.Text = selectedRow.Cena.ToString();
        }
        private void textBoxAmountData()
        {
            int selectedNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
            string selectedProduct = comboBoxProduct.SelectedValue.ToString();
            v_Dodaj_szczegol_sprzedaz selectedRow = this.db.v_Dodaj_szczegol_sprzedaz.Single(a => (a.Produkt == selectedProduct && a.Numer_sprzedaży == selectedNoSale));
            textBoxAmount.Text = selectedRow.Ilość.ToString();
        }
        private void textBoxNoTelData()
        {
            int selectedNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
            v_Dodaj_szczegol_sprzedaz selectedRow = this.db.v_Dodaj_szczegol_sprzedaz.Where(a => a.Numer_sprzedaży == selectedNoSale).First();
            textBoxNoTel.Text = selectedRow.Numer_telefonu_klient.ToString();
        }
        private void btnAddNewSale_Click(object sender, EventArgs e)
        {
            if(textBoxAmount.Text.Length > 0 && textBoxAmount.Text.Length > 0)
            {
                int selectedNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                string selectedProduct = comboBoxProduct.SelectedValue.ToString();
                Produkt selectedProductFromTableProduct = this.db.Produkt.Single(a => a.Nazwa_produkt == selectedProduct);
                List<Szczegoly_sprzedaz> selectedRow = this.db.Szczegoly_sprzedaz.Where(a => (a.ID_produkt == selectedProductFromTableProduct.ID_produkt && a.ID_sprzedaz == selectedNoSale)).ToList();
                if(selectedRow.Count() < 1)
                {
                    Szczegoly_sprzedaz newSaleDetails = new Szczegoly_sprzedaz();
                    newSaleDetails.ID_sprzedaz = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                    newSaleDetails.ID_produkt = selectedProductFromTableProduct.ID_produkt;
                    newSaleDetails.Kwota_sprzedaz = int.Parse(textBoxPrice.Text);
                    newSaleDetails.ID_podatek = int.Parse(comboBoxTax.SelectedValue.ToString());
                    newSaleDetails.Ilosc = int.Parse(textBoxAmount.Text);
                    this.db.Szczegoly_sprzedaz.Add(newSaleDetails);
                    this.db.SaveChanges();
                    MessageBox.Show($"Dodano nowy szczegół do sprzedaży: {comboBoxNoSale.SelectedValue}.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }
                else
                {
                    MessageBox.Show("Szczegóły dla danego produktu i nr sprzedaży już istnieją!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie wprowadzono danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxNoSale_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxProductData();
            textBoxNoTelData();
            textBoxAmount.Clear();
            textBoxPrice.Clear();
        }

        private void comboBoxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxPriceData();
            textBoxAmountData();
        }
    }
}
