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
    public partial class FormSalesDepartmentClientRemoveClient : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentClientRemoveClient(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
        }
        private void showData()
        {
            this.dgvClientRemove.DataSource = this.db.Klient.ToList();
            this.dgvClientRemove.Columns["Nr_telefon_klient"].Visible = false;
            this.dgvClientRemove.Columns["Email_klient"].Visible = false;
            this.dgvClientRemove.Columns["Zamowienie"].Visible = false;
            this.dgvClientRemove.Columns["Dane_adresowe_klient"].Visible = false;
            this.dgvClientRemove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvClientRemove_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedRowINT = int.Parse(this.dgvClientRemove.CurrentRow.Cells[0].Value.ToString());
            Klient selectedClient = db.Klient.Single(a => a.ID_klient == selectedRowINT);
            Dane_adresowe_klient daneKlientDaneAdresowe = db.Dane_adresowe_klient.Single(b => b.ID_klient == selectedRowINT);
            Email_klient daneEmailKlient = db.Email_klient.Single(c => c.ID_klient == selectedRowINT);
            Nr_telefon_klient daneNrTelKlient = db.Nr_telefon_klient.Single(d => d.ID_klient == selectedRowINT);
            if (selectedRowINT != 0)
            {
                DialogResult result = MessageBox.Show($"Czy chcesz usunąć klienta: {selectedClient.Nazwisko} {selectedClient.Imie}?", "Pytanie", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        this.db.Klient.Remove(selectedClient);
                        this.db.Dane_adresowe_klient.Remove(daneKlientDaneAdresowe);
                        this.db.Nr_telefon_klient.Remove(daneNrTelKlient);
                        this.db.Email_klient.Remove(daneEmailKlient);
                        this.db.SaveChanges();
                        MessageBox.Show("Klient został usunięty z bazy danych!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Klient widnieje w historii zamówień. Nie można usunąć tego klienta","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    
                }
            }
        }
    }
}