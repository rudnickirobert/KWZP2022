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
    public partial class FormHRDepartmentTimesheets : Form
    {
        KWZPEntities db;
        public FormHRDepartmentTimesheets(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbPracownik.DataSource = db.Pracownik.ToList();
            cmbPracownik.DisplayMember = "Nazwisko";
            cmbPracownik.ValueMember = "ID_pracownik";
            cmbNieobecnosc.DataSource = db.Rodzaj_nieobecnosci.ToList();
            cmbNieobecnosc.DisplayMember = "Symbol";
            cmbNieobecnosc.ValueMember = "ID_rodzaj_nieobecnosci";
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvNieobecnosc.DataSource = db.v_Nieobecnosc.ToList();
            dgvNieobecnosc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnDodajNieobecnosc_Click(object sender, EventArgs e)
        {
            Nieobecnosc nieobecnosc = new Nieobecnosc();
            nieobecnosc.ID_pracownik = (int)cmbPracownik.SelectedValue;
            nieobecnosc.ID_rodzaj_nieobecnosci = (int)cmbNieobecnosc.SelectedValue;
            nieobecnosc.Data_od = dtOD.Value;
            nieobecnosc.Data_do = dtDO.Value;
            db.Nieobecnosc.Add(nieobecnosc);
            db.SaveChanges();
            initDataGridView();
            MessageBox.Show("Poprawnie dodano nieobecność do bazy danych");
        }
    }
}
