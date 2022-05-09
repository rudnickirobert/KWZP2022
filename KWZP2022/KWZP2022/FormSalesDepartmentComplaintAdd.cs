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
    public partial class FormSalesDepartmentComplaintAdd : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentComplaintAdd(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            comboBoxNoSaleData();
            comboBoxNoProductData();
            comboBoxNoEmployeeData();
        }
        private void showData()
        {
            this.dgvComplaint.DataSource = this.db.Reklamacja.ToList();
            this.dgvComplaint.Columns["Pracownik"].Visible = false;
            this.dgvComplaint.Columns["Zwrot"].Visible = false;
            this.dgvComplaint.Columns["Sprzedaz"].Visible = false;
            this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void clearData()
        {
            textBoxAmount.Clear();
            textBoxDesciption.Clear();
            cbAccept.Checked = false;
            cbDateComplaint.Checked = false;
            dtpDateComplaint.Value = DateTime.Now;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void msgError()
        {
            MessageBox.Show("Błędnie wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void comboBoxNoSaleData()
        {
            comboBoxNoSale.DataSource = this.db.Sprzedaz.ToList();
            comboBoxNoSale.ValueMember = "ID_sprzedaz";
            comboBoxNoSale.DisplayMember = "ID_sprzedaz";
        }

        private void comboBoxNoProductData()
        {
            int selectNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
            comboBoxNoProduct.DataSource = this.db.v_Sprzedany_produkt.Where(a => a.ID_sprzedaz == selectNoSale).ToList();
            comboBoxNoProduct.ValueMember = "ID_produkt";
            comboBoxNoProduct.DisplayMember = "Nazwa_produkt";
        }
        private void comboBoxNoEmployeeData()
        {
            comboBoxNoEmployee.DataSource = this.db.v_Pracownik_dzial.ToList();
            comboBoxNoEmployee.ValueMember = "ID_pracownik";
            comboBoxNoEmployee.DisplayMember = "Nazwisko";
        }
        private void comboBoxNoSale_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxNoProductData();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (comboBoxNoEmployee.SelectedValue != null && comboBoxNoProduct.SelectedValue != null && comboBoxNoSale.SelectedValue != null && textBoxAmount.Text.Length > 0 && cbDateComplaint.Checked == true && textBoxDesciption.Text.Length > 0)
            {
                int selectNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                int selectNoProduct = int.Parse(comboBoxNoProduct.SelectedValue.ToString());
                Szczegoly_sprzedaz productCount = this.db.Szczegoly_sprzedaz.Single(a => a.ID_sprzedaz == selectNoSale && a.ID_produkt == selectNoProduct);
                int selectNoSaleReturn = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                int selectNoProductReturn = int.Parse(comboBoxNoProduct.SelectedValue.ToString());
                int productReturnCount = this.db.v_Reklamacja.Count(a => a.Numer_sprzedaży == selectNoSaleReturn && a.ID_produkt == selectNoProductReturn && a.Akceptacja == true);
                if (productReturnCount != 0)
                {
                    try
                    {
                        v_Reklamacja productReturnSingle = this.db.v_Reklamacja.Single(a => a.Numer_sprzedaży == selectNoSale && a.ID_produkt == selectNoProduct);
                        int amountTotal = productCount.Ilosc - productReturnSingle.Ilość - int.Parse(textBoxAmount.Text);
                        if (amountTotal >= 0)
                        {
                            MessageBox.Show($"Dodano nową reklamacje!\nKlientowi pozostało jeszcze: {amountTotal} produktów", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reklamacja newComplaint = new Reklamacja();
                            newComplaint.ID_sprzedaz = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                            newComplaint.ID_pracownik = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                            newComplaint.Opis_reklamacja = textBoxDesciption.Text;
                            newComplaint.Data_reklamacja = dtpDateComplaint.Value.Date;
                            this.db.Reklamacja.Add(newComplaint);
                            this.db.SaveChanges();
                            Zwrot newReturn = new Zwrot();
                            newReturn.ID_reklamacja = this.db.Reklamacja.Count();
                            newReturn.ID_produkt = int.Parse(comboBoxNoProduct.SelectedValue.ToString());
                            newReturn.Ilosc = int.Parse(textBoxAmount.Text);
                            newReturn.Akceptacja = cbAccept.Checked;
                            this.db.Zwrot.Add(newReturn);
                            this.db.SaveChanges();
                            clearData();
                            showData();
                        }
                        else
                        {
                            MessageBox.Show("Zwrócono więcej produktów niż zostało kupionych", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie można oddać na reklamacje!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    try
                    {
                        int amountTotal = productCount.Ilosc - int.Parse(textBoxAmount.Text);
                        if (amountTotal >= 0)
                        {
                            MessageBox.Show($"Dodano nową reklamacje!\nKlientowi pozostało jeszcze: {amountTotal} produktów", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reklamacja newComplaint = new Reklamacja();
                            newComplaint.ID_sprzedaz = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                            newComplaint.ID_pracownik = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                            newComplaint.Opis_reklamacja = textBoxDesciption.Text;
                            newComplaint.Data_reklamacja = dtpDateComplaint.Value.Date;
                            this.db.Reklamacja.Add(newComplaint);
                            this.db.SaveChanges();
                            Zwrot newReturn = new Zwrot();
                            newReturn.ID_reklamacja = this.db.Reklamacja.Count();
                            newReturn.ID_produkt = int.Parse(comboBoxNoProduct.SelectedValue.ToString());
                            newReturn.Ilosc = int.Parse(textBoxAmount.Text);
                            newReturn.Akceptacja = cbAccept.Checked;
                            this.db.Zwrot.Add(newReturn);
                            this.db.SaveChanges();
                            clearData();
                            showData();
                        }
                        else
                        {
                            MessageBox.Show("Zwrócono więcej produktów niż zostało kupionych", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie można oddać na reklamacje!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                msgError();
            }
        }

        private void btnCheckComplaint_Click(object sender, EventArgs e)
        {
            if (comboBoxNoProduct.SelectedValue != null && comboBoxNoSale.SelectedValue != null && textBoxAmount.Text.Length > 0)
            {
                int selectNoSale = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                int selectNoProduct = int.Parse(comboBoxNoProduct.SelectedValue.ToString());
                Szczegoly_sprzedaz productCount = this.db.Szczegoly_sprzedaz.Single(a => a.ID_sprzedaz == selectNoSale && a.ID_produkt == selectNoProduct);
                int selectNoSaleReturn = int.Parse(comboBoxNoSale.SelectedValue.ToString());
                int selectNoProductReturn = int.Parse(comboBoxNoProduct.SelectedValue.ToString());
                int productReturnCount = this.db.v_Reklamacja.Count(a => a.Numer_sprzedaży == selectNoSaleReturn && a.ID_produkt == selectNoProductReturn && a.Akceptacja == true);
                if (productReturnCount != 0)
                {
                    try
                    {
                        v_Reklamacja productReturnSingle = this.db.v_Reklamacja.Single(a => a.Numer_sprzedaży == selectNoSale && a.ID_produkt == selectNoProduct);
                        int amountTotal = productCount.Ilosc - productReturnSingle.Ilość - int.Parse(textBoxAmount.Text);
                        if (amountTotal >= 0)
                        {
                            MessageBox.Show("Można przyjąć reklamację", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Zwrócono więcej produktów niż zostało kupionych", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie można oddać na reklamacje!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    int amountTotal = productCount.Ilosc - int.Parse(textBoxAmount.Text);
                    if (amountTotal >= 0)
                    {
                        MessageBox.Show("Można przyjąć reklamację", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Zwrócono więcej produktów niż zostało kupionych", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                msgError();
            }
        }
    }
}
