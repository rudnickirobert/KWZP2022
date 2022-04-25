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
            var dane = from klient in db.Klients
                       select new
                       {
                           klient.ID_klient,
                           klient.Nazwisko,
                           klient.Imie,
                           klient.NIP
                       };
            this.dgvClientRemove.DataSource = dane.ToList();
            this.dgvClientRemove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvClientRemove_MouseClick(object sender, MouseEventArgs e)
        {
            var dane = this.dgvClientRemove.CurrentRow.Cells[0].Value.ToString();
            int daneINT = int.Parse(dane);
            Klient danyKlient = db.Klients.Single(a => a.ID_klient == daneINT);
            Dane_adresowe_klient daneKlientDaneAdresowe = db.Dane_adresowe_klient.Single(b => b.ID_klient == daneINT);
            Email_klient daneEmailKlient = db.Email_klient.Single(c => c.ID_klient == daneINT);
            Nr_telefon_klient daneNrTelKlient = db.Nr_telefon_klient.Single(d => d.ID_klient == daneINT);
            if (dane != null)
            {
                DialogResult result = MessageBox.Show("Czy chcesz usunąć zaznaczony rekord?", "Pytanie", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    this.db.Klients.Remove(danyKlient);
                    this.db.Dane_adresowe_klient.Remove(daneKlientDaneAdresowe);
                    this.db.Nr_telefon_klient.Remove(daneNrTelKlient);
                    this.db.Email_klient.Remove(daneEmailKlient);
                    this.db.SaveChanges();
                    MessageBox.Show("Rekord został usunięty!", "Informacja", MessageBoxButtons.OK);
                    showData();
                }
            }
        }
    }
}