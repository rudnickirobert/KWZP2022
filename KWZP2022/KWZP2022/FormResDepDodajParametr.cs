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
    public partial class FormResDepDodajParametr : Form
    {
        KWZPEntities db;
        public FormResDepDodajParametr(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbJednostka.DataSource = db.Jednostka.ToList();
            cmbJednostka.DisplayMember = "Nazwa_jednostka";
            cmbJednostka.ValueMember = "ID_jednostka";
        }

        private void btnDodajParametr_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaParametr.Text))
            {
                MessageBox.Show("Wprowadź dane!");
            }
            else
            {
                Rodzaj_parametr rodzajParametr = new Rodzaj_parametr();
                rodzajParametr.Nazwa_rodzaj_parametr = txtNazwaParametr.Text;
                rodzajParametr.ID_jednostka = (int)cmbJednostka.SelectedValue;
                db.Rodzaj_parametr.Add(rodzajParametr);
                db.SaveChanges();
                MessageBox.Show("Poprawnie dodano parametr " + txtNazwaParametr.Text);
                this.Close();
            }
        }

        private void btnDodajJednostka_Click(object sender, EventArgs e)
        {
            FormResDepDodajJednostka dodajJednostka = new FormResDepDodajJednostka(db);
            dodajJednostka.ShowDialog();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            cmbJednostka.DataSource = db.Jednostka.ToList();
            cmbJednostka.DisplayMember = "Nazwa_jednostka";
            cmbJednostka.ValueMember = "ID_jednostka";
        }
    }
}
