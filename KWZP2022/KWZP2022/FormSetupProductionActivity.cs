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
            showData();
        }
        public void showData()
        {
            dgvActivity.DataSource = db.v_Czynnosc_produkcyjna.ToList();
            this.dgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            Czynnosc_produkcyjna czynnoscNowa = new Czynnosc_produkcyjna();
            czynnoscNowa.Nazwa = txtActivity.Text;
            db.Czynnosc_produkcyjna.Add(czynnoscNowa);
            db.SaveChanges();
            MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
            showData();
        }

        private void btnEditActivity_Click(object sender, EventArgs e)
        {
            int idCzynnosc = int.Parse(this.dgvActivity.CurrentRow.Cells[0].Value.ToString());
            Czynnosc_produkcyjna czynnoscEdytuj = this.db.Czynnosc_produkcyjna.Single(a => a.ID_czynnosc_produkcyjna == idCzynnosc);
            czynnoscEdytuj.Nazwa = txtActivity.Text;
            this.db.SaveChanges();
            MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
        }

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCzynnosc = int.Parse(this.dgvActivity.CurrentRow.Cells[0].Value.ToString());
            Czynnosc_produkcyjna czynnoscWybrana = this.db.Czynnosc_produkcyjna.Single(a => a.ID_czynnosc_produkcyjna == idCzynnosc);
            txtActivity.Text = czynnoscWybrana.Nazwa;
        }
    }
}
