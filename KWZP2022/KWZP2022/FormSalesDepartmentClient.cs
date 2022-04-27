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
    public partial class FormSalesDepartmentClient : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentClient(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            cleanTextBox();
        }
        private void cleanTextBox()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxNIP.Clear();
            textBoxCity.Clear();
            textBoxBuildingNumber.Clear();
            textBoxApartmentNumber.Clear();
            textBoxPostCode.Clear();
            textBoxStreet.Clear();
        }
        private void messageBox(string searchItem)
        {
            MessageBox.Show($"{searchItem} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void msgCleanShowData(string searchItem)
        {
            messageBox(searchItem);
            cleanTextBox();
            showData();
        }
        private void showData()
        {
            this.db = new KWZPEntities();
            this.dgvClient.DataSource = this.db.v_Klient.ToList();
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            cleanTextBox();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (textBoxSurname.Text.Length > 0)
                choose = "Surname";
            if (textBoxName.Text.Length > 0)
                choose = "Name";
            if (textBoxNIP.Text.Length > 0)
                choose = "NIP";
            if (textBoxCity.Text.Length > 0)
                choose = "City";
            if (textBoxBuildingNumber.Text.Length > 0)
                choose = "NoBuilding";
            if (textBoxApartmentNumber.Text.Length > 0)
                choose = "NoApartment";
            if (textBoxPostCode.Text.Length > 0)
                choose = "PostCode";
            if (textBoxStreet.Text.Length > 0)
                choose = "Street";

            switch (choose)
            {
                case "Surname":
                    searchSurname();
                    break;
                case "Name":
                    searchName();
                    break;
                case "NIP":
                    searchNip();
                    break;
                case "City":
                    searchCity();
                    break;
                case "NoBuilding":
                    searchNoBuilding();
                    break;
                case "NoApartment":
                    searchNoApartment();
                    break;
                case "PostCode":
                    searchPostCode();
                    break;
                case "Street":
                    searchStreet();
                    break;
                default:
                    wrongData();
                    break;
            }
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentClientRemoveClient formSalesDepartmentClientRemoveClient = new FormSalesDepartmentClientRemoveClient(db);
            formSalesDepartmentClientRemoveClient.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int clientFromDgv = int.Parse(this.dgvClient.CurrentRow.Cells[0].Value.ToString());
            Klient selectedClientForModify = this.db.Klient.Single(a => a.ID_klient == clientFromDgv);
            FormSalesDepartmentClientModifyClient formSalesDepartmentClientModifyClient = new FormSalesDepartmentClientModifyClient(db, selectedClientForModify);
            formSalesDepartmentClientModifyClient.ShowDialog();
        }



        private void searchSurname()
        {
            List<v_Klient> searchClientSurnameList = db.v_Klient.Where(a => a.Nazwisko == textBoxSurname.Text).ToList();
            if (searchClientSurnameList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientSurnameList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwane nazwisko: {textBoxSurname.Text}");
            }
        }
        private void searchName()
        {
            List<v_Klient> searchClientNameList = db.v_Klient.Where(a => a.Imię == textBoxName.Text).ToList();
            if (searchClientNameList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientNameList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwane imię: {textBoxName.Text}");
            }
        }
        private void searchNip()
        {
            List<v_Klient> searchClientNIPList = db.v_Klient.Where(a => a.NIP == textBoxNIP.Text).ToList();
            if (searchClientNIPList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientNIPList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwany NIP: {textBoxNIP.Text}");
            }
        }
        private void searchCity()
        {
            List<v_Klient> searchClientCityList = db.v_Klient.Where(a => a.Miejscowość == textBoxCity.Text).ToList();
            if (searchClientCityList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientCityList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwana miejscowość: {textBoxCity.Text}");
            }
        }
        private void searchNoBuilding()
        {
            try
            {
                int noBuildingToInt = int.Parse(textBoxBuildingNumber.Text);
                List<v_Klient> searchClientNoBuildingList = db.v_Klient.Where(a => a.Numer_budynku == noBuildingToInt).ToList();
                if (searchClientNoBuildingList.Count() > 0)
                {
                    this.dgvClient.DataSource = searchClientNoBuildingList;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany nr budynku: {textBoxBuildingNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru budynku!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void searchNoApartment()
        {
            try
            {
                int noApartmentToInt = int.Parse(textBoxApartmentNumber.Text);
                List<v_Klient> searchClientNoApartmentList = db.v_Klient.Where(a => a.Numer_lokalu == noApartmentToInt).ToList();
                if (searchClientNoApartmentList.Count() > 0)
                {
                    this.dgvClient.DataSource = searchClientNoApartmentList;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany nr lokalu: {textBoxApartmentNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru lokalu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchPostCode()
        {
            List<v_Klient> searchClientPostCodeList = db.v_Klient.Where(a => a.Kod_pocztowy == textBoxPostCode.Text).ToList();
            if (searchClientPostCodeList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientPostCodeList;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwany kod pocztowy: {textBoxPostCode.Text}");
            }
        }
        private void searchStreet()
        {
            List < v_Klient> searchClientStreet = db.v_Klient.Where(a => a.Ulica == textBoxStreet.Text).ToList();
            if (searchClientStreet.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientStreet;
            }
            else
            {
                msgCleanShowData($"Wyszukiwana ulica: {textBoxStreet.Text}");
            }
        }
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showData();
        }

        private void FormSalesDepartmentClient_Activated(object sender, EventArgs e)
        {
            showData();
        }
    }
}