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
            MessageBox.Show("Wyszukiwany numer sprzedaży nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK);
        }
        private void showData()
        {
            var dane = from v_klient in db.v_Klient
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
            this.dgvClient.DataSource = dane.ToList();
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            cleanTextBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox2Name.Text.Length > 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length == 0 && textBoxCity.Text.Length == 0 && textBoxNo1.Text.Length == 0 && textBoxNo2.Text.Length == 0 && textBoxPostCode.Text.Length == 0 && textBoxStreet.Text.Length == 0)
            {
                var data = db.v_Klient.Where(a => a.Nazwisko == textBox2Name.Text);
                int name2 = data.Count();
                if (name2 > 0)
                {
                    this.dgvClient.DataSource = data.ToList();
                    this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanTextBox();
                }
                else
                {
                    messageBox();
                    cleanTextBox();
                    showData();
                }

            }
            else if (textBox2Name.Text.Length == 0 && textBox1Name.Text.Length > 0 && textBoxNIP.Text.Length == 0 && textBoxCity.Text.Length == 0 && textBoxNo1.Text.Length == 0 && textBoxNo2.Text.Length == 0 && textBoxPostCode.Text.Length == 0 && textBoxStreet.Text.Length == 0)
            {
                var data = db.v_Klient.Where(a => a.Imię == textBox1Name.Text);
                int name1 = data.Count();
                if (name1 > 0)
                {
                    this.dgvClient.DataSource = data.ToList();
                    this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanTextBox();
                }
                else
                {
                    messageBox();
                    cleanTextBox();
                    showData();
                }
            }
            else if (textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length > 0 && textBoxCity.Text.Length == 0 && textBoxNo1.Text.Length == 0 && textBoxNo2.Text.Length == 0 && textBoxPostCode.Text.Length == 0 && textBoxStreet.Text.Length == 0)
            {
                var data = db.v_Klient.Where(a => a.NIP == textBoxNIP.Text);
                int nip = data.Count();
                if (nip > 0)
                {
                    this.dgvClient.DataSource = data.ToList();
                    this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanTextBox();
                }
                else
                {
                    messageBox();
                    cleanTextBox();
                    showData();
                }
            }
            else if (textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length == 0 && textBoxCity.Text.Length > 0 && textBoxNo1.Text.Length == 0 && textBoxNo2.Text.Length == 0 && textBoxPostCode.Text.Length == 0 && textBoxStreet.Text.Length == 0)
            {
                string dataCity = textBoxCity.Text;
                var data = db.v_Klient.Where(a => a.Miejscowość == dataCity).ToList();
                int umowa = data.Count();
                if (umowa > 0)
                {
                    this.dgvClient.DataSource = data;
                    this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanTextBox();
                }
                else
                {
                    messageBox();
                    cleanTextBox();
                    showData();
                }
            }
            else if (textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length == 0 && textBoxCity.Text.Length == 0 && textBoxNo1.Text.Length > 0 && textBoxNo2.Text.Length == 0 && textBoxPostCode.Text.Length == 0 && textBoxStreet.Text.Length == 0)
            {
                try
                {
                    string text = textBoxNo1.Text;
                    int textINT = int.Parse(text);
                    var dataSearch = db.v_Klient.Where(a => a.Numer_budynku == textINT).ToList();
                    var data = dataSearch.Where(a => a.Numer_budynku > 0).Count();
                    if (data > 0)
                    {
                        this.dgvClient.DataSource = dataSearch;
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
            else if (textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length == 0 && textBoxCity.Text.Length == 0 && textBoxNo1.Text.Length == 0 && textBoxNo2.Text.Length > 0 && textBoxPostCode.Text.Length == 0 && textBoxStreet.Text.Length == 0)
            {
                try
                {
                    string text = textBoxNo2.Text;
                    int textINT = int.Parse(text);
                    var dataSearch = db.v_Klient.Where(a => a.Numer_lokalu == textINT).ToList();
                    var data = dataSearch.Where(a => a.Numer_lokalu > 0).Count();
                    if (data > 0)
                    {
                        this.dgvClient.DataSource = dataSearch;
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
            else if (textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length == 0 && textBoxCity.Text.Length == 0 && textBoxNo1.Text.Length == 0 && textBoxNo2.Text.Length == 0 && textBoxPostCode.Text.Length > 0 && textBoxStreet.Text.Length == 0)
            {
                string tekst = textBoxPostCode.Text;
                var dataPostCode = db.v_Klient.Where(a => a.Kod_pocztowy == tekst).ToList();
                int data = dataPostCode.Count();
                if (data > 0)
                {
                    this.dgvClient.DataSource = dataPostCode;
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
            else if (textBox2Name.Text.Length == 0 && textBox1Name.Text.Length == 0 && textBoxNIP.Text.Length == 0 && textBoxCity.Text.Length == 0 && textBoxNo1.Text.Length == 0 && textBoxNo2.Text.Length == 0 && textBoxPostCode.Text.Length == 0 && textBoxStreet.Text.Length > 0)
            {
                string tekst = textBoxStreet.Text;
                var dataStreet = db.v_Klient.Where(a => a.Ulica == tekst).ToList();
                int data = dataStreet.Count();
                if (data > 0)
                {
                    this.dgvClient.DataSource = dataStreet;
                }
                else
                {
                    cleanTextBox();
                    showData();
                    messageBox();
                    showData();
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
    }
}
