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
    public partial class FormResDepServices : Form
    {
        KWZPEntities db;
        public FormResDepServices(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvCompletedServices.DataSource = db.v_Obslugi_zakonczone.ToList();
            dgvOngoingServices.DataSource = db.v_Obslugi_w_trakcie.ToList();
            dgvOngoingServices.Columns[4].Visible = false;
            dgvCompletedServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvOngoingServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            FormResDepServicesAdd nowaObslugaForm = new FormResDepServicesAdd(db);
            nowaObslugaForm.ShowDialog();
        }
        private void btnCloseService_Click(object sender, EventArgs e)
        {
            if (this.dgvOngoingServices.CurrentRow.Cells[0].Value != null)
            {
                int wybranaObslugaID = int.Parse(this.dgvOngoingServices.CurrentRow.Cells[0].Value.ToString());
                Obsluga wybranaObsluga = this.db.Obsluga.Single(a => a.ID_obsluga == wybranaObslugaID);
                if (wybranaObsluga.Pracownik.Count() > 0)
                {
                    if (wybranaObsluga.ID_rodzaj_obsluga == 1 && wybranaObsluga.Wymiana_czesc.Count() == 0)
                    {
                        MessageBox.Show("Obsługa nie ma przypisanej wymiany części!", "Błąd", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    { 
                    int daneObsluga = int.Parse(this.dgvOngoingServices.CurrentRow.Cells[0].Value.ToString());
                    Obsluga daneObslugaID = this.db.Obsluga.Single(a => a.ID_obsluga == daneObsluga);
                    daneObslugaID.Data_do = System.DateTime.Now;
                    db.SaveChanges();
                    initDataGridView();
                    MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Przypisz pracownika!", "Błąd", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono obslugi!", "Błąd", MessageBoxButtons.OK);
            }
        }
        private void btnPrzypiszPracownika_Click(object sender, EventArgs e)
        {
            int wybranaObsluga = int.Parse(this.dgvOngoingServices.CurrentRow.Cells[0].Value.ToString());
            Obsluga wybranaObslugaDGV = this.db.Obsluga.Single(a => a.ID_obsluga == wybranaObsluga);
            FormResDepServicesWorkers formResDepServicesWorkers = new FormResDepServicesWorkers(db, wybranaObslugaDGV);
            formResDepServicesWorkers.ShowDialog();
        }
        private void btnDodajWymiane_Click(object sender, EventArgs e)
        {
            FormResDepServicesExchanged wymianaForm = new FormResDepServicesExchanged(db);
            wymianaForm.ShowDialog();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            initDataGridView();
        }
        private void btnStats_Click(object sender, EventArgs e)
        {
            FormResDepStatystykiObslug statystykiObslug = new FormResDepStatystykiObslug(db);
            statystykiObslug.ShowDialog();
        }
    }
}
