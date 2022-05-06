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
    public partial class FormResDepDodajCzesc : Form
    {
        KWZPEntities db;
        public FormResDepDodajCzesc(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
        private void btnDodajRodzaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaRodzaj.Text))
            {
                MessageBox.Show("Wprowadź dane!");
            }
            else
            {
                Rodzaj_czesc rodzajCzesc = new Rodzaj_czesc();
                rodzajCzesc.Nazwa_rodzaj_czesc = txtNazwaRodzaj.Text;
                db.Rodzaj_czesc.Add(rodzajCzesc);
                db.SaveChanges();
                MessageBox.Show("Poprawnie dodano rodzaj części: " + txtNazwaRodzaj.Text);
                this.Close();
            }
        }
    }
}
