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
    public partial class FormResDepServicesWorkers : Form
    {
        KWZPEntities db;
        public FormResDepServicesWorkers(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbObsluga.DataSource = db.v_Obsluga_cmb.ToList();
            cmbObsluga.DisplayMember = "ComboObsluga";
            cmbObsluga.ValueMember = "ID";
            cmbPracownik.DataSource = db.v_Pracownik_obslugi.ToList();
            cmbPracownik.DisplayMember = "Pracownik";
            cmbPracownik.ValueMember = "ID_pracownik";
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvObsluga.DataSource = db.v_Obsluga_pracownik.ToList();
            dgvObsluga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            //Sklad_obsluga obslugaPracownik = new Sklad_obsluga();
            //obslugaPracownik.ID_obsluga = (int)cmbObsluga.SelectedValue;
            //obslugaPracownik.ID_pracownik = (int)cmbPracownik.SelectedValue;
            //db.Sklad_obsluga.Add(obslugaPracownik);
            //db.SaveChanges();
            //initDataGridView();
            //MessageBox.Show("Poprawnie dodano pracownika do obsługi");
        }

        private void btnEdytujPracownika_Click(object sender, EventArgs e)
        {

        }

        private void btnUsunPracownika_Click(object sender, EventArgs e)
        {

        }
    }
}
