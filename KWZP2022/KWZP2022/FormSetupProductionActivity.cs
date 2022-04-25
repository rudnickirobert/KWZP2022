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
    public partial class FormSetupProductionActivity : Form
    {
        KWZPEntities db;
        public FormSetupProductionActivity(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            ShowData();
        }
        public void ShowData()
        {
            dgvActivity.DataSource = db.v_Czynnosc_produkcyjna.ToList();
            this.dgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            Czynnosc_produkcyjna czynnoscnew = new Czynnosc_produkcyjna();
            czynnoscnew.Nazwa = txtActivity.Text;
            db.Czynnosc_produkcyjna.Add(czynnoscnew);
            db.SaveChanges();
            MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
            ShowData();
        }



        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_czynnosc = int.Parse(this.dgvActivity.CurrentRow.Cells[0].Value.ToString());
            Czynnosc_produkcyjna czynnosc = this.db.Czynnosc_produkcyjna.Single(a => a.ID_czynnosc_produkcyjna == id_czynnosc);
            txtActivity.Text = czynnosc.Nazwa;
        }

        private void btnEditActivity_Click(object sender, EventArgs e)
        {
            int id_czynnosc = int.Parse(this.dgvActivity.CurrentRow.Cells[0].Value.ToString());
            Czynnosc_produkcyjna czynnosc = this.db.Czynnosc_produkcyjna.Single(a => a.ID_czynnosc_produkcyjna == id_czynnosc);
            czynnosc.Nazwa = txtActivity.Text;
            this.db.SaveChanges();
            MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
