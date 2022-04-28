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
        }
        private void btnSalesDetails_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentAddSalesDetails formSalesDepartmentAddSalesDetails = new FormSalesDepartmentAddSalesDetails(db);
            formSalesDepartmentAddSalesDetails.ShowDialog();
        }
    }
}
