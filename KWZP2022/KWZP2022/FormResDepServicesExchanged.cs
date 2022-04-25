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
            initDataGridViewWymiana();
        }
        private void initDataGridViewObslugi()
        {
            dgvObslugiWymiana.DataSource = db.v_Oblugi_w_trakcie_wymiana.ToList();
            dgvObslugiWymiana.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvObslugiWymiana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvObslugiWymiana.Columns[2].Visible = false;
            dgvObslugiWymiana.Columns[4].Visible=false;
        }
        private void initDataGridViewMaszyny()
        {
            dgvMaszyny.DataSource = db.v_Sklad_SP_maszyna.ToList();
            dgvMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvMaszyny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaszyny.Columns[0].Visible = false;
            dgvMaszyny.Columns[1].Visible = false;
            dgvMaszyny.Columns[2].Visible = false;
        }
        private void initDataGridViewCzesci()
        {
            dgvCzesci.DataSource = db.v_Sklad_maszyna.ToList();
            dgvCzesci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvCzesci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCzesci.Columns[0].Visible = false;
            dgvCzesci.Columns[1].Visible = false;
            dgvCzesci.Columns[2].Visible = false;
        }
        private void initDataGridViewWymiana()
        {
            dgvHistoriaWymian.DataSource = db.v_Wymiana_czesc_w_trakcie.ToList();
            dgvHistoriaWymian.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvCzesci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //dgvCzesci.Columns[0].Visible = false;
            //dgvCzesci.Columns[1].Visible = false;
            //dgvCzesci.Columns[2].Visible = false;
        }


        private void btnWyborObslugi_Click(object sender, EventArgs e)
        {
            string wyborObslugi = dgvObslugiWymiana.CurrentRow.Cells[1].Value.ToString();
            int wyborObslugiID = int.Parse(wyborObslugi);
            System.Linq.IQueryable skladObslugi = db.v_Sklad_SP_maszyna.Where(a => a.ID_stanowiska_produkcyjnego == wyborObslugiID);
            int skladObslugiID = skladObslugi.Cast<v_Sklad_SP_maszyna>().Where(a => a.ID_stanowiska_produkcyjnego > 0).Count();
            if (skladObslugiID > 0)
            {
                dgvMaszyny.DataSource = skladObslugi.Cast<v_Sklad_SP_maszyna>().ToList();
                dgvMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                this.dgvMaszyny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                dgvMaszyny.Columns[0].Visible = false;
                dgvMaszyny.Columns[1].Visible = false;
                dgvMaszyny.Columns[2].Visible = false;
                txtWybranaObsluga.Text= dgvObslugiWymiana.CurrentRow.Cells[1].Value.ToString();
                btnWyborMaszyny.Visible = true;
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
                System.Linq.IQueryable skladMaszyna = db.v_Sklad_maszyna.Where(a => a.ID_maszyna == wyborMaszynyID);
                int skladMaszynaID = skladMaszyna.Cast<v_Sklad_maszyna>().Where(a => a.ID_maszyna > 0).Count();
                if (skladMaszynaID > 0)
                {
                    dgvCzesci.DataSource = skladMaszyna.Cast<v_Sklad_maszyna>().ToList();
                    dgvCzesci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    this.dgvCzesci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCzesci.Columns[0].Visible = false;
                    dgvCzesci.Columns[1].Visible = false;
                    dgvCzesci.Columns[2].Visible = false;
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
                wymiana.ID_obsluga = (int)dgvObslugiWymiana.CurrentRow.Cells[1].Value;
                wymiana.ID_maszyna_nr = (int)dgvMaszyny.CurrentRow.Cells[1].Value;
                wymiana.ID_czesc = (int)dgvCzesci.CurrentRow.Cells[1].Value;
                db.Wymiana_czesc.Add(wymiana);
                db.SaveChanges();
                initDataGridViewObslugi();
            }
            catch
            {
                MessageBox.Show("Wybierz część!");
            }
        }
        private void btnUsunWymiane_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wymienianą część: " + this.dgvWymianaCzesc.CurrentRow.Cells[3].Value + "?", "Question", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        string current_wymiana = this.dgvWymianaCzesc.CurrentRow.Cells[0].Value.ToString();
            //        int daneINT = int.Parse(current_wymiana);
            //        Wymiana_czesc danaWymiana = db.Wymiana_czesc.Single(a => a.ID_obsluga == daneINT);
            //        this.db.Wymiana_czesc.Remove(danaWymiana);
            //        db.SaveChanges();
            //        initDataGridView();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Nie można usunąć części");
            //}

        }
    }
}

