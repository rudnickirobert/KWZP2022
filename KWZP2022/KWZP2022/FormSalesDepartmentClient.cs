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
            textBox1Name.Clear();
            textBox2Name.Clear();
            textBoxNIP.Clear();
            textBoxCity.Clear();
            textBoxNo1.Clear();
            textBoxNo2.Clear();
            textBoxPostCode.Clear();
            textBoxStreet.Clear();
        }
        private void messageBox()
        {
            MessageBox.Show("Wyszukiwany numer sprzedaży nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void msgCleanShowData()
        {
            messageBox();
            cleanTextBox();
            showData();
        }
        private void showData()
        {
            var datavClient = from v_klient in db.v_Klient
                              select new
                              {
                                  v_klient.ID,
                                  v_klient.Nazwisko,
                                  v_klient.Imię,
                                  v_klient.NIP,
                                  v_klient.Miejscowość,
                                  v_klient.Ulica,
                                  v_klient.Numer_budynku,
                                  v_klient.Numer_lokalu,
                                  v_klient.Kod_pocztowy
                              };
            this.dgvClient.DataSource = datavClient.ToList();
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
            if (textBox2Name.Text.Length > 0)
                choose = "Surname";
            if (textBox1Name.Text.Length > 0)
                choose = "Name";
            if (textBoxNIP.Text.Length > 0)
                choose = "NIP";
            if (textBoxCity.Text.Length > 0)
                choose = "City";
            if (textBoxNo1.Text.Length > 0)
                choose = "NoBuilding";
            if (textBoxNo2.Text.Length > 0)
                choose = "NoApartment";
            if (textBoxPostCode.Text.Length > 0)
                choose = "PostCode";
            if (textBoxStreet.Text.Length > 0)
                choose = "Street";

            switch (choose)
            {
                case "Surname":
                    enterSurname();
                    break;
                case "Name":
                    enterName();
                    break;
                case "NIP":
                    enterNip();
                    break;
                case "City":
                    enterCity();
                    break;
                case "NoBuilding":
                    enterNoBuilding();
                    break;
                case "NoApartment":
                    enterNoApartment();
                    break;
                case "PostCode":
                    enterPostCode();
                    break;
                case "Street":
                    enterStreet();
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
            FormSalesDepartmentClientModifyClient formSalesDepartmentClientModifyClient = new FormSalesDepartmentClientModifyClient(db);
            formSalesDepartmentClientModifyClient.ShowDialog();
        }



        private void enterSurname()
        {
            System.Linq.IQueryable vClientSurname = db.v_Klient.Where(a => a.Nazwisko == textBox2Name.Text);
            int vClientSurnameInt = vClientSurname.Cast<v_Klient>().Count();
            if (vClientSurnameInt > 0)
            {
                this.dgvClient.DataSource = vClientSurname.Cast<v_Klient>().ToList();
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterName()
        {
            System.Linq.IQueryable vClientName = db.v_Klient.Where(a => a.Imię == textBox1Name.Text);
            int vClientNameInt = vClientName.Cast<v_Klient>().Count();
            if (vClientNameInt > 0)
            {
                this.dgvClient.DataSource = vClientName.Cast<v_Klient>().ToList();
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterNip()
        {
            System.Linq.IQueryable vClientNip = db.v_Klient.Where(a => a.NIP == textBoxNIP.Text);
            int vClientNipInt = vClientNip.Cast<v_Klient>().Count();
            if (vClientNipInt > 0)
            {
                this.dgvClient.DataSource = vClientNip.Cast<v_Klient>().ToList();
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterCity()
        {
            string dataCity = textBoxCity.Text;
            System.Linq.IQueryable vClientCity = db.v_Klient.Where(a => a.Miejscowość == dataCity);
            int vClientCityInt = vClientCity.Cast<v_Klient>().Count();
            if (vClientCityInt > 0)
            {
                this.dgvClient.DataSource = vClientCity.Cast<v_Klient>().ToList();
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterNoBuilding()
        {
            try
            {
                string noBuilding = textBoxNo1.Text;
                int noBuildingInt = int.Parse(noBuilding);
                System.Linq.IQueryable vClientNoBuilding = db.v_Klient.Where(a => a.Numer_budynku == noBuildingInt);
                int vClientNoBuildingInt = vClientNoBuilding.Cast<v_Klient>().Where(a => a.Numer_budynku > 0).Count();
                if (vClientNoBuildingInt > 0)
                {
                    this.dgvClient.DataSource = vClientNoBuilding.Cast<v_Klient>().ToList();
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData();
                }
            }
            catch (Exception)
            {
                msgCleanShowData();
            }
        }
        private void enterNoApartment()
        {
            try
            {
                string noApartment = textBoxNo2.Text;
                int noApartmentInt = int.Parse(noApartment);
                List<v_Klient> vClientNoApartment = db.v_Klient.Where(a => a.Numer_lokalu == noApartmentInt).ToList();
                int vClientNoApartmentInt = vClientNoApartment.Cast<v_Klient>().Where(a => a.Numer_lokalu > 0).Count();
                if (vClientNoApartmentInt > 0)
                {
                    this.dgvClient.DataSource = vClientNoApartment.Cast<v_Klient>().ToList();
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData();
                }
            }
            catch (Exception)
            {
                msgCleanShowData();
            }
        }
        private void enterPostCode()
        {
            string postCode = textBoxPostCode.Text;
            System.Linq.IQueryable vClientPostCode = db.v_Klient.Where(a => a.Kod_pocztowy == postCode);
            int vClientPostCodeInt = vClientPostCode.Cast<v_Klient>().Count();
            if (vClientPostCodeInt > 0)
            {
                this.dgvClient.DataSource = vClientPostCode.Cast<v_Klient>().ToList();
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterStreet()
        {
            string street = textBoxStreet.Text;
            System.Linq.IQueryable vClientStreet = db.v_Klient.Where(a => a.Ulica == street);
            int vClientStreetInt = vClientStreet.Cast<v_Klient>().Count();
            if (vClientStreetInt > 0)
            {
                this.dgvClient.DataSource = vClientStreet.Cast<v_Klient>().ToList();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showData();
        }
    }
}