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
    public partial class FormNewCommertialOffer : Form
    {
        KWZPEntities db;
        public FormNewCommertialOffer(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            comboBoxData();
        }
        private void comboBoxData()
        {
            comboBoxEmployeeData();
            comboBoxNoOrderData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxEmployeeData()
        {
            comboBoxEmployee.DataSource = this.db.v_Pracownik_dzial.ToList();
            comboBoxEmployee.ValueMember = "ID_pracownik";
            comboBoxEmployee.DisplayMember = "Nazwisko";
        }
        private void comboBoxNoOrderData()
        {
            comboBoxNoOrder.DataSource = this.db.v_Zamowienia_niesprzedane.ToList();
            comboBoxNoOrder.ValueMember = "ID_zamowienie";
            comboBoxNoOrder.DisplayMember = "ID_zamowienie";
        }

        private void btnAddNewOffer_Click(object sender, EventArgs e)
        {
           // this.dataGridView1.DataSource = this.db.Oferta_handlowa.Single(a => a.ID_status_oferta == 1);
           //this.dataGridView1.DataSource = this.db.
        }
    }
}
