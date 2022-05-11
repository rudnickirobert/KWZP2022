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
    public partial class FormNewCommertialOffer : Form
    {
        KWZPEntities db;
        public FormNewCommertialOffer(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            comboBoxData();
            comboBoxNoOrder.SelectedIndex = -1;
        }
        private void comboBoxData()
        {
            this.db = new KWZPEntities();
            comboBoxEmployeeData();
            comboBoxNoOrderData();
            comboBoxGuaranteeData();
            comboBoxOfferStatusData();
        }
        private void textBoxTextClear()
        {
            textBoxPrice.Clear();
            textBoxPriceForEmployee.Clear();
            textBoxPriceForMachines.Clear();
            textBoxPriceForMaterials.Clear();
            textBoxPriceForOrder.Clear();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxEmployeeData()
        {
            comboBoxEmployee.DataSource = this.db.v_Pracownik_dzial.ToList();
            comboBoxEmployee.ValueMember = "ID_pracownik";
            comboBoxEmployee.DisplayMember = "Nazwisko";
        }
        private void comboBoxNoOrderData()
        {
            comboBoxNoOrder.DataSource = this.db.v_Zamowienia_bez_umowy.ToList();
            comboBoxNoOrder.ValueMember = "ID_zamowienie";
            comboBoxNoOrder.DisplayMember = "ID_zamowienie";
        }
        private void comboBoxGuaranteeData()
        {
            comboBoxGuarantee.DataSource = this.db.Gwarancja.ToList();
            comboBoxGuarantee.ValueMember = "ID_gwarancja";
            comboBoxGuarantee.DisplayMember = "Opis_gwarancja";
        }
        private void textBoxPricesData()
        {
            int selectedNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
            bool checkingMaterialsError = false;
            if (this.db.v_Kwota_za_materialy.Where(a => a.ID_zamowienie == selectedNoOrder).ToList().Count() > 0)
            {
                if(this.db.v_Kwota_za_materialy.Where(a => a.ID_zamowienie == selectedNoOrder).ToList().Count() > 0)
                {
                    v_Kwota_za_materialy priceForMaterialsSelectedNoOrder = this.db.v_Kwota_za_materialy.Single(a => a.ID_zamowienie == selectedNoOrder);
                    textBoxPriceForMaterials.Text = String.Format("{0:N2}", priceForMaterialsSelectedNoOrder.Cena_za_zamówienie);
                }
                else
                {
                    comboBoxNoOrder.SelectedIndex = -1;
                    textBoxTextClear();
                    MessageBox.Show("Nie dodano materiałów do wytworzenia nowego produktu! Proszę dodać materiały do produktu lub wybrać inne zamówienie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkingMaterialsError = true;
                }
            }
            else
            {
                if(this.db.v_Kwota_za_materialy_bez_produktu.Where(a => a.ID_zamowienie == selectedNoOrder).ToList().Count() > 0)
                {
                    v_Kwota_za_materialy_bez_produktu priceForMaterialsSelectedNoOrder = this.db.v_Kwota_za_materialy_bez_produktu.Single(a => a.ID_zamowienie == selectedNoOrder);
                    textBoxPriceForMaterials.Text = String.Format("{0:N2}", priceForMaterialsSelectedNoOrder.Cena_za_zamówienie);
                }
                else
                {
                    comboBoxNoOrder.SelectedIndex = -1;
                    textBoxTextClear();
                    MessageBox.Show("Nie dodano materiałów do wytworzenia nowego produktu! Proszę dodać materiały do produktu lub wybrać inne zamówienie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkingMaterialsError = true;
                }
            }
            bool compositionProductsError = false;
            bool compositionSemiFinishedProductsError = false;
            if (checkingMaterialsError == false)
            {
                if (this.db.v_Kwota_za_materialy.Where(a => a.ID_zamowienie == selectedNoOrder).ToList().Count() > 0)
                {
                    List<v_Zamowione_produkty> productsList = this.db.v_Zamowione_produkty.Where(a => a.ID_zamowienie == selectedNoOrder).ToList();
                    foreach (v_Zamowione_produkty orderedProducts in productsList)
                    {
                        List<Sklad_produkt> compositionProductsList = this.db.Sklad_produkt.Where(a => a.ID_produkt == orderedProducts.ID_produkt).ToList();

                        foreach (Sklad_produkt checkingSemiFinishedProducts in compositionProductsList)
                        {
                            if (this.db.Proces_polprodukt_czynnosc.Where(a => a.ID_polprodukt == checkingSemiFinishedProducts.ID_polprodukt).ToList().Count == 0)
                            {
                                comboBoxNoOrder.SelectedIndex = -1;
                                textBoxTextClear();
                                MessageBox.Show("Nie dodano czynności półproduktu", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                compositionSemiFinishedProductsError = true;
                                break;
                            }
                        }
                        if(compositionSemiFinishedProductsError)
                        {
                            break;
                        }
                        else
                        {
                            List<Sklad_produkt_material> compositionMaterialsForProductsList = this.db.Sklad_produkt_material.Where(a => a.ID_produkt == orderedProducts.ID_produkt).ToList();
                            foreach (Sklad_produkt_material checkingProducts in compositionMaterialsForProductsList)
                            {
                                if (this.db.Proces_produkt_czynnosc.Where(a => a.ID_produkt == checkingProducts.ID_produkt).ToList().Count == 0)
                                {
                                    comboBoxNoOrder.SelectedIndex = -1;
                                    textBoxTextClear();
                                    MessageBox.Show("Nie dodano czynności produktu", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    compositionProductsError = true;
                                    break;
                                }
                            }
                        }
                        if (compositionProductsError)
                        {
                            break;
                        }
                    }
                    if(compositionSemiFinishedProductsError == false && compositionProductsError == false)
                    {
                        v_Kwota_za_materialy priceForMaterialsSelectedNoOrder = this.db.v_Kwota_za_materialy.Single(a => a.ID_zamowienie == selectedNoOrder);
                        v_Szacowany_koszt_maszyn_do_zamowienia priceForMachines = this.db.v_Szacowany_koszt_maszyn_do_zamowienia.Single(a => a.ID_zamowienie == selectedNoOrder);
                        v_Szacowany_koszt_pracownik_do_zamowienia priceForEmployee = this.db.v_Szacowany_koszt_pracownik_do_zamowienia.Single(a => a.ID_zamowienie == selectedNoOrder);
                        textBoxPriceForMaterials.Text = String.Format("{0:N2}", priceForMaterialsSelectedNoOrder.Cena_za_zamówienie);
                        textBoxPriceForMachines.Text = String.Format("{0:N2}", priceForMachines.Średnia);
                        textBoxPriceForEmployee.Text = String.Format("{0:N2}", priceForEmployee.Średnia);
                        textBoxPriceForOrder.Text = String.Format("{0:N2}", (priceForMaterialsSelectedNoOrder.Cena_za_zamówienie.Value + priceForMachines.Średnia + priceForEmployee.Średnia) * 2);
                    }
                }
                else
                {
                    List<v_Zamowione_produkty> productsList = this.db.v_Zamowione_produkty.Where(a => a.ID_zamowienie == selectedNoOrder).ToList();
                    foreach (v_Zamowione_produkty orderedProducts in productsList)
                    {
                        List<Sklad_produkt> compositionProductsList = this.db.Sklad_produkt.Where(a => a.ID_produkt == orderedProducts.ID_produkt).ToList();

                        foreach (Sklad_produkt checkSemiFinishedProducts in compositionProductsList)
                        {
                            if (this.db.Proces_polprodukt_czynnosc.Where(a => a.ID_polprodukt == checkSemiFinishedProducts.ID_polprodukt).ToList().Count == 0)
                            {
                                comboBoxNoOrder.SelectedIndex = -1;
                                textBoxTextClear();
                                MessageBox.Show("Nie dodano czynności półproduktu", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                compositionSemiFinishedProductsError = true;
                                break;
                            }
                        }
                        if (compositionSemiFinishedProductsError)
                        {
                            break;
                        }
                    }
                    if(compositionSemiFinishedProductsError == false)
                    {
                        v_Kwota_za_materialy_bez_produktu priceForMaterialsSelectedNoOrder = this.db.v_Kwota_za_materialy_bez_produktu.Single(a => a.ID_zamowienie == selectedNoOrder);
                        v_Szacowany_koszt_maszyn_do_zamowienia priceForMachines = this.db.v_Szacowany_koszt_maszyn_do_zamowienia.Single(a => a.ID_zamowienie == selectedNoOrder);
                        v_Szacowany_koszt_pracownik_do_zamowienia priceForEmployee = this.db.v_Szacowany_koszt_pracownik_do_zamowienia.Single(a => a.ID_zamowienie == selectedNoOrder);
                        textBoxPriceForMachines.Text = String.Format("{0:N2}", priceForMachines.Średnia);
                        textBoxPriceForEmployee.Text = String.Format("{0:N2}", priceForEmployee.Średnia);
                        textBoxPriceForOrder.Text = String.Format("{0:N2}", (priceForMaterialsSelectedNoOrder.Cena_za_zamówienie.Value + priceForMachines.Średnia + priceForEmployee.Średnia) * 2);
                    }
                }
            }
        }
        private void comboBoxOfferStatusData()
        {
            if (comboBoxNoOrder.SelectedValue != null)
            {
                int selectedNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
                Zamowienie orderNotAccepted = this.db.Zamowienie.Single(a => a.ID_zamowienie == selectedNoOrder);
                if (orderNotAccepted.ID_typ_zamowienie == 2)
                {
                    comboBoxOfferStatus.DataSource = this.db.Status_oferta.Where(a => a.ID_status_oferta == 1).ToList();
                    comboBoxOfferStatus.ValueMember = "ID_status_oferta";
                    comboBoxOfferStatus.DisplayMember = "Nazwa_status_oferta";
                }
                else
                {
                    comboBoxOfferStatus.DataSource = this.db.Status_oferta.Where(a => a.ID_status_oferta == 3 || a.ID_status_oferta == 1).OrderByDescending(a => a.ID_status_oferta).ToList();
                    comboBoxOfferStatus.ValueMember = "ID_status_oferta";
                    comboBoxOfferStatus.DisplayMember = "Nazwa_status_oferta";
                }
            }
            else
            {
                MessageBox.Show("Nie ma zamówień dla których można stworzyć ofertę", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAddNewOffer_Click(object sender, EventArgs e)
        {
            bool errorWithEnteredData = false;
            if (comboBoxNoOrder.SelectedValue == null)
            {
                MessageBox.Show("Źle wprowadzono dane", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorWithEnteredData = true;
                comboBoxNoOrder.SelectedIndex = -1;
            }
            bool requiredMaterialError = false;
            if (errorWithEnteredData == false)
            {
                int selectedNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
                List<v_Potrzebne_materialy> necessaryMaterial = this.db.v_Potrzebne_materialy.Where(a => a.ID_zamowienie == selectedNoOrder).ToList();
                List<v_Aktualny_stan_magazyn> materialsInWarehouse = this.db.v_Aktualny_stan_magazyn.ToList();
                foreach (v_Potrzebne_materialy requiredMaterial in necessaryMaterial)
                {
                    foreach (v_Aktualny_stan_magazyn materialInWarehouse in materialsInWarehouse)
                    {
                        if (requiredMaterial.ID_material == materialInWarehouse.ID)
                        {
                            int materialAmount = (int)(materialInWarehouse.Aktualny_stan);
                            if (materialAmount < 0)
                            {
                                MessageBox.Show("Nie ma wystarczającej ilości materiałów w magazynie!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                missingMaterials();
                                requiredMaterialError = true;
                                break;
                            }
                        }
                    }
                    if (requiredMaterialError)
                    {
                        break;
                    }
                }
                if(requiredMaterialError == false)
                {
                    v_Szacowany_czas_realizacji_zamowienia timeForOrder = this.db.v_Szacowany_czas_realizacji_zamowienia.Single(a => a.ID_zamowienie == selectedNoOrder);
                    int amountDays = int.Parse(timeForOrder.Szacowany_czas_realizacji.ToString()) + 1;
                    if (dtpDateOfImplementation.Value.Date > (DateTime.Now.AddDays(amountDays)))
                    {
                        int suggestedPrice = (int)(double.Parse(textBoxPriceForOrder.Text));
                        int enteredPrice = int.Parse(textBoxPrice.Text.ToString());
                        if (enteredPrice < suggestedPrice)
                        {
                            DialogResult enteredPriceLowerThansuggestedPrice = MessageBox.Show("Czy na pewno kwota za zamówienie ma być niższa od kwoty sugerowanej?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (enteredPriceLowerThansuggestedPrice == DialogResult.Yes)
                            {
                                Oferta_handlowa newComertialOffer = new Oferta_handlowa();
                                newComertialOffer.ID_pracownik = int.Parse(comboBoxEmployee.SelectedValue.ToString());
                                newComertialOffer.ID_zamowienie = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
                                newComertialOffer.ID_gwarancja = int.Parse(comboBoxGuarantee.SelectedValue.ToString());
                                newComertialOffer.Termin_realizacja = dtpDateOfImplementation.Value.Date;
                                newComertialOffer.ID_status_oferta = int.Parse(comboBoxOfferStatus.SelectedValue.ToString());
                                newComertialOffer.Cena = int.Parse(textBoxPrice.Text);
                                this.db.Oferta_handlowa.Add(newComertialOffer);
                                this.db.SaveChanges();
                                MessageBox.Show("Dodano nową ofertę handlową", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (comboBoxOfferStatus.SelectedValue.ToString() == "1")
                                {
                                    Umowa_sprzedaz newSaleArrangement = new Umowa_sprzedaz();
                                    Oferta_handlowa selectedOffer = this.db.Oferta_handlowa.AsEnumerable().Last();
                                    newSaleArrangement.ID_oferta_handlowa = selectedOffer.ID_oferta_handlowa;
                                    this.db.Umowa_sprzedaz.Add(newSaleArrangement);
                                    this.db.SaveChanges();
                                    List<IGrouping<int, Oferta_handlowa>> acceptedCommercialOfferList = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 1).GroupBy(a => a.ID_zamowienie).ToList();
                                    List<IGrouping<int, Oferta_handlowa>> commercialOfferForConsiderationList = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 3).GroupBy(a => a.ID_zamowienie).ToList();
                                    int offerFromComboBoxNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
                                    int commercialOfferForConsiderationCount = commercialOfferForConsiderationList.Where(a => a.Key == offerFromComboBoxNoOrder).GroupBy(a => a.Key).ToList().Count();
                                    int acceptedCommercialOfferListCount = acceptedCommercialOfferList.Where(a => a.Key == offerFromComboBoxNoOrder).GroupBy(a => a.Key).ToList().Count();
                                    List<Oferta_handlowa> selectedCommercialOfferForConsiderationList = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 3 && a.ID_zamowienie == offerFromComboBoxNoOrder).ToList();
                                    if (commercialOfferForConsiderationCount == acceptedCommercialOfferListCount)
                                    {
                                        foreach (Oferta_handlowa commercialOfferForConsiderationCancel in selectedCommercialOfferForConsiderationList)
                                        {
                                            commercialOfferForConsiderationCancel.ID_status_oferta = 2;
                                            this.db.SaveChanges();
                                        }
                                    }
                                    Alert newAlertForProductionDepartment = new Alert();
                                    newAlertForProductionDepartment.ID_dzial = 3;
                                    newAlertForProductionDepartment.Tresc = $"Nowe zamówienie nr: {newComertialOffer.ID_zamowienie}";
                                    newAlertForProductionDepartment.Czy_odczytano = false;
                                    this.db.Alert.Add(newAlertForProductionDepartment);
                                    this.db.SaveChanges();
                                    comboBoxData();
                                }
                            }
                            else if (enteredPriceLowerThansuggestedPrice == DialogResult.No)
                            {
                                MessageBox.Show("Oferta handlowa została anulowana", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            Oferta_handlowa newComertialOffer = new Oferta_handlowa();
                            newComertialOffer.ID_pracownik = int.Parse(comboBoxEmployee.SelectedValue.ToString());
                            newComertialOffer.ID_zamowienie = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
                            newComertialOffer.ID_gwarancja = int.Parse(comboBoxGuarantee.SelectedValue.ToString());
                            newComertialOffer.Termin_realizacja = dtpDateOfImplementation.Value.Date;
                            newComertialOffer.ID_status_oferta = int.Parse(comboBoxOfferStatus.SelectedValue.ToString());
                            newComertialOffer.Cena = int.Parse(textBoxPrice.Text);
                            this.db.Oferta_handlowa.Add(newComertialOffer);
                            this.db.SaveChanges();
                            MessageBox.Show("Dodano nową ofertę handlową", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (comboBoxOfferStatus.SelectedValue.ToString() == "1")
                            {
                                Umowa_sprzedaz newSaleArrangement = new Umowa_sprzedaz();
                                Oferta_handlowa selectedOffer = this.db.Oferta_handlowa.AsEnumerable().Last();
                                newSaleArrangement.ID_oferta_handlowa = selectedOffer.ID_oferta_handlowa;
                                this.db.Umowa_sprzedaz.Add(newSaleArrangement);
                                this.db.SaveChanges();
                                List<IGrouping<int, Oferta_handlowa>> acceptedCommercialOfferList = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 1).GroupBy(a => a.ID_zamowienie).ToList();
                                List<IGrouping<int, Oferta_handlowa>> commercialOfferForConsiderationList = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 3).GroupBy(a => a.ID_zamowienie).ToList();
                                int offerFromComboBoxNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
                                int commercialOfferForConsiderationCount = commercialOfferForConsiderationList.Where(a => a.Key == offerFromComboBoxNoOrder).GroupBy(a => a.Key).ToList().Count();
                                int acceptedCommercialOfferListCount = acceptedCommercialOfferList.Where(a => a.Key == offerFromComboBoxNoOrder).GroupBy(a => a.Key).ToList().Count();
                                List<Oferta_handlowa> selectedCommercialOfferForConsiderationList = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 3 && a.ID_zamowienie == offerFromComboBoxNoOrder).ToList();
                                if (commercialOfferForConsiderationCount == acceptedCommercialOfferListCount)
                                {
                                    foreach (Oferta_handlowa commercialOfferForConsiderationCancel in selectedCommercialOfferForConsiderationList)
                                    {
                                        commercialOfferForConsiderationCancel.ID_status_oferta = 2;
                                        this.db.SaveChanges();
                                    }
                                }
                                Alert newAlertForProductionDepartment = new Alert();
                                newAlertForProductionDepartment.ID_dzial = 3;
                                newAlertForProductionDepartment.Tresc = $"Nowe zamówienie nr: {newComertialOffer.ID_zamowienie}";
                                newAlertForProductionDepartment.Czy_odczytano = false;
                                this.db.Alert.Add(newAlertForProductionDepartment);
                                this.db.SaveChanges();
                                comboBoxData();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Źle wprowadzono dane", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            comboBoxNoOrder.SelectedIndex = -1;
        }
        private void comboBoxNoOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxTextClear();
            dgvMissingMaterials.Visible = false;
            lblDescription.Visible = false;
            btnAddAlert.Visible = false;
            comboBoxOfferStatusData();
            textBoxPricesData();
            if (comboBoxNoOrder.SelectedValue != null)
            {
                int selectedNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
                v_Szacowany_czas_realizacji_zamowienia timeForOrder = this.db.v_Szacowany_czas_realizacji_zamowienia.Single(a => a.ID_zamowienie == selectedNoOrder);
                int amountDays = int.Parse(timeForOrder.Szacowany_czas_realizacji.ToString()) + 2;
                dtpDateOfImplementation.Value = DateTime.Now.AddDays(amountDays);
                if (amountDays != 1)
                {
                    lblCompletionDate.Text = $"Termin realizacji (min. {amountDays} dni):";
                }
                else
                {
                    lblCompletionDate.Text = $"Termin realizacji (min. {amountDays} dzień):";
                }
            }
            else
            {
                lblCompletionDate.Text = $"Termin realizacji:";
            }
        }

        private void btnCheckAvailableMaterials_Click(object sender, EventArgs e)
        {
            if (comboBoxNoOrder.SelectedValue != null)
            {
                bool materialInWarehouseErrorLoop = false;
                bool requiredMaterialErrorLoop = false;
                int selectedNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
                List<v_Potrzebne_materialy> necessaryMaterial = this.db.v_Potrzebne_materialy.Where(a => a.ID_zamowienie == selectedNoOrder).ToList();
                List<v_Aktualny_stan_magazyn> materialsInWarehouse = this.db.v_Aktualny_stan_magazyn.ToList();
                foreach (v_Potrzebne_materialy requiredMaterial in necessaryMaterial)
                {
                    foreach (v_Aktualny_stan_magazyn materialInWarehouse in materialsInWarehouse)
                    {
                        if (requiredMaterial.ID_material == materialInWarehouse.ID)
                        {
                            int materialAmount = (int)(materialInWarehouse.Aktualny_stan);
                            if (materialAmount < 0)
                            {
                                MessageBox.Show("Nie ma wystarczającej ilości materiałów w magazynie!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                missingMaterials();
                                requiredMaterialErrorLoop = true;
                                break;
                            }
                        }
                    }
                    if (requiredMaterialErrorLoop)
                    {
                        materialInWarehouseErrorLoop = true;
                        break;
                    }
                }
                if(materialInWarehouseErrorLoop == false)
                {
                    MessageBox.Show("W magazynie jest wystarczająco materiałów!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void missingMaterials()
        {
            lblDescription.Visible = true;
            dgvMissingMaterials.Visible = true;
            btnAddAlert.Visible = true;
            dgvMissingMaterials.DataSource = this.db.v_Brakujacy_material.ToList();
            dgvMissingMaterials.Columns["ID_material"].Visible = false;
            dgvMissingMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAddAlert_Click(object sender, EventArgs e)
        {
            if (this.dgvMissingMaterials.SelectedRows.Count > 0)
            {
                if (this.dgvMissingMaterials.CurrentRow != null)
                {
                    string material = this.dgvMissingMaterials.CurrentRow.Cells[1].Value.ToString();
                    string amount = this.dgvMissingMaterials.CurrentRow.Cells[2].Value.ToString();
                    int alertCountBefore = this.db.Alert.ToList().Count;
                    FormDodajAlert addAlert = new FormDodajAlert(db, material, amount);
                    addAlert.ShowDialog();
                    int alertCountAfter = this.db.Alert.ToList().Count;
                    if (alertCountBefore >= alertCountAfter)
                    {
                        MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int alertCountBefore = this.db.Alert.ToList().Count;
                    FormDodajAlert addAlert = new FormDodajAlert(db);
                    addAlert.ShowDialog();
                    int alertCountAfter = this.db.Alert.ToList().Count;
                    if (alertCountBefore >= alertCountAfter)
                    {
                        MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                string material = this.dgvMissingMaterials.CurrentRow.Cells[1].Value.ToString();
                string amount = this.dgvMissingMaterials.CurrentRow.Cells[2].Value.ToString();
                int alertCountBefore = this.db.Alert.ToList().Count;
                FormDodajAlert addAlert = new FormDodajAlert(db);
                addAlert.ShowDialog();
                int alertCountAfter = this.db.Alert.ToList().Count;
                if (alertCountBefore >= alertCountAfter)
                {
                    MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
