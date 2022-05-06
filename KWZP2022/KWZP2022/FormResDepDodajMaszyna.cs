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
    public partial class FormResDepDodajMaszyna : Form
    {
        KWZPEntities db;
        public FormResDepDodajMaszyna(KWZPEntities db)
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
                Rodzaj_maszyna rodzajMaszyna = new Rodzaj_maszyna();
                rodzajMaszyna.Nazwa_rodzaj_maszyna = txtNazwaRodzaj.Text;
                rodzajMaszyna.Opis = txtOpis.Text;
                db.Rodzaj_maszyna.Add(rodzajMaszyna);
                db.SaveChanges();
                MessageBox.Show("Poprawnie dodano rodzaj maszyny: " + txtNazwaRodzaj.Text);
                this.Close();
            }
        }
    }
}
