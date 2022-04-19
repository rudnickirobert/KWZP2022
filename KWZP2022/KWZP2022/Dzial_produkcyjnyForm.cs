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
    public partial class Dzial_produkcyjnyForm : Form
    {
        KWZPEntities db = new KWZPEntities();

        public Dzial_produkcyjnyForm()
        {
            InitializeComponent();
        }

        private void btnProdukty_Click(object sender, EventArgs e)
        {
            var Produkty = new ProduktyForm();
            Produkty.Show();
        }
    }
}
