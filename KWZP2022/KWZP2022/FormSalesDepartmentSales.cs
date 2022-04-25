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
    public partial class FormSalesDepartmentSales : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentSales(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
        }

        private void showData()
        {
            var dataSales = from salesView in this.db.v_Sprzedaz
                            select new
                            {
                                salesView.Numer_sprzedaży,
                                salesView.Nazwisko_klienta,
                                salesView.Imię_klienta,
                                salesView.NIP,
                                salesView.Data_początku_sprzedaży,
                                salesView.Data_końca_sprzedaży,
                                salesView.Umowa,
                                salesView.Koszt
                            };
            this.dgvSales.DataSource = dataSales.ToList();
            this.dgvSales.Columns[0].HeaderText = "Nr sprzedaży";
            this.dgvSales.Columns[1].HeaderText = "Nazwisko";
            this.dgvSales.Columns[2].HeaderText = "Imię";
            this.dgvSales.Columns[3].HeaderText = "NIP";
            this.dgvSales.Columns[4].HeaderText = "Data początku sprzedaży";
            this.dgvSales.Columns[5].HeaderText = "Data końca sprzedaży";
            this.dgvSales.Columns[6].HeaderText = "Nr umowy";
            this.dgvSales.Columns[7].HeaderText = "Koszt";
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choice = "";
            if (textBoxSurame.Text.Length > 0)
                choice = "Surname";
            if (textBoxName.Text.Length > 0)
                choice = "FirstName";
            if (textBoxNIP.Text.Length > 0)
                choice = "NIP";
            if (textBoxNrArrangement.Text.Length > 0)
                choice = "NrUmowy";
            if (textBoxNrSale.Text.Length > 0)
                choice = "NrSprzedazy";
            switch (choice)
            {
                case "Surname":
                    enterSurname();
                    break;
                case "FirstName":
                    enterFirstname();
                    break;
                case "NIP":
                    enterNIP();
                    break;
                case "NrUmowy":
                    enterNoArrangement();
                    break;
                case "NrSprzedazy":
                    enterNoSale();
                    break;
                default:
                    errorData();
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
        }
        private void cleanTextBox()
        {
            textBoxName.Clear();
            textBoxSurame.Clear();
            textBoxNIP.Clear();
            textBoxNrArrangement.Clear();
            textBoxNrSale.Clear();
        }
        private void enterSurname()
        {
            List<v_Sprzedaz> clientSurname = db.v_Sprzedaz.Where(a => a.Nazwisko_klienta == textBoxSurame.Text).ToList();
            int clientSurnameInt = clientSurname.Count();
            if (clientSurnameInt > 0)
            {
                this.dgvSales.DataSource = clientSurnameInt;
                this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                MessageBox.Show($"Klient z nazwiskiem: {textBoxSurame.Text}, nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cleanTextBox();
                showData();
            }
        }
        private void enterFirstname()
        {
            List<v_Sprzedaz> clientName = db.v_Sprzedaz.Where(a => a.Imię_klienta == textBoxName.Text).ToList();
            int clientNameInt = clientName.Count();
            if (clientNameInt > 0)
            {
                this.dgvSales.DataSource = clientName.ToList();
                this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                MessageBox.Show($"Klient o imieniu: {textBoxName.Text}, nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cleanTextBox();
                showData();
            }
        }
        private void enterNIP()
        {
            List<v_Sprzedaz> dataNip = db.v_Sprzedaz.Where(a => a.NIP == textBoxNIP.Text).ToList();
            int dataNipInt = dataNip.Count();
            if (dataNipInt > 0)
            {
                this.dgvSales.DataSource = dataNipInt;
                this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                MessageBox.Show($"Klient z NIP: {textBoxNIP.Text}, nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cleanTextBox();
                showData();
            }
        }
        private void enterNoArrangement()
        {
            try
            {
                string dataArrangement = textBoxNrArrangement.Text;
                int dataArrangementINT = int.Parse(dataArrangement);
                List<v_Sprzedaz> dataNoArrangement = db.v_Sprzedaz.Where(a => a.Umowa == dataArrangementINT).ToList();
                int dataNoArrangementInt = dataNoArrangement.Count();
                if (dataNoArrangementInt > 0)
                {
                    this.dgvSales.DataSource = dataNoArrangement;
                    this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanTextBox();
                }
                else
                {
                    MessageBox.Show($"Nr umowy: {textBoxNrArrangement.Text}, nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleanTextBox();
                    showData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Nr umowy: {textBoxNrArrangement.Text}, nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                showData();
                cleanTextBox();
            }
        }
        private void enterNoSale()
        {
            try
            {
                string text = textBoxNrSale.Text;
                int textINT = int.Parse(text);
                List<v_Sprzedaz> dataNoSale = db.v_Sprzedaz.Where(a => a.Numer_sprzedaży == textINT).ToList();
                int dataNoSaleInt = dataNoSale.Where(a => a.Numer_sprzedaży > 0).Count();
                if (dataNoSaleInt > 0)
                {
                    this.dgvSales.DataSource = dataNoSale;
                    cleanTextBox();
                }
                else
                {
                    MessageBox.Show($"Nr sprzedaży: {textBoxNrSale.Text}, nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleanTextBox();
                    showData();
                    showData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Nr sprzedaży: {textBoxNrSale.Text}, nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                showData();
                cleanTextBox();
            }
        }
        private void errorData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showData();
        }

        private void btnAddNewSale_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentAddSales formSalesDepartmentAddSales = new FormSalesDepartmentAddSales(db);
            formSalesDepartmentAddSales.ShowDialog();
        }
    }
}