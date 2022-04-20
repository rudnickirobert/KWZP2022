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
    public partial class ProdukcjaFrom : Form
    {
        KWZPEntities db;
        public ProdukcjaFrom(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnProdukty_Click(object sender, EventArgs e)
        {
            ProduktForm produktFrom = new ProduktForm(db);
            produktFrom.ShowDialog();
         
        }

        private void btnPolprodukty_Click(object sender, EventArgs e)
        {
            PolproduktForm polproduktForm = new PolproduktForm(db);
            polproduktForm.ShowDialog();
        }

        private void btnStanowiska_Click(object sender, EventArgs e)
        {
            SlownikStanowiskoForm slownikStanowiskoForm = new SlownikStanowiskoForm(db);
            slownikStanowiskoForm.ShowDialog();
        }

        private void btnParpol_Click(object sender, EventArgs e)
        {
            Parametr_polproduktForm parametr_PolproduktForm = new Parametr_polproduktForm(db);
            parametr_PolproduktForm.ShowDialog();
        }
    }
}
