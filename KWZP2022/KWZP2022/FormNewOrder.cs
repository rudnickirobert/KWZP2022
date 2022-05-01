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
    public partial class FormNewOrder : Form
    {
        KWZPEntities db;
        public FormNewOrder(KWZPEntities db)
        {
            this.db = db;
            InitializeComponent();

            showDataBox();
            showData();
        }
        private void showData()
        {
            this.db = new KWZPEntities();
            this.dgvOrders.DataSource = this.db.v_Zamowienie.OrderBy(a => a.Nr_zamówienia).ToList();
            this.dgvOrders.Columns[0].HeaderText = "Data przyjęcia zamówienia";
            this.dgvOrders.Columns[1].HeaderText = "Nr zamówienia";
            this.dgvOrders.Columns[2].HeaderText = "Nazwisko klienta";
            this.dgvOrders.Columns[3].HeaderText = "Imię klienta";
            this.dgvOrders.Columns[4].HeaderText = "Typ zamówienia";
            this.dgvOrders.Columns[5].HeaderText = "Nazwisko pracownika";
            this.dgvOrders.Columns[6].HeaderText = "Imię pracownika";
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            FormProdukt produktForm = new FormProdukt(db);
            produktForm.ShowDialog();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showDataBox();
            showData();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            if (textBoxNoTelClient.Text.Length > 0)
            {
                List<Nr_telefon_klient> selectClientByNoTel = this.db.Nr_telefon_klient.Where(a => (a.Numer == textBoxNoTelClient.Text && a.Data_do == null)).ToList();
                if (selectClientByNoTel.Count() > 0)
                {
                    int selectedTypZamowienieInt = int.Parse(comboBoxOrderType.SelectedValue.ToString());
                    Typ_zamowienie selectedTypZamowienie = this.db.Typ_zamowienie.Single(a => a.ID_typ_zamowienie == selectedTypZamowienieInt);
                    Nr_telefon_klient selectedClient = this.db.Nr_telefon_klient.SingleOrDefault(a => a.Numer == textBoxNoTelClient.Text);
                    if (selectedClient != null)
                    {
                        int selectedEmployeeInt = int.Parse(comboBoxEmployee.SelectedValue.ToString());
                        Pracownik selectedEmpployee = this.db.Pracownik.Single(a => a.ID_pracownik == selectedEmployeeInt);
                        Zamowienie newZamowienie = new Zamowienie();
                        newZamowienie.ID_klient = selectedClient.ID_klient;
                        newZamowienie.ID_pracownik = selectedEmpployee.ID_pracownik;
                        newZamowienie.Data_zamowienie = dtpDateOrder.Value.Date;
                        newZamowienie.ID_typ_zamowienie = selectedTypZamowienie.ID_typ_zamowienie;

                        if (comboBoxOrderType.SelectedValue.ToString() == "1")
                        {
                            MessageBox.Show("Wprowadź nowy produkt", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int counterProdutsBefore = this.db.Produkt.Count();
                            FormProdukt produktForm = new FormProdukt(db);
                            produktForm.ShowDialog();
                            int counterProdutsAfter = this.db.Produkt.Count();
                            if (counterProdutsAfter > counterProdutsBefore)
                            {
                                this.db.Zamowienie.Add(newZamowienie);
                                this.db.SaveChanges();
                                MessageBox.Show("Dodano zamówienie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                int counterOrderDetailsBefore = this.db.Zamowienie_szczegol.Count();
                                FormNewOrderDetails formNewOrderDetails = new FormNewOrderDetails(db, newZamowienie);
                                formNewOrderDetails.ShowDialog();
                                int counterOrderDetailsAfter = this.db.Zamowienie_szczegol.Count();
                                if (counterOrderDetailsAfter > counterOrderDetailsBefore)
                                {
                                    showData();
                                    MessageBox.Show("Poprawnie zrealizowano zamówienie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Wprowadź szczegóły zamówienia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                DialogResult resultNewProduct = MessageBox.Show("Nie wprowadzono nowego produktu. Czy chcesz wprowadzić nowy produkt?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (resultNewProduct == DialogResult.Yes)
                                {
                                    int counterProdutsBeforeAgain = this.db.Produkt.Count();
                                    FormProdukt produktFormAgain = new FormProdukt(db);
                                    produktForm.ShowDialog();
                                    int counterProdutsAfterAgain = this.db.Produkt.Count();
                                    if (counterProdutsAfterAgain > counterProdutsBeforeAgain)
                                    {
                                        this.db.Zamowienie.Add(newZamowienie);
                                        this.db.SaveChanges();
                                        MessageBox.Show("Dodano zamówienie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        int counterOrderDetailsBefore = this.db.Zamowienie_szczegol.Count();
                                        FormNewOrderDetails formNewOrderDetails = new FormNewOrderDetails(db, newZamowienie);
                                        formNewOrderDetails.ShowDialog();
                                        int counterOrderDetailsAfter = this.db.Zamowienie_szczegol.Count();
                                        if (counterOrderDetailsAfter > counterOrderDetailsBefore)
                                        {
                                            MessageBox.Show("Poprawnie zrealizowano zamówienie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            showData();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Wprowadź szczegóły zamówienia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie wprowadzono nowego produktu. Zamówienie zostało anulowane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                if(resultNewProduct == DialogResult.No)
                                {
                                    MessageBox.Show("Anulowano zamówienie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else if (comboBoxOrderType.SelectedValue.ToString() == "2")
                        {
                            this.db.Zamowienie.Add(newZamowienie);
                            this.db.SaveChanges();
                            int counterOrderDetailsBeforeAgain = this.db.Zamowienie_szczegol.Count();
                            MessageBox.Show("Dodano zamówienie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormNewOrderDetails formNewOrderDetails = new FormNewOrderDetails(db, newZamowienie);
                            formNewOrderDetails.ShowDialog();
                            int counterOrderDetailsAfterAgain = this.db.Zamowienie_szczegol.Count();
                            if (counterOrderDetailsAfterAgain > counterOrderDetailsBeforeAgain)
                            {
                                MessageBox.Show("Poprawnie zrealizowano zamówienie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                showData();
                            }
                            else
                            {
                                MessageBox.Show("Wprowadź szczegóły zamówienia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wprowadź dane nowego klienta do systemu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Wprowadzony numer: {textBoxNoTelClient.Text} jest nieaktualny!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Błędnie wprowadzono dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int orderNo = int.Parse(this.dgvOrders.CurrentRow.Cells[1].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć zamówienie numer: {orderNo}", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Zamowienie selectZamowienie = this.db.Zamowienie.Single(a => a.ID_zamowienie == orderNo);
                    this.db.Zamowienie.Remove(selectZamowienie);
                    List<Zamowienie_szczegol> selectZamowienieSzczegol = this.db.Zamowienie_szczegol.Where(a => a.ID_zamowienie == orderNo).ToList();
                    this.db.Zamowienie_szczegol.RemoveRange(selectZamowienieSzczegol);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć zamówienia, które zostało sprzedane!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void btnNewOrderDetails_Click(object sender, EventArgs e)
        {
            int selectedOrderDetails = int.Parse(this.dgvOrders.CurrentRow.Cells[1].Value.ToString());
            Zamowienie selectedOrder = this.db.Zamowienie.Single(a => a.ID_zamowienie == selectedOrderDetails);
            FormNewOrderDetails formNewOrderDetails = new FormNewOrderDetails(db, selectedOrder);
            formNewOrderDetails.ShowDialog();
        }
        private void btnCommercialOffer_Click(object sender, EventArgs e)
        {
            DialogResult commertialOfferResult = MessageBox.Show("Czy na pewno chcesz przejść do oferty handlowej?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (commertialOfferResult == DialogResult.Yes)
            {
                int ordersAmount = this.db.Zamowienie.GroupBy(a => a.ID_zamowienie).Count();
                int ordersDetailsAmount = this.db.Zamowienie_szczegol.GroupBy(a => a.ID_zamowienie).Count();
                if (ordersAmount == ordersDetailsAmount)
                {
                    FormNewCommertialOffer formNewCommertialOffer = new FormNewCommertialOffer(db);
                    formNewCommertialOffer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nie wprowadzono danych","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void FormNewOrder_Activated(object sender, EventArgs e)
        {
            showData();
        }
    }
}
