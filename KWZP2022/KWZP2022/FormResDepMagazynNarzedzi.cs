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
    public partial class FormResDepMagazynNarzedzi : Form
    {
        KWZPEntities db;
        public FormResDepMagazynNarzedzi(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }
        private void btnDodajNarzedzie_Click(object sender, EventArgs e)
        {
            FormResDepZamowienieNarzedzia narzedzieForm = new FormResDepZamowienieNarzedzia(db);
            narzedzieForm.ShowDialog();
        }
        private void initDataGridView()
        {
            dgvMagazynNarzedzie.DataSource = db.v_Magazyn_narzedzia_nieuzywane.ToList();
            dgvMagazynNarzedzie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMagazynNarzedzie.Columns[2].Visible = false;
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
        }

        private void dgvMagazynNarzedzie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int wybraneNarzedzie = int.Parse(this.dgvMagazynNarzedzie.CurrentRow.Cells[2].Value.ToString());
            Narzedzie wybraneNarzedzieDGV = this.db.Narzedzie.Single(a => a.ID_narzedzie == wybraneNarzedzie);
            FormResDepHistoriaZamowienNarzedzia formResDepHisZamNarz = new FormResDepHistoriaZamowienNarzedzia(db, wybraneNarzedzieDGV);
            formResDepHisZamNarz.ShowDialog();
        }
    }
}
