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
    public partial class FormHRDepartmentOvertime : Form
    {
        KWZPEntities db;
        public FormHRDepartmentOvertime(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            comboBoxAddValue();
            showData();
        }
        private void showData()
        {
            this.dgvNadgodziny.DataSource = db.Nadgodziny.ToList();
            dgvNadgodziny.Columns["ID_nadgodziny"].Visible = false;
            this.dgvNadgodziny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void comboBoxAddValue()
        {
            cmbPracownik.DataSource = this.db.Pracownik.ToList();
            cmbPracownik.ValueMember = "ID_pracownik";
            cmbPracownik.DisplayMember = "ID_pracownik";
        }
        private void btnDodajNadgodziny_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbPracownik.Text))
            {
                MessageBox.Show("Wprowadź prawcownika!");
            }
            else
            {
                Nadgodziny nadgodziny = new Nadgodziny();
                nadgodziny.ID_pracownik = (int)cmbPracownik.SelectedValue;
                nadgodziny.Data_nadgodziny = dtnadgodziny.Value;
                nadgodziny.Czas = Convert.ToInt32(tbCzasNadgodzin.Text);
                db.Nadgodziny.Add(nadgodziny);
                db.SaveChanges();
                showData();
            }
        }
    }
}
