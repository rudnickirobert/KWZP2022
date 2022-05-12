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
            this.db = new KWZPEntities();
            this.dgvOrderDetails.DataSource = this.db.v_Zamowienie_szczegol.ToList();
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesDetails.DataSource = this.db.v_Szczegol_sprzedaz.ToList();
            this.dgvSalesDetails.Columns["ID_sprzedaz"].Visible = false;
            this.dgvSalesDetails.Columns["ID_produkt"].Visible = false;
            this.dgvSalesDetails.Columns["ID_podatek"].Visible = false;
            this.dgvSalesDetails.Columns["ID_szczegoly_sprzedaz"].HeaderText = "Numer szczegółu";
            this.dgvSalesDetails.Columns["Nr_sprzedaz"].HeaderText = "Numer sprzedaży";
            this.dgvSalesDetails.Columns["Nazwa_produkt"].HeaderText = "Nazwa produktu";
            this.dgvSalesDetails.Columns["Ilosc"].HeaderText = "Ilość sztuk";
            this.dgvSalesDetails.Columns["Procent"].HeaderText = "Podatek [%]";
            this.dgvSalesDetails.Columns["Kwota_sprzedaz"].HeaderText = "Cena za sztukę";
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
            comboBoxTax.SelectedIndex = 2;
        }
        private void textBoxPriceData()
        {
            int selectedNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
            string selectedProductComboBox = comboBoxProduct.SelectedValue.ToString();
            Produkt selectedProductTable = this.db.Produkt.Single(a => a.Nazwa_produkt == selectedProductComboBox);
            int selectedTaxComboBox = int.Parse(comboBoxTax.SelectedValue.ToString());
            Podatek selectedTaxTable = this.db.Podatek.Single(a => a.ID_podatek == selectedTaxComboBox);
            List<v_Koszt_material_sztuka_suma> selectMaterialsCost = this.db.v_Koszt_material_sztuka_suma.Where(a => a.ID_produkt == selectedProductTable.ID_produkt).ToList();
            List<v_Koszt_material_polprodukt_sztuka_suma> selectMaterialsSemiFinishedProductsCost = this.db.v_Koszt_material_polprodukt_sztuka_suma.Where(a => a.ID_produkt == selectedProductTable.ID_produkt).ToList();
            Sprzedaz selectSaleNumber = this.db.Sprzedaz.Single(a => a.ID_sprzedaz == selectedNoSale);
            Umowa_sprzedaz selectSaleAgreement = this.db.Umowa_sprzedaz.Single(a => a.ID_umowa_sprzedaz == selectSaleNumber.ID_umowa_sprzedaz);
            Oferta_handlowa selectPriceFromCommercialOffer = this.db.Oferta_handlowa.Single(a => a.ID_oferta_handlowa == selectSaleAgreement.ID_oferta_handlowa);
            
            if (selectMaterialsCost.Count > 0)
            {
                List<v_Kwota_za_materialy> priceForMaterialsSelectedNoOrder = this.db.v_Kwota_za_materialy.Where(a => a.ID_zamowienie == selectPriceFromCommercialOffer.ID_zamowienie).ToList();
                if (priceForMaterialsSelectedNoOrder.Count > 0)
                {
                    v_Kwota_za_materialy priceForMaterialsFullProduct = this.db.v_Kwota_za_materialy.Single(a => a.ID_zamowienie == selectPriceFromCommercialOffer.ID_zamowienie);
                    double multiplier = (double)selectPriceFromCommercialOffer.Cena / (double)priceForMaterialsFullProduct.Cena_za_zamówienie;
                    int costProduct = decimal.ToInt32(selectMaterialsCost.Single(a => a.ID_produkt == selectedProductTable.ID_produkt).Suma_koszt_materiał.Value);
                    int bruttoPrice = (int)(costProduct * multiplier + ((costProduct * multiplier) * ((double)selectedTaxTable.Procent / 100)));
                    textBoxPrice.Text = bruttoPrice.ToString();
                }
            }
            else
            {
                v_Kwota_za_materialy_bez_produktu priceForMaterialsSemiFinishedProduct = this.db.v_Kwota_za_materialy_bez_produktu.Single(a => a.ID_zamowienie == selectPriceFromCommercialOffer.ID_zamowienie);
                double multiplier = (double)selectPriceFromCommercialOffer.Cena / (double)priceForMaterialsSemiFinishedProduct.Cena_za_zamówienie;
                int costProduct = decimal.ToInt32(selectMaterialsSemiFinishedProductsCost.Single(a => a.ID_produkt == selectedProductTable.ID_produkt).Suma_koszt_material_na_półprodukt.Value);
                int bruttoPrice = (int)(costProduct * multiplier + ((costProduct * multiplier) * ((double)selectedTaxTable.Procent / 100)));
                textBoxPrice.Text = bruttoPrice.ToString();
            }
        }
        private void textBoxAmountData()
        {
            int selectedNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
            string selectedProduct = comboBoxProduct.SelectedValue.ToString();
            v_Dodaj_szczegol_sprzedaz selectedRow = this.db.v_Dodaj_szczegol_sprzedaz.Where(a => (a.Produkt == selectedProduct && a.Numer_sprzedaży == selectedNoSale)).First();
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
            if(textBoxAmount.Text.Length > 0 && textBoxPrice.Text.Length > 0)
            {
                try
                {
                    int selectedNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                    string selectedProduct = comboBoxProduct.SelectedValue.ToString();
                    Produkt selectedProductFromTableProduct = this.db.Produkt.Single(a => a.Nazwa_produkt == selectedProduct);
                    int selectedTax = int.Parse(comboBoxTax.SelectedValue.ToString());
                    List<Szczegoly_sprzedaz> selectedRow = this.db.Szczegoly_sprzedaz.Where(a => (a.ID_produkt == selectedProductFromTableProduct.ID_produkt && a.ID_sprzedaz == selectedNoSale && a.ID_podatek == selectedTax)).ToList();
                    if (selectedRow.Count() < 1)
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
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            comboBoxTaxData();
            textBoxAmountData();
            textBoxPriceData();
        }

        private void comboBoxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxPrice.Clear();
            textBoxAmountData();
            textBoxPriceData();
        }

        private void comboBoxTax_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxPriceData();
        }

        private void dgvSalesDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int numberSaleDetail = int.Parse(this.dgvSalesDetails.CurrentRow.Cells[0].Value.ToString());
            Szczegoly_sprzedaz selectedSaleDetail = this.db.Szczegoly_sprzedaz.Single(a => a.ID_szczegoly_sprzedaz == numberSaleDetail);
            Sprzedaz selectedSale = this.db.Sprzedaz.Single(a => a.ID_sprzedaz == selectedSaleDetail.ID_sprzedaz);
            Produkt selectedProduct = this.db.Produkt.Single(a => a.ID_produkt == selectedSaleDetail.ID_produkt);
            Podatek selectedTax = this.db.Podatek.Single(a => a.ID_podatek == selectedSaleDetail.ID_podatek);
            v_Dodaj_szczegol_sprzedaz selectClient = this.db.v_Dodaj_szczegol_sprzedaz.Where(a => a.Numer_sprzedaży == selectedSale.Nr_sprzedaz).First();
            comboBoxNoSale.Text = selectedSale.Nr_sprzedaz.ToString();
            comboBoxNoSale_SelectionChangeCommitted(selectedSale, e);
            comboBoxProduct.Text = selectedProduct.Nazwa_produkt.ToString();
            comboBoxTax.Text = selectedTax.Procent.ToString();
            textBoxAmount.Text = selectedSaleDetail.Ilosc.ToString();
            textBoxPrice.Text = selectedSaleDetail.Kwota_sprzedaz.ToString();
            textBoxNoTel.Text = selectClient.Numer_telefonu_klient.ToString();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string selectedSaleDetailNoSale = this.dgvSalesDetails.CurrentRow.Cells[1].Value.ToString();
            string selectedSaleDetailProduct = this.dgvSalesDetails.CurrentRow.Cells[3].Value.ToString();
            if ((comboBoxNoSale.Text != selectedSaleDetailNoSale) || (comboBoxProduct.Text != selectedSaleDetailProduct))
            {
                MessageBox.Show("Dane nie są zgodne! Kliknij dwa razy na sprzedaż którą chcesz zmodyfikować.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((comboBoxNoSale.Text == selectedSaleDetailNoSale) && (comboBoxProduct.Text == selectedSaleDetailProduct))
            {
                if (comboBoxNoSale.Text.Length < 0 || comboBoxProduct.Text.Length < 0 || comboBoxTax.Text.Length < 0 || textBoxAmount.Text.Length < 0 || textBoxPrice.Text.Length < 0)
                {
                    MessageBox.Show("Nie wprowadzono danych poprawnie!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult changeSale = MessageBox.Show("Czy na pewno chcesz zmienić szczegóły sprzedaży?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (changeSale == DialogResult.Yes)
                    {
                        int selectedSaleDetailFromDgv = int.Parse(this.dgvSalesDetails.CurrentRow.Cells[0].Value.ToString());
                        Szczegoly_sprzedaz selecetedSaleDetail = this.db.Szczegoly_sprzedaz.Single(a => a.ID_szczegoly_sprzedaz == selectedSaleDetailFromDgv);
                        string selectedProductFromComboBox = comboBoxProduct.Text;
                        Produkt selectedProduct = this.db.Produkt.Single(a => a.Nazwa_produkt == selectedProductFromComboBox);
                        selecetedSaleDetail.ID_sprzedaz = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                        selecetedSaleDetail.ID_produkt = selectedProduct.ID_produkt;
                        selecetedSaleDetail.Kwota_sprzedaz = int.Parse(textBoxPrice.Text);
                        selecetedSaleDetail.ID_podatek = int.Parse(comboBoxTax.SelectedValue.ToString());
                        selecetedSaleDetail.Ilosc = int.Parse(textBoxAmount.Text);
                        this.db.SaveChanges();
                        showData();
                        MessageBox.Show("Zmodyfikowano dane!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
