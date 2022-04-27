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
    public partial class FormDodajAlert : Form
    {

        KWZPEntities db;
        public FormDodajAlert(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbDzial.DataSource = db.Dzial.ToList();
            cmbDzial.DisplayMember = "Nazwa_dzial";
            cmbDzial.ValueMember = "ID_dzial";
        }

        private void btnDodajAlert_Click(object sender, EventArgs e)
        {
            Alert dodajAlert = new Alert();
            dodajAlert.ID_dzial = (int)cmbDzial.SelectedValue;
            dodajAlert.Tresc = txtTresc.Text;
            dodajAlert.Czy_odczytano = Convert.ToBoolean(0);
            db.Alert.Add(dodajAlert);
            db.SaveChanges();
            MessageBox.Show("Dodano alert");
        }
    }
}
