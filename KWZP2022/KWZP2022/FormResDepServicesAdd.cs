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
    public partial class FormResDepServicesAdd : Form
    {
        KWZPEntities db;
        public FormResDepServicesAdd(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbObsluga.DataSource = db.Rodzaj_obsluga.ToList();
            cmbObsluga.DisplayMember = "Nazwa_rodzaj_obsluga";
            cmbObsluga.ValueMember = "ID_rodzaj_obsluga";
            cmbStanowisko.DataSource = db.v_Stanowisko_produkcyjne.ToList();
            cmbStanowisko.DisplayMember = "Nazwa_stanowiska";
            cmbStanowisko.ValueMember = "ID";
        }
        private void btnDodajObsluge_Click(object sender, EventArgs e)
        {
            Obsluga nowaObsluga = new Obsluga();
            nowaObsluga.ID_rodzaj_obsluga = (int)cmbObsluga.SelectedValue;
            nowaObsluga.ID_stanowisko_produkcyjne = (int)cmbStanowisko.SelectedValue;
            nowaObsluga.Data_od = System.DateTime.Now;
            db.Obsluga.Add(nowaObsluga);
            db.SaveChanges();
            MessageBox.Show("Dodano Obsługę!");
            this.Close();   
        }
    }
}
