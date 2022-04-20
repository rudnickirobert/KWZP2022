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
    public partial class ZamowieniaResDepFORM : Form
    {
        KWZPEntities db;
        public ZamowieniaResDepFORM(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ZamowieniaResDepFORM_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_material_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_czesc_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_narzedzie_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_maszyna_Click(object sender, EventArgs e)
        {

        }
    }
}
