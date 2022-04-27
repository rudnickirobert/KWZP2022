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
    
    public partial class FormDepartmentsAdd : Form
    {
        KWZPEntities db;
        public FormDepartmentsAdd(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            
        }
        public void showData()
        {
            dgvDepartment.DataSource = db.Dzial.ToList();
            dgvDepartment.Columns["Alert"].Visible = false;
            dgvDepartment.Columns["Etat"].Visible = false;
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            Dzial departmentNew = new Dzial();
            departmentNew.Nazwa_dzial = txtDepartment.Text;
            db.Dzial.Add(departmentNew);
            db.SaveChanges();
            MessageBox.Show("Zapisano nowe stanowisko!", "Informacja", MessageBoxButtons.OK);
            showData();
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            int idDepartment = int.Parse(this.dgvDepartment.CurrentRow.Cells[0].Value.ToString());
            Dzial departmentNew = this.db.Dzial.Single(a => a.ID_dzial == idDepartment);
            departmentNew.Nazwa_dzial = txtDepartment.Text;
            this.db.SaveChanges();
            MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
            showData();
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idDepartment = int.Parse(this.dgvDepartment.CurrentRow.Cells[0].Value.ToString());
            Dzial departmentNew = this.db.Dzial.Single(a => a.ID_dzial == idDepartment);
            txtDepartment.Text = departmentNew.Nazwa_dzial;
        }
    }
}
