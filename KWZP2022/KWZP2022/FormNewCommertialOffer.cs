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
            
            //comboBoxNoOrder.DataSource
        }

        private void btnAddNewOffer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.db.Oferta_handlowa.Where(a => !(a.ID_status_oferta == 1 || a.ID_status_oferta != 3)).ToList();
        }
    }
}
