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
            ComboboxProdukt();
            

        }

        private void refreshComboboxes()
        {
            ComboboxProdukt();
            ComboboxParametr();
        }

        private void ComboboxProdukt()
        {
            cbProdukt.DataSource = db.Produkt.ToList();
            cbProdukt.DisplayMember = "Nazwa_produkt";
            cbProdukt.ValueMember = "ID_produkt";
            cbProdukt.SelectedValue = 0;
        }


        private void ComboboxParametr()
        {
            string produkt = cbProdukt.SelectedValue.ToString();
            int produktID = int.Parse(produkt);
            cbParametr.DataSource = db.Parametr_produkt.Where(a => a.ID_produkt == produktID).ToList();
            cbParametr.DisplayMember = "Parametr";
            cbParametr.ValueMember = "ID_parametr_produkt";
        }

        private void cbProdukt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxParametr();
        }
    }
}
