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
    public partial class FormStatystykiProdukcja : Form
    {
        KWZPEntities db;
        public FormStatystykiProdukcja(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnGodziny_Click(object sender, EventArgs e)
        {
            FormCzasPracyProdukcja czasPracyProdukcjaForm = new FormCzasPracyProdukcja(db);
            czasPracyProdukcjaForm.ShowDialog();
        }

        private void btnKoszt_Click(object sender, EventArgs e)
        {
            FormKosztProdukcja kosztProdukcjaForm = new FormKosztProdukcja(db);
            kosztProdukcjaForm.ShowDialog();
        }
    }
}
