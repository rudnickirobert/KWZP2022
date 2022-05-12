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
    public partial class FormSalesDepartmentOffersForConsideration : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentOffersForConsideration(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            comboBoxOffersData();
            showData();
        }
        private void showData()
        {
            this.dgvOffersForConsideration.DataSource = this.db.v_Oferta_handlowa_do_rozpatrzenia.ToList();
            this.dgvOffersForConsideration.Columns[0].HeaderText = "Nr oferty";
            this.dgvOffersForConsideration.Columns[1].HeaderText = "Nr zamówienia";
            this.dgvOffersForConsideration.Columns[3].HeaderText = "Termin realizacji";
            this.dgvOffersForConsideration.Columns[4].HeaderText = "Opis gwarancji";
            this.dgvOffersForConsideration.Columns[5].HeaderText = "Status oferty handlowej";
            this.dgvOffersForConsideration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxOffersData()
        {
            List<IGrouping<int,Oferta_handlowa>> orderList = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 3).GroupBy(a => a.ID_zamowienie).ToList();
            comboBoxOffers.DataSource = orderList;
            comboBoxOffers.ValueMember = "Key";
            comboBoxOffers.DisplayMember = "Key";
        }

        private void comboBoxOffers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int chooseNoSale = int.Parse(comboBoxOffers.SelectedValue.ToString());
            this.dgvOffersForConsideration.DataSource = this.db.v_Oferta_handlowa_do_rozpatrzenia.Where(a => a.Nr_zamówienia == chooseNoSale).ToList();
            this.dgvOffersForConsideration.Columns[0].HeaderText = "Nr oferty";
            this.dgvOffersForConsideration.Columns[1].HeaderText = "Nr zamówienia";
            this.dgvOffersForConsideration.Columns[3].HeaderText = "Termin realizacji";
            this.dgvOffersForConsideration.Columns[4].HeaderText = "Opis gwarancji";
            this.dgvOffersForConsideration.Columns[5].HeaderText = "Status oferty handlowej";
            this.dgvOffersForConsideration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
        }
        private void dgvOffersForConsideration_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectOffer = int.Parse(this.dgvOffersForConsideration.CurrentRow.Cells[0].Value.ToString());
            DialogResult acceptedOffer = MessageBox.Show($"Czy chcesz zaackeptować ofertę nr: {selectOffer}?\nTak - Akceptacja oferty, pozostałe zostną odrzucone\nNie - Odrzucenie oferty","Pytanie",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if(acceptedOffer == DialogResult.Yes)
            {
                Oferta_handlowa selectedOffer = this.db.Oferta_handlowa.Single(a => a.ID_oferta_handlowa == selectOffer);
                selectedOffer.ID_status_oferta = 1;
                Umowa_sprzedaz newSaleArrangement = new Umowa_sprzedaz();
                newSaleArrangement.ID_oferta_handlowa = selectOffer;
                this.db.Umowa_sprzedaz.Add(newSaleArrangement);
                this.db.SaveChanges();
                List<IGrouping<int, Oferta_handlowa>> acceptedCommercialOfferList = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 1).GroupBy(a => a.ID_zamowienie).ToList();
                List<IGrouping<int, Oferta_handlowa>> commercialOfferForConsideration = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 3).GroupBy(a => a.ID_zamowienie).ToList();
                int offerFromDataGridView = int.Parse(this.dgvOffersForConsideration.CurrentRow.Cells[1].Value.ToString());
                int commercialOfferForConsiderationCount = commercialOfferForConsideration.Where(a => a.Key == offerFromDataGridView).GroupBy(a => a.Key).ToList().Count();
                int acceptedCommercialOfferListCount = acceptedCommercialOfferList.Where(a => a.Key == offerFromDataGridView).GroupBy(a => a.Key).ToList().Count();
                List<Oferta_handlowa> selectedCommercialOfferForConsiderationList = this.db.Oferta_handlowa.Where(a => a.ID_status_oferta == 3 && a.ID_zamowienie == offerFromDataGridView).ToList();
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
                newAlertForProductionDepartment.Tresc = $"Nowe zamówienie nr: {selectedOffer.ID_zamowienie}";
                newAlertForProductionDepartment.Czy_odczytano = false;
                this.db.Alert.Add(newAlertForProductionDepartment);
                this.db.SaveChanges();
                showData();
                comboBoxOffersData();
            }
            else if(acceptedOffer == DialogResult.No)
            {
                Oferta_handlowa selectedOffer = this.db.Oferta_handlowa.Single(a => a.ID_oferta_handlowa == selectOffer);
                selectedOffer.ID_status_oferta = 2;
                this.db.SaveChanges();
                showData();
                comboBoxOffersData();
            }
        }
    }
}
