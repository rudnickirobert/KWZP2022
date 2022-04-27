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
    public partial class FormResDepServicesReplacement : Form
    {
        KWZPEntities db;
        public FormResDepServicesReplacement(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
            cmbMaszyna.DataSource = db.v_Maszyna_nr_seryjny.ToList();
            cmbMaszyna.DisplayMember = "Maszyna_nr";
            cmbMaszyna.ValueMember = "ID_maszyna_nr";
            cmbObsluga.DataSource = db.v_Obsluga_cmb_wymiana.ToList();
            cmbObsluga.DisplayMember = "ComboObsluga";
            cmbObsluga.ValueMember = "ID";
            cmbCzesc.DataSource = db.Czesc.ToList();
            cmbCzesc.DisplayMember = "Nazwa_czesc";
            cmbCzesc.ValueMember = "ID_czesc";
        }
        private void initDataGridView()
        {
            dgvWymianaCzesc.DataSource = db.v_Wymiana_czesc.ToList();
            dgvWymianaCzesc.Columns[1].Visible = false;
            dgvWymianaCzesc.Columns[2].Visible = false;
            dgvWymianaCzesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodajWymiane_Click(object sender, EventArgs e)
        {
            Wymiana_czesc wymiana = new Wymiana_czesc();
            wymiana.ID_obsluga = (int)cmbObsluga.SelectedValue;
            wymiana.ID_maszyna_nr = (int)cmbMaszyna.SelectedValue;
            wymiana.ID_czesc = (int)cmbCzesc.SelectedValue;
            db.Wymiana_czesc.Add(wymiana);
            db.SaveChanges();
            initDataGridView();
        }

        private void btnEdytujWymiana_Click(object sender, EventArgs e)
        {
            if (this.dgvWymianaCzesc.CurrentRow.Cells[0].Value != null)
            {
                int daneWymiana = int.Parse(this.dgvWymianaCzesc.CurrentRow.Cells[0].Value.ToString());
                Wymiana_czesc daneWymianaID = this.db.Wymiana_czesc.Single(a => a.ID_obsluga == daneWymiana);
                daneWymianaID.ID_obsluga = (int)cmbObsluga.SelectedValue;
                daneWymianaID.ID_maszyna_nr = (int)cmbMaszyna.SelectedValue;
                daneWymianaID.ID_czesc = (int)cmbCzesc.SelectedValue;
                db.SaveChanges();
                initDataGridView();
                MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nie zaznaczono maszyny!", "Błąd", MessageBoxButtons.OK);
            }
        }

        private void btnUsunWymiana_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wymienianą część: " + this.dgvWymianaCzesc.CurrentRow.Cells[3].Value + "?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string current_wymiana = this.dgvWymianaCzesc.CurrentRow.Cells[0].Value.ToString();
                    int daneINT = int.Parse(current_wymiana);
                    Wymiana_czesc danaWymiana = db.Wymiana_czesc.Single(a => a.ID_obsluga == daneINT);
                    this.db.Wymiana_czesc.Remove(danaWymiana);
                    db.SaveChanges();
                    initDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Nie można usunąć części");
            }

        }
        private void dgvWymianaCzesc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvWymianaCzesc.Rows[e.RowIndex];
                cmbCzesc.SelectedValue = row.Cells[6].Value;
                cmbMaszyna.SelectedValue = row.Cells[4].Value;
                cmbObsluga.SelectedValue = row.Cells[0].Value;
            }
        }

        private void btnZatwierdzObsluga_Click(object sender, EventArgs e)
        {
            lblMaszyna.Visible = true;
            cmbMaszyna.Visible = true;
            btnZatwierdzMaszyna.Visible=true;
        }

        private void btnZatwierdzMaszyna_Click(object sender, EventArgs e)
        {
            lblCzesc.Visible = true;
            cmbCzesc.Visible=true;
            btnDodajWymiane.Visible=true;
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
