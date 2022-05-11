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
    public partial class FormResDepServicesExchanged : Form
    {
        KWZPEntities db;
        public FormResDepServicesExchanged(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridViewObslugi();
        }
        private void initDataGridViewObslugi()
        {
            dgvObslugiWymiana.DataSource = db.v_Obslugi_w_trakcie_wymiana.ToList();
            dgvObslugiWymiana.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvObslugiWymiana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvObslugiWymiana.Columns[2].Visible = false;
            dgvObslugiWymiana.Columns[4].Visible=false;
        }
        private void initDataGridViewWymiana()
        {
            string obsluga = dgvObslugiWymiana.CurrentRow.Cells[0].Value.ToString();
            int obslugaID = int.Parse(obsluga);
            List<v_Wymiana_czesc_w_trakcie> wymiana = db.v_Wymiana_czesc_w_trakcie.Where(a => a.ID_obsluga == obslugaID).ToList();
            if (wymiana.Count() >= 0)
            {
                dgvHistoriaWymian.DataSource = wymiana;
                dgvHistoriaWymian.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                this.dgvHistoriaWymian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                dgvHistoriaWymian.Columns[0].Visible = false;
                dgvHistoriaWymian.Columns[1].Visible = false;
                dgvHistoriaWymian.Columns[2].Visible = false;
                dgvHistoriaWymian.Columns[3].Visible = false;
                dgvHistoriaWymian.Columns[4].Visible = false;
            }
            else
            {
                MessageBox.Show("Wybierz wymianę");
            }
        }
        private void btnWyborObslugi_Click(object sender, EventArgs e)
        {
            string wyborStanowiska = dgvObslugiWymiana.CurrentRow.Cells[1].Value.ToString();
            int wyborStanowiskaID = int.Parse(wyborStanowiska);
            List<v_Sklad_SP_maszyna> skladStanowiska = db.v_Sklad_SP_maszyna.Where(a => a.ID_stanowiska_produkcyjnego == wyborStanowiskaID).ToList();
            if (skladStanowiska.Count() > 0)
            {
                dgvMaszyny.DataSource = skladStanowiska;
                dgvMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                this.dgvMaszyny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                dgvMaszyny.Columns[0].Visible = false;
                dgvMaszyny.Columns[1].Visible = false;
                dgvMaszyny.Columns[2].Visible = false;
                txtWybranaObsluga.Text= dgvObslugiWymiana.CurrentRow.Cells[0].Value.ToString();
                btnWyborMaszyny.Visible = true;
                initDataGridViewWymiana();
            }
            else
            {
                MessageBox.Show("Wybierz poprawną obsługę");
            }
        }

        private void btnWyborMaszyny_Click(object sender, EventArgs e)
        {
            try
            {
                string wyborMaszyny = dgvMaszyny.CurrentRow.Cells[2].Value.ToString();
                int wyborMaszynyID = int.Parse(wyborMaszyny);
                List< v_Sklad_maszyna > skladMaszyna = db.v_Sklad_maszyna.Where(a => a.ID_maszyna == wyborMaszynyID).ToList();
                if (skladMaszyna.Count() > 0)
                {
                    dgvCzesci.DataSource = skladMaszyna;
                    dgvCzesci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    this.dgvCzesci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCzesci.Columns[0].Visible = false;
                    dgvCzesci.Columns[1].Visible = false;
                    dgvCzesci.Columns[2].Visible = false;
                    dgvCzesci.Columns[3].Visible = false;
                    txtMaszynaWybrana.Text = dgvMaszyny.CurrentRow.Cells[4].Value.ToString();
                    btnDodajWymiane.Visible = true;
                    btnUsunWymiane.Visible = true;
                }
                else
                {
                    MessageBox.Show("Maszyna nie ma przypisanych części");
                }
            }
            catch
            {
                MessageBox.Show("Wybierz maszynę!");
            }
        }
        private void btnDodajWymiane_Click(object sender, EventArgs e)
        {
            try
            {
                Wymiana_czesc wymiana = new Wymiana_czesc();
                wymiana.ID_obsluga = (int)dgvObslugiWymiana.CurrentRow.Cells[0].Value;
                wymiana.ID_maszyna_nr = (int)dgvMaszyny.CurrentRow.Cells[1].Value;
                wymiana.ID_czesc = (int)dgvCzesci.CurrentRow.Cells[1].Value;
                db.Wymiana_czesc.Add(wymiana);
                db.SaveChanges();
                initDataGridViewWymiana();
                MessageBox.Show("Wymieniono!");
            }
            catch
            {
                MessageBox.Show("Wybierz poprawną część!");
            }
        }
        private void btnUsunWymiane_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wymienianą część: " + this.dgvHistoriaWymian.CurrentRow.Cells[7].Value + "?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string wymianaObsluga = this.dgvHistoriaWymian.CurrentRow.Cells[0].Value.ToString();
                    int wymianaObslugaID = int.Parse(wymianaObsluga);
                    string wymianaMaszyna = this.dgvHistoriaWymian.CurrentRow.Cells[1].Value.ToString();
                    int wymianaMaszynaID = int.Parse(wymianaMaszyna);
                    string wymianaCzesc = this.dgvHistoriaWymian.CurrentRow.Cells[2].Value.ToString();
                    int wymianaCzescID = int.Parse(wymianaCzesc);
                    Wymiana_czesc danaWymiana = db.Wymiana_czesc.Single(a => a.ID_obsluga == wymianaObslugaID && a.ID_maszyna_nr==wymianaMaszynaID && a.ID_czesc==wymianaCzescID);
                    db.Wymiana_czesc.Remove(danaWymiana);
                    db.SaveChanges();
                    initDataGridViewWymiana();
                }
            }
            catch
            {
                MessageBox.Show("Nie można usunąć części");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvHistoriaWymian.DataSource = null;
            dgvCzesci.DataSource = null;
            dgvMaszyny.DataSource = null;
            txtMaszynaWybrana.Clear();
            txtWybranaObsluga.Clear();
            btnWyborMaszyny.Visible = false;
            btnUsunWymiane.Visible = false;
            btnDodajWymiane.Visible = false;
        }
    }
}

