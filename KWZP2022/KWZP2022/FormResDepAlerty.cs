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
    public partial class FormResDepAlerty : Form
    {
        KWZPEntities db;
        public FormResDepAlerty(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            dgvAlerty.DataSource = db.v_Alerty_ResorceDepartment_nieodczytane.ToList();
            dgvAlerty.Columns[1].Visible = false;
            dgvAlerty.Columns[0].Visible = false;
            dgvAlerty.Columns[4].Visible = false;
            dgvAlerty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodajAlert_Click(object sender, EventArgs e)
        {
            FormDodajAlert dodajAlert = new FormDodajAlert(db);
            dodajAlert.ShowDialog();
        }

        private void btnOdczytano_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy alert: " + this.dgvAlerty.CurrentRow.Cells[3].Value + " został odczytany?", "Odczytano Alert?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int odczytano = int.Parse(this.dgvAlerty.CurrentRow.Cells[0].Value.ToString());
                Alert odczytanoID = this.db.Alert.Single(a => a.ID_alert == odczytano);
                odczytanoID.Czy_odczytano = Convert.ToBoolean(1);
                db.SaveChanges();
                initDataGridView();
            }
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
        }
    }
}
