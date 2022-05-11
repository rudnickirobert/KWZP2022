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
    public partial class FormSalesDepartmentSalesAgreement : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentSalesAgreement(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvSalesAgreementData();
        }
        private void dgvSalesAgreementData()
        {
            this.dgvSalesAgreement.DataSource = this.db.v_Umowy_sprzedazy.ToList();
            this.dgvSalesAgreement.Columns[0].HeaderText = "Nr umowy";
            this.dgvSalesAgreement.Columns[1].HeaderText = "Nr oferty handlowej";
            this.dgvSalesAgreement.Columns[2].HeaderText = "Nr zamówienia";
            this.dgvSalesAgreement.Columns[3].HeaderText = "Nr telefonu klienta";
            this.dgvSalesAgreement.Columns[4].HeaderText = "Typ zamówienia";
            this.dgvSalesAgreement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvSalesAgreementData(int saleAgreement)
        {
            this.dgvSalesAgreement.DataSource = this.db.v_Umowy_sprzedazy.Where(a => a.ID_umowa_sprzedaz == saleAgreement).ToList();
            this.dgvSalesAgreement.Columns[0].HeaderText = "Nr umowy";
            this.dgvSalesAgreement.Columns[1].HeaderText = "Nr oferty handlowej";
            this.dgvSalesAgreement.Columns[2].HeaderText = "Nr zamówienia";
            this.dgvSalesAgreement.Columns[3].HeaderText = "Nr telefonu klienta";
            this.dgvSalesAgreement.Columns[4].HeaderText = "Typ zamówienia";
            this.dgvSalesAgreement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvSalesAgreementData(string noTelClient)
        {
            this.dgvSalesAgreement.DataSource = this.db.v_Umowy_sprzedazy.Where(a => a.Numer == noTelClient).ToList();
            this.dgvSalesAgreement.Columns[0].HeaderText = "Nr umowy";
            this.dgvSalesAgreement.Columns[1].HeaderText = "Nr oferty handlowej";
            this.dgvSalesAgreement.Columns[2].HeaderText = "Nr zamówienia";
            this.dgvSalesAgreement.Columns[3].HeaderText = "Nr telefonu klienta";
            this.dgvSalesAgreement.Columns[4].HeaderText = "Typ zamówienia";
            this.dgvSalesAgreement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvSalesAgreementData(string noTelClient, int noSaleAgreement)
        {
            this.dgvSalesAgreement.DataSource = this.db.v_Umowy_sprzedazy.Where(a => a.Numer == noTelClient && a.ID_umowa_sprzedaz == noSaleAgreement).ToList();
            this.dgvSalesAgreement.Columns[0].HeaderText = "Nr umowy";
            this.dgvSalesAgreement.Columns[1].HeaderText = "Nr oferty handlowej";
            this.dgvSalesAgreement.Columns[2].HeaderText = "Nr zamówienia";
            this.dgvSalesAgreement.Columns[3].HeaderText = "Nr telefonu klienta";
            this.dgvSalesAgreement.Columns[4].HeaderText = "Typ zamówienia";
            this.dgvSalesAgreement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvSalesAgreement_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult removeSaleAgreement = MessageBox.Show($"Czy chcesz usunąc umowę o numerze: {this.dgvSalesAgreement.CurrentRow.Cells[0].Value}? Wszystkie oferty handlowe dotyczące tego zamówienia przyjmą status do rozpatrzenia.", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (removeSaleAgreement == DialogResult.Yes)
            {
                int selectedSalesAgreementFromDgv = int.Parse(this.dgvSalesAgreement.CurrentRow.Cells[0].Value.ToString());
                if (this.db.Sprzedaz.Where(a => a.ID_umowa_sprzedaz == selectedSalesAgreementFromDgv).ToList().Count() <= 0)
                {
                    Umowa_sprzedaz selectedSalesAgreement = this.db.Umowa_sprzedaz.Single(a => a.ID_umowa_sprzedaz == selectedSalesAgreementFromDgv);
                    this.db.Umowa_sprzedaz.Remove(selectedSalesAgreement);
                    int selectedOfferFromDgv = int.Parse(this.dgvSalesAgreement.CurrentRow.Cells[2].Value.ToString());
                    List<Oferta_handlowa> commercialOfferList = this.db.Oferta_handlowa.Where(a => a.ID_zamowienie == selectedOfferFromDgv).ToList();
                    foreach (Oferta_handlowa commercialOfferForConsideration in commercialOfferList)
                    {
                        commercialOfferForConsideration.ID_status_oferta = 3;
                    }
                    this.db.SaveChanges();
                    dgvSalesAgreementData();
                }
                else
                {
                    MessageBox.Show("Nie można usunąć umowy, która została sprzedana!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSearchSalesAgreement_Click(object sender, EventArgs e)
        {
            try
            {
                string choice = "";
                if (textBoxNoTelClient.TextLength > 0 && textBoxSearchSaleAgreement.TextLength > 0)
                {
                    int output = 0;
                    bool checkIsNumber = int.TryParse(textBoxNoTelClient.Text, out output);
                    if(checkIsNumber == true)
                    {
                        choice = "noTelClientAndNoSaleAgreement";
                    }
                    else
                    {
                        MessageBox.Show("Wprowadzono błędne dane!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNoTelClient.Clear();
                        textBoxSearchSaleAgreement.Clear();
                    }
                }
                else if (textBoxNoTelClient.TextLength > 0 && textBoxSearchSaleAgreement.TextLength == 0)
                {
                    int output = 0;
                    bool checkIsNumber = int.TryParse(textBoxNoTelClient.Text, out output);
                    if (checkIsNumber == true)
                    {
                        choice = "noTelClient";
                    }
                    else
                    {
                        MessageBox.Show("Wprowadzono błędne dane!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNoTelClient.Clear();
                    }
                }
                else if (textBoxNoTelClient.TextLength == 0 && textBoxSearchSaleAgreement.TextLength > 0)
                {
                    choice = "noSaleAgreement";
                }
                else if (textBoxNoTelClient.TextLength == 0 && textBoxSearchSaleAgreement.TextLength == 0)
                {
                    choice = "textBoxesWereBlank";
                }

                switch (choice)
                {
                    case "noTelClientAndNoSaleAgreement":
                        int selectedSaleAgreement = int.Parse(textBoxSearchSaleAgreement.Text);
                        dgvSalesAgreementData(textBoxNoTelClient.Text, selectedSaleAgreement);
                        break;
                    case "noTelClient":
                        dgvSalesAgreementData(textBoxNoTelClient.Text);
                        break;
                    case "noSaleAgreement":
                        int selectedSaleAgreementSecond = int.Parse(textBoxSearchSaleAgreement.Text);
                        dgvSalesAgreementData(selectedSaleAgreementSecond);
                        break;
                    case "textBoxesWereBlank":
                        MessageBox.Show("Pola tekstowe są puste!","Uwaga!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadzono błędne dane!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNoTelClient.Clear();
                textBoxSearchSaleAgreement.Clear();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSalesAgreementData();
        }

        private void btnClearNoAgreement_Click(object sender, EventArgs e)
        {
            textBoxSearchSaleAgreement.Clear();
        }

        private void btnClearNoTelClient_Click(object sender, EventArgs e)
        {
            textBoxNoTelClient.Clear();
        }
    }
}
