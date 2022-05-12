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
    public partial class FormHRDepartmentNewSalary : Form
    {
        KWZPEntities db;
        public FormHRDepartmentNewSalary(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            comboBoxAddValue();
            showData();
        }
        private void showData()
        {
            this.dgvSalary.DataSource = db.v_Wyplata_suma.ToList();
            dgvSalary.Columns["ID_pracownik"].Visible = false;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void comboBoxAddValue()
        {
            cbIDpracownik.DataSource = this.db.Pracownik.ToList();
            cbIDpracownik.ValueMember = "ID_pracownik";
            cbIDpracownik.DisplayMember = "ID_pracownik";
        }

        private void btnSaveSalary_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbIDpracownik.Text))
            {
                MessageBox.Show("Wprowadź prawcownika!");
            }
            else 
            {
                Wyplata wyplata = new Wyplata();
                wyplata.ID_Pracownik = (int)cbIDpracownik.SelectedValue;
                wyplata.Data_wyplaty = dSalary.Value;
                db.Wyplata.Add(wyplata);
                db.SaveChanges();
                showData();

            }
        }
    }
}
