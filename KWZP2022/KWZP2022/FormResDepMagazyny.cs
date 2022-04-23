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
    public partial class FormResDepMagazyny : Form
    {
        KWZPEntities db;
        public FormResDepMagazyny(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
        private void btnMagazyn_czesc_Click(object sender, EventArgs e)
        {
            FormResDepMagazynCzesci magazynCzesci = new FormResDepMagazynCzesci(db);
            magazynCzesci.ShowDialog();
        }
        private void btnMagazyn_material_Click(object sender, EventArgs e)
        {
            FormResDepMagazynMaterialow magazynMaterialow = new FormResDepMagazynMaterialow(db);
            magazynMaterialow.ShowDialog();
        }
        private void btnMagazyn_narzedzie_Click(object sender, EventArgs e)
        {
            FormResDepMagazynNarzedzi magazynNarzedzi = new FormResDepMagazynNarzedzi(db);
            magazynNarzedzi.ShowDialog();
        }
        private void btnMagazyn_maszyna_Click(object sender, EventArgs e)
        {
            FormResDepMagazynMaszyn magazynMaszyn = new FormResDepMagazynMaszyn(db);
            magazynMaszyn.ShowDialog();
        }
    }
}
