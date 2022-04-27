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
    public partial class FormPosistionsAdd : Form
    {
        KWZPEntities db;
        public FormPosistionsAdd(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
        }
        public void showData()
        {
            dgvPosition.DataSource = db.Stanowisko.ToList();
            dgvPosition.Columns["Etat"].Visible = false;
            this.dgvPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnPositionAdd_Click(object sender, EventArgs e)
        {
            Stanowisko positionNew = new Stanowisko();
            positionNew.Nazwa_stanowiska = txtPosition.Text;
            db.Stanowisko.Add(positionNew);
            db.SaveChanges();
            MessageBox.Show("Zapisano nowy dział!", "Informacja", MessageBoxButtons.OK);
            showData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             int idPosition = int.Parse(this.dgvPosition.CurrentRow.Cells[0].Value.ToString());
             Stanowisko stanowiskoNowe = this.db.Stanowisko.Single(a => a.ID_stanowisko == idPosition);
             stanowiskoNowe.Nazwa_stanowiska = txtPosition.Text;
             this.db.SaveChanges();
             MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
             showData();
            
        }
    }
}
