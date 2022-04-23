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
        private void comboBoxOfferStatusData()
        {
            int selectedNoOrder = int.Parse(comboBoxNoOrder.SelectedValue.ToString());
            Zamowienie orderNotAccepted = this.db.Zamowienie.Single(a => a.ID_zamowienie == selectedNoOrder);
            if(orderNotAccepted.ID_typ_zamowienie == 2)
            {
                comboBoxOfferStatus.DataSource = this.db.Status_oferta.Where(a => a.ID_status_oferta == 1).ToList();
                comboBoxOfferStatus.ValueMember = "ID_status_oferta";
                comboBoxOfferStatus.DisplayMember = "Nazwa_status_oferta";
            }
            else
            {
                comboBoxOfferStatus.DataSource = this.db.Status_oferta.Where(a => a.ID_status_oferta == 3 || a.ID_status_oferta == 1).ToList();
                comboBoxOfferStatus.ValueMember = "ID_status_oferta";
                comboBoxOfferStatus.DisplayMember = "Nazwa_status_oferta";
            }
            
        }
        private void btnAddNewOffer_Click(object sender, EventArgs e)
        {
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
            }
            else
            {
                MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void comboBoxNoOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxOfferStatusData();
        }
    }
}
