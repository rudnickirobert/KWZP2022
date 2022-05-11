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
    public partial class FormSalesDepartmentAddSales : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentAddSales(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            textBoxNrSaleData();
            comboBoxPaymentMethodData();
            comboBoxSaleArrangementData();
            showData();
            comboBoxSaleArrangement.SelectedIndex = -1;
        }
        private void showData()
        {
            this.db = new KWZPEntities();
            this.dgvSales.DataSource = this.db.v_Sprzedane_zamowienia_form.ToList();
            this.dgvSales.Columns[0].HeaderText = "Nr umowy";
            this.dgvSales.Columns[1].HeaderText = "Nr sprzedaży";
            this.dgvSales.Columns[2].HeaderText = "Data sprzedaży";
            this.dgvSales.Columns[3].HeaderText = "Data płatności";
            this.dgvSales.Columns[4].HeaderText = "Forma płatności";
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void textBoxNrSaleData()
        {
            textBoxNrSale.Text = (this.db.Sprzedaz.Count() + 1).ToString();
        }
        private void dtpData()
        {
            int selectedSaleArrangementFromComboBox = int.Parse(comboBoxSaleArrangement.SelectedValue.ToString());
            Umowa_sprzedaz selectedSaleArrangement = this.db.Umowa_sprzedaz.Single(a => a.ID_umowa_sprzedaz == selectedSaleArrangementFromComboBox);
            Oferta_handlowa selectedComertialOffer = this.db.Oferta_handlowa.Single(a => (a.ID_oferta_handlowa == selectedSaleArrangement.ID_oferta_handlowa && a.ID_status_oferta == 1));
            dtpSaleBegin.Value = selectedComertialOffer.Termin_realizacja.Date;
            dtpSaleEnd.Value = selectedComertialOffer.Termin_realizacja.Date;
            dtpDateOfPayment.Value = selectedComertialOffer.Termin_realizacja.Date;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxPaymentMethodData()
        {
            comboBoxPaymentMethod.DataSource = this.db.Forma_platnosc.ToList();
            comboBoxPaymentMethod.ValueMember = "ID_forma_platnosc";
            comboBoxPaymentMethod.DisplayMember = "Forma_platnosc1";
        }
        private void comboBoxSaleArrangementData()
        {
            comboBoxSaleArrangement.DataSource = this.db.v_Umowa_do_sprzedaz.ToList();
            comboBoxSaleArrangement.ValueMember = "Nr_umowy_sprzedaży";
            comboBoxSaleArrangement.DisplayMember = "Nr_umowy_sprzedaży";
        }

        private void btnAddNewSale_Click(object sender, EventArgs e)
        {
            if (dtpSaleBegin.Value.Date > dtpSaleEnd.Value.Date || dtpDateOfPayment.Value.Date < dtpSaleEnd.Value.Date)
            {
                MessageBox.Show("Wprowadzone daty są niepoprawnie wprowadzone!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Sprzedaz newSale = new Sprzedaz();
                    newSale.Nr_sprzedaz = int.Parse(textBoxNrSale.Text);
                    newSale.Data_sprzedaz_poczatek = dtpSaleBegin.Value.Date;
                    newSale.Data_sprzedaz_koniec = dtpSaleEnd.Value.Date;
                    newSale.Termin_zaplata = dtpDateOfPayment.Value.Date;
                    newSale.ID_forma_platnosc = int.Parse(comboBoxPaymentMethod.SelectedValue.ToString());
                    if (comboBoxSaleArrangement.SelectedValue != null)
                    {
                        newSale.ID_umowa_sprzedaz = int.Parse(comboBoxSaleArrangement.SelectedValue.ToString());
                        this.db.Sprzedaz.Add(newSale);
                        this.db.SaveChanges();
                        MessageBox.Show("Dodano nową sprzedaż!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                    }
                    else
                    {
                        MessageBox.Show("Nie podano nr umowy sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                comboBoxSaleArrangementData();
                comboBoxSaleArrangement.SelectedIndex = -1;
                textBoxNrSaleData();
            }
        }
        private void btnSalesDetails_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentAddSalesDetails formSalesDepartmentAddSalesDetails = new FormSalesDepartmentAddSalesDetails(db);
            formSalesDepartmentAddSalesDetails.ShowDialog();
        }

        private void comboBoxSaleArrangement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtpData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int numberAgreement = int.Parse(this.dgvSales.CurrentRow.Cells[0].Value.ToString());
            Sprzedaz selectedSale = this.db.Sprzedaz.Single(a => a.ID_umowa_sprzedaz == numberAgreement);
            string selectedNoSale = selectedSale.Nr_sprzedaz.ToString();
            if (textBoxNrSale.Text != selectedNoSale)
            {
                MessageBox.Show("Dane nie są zgodne! Kliknij dwa razy na sprzedaż którą chcesz zmodyfikować.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dtpSaleBegin.Value.Date > dtpSaleEnd.Value.Date || dtpDateOfPayment.Value.Date < dtpSaleEnd.Value.Date)
                {
                    MessageBox.Show("Wprowadzone daty są niepoprawnie wprowadzone!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int checkSaleDetails = this.db.Szczegoly_sprzedaz.Where(a => a.ID_sprzedaz == numberAgreement).ToList().Count();
                    if (checkSaleDetails > 0)
                    {
                        DialogResult changeExistingSale = MessageBox.Show("Zmieniasz dane sprzedaży, która posiada szczegóły sprzedaży. Czy na pewno chcesz zmienić dane?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (changeExistingSale == DialogResult.Yes)
                        {
                            selectedSale.Nr_sprzedaz = int.Parse(textBoxNrSale.Text);
                            selectedSale.Data_sprzedaz_poczatek = dtpSaleBegin.Value.Date;
                            selectedSale.Data_sprzedaz_koniec = dtpSaleEnd.Value.Date;
                            selectedSale.Termin_zaplata = dtpDateOfPayment.Value.Date;
                            selectedSale.ID_forma_platnosc = int.Parse(comboBoxPaymentMethod.SelectedValue.ToString());
                            this.db.SaveChanges();
                            MessageBox.Show("Zmodyfikowano sprzedaż!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showData();
                        }
                    }
                    else
                    {
                        DialogResult changeSale = MessageBox.Show("Czy na pewno chcesz zmienić dane sprzedaży?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (changeSale == DialogResult.Yes)
                        {
                            selectedSale.Nr_sprzedaz = int.Parse(textBoxNrSale.Text);
                            selectedSale.Data_sprzedaz_poczatek = dtpSaleBegin.Value.Date;
                            selectedSale.Data_sprzedaz_koniec = dtpSaleEnd.Value.Date;
                            selectedSale.Termin_zaplata = dtpDateOfPayment.Value.Date;
                            selectedSale.ID_forma_platnosc = int.Parse(comboBoxPaymentMethod.SelectedValue.ToString());
                            this.db.SaveChanges();
                            MessageBox.Show("Zmodyfikowano sprzedaż!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showData();
                        }
                    }
                }
            }
        }

        private void dgvSales_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedNumberSale = int.Parse(this.dgvSales.CurrentRow.Cells[1].Value.ToString());
            Sprzedaz selectedSale = this.db.Sprzedaz.Single(a => a.ID_umowa_sprzedaz == selectedNumberSale);
            textBoxNrSale.Text = selectedSale.ID_sprzedaz.ToString();
            dtpSaleBegin.Value = selectedSale.Data_sprzedaz_poczatek.Date;
            dtpSaleEnd.Value = selectedSale.Data_sprzedaz_koniec.Date;
            dtpDateOfPayment.Value = selectedSale.Termin_zaplata.Date;
            comboBoxPaymentMethod.Text = selectedSale.Forma_platnosc.ToString();
        }
    }
}
