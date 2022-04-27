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
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
        }
    }
}
