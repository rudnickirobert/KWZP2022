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
    public partial class FormNewOreder : Form
    {
        KWZPEntities db;
        public FormNewOreder(KWZPEntities db)
        {
            this.db = db;
            InitializeComponent();
            
            showDataBox();
            showData();
        }
        private void showData()
        {
            this.dgvOrders.DataSource = this.db.v_Zamowienie.ToList();
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void showDataBox()
        {
            comboBoxOrderTypeData();
            comboBoxEmployeeData();
        }
        private void comboBoxOrderTypeData()
        {
            comboBoxOrderType.DataSource = this.db.Typ_zamowienie.ToList();
            comboBoxOrderType.ValueMember = "ID_typ_zamowienie";
            comboBoxOrderType.DisplayMember = "Rodzaj_zamowienie";
        }
        private void comboBoxEmployeeData()
        {
            comboBoxEmployee.DataSource = this.db.v_Pracownik_dzial.ToList();
            comboBoxEmployee.ValueMember = "ID_pracownik";
            comboBoxEmployee.DisplayMember = "Nazwisko";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentClientNewClient formSalesDepartmentClientNewClient = new FormSalesDepartmentClientNewClient(db);
            formSalesDepartmentClientNewClient.ShowDialog();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            ProduktForm produktForm = new ProduktForm(db);
            produktForm.ShowDialog();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showDataBox();
            showData();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            if(textBoxNoTelClient.Text.Length > 0)
            {
                int selectedTyp_ZamowienieInt = int.Parse(comboBoxOrderType.SelectedValue.ToString());
                Typ_zamowienie selectedTyp_Zamowienie = this.db.Typ_zamowienie.Single(a => a.ID_typ_zamowienie == selectedTyp_ZamowienieInt);
                Nr_telefon_klient selectedClient = this.db.Nr_telefon_klient.Single(a => a.Numer == textBoxNoTelClient.Text);
                int selectedEmpployeeInt = int.Parse(comboBoxEmployee.SelectedValue.ToString());
                Pracownik selectedEmpployee = this.db.Pracownik.Single(a => a.ID_pracownik == selectedEmpployeeInt);
                Zamowienie newZamowienie = new Zamowienie();
                newZamowienie.ID_klient = selectedClient.ID_klient;
                newZamowienie.ID_pracownik = selectedEmpployee.ID_pracownik;
                newZamowienie.Data_zamowienie = dtpDateOrder.Value.Date;
                newZamowienie.ID_typ_zamowienie = selectedTyp_Zamowienie.ID_typ_zamowienie;

                if(comboBoxOrderType.SelectedValue.ToString() == "1")
                {
                    MessageBox.Show("Wprowadź nowy produkt", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int counterProdutsBefore = this.db.Produkt.Count();
                    ProduktForm produktForm = new ProduktForm(db);
                    produktForm.ShowDialog();
                    int counterProdutsAfter = this.db.Produkt.Count();
                    if (counterProdutsAfter > counterProdutsBefore)
                    {
                        this.db.Zamowienie.Add(newZamowienie);
                        this.db.SaveChanges();
                        MessageBox.Show("Dodano zamówienie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormNewOrderDetails formNewOrderDetails = new FormNewOrderDetails(db, newZamowienie);
                        formNewOrderDetails.ShowDialog();
                        showData();
                    }
                    else
                    {
                        DialogResult resultNewProduct = MessageBox.Show("Nie wprowadzono nowego produktu. Czy chcesz wprowadzić nowy produkt?","Pytanie", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if(resultNewProduct == DialogResult.Yes)
                        {
                            int counterProdutsBeforeAgain = this.db.Produkt.Count();
                            ProduktForm produktFormAgain = new ProduktForm(db);
                            produktForm.ShowDialog();
                            int counterProdutsAfterAgain = this.db.Produkt.Count();
                            if (counterProdutsAfterAgain > counterProdutsBeforeAgain)
                            {
                                this.db.Zamowienie.Add(newZamowienie);
                                this.db.SaveChanges();
                                MessageBox.Show("Dodano zamówienie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormNewOrderDetails formNewOrderDetails = new FormNewOrderDetails(db, newZamowienie);
                                formNewOrderDetails.ShowDialog();
                                showData();
                            }
                            else
                            {
                                MessageBox.Show("Nie wprowadzono nowego produktu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (comboBoxOrderType.SelectedValue.ToString() == "2")
                {
                    this.db.Zamowienie.Add(newZamowienie);
                    this.db.SaveChanges();
                    MessageBox.Show("Dodano zamówienie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormNewOrderDetails formNewOrderDetails = new FormNewOrderDetails(db, newZamowienie);
                    formNewOrderDetails.ShowDialog();
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Błędnie wprowadzono dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Poprawnie zrealizowano zamówienie","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int orderNo = int.Parse(this.dgvOrders.CurrentRow.Cells[1].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć zamówienie numer: {orderNo}","Pytanie",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Zamowienie selectZamowienie = this.db.Zamowienie.Single(a => a.ID_zamowienie == orderNo);
                this.db.Zamowienie.Remove(selectZamowienie);
                List<Zamowienie_szczegol> selectZamowienie_Szczegol = this.db.Zamowienie_szczegol.Where(a => a.ID_zamowienie == orderNo).ToList();
                this.db.Zamowienie_szczegol.RemoveRange(selectZamowienie_Szczegol);
                this.db.SaveChanges();
                showData();
            }
        }

        private void btnNewOrderDetails_Click(object sender, EventArgs e)
        {
            int selectedOrderDetails = int.Parse(this.dgvOrders.CurrentRow.Cells[1].Value.ToString());
            Zamowienie selectedOrder = this.db.Zamowienie.Single(a => a.ID_zamowienie == selectedOrderDetails);
            FormNewOrderDetails formNewOrderDetails = new FormNewOrderDetails(db, selectedOrder);
            formNewOrderDetails.ShowDialog();
        }
    }
}
