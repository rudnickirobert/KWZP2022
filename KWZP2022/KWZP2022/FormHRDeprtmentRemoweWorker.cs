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
    public partial class FormHRDeprtmentRemoweWorker : Form
    {
        KWZPEntities db;
        public FormHRDeprtmentRemoweWorker(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
        }
        private void showData()
        {
            this.dgvWorkerRemowe.DataSource = this.db.v_Pracownik.ToList();
            this.dgvWorkerRemowe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvWorkerRemove_MouseClick(object sender, MouseEventArgs e)
        {
            var dane = this.dgvWorkerRemowe.CurrentRow.Cells[0].Value.ToString();
            var daneINT = int.Parse(dane);
            Pracownik danypracownik = db.Pracowniks.Single(a => a.ID_pracownik == daneINT);
            Dane_adresowe_pracownik danepracownikdaneadresowe = db.Dane_adresowe_pracownik.Single(b => b.ID_pracownik == daneINT);
            Email_pracownik daneemailpracownik = db.Email_pracownik.Single(c => c.ID_pracownik == daneINT);
            Nr_telefon_pracownik danenrtelpracownik = db.Nr_telefon_pracownik.Single(d => d.ID_pracownik == daneINT);
            if (dane != null)
            {
                DialogResult result = MessageBox.Show("Czy chcesz usunąć zaznaczony rekord?", "Pytanie", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.db.Pracowniks.Remove(danypracownik);
                    this.db.Dane_adresowe_pracownik.Remove(danepracownikdaneadresowe);
                    this.db.Nr_telefon_pracownik.Remove(danenrtelpracownik);
                    this.db.Email_pracownik.Remove(daneemailpracownik);
                    this.db.SaveChanges();
                    MessageBox.Show("Rekord został usunięty!", "Informacja", MessageBoxButtons.OK);
                    showData();
                }
            }
        }
    }
}
