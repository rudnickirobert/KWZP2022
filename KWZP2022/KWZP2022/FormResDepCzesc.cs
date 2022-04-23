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
    public partial class FormResDepCzesc : Form
    {
        KWZPEntities db;
        public FormResDepCzesc(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbRodzajCzesc.DataSource = db.Rodzaj_material.ToList();
            cmbRodzajCzesc.DisplayMember = "Nazwa_rodzaj_czesc";
            cmbRodzajCzesc.ValueMember = "ID_rodzaj_czesc";
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvCzesc.DataSource = db.Czesc.ToList();
            for (int i = 0; i < dgvCzesc.Columns.Count; i++)
            {
                dgvCzesc.Columns[i].Visible = false;
            }
            dgvCzesc.Columns["ID_czescl"].Visible = true;
            dgvCzesc.Columns[0].HeaderText = "ID";
            dgvCzesc.Columns["Nazwa_czesc"].Visible = true;
            dgvCzesc.Columns["ID_rodzaj_czesc"].Visible = true;
            dgvCzesc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvCzesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
