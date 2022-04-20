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
    public partial class DzialZasobowFORM : Form
    {
        KWZPEntities db;
        public DzialZasobowFORM(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {

        }

        private void btnService_Click(object sender, EventArgs e)
        {

        }
    }
}
