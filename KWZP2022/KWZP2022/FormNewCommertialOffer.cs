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
        }
        private void comboBoxData()
        {
            this.db = new KWZPEntities();
            comboBoxEmployeeData();
            comboBoxNoOrderData();
            comboBoxGuaranteeData();
            comboBoxOfferStatusData();
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
            comboBoxNoOrder.DataSource = this.db.v_Zamowienia_niesprzedane.ToList();
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
            try
            {
                double selectedNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
                v_Kwota_za_materialy priceForMaterialsSelectedNoOrder = this.db.v_Kwota_za_materialy.Single(a => a.ID_zamowienie == selectedNoOrder);
                textBoxPriceForMaterials.Text = String.Format("{0:N2}", priceForMaterialsSelectedNoOrder.Cena_za_zamówienie);
                textBoxPriceForOrder.Text = String.Format("{0:N2}", priceForMaterialsSelectedNoOrder.Cena_za_zamówienie.Value * 2);
            }
            catch (Exception)
            {
                MessageBox.Show("Nie dodano materiałów do wytworzenia nowego produktu! Proszę dodać materiały do produktu lub wybrać inne zamówienie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxNoOrder.SelectedIndex = 0;
                textBoxPriceForMaterials.Clear();
                textBoxPriceForOrder.Clear();
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
                MessageBox.Show("Brakuje zamówień dla których można stworzyć ofertę!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddNewOffer_Click(object sender, EventArgs e)
        {
            if (comboBoxNoOrder.SelectedValue == null)
            {
                MessageBox.Show("Źle wprowadzono dane", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto EndLoop;
            }
            int selectedNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
            List<v_Potrzebne_materialy> necessaryMaterial = this.db.v_Potrzebne_materialy.Where(a => a.ID_zamowienie == selectedNoOrder).ToList();
            List<v_Aktualny_stan_magazyn> materialsInWarehouse = this.db.v_Aktualny_stan_magazyn.ToList();
            foreach (v_Potrzebne_materialy requiredMaterial in necessaryMaterial)
            {
                foreach (v_Aktualny_stan_magazyn materialInWarehouse in materialsInWarehouse)
                {
                    if (requiredMaterial.ID_material == materialInWarehouse.ID)
                    {
                        int materialAmount = (int)(materialInWarehouse.Aktualny_stan - requiredMaterial.Masa_materiału);
                        if (materialAmount < 0)
                        {
                            MessageBox.Show("Nie ma wystarczającej ilości materiałów w magazynie!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            missingMaterials();
                            goto EndLoop;
                        }
                    }
                }
            }
            if (dtpDateOfImplementation.Value.Date > (DateTime.Now.AddDays(14)))
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
                    comboBoxData();
                }
            }
            else
            {
                MessageBox.Show("Źle wprowadzono dane", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        EndLoop:;
            comboBoxNoOrder.SelectedIndex = -1;
        }
        private void comboBoxNoOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvMissingMaterials.Visible = false;
            lblDescription.Visible = false;
            btnAddAlert.Visible = false;
            comboBoxOfferStatusData();
            textBoxPricesData();
        }

        private void btnCheckAvailableMaterials_Click(object sender, EventArgs e)
        {
            if (comboBoxNoOrder.SelectedValue == null)
                goto EndLoop;
            int selectedNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
            List<v_Potrzebne_materialy> necessaryMaterial = this.db.v_Potrzebne_materialy.Where(a => a.ID_zamowienie == selectedNoOrder).ToList();
            List<v_Aktualny_stan_magazyn> materialsInWarehouse = this.db.v_Aktualny_stan_magazyn.ToList();
            foreach (v_Potrzebne_materialy requiredMaterial in necessaryMaterial)
            {
                foreach (v_Aktualny_stan_magazyn materialInWarehouse in materialsInWarehouse)
                {
                    if (requiredMaterial.ID_material == materialInWarehouse.ID)
                    {
                        int materialAmount = (int)(materialInWarehouse.Aktualny_stan - requiredMaterial.Masa_materiału);
                        if (materialAmount < 0)
                        {
                            MessageBox.Show("Nie ma wystarczającej ilości materiałów w magazynie!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            missingMaterials();
                            goto EndLoop;
                        }
                    }
                }
            }
            MessageBox.Show("W magazynie jest wystarczająco materiałów!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        EndLoop:;
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
