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
            this.dgvSales.DataSource = db.v_Sprzedaz.ToList();
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
                    messageBox();
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
                    messageBox();
                    cleanTextBox();
                    showData();
                }
            }
            else if(textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length > 0 && textBoxNrArrangement.Text.Length == 0 && textBoxNrSale.Text.Length == 0)
            {
                var data = db.v_Sprzedaz.Where(a => a.NIP == textBox2Name.Text);
                int nip = data.Count();
                if(nip > 0)
                {
                    this.dgvSales.DataSource = data.ToList();
                    this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanTextBox();
                }
                else
                {
                    messageBox();
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
                        messageBox();
                        cleanTextBox();
                        showData();
                    }
                }
                catch (Exception)
                {
                    messageBox();
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
                        cleanTextBox();
                        showData();
                        messageBox();
                        showData();
                    }
                }
                catch (Exception)
                {
                    messageBox();
                    showData();
                    cleanTextBox();
                }
            }
            else
            {
                MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK);
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
            MessageBox.Show("Wyszukiwany numer sprzedaży nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK);
        }
    }
}


