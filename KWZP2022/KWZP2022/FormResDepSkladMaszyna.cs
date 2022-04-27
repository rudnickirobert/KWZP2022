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
    public partial class FormResDepSkladMaszyna : Form
    {
        KWZPEntities db;
        Maszyna wybranaMaszynaDGV;
        public FormResDepSkladMaszyna(KWZPEntities db, Maszyna wybranaMaszynaDGV)
        {
            InitializeComponent();
            this.db = db;
            this.wybranaMaszynaDGV = wybranaMaszynaDGV;
            initDataGridViewCzesci();
            initDataGridViewSkladMaszyny();
        }
        private void initDataGridViewCzesci()
        {
            dgvCzesci.DataSource = db.v_Czesci.ToList();
            dgvCzesci.Columns[1].Visible = false;
            dgvCzesci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvCzesci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void initDataGridViewSkladMaszyny()
        {
            int wybranySklad = wybranaMaszynaDGV.ID_maszyna;
            List<v_Sklad_maszyna> skladMaszyna = db.v_Sklad_maszyna.Where(a => a.ID_maszyna == wybranySklad).ToList();
            dgvSklad.DataSource = skladMaszyna;
            dgvSklad.Columns[0].Visible = false;
            dgvSklad.Columns[1].Visible = false;
            dgvSklad.Columns[2].Visible = false;
            dgvSklad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvSklad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnDodajCzesc_Click(object sender, EventArgs e)
        {
            FormResDepCzesc formResDepCzesc = new FormResDepCzesc(db);
            formResDepCzesc.ShowDialog();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridViewCzesci();
            initDataGridViewSkladMaszyny();
        }

        private void btnPrzypisz_Click(object sender, EventArgs e)
        {
            try
            {
                Sklad_maszyna sklad = new Sklad_maszyna();
                sklad.ID_czesc = (int)dgvCzesci.CurrentRow.Cells[0].Value;
                sklad.ID_maszyna = wybranaMaszynaDGV.ID_maszyna;
                sklad.Liczba_czesci = (int)numLiczbaCzesci.Value;
                db.Sklad_maszyna.Add(sklad);
                db.SaveChanges();
                initDataGridViewSkladMaszyny();
                MessageBox.Show("Dodano część do składu maszyny!");
            }
            catch
            {
                MessageBox.Show("Wybierz poprawną część!");
            }
        }
        private void btnUsunPrzypisanie_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć " + this.dgvSklad.CurrentRow.Cells[2].Value + " ze składu " + this.dgvSklad.CurrentRow.Cells[2].Value + "?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string wybranaCzesc = this.dgvSklad.CurrentRow.Cells[1].Value.ToString();
                    int wybranaCzescID = int.Parse(wybranaCzesc);
                    string wybranaMaszyna = this.dgvSklad.CurrentRow.Cells[0].Value.ToString();
                    int wybranaMaszynaID = int.Parse(wybranaMaszyna);
                    string wybranySklad = this.dgvSklad.CurrentRow.Cells[2].Value.ToString();
                    int wybranySkladID = int.Parse(wybranySklad);
                    Sklad_maszyna danySklad = db.Sklad_maszyna.Single(a => a.ID_czesc == wybranaCzescID && a.ID_maszyna == wybranaMaszynaID && a.ID_sklad_maszyna == wybranySkladID);
                    db.Sklad_maszyna.Remove(danySklad);
                    db.SaveChanges();
                    initDataGridViewCzesci();
                    initDataGridViewSkladMaszyny();
                }
            }
            catch
            {
                MessageBox.Show("Nie można usunąć części");
            }
        }
    }
}
