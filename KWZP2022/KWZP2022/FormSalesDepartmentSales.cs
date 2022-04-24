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
            var salesData = from sales in this.db.v_Sprzedaz
                            select new
                            {
                                sales.Numer_sprzedaży,
                                sales.Nazwisko_klienta,
                                sales.Imię_klienta,
                                sales.NIP,
                                sales.Data_początku_sprzedaży,
                                sales.Data_końca_sprzedaży,
                                sales.Umowa,
                                sales.Koszt
                            };
            this.dgvSales.DataSource = salesData.ToList();
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(textBox2Name.Text.Length > 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length == 0 && textBoxNrArrangement.Text.Length == 0 && textBoxNrSale.Text.Length == 0)
            {
                var data = db.v_Sprzedaz.Where(a => a.Nazwisko_klienta == textBox2Name.Text);
                int name2 = data.Count();
                if (name2 > 0)
                {
                    this.dgvSales.DataSource = data.ToList();
                    this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanTextBox();
                }
                else
                {
                    MessageBox.Show($"Klient z nazwiskiem: {textBox2Name.Text}, nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleanTextBox();
                    showData();
                }
                
            }
            else if(textBox2Name.Text.Length == 0 && textBox1Name.Text.Length > 0 && textBoxNIP.Text.Length == 0 && textBoxNrArrangement.Text.Length == 0 && textBoxNrSale.Text.Length == 0)
            {
                var data = db.v_Sprzedaz.Where(a => a.Imię_klienta == textBox1Name.Text);
                int name1 = data.Count();
                if (name1 > 0)
                {
                    this.dgvSales.DataSource = data.ToList();
                    this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanTextBox();
                }
                else
                {
                    MessageBox.Show($"Klient o imieniu: {textBox1Name.Text}, nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleanTextBox();
                    showData();
                }
            }
            else if(textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length > 0 && textBoxNrArrangement.Text.Length == 0 && textBoxNrSale.Text.Length == 0)
            {
                var data = db.v_Sprzedaz.Where(a => a.NIP == textBoxNIP.Text);
                int nip = data.Count();
                if(nip > 0)
                {
                    this.dgvSales.DataSource = data.ToList();
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
            else if(textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length == 0 && textBoxNrArrangement.Text.Length > 0 && textBoxNrSale.Text.Length == 0)
            {
                try
                {
                    string dataArrangement = textBoxNrArrangement.Text;
                    int dataArrangementINT = int.Parse(dataArrangement);
                    var data = db.v_Sprzedaz.Where(a => a.Umowa == dataArrangementINT).ToList();
                    int umowa = data.Count();
                    if (umowa > 0)
                    {
                        this.dgvSales.DataSource = data;
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
            else if(textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length == 0 && textBoxNrArrangement.Text.Length == 0 && textBoxNrSale.Text.Length > 0)
            {
                try
                {
                    string text = textBoxNrSale.Text;
                    int textINT = int.Parse(text);
                    var dataSearch = db.v_Sprzedaz.Where(a => a.Numer_sprzedaży == textINT).ToList();
                    var data = dataSearch.Where(a => a.Numer_sprzedaży > 0).Count();
                    if (data > 0)
                    {
                        this.dgvSales.DataSource = dataSearch;
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
            else
            {
                MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                showData();
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
            textBox1Name.Clear();
            textBox2Name.Clear();
            textBoxNIP.Clear();
            textBoxNrArrangement.Clear();
            textBoxNrSale.Clear();
        }
        private void messageBox()
        {
            MessageBox.Show("Wyszukiwany numer sprzedaży nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}


