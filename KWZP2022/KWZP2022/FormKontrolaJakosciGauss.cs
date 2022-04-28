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
    public partial class FormKontrolaJakosciGauss : Form
    {
        KWZPEntities db;
        public FormKontrolaJakosciGauss(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            comboboxProdukt();
            comboboxParametr();
            this.db = new KWZPEntities();       
        }

        private void refreshComboboxes()
        {
            comboboxProdukt();
            comboboxParametr();
        }

        private void comboboxProdukt()
        {            
            cbProdukt.DataSource = this.db.Produkt.ToList();
            cbProdukt.DisplayMember = "Nazwa_produkt";
            cbProdukt.ValueMember = "ID_produkt";            
        }


        private void comboboxParametr()
        {           
            int produktID = int.Parse(cbProdukt.SelectedValue.ToString());
           
            cbParametr.DataSource = this.db.v_Parametry_produkt.Where(a => a.ID_produkt == produktID).ToList();
            cbParametr.ValueMember = "ID_parametr_produkt";
            cbParametr.DisplayMember = "Parametr";           

        }

        private void cbProdukt_SelectionChangeCommited(object sender, EventArgs e)
        {
            comboboxParametr();
        }
    }
}
