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
    public partial class ResDepFORMMagazyn : Form
    {
        KWZPEntities db;
        public ResDepFORMMagazyn(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ResDepFORMMagazyn_Load(object sender, EventArgs e)
        {

        }

        private void btnMagazyn_material_Click(object sender, EventArgs e)
        {

        }

        private void btnMagazyn_czesc_Click(object sender, EventArgs e)
        {

        }

        private void btnMagazyn_narzedzie_Click(object sender, EventArgs e)
        {

        }

        private void btnMagazyn_maszyna_Click(object sender, EventArgs e)
        {

        }
    }
}
