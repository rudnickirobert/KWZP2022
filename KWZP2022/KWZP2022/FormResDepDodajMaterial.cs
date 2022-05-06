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
    public partial class FormResDepDodajMaterial : Form
    {
        KWZPEntities db;
        public FormResDepDodajMaterial(KWZPEntities db)
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
                Rodzaj_material rodzajMaterial = new Rodzaj_material();
                rodzajMaterial.Nazwa_rodzaj_material = txtNazwaRodzaj.Text;
                db.Rodzaj_material.Add(rodzajMaterial);
                db.SaveChanges();
                MessageBox.Show("Poprawnie dodano rodzaj materiału: " + txtNazwaRodzaj.Text);
                this.Close();
            }
        }
    }
}
