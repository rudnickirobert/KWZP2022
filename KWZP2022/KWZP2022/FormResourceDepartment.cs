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
    public partial class FormResourceDepartment : Form
    {
        KWZPEntities db;
        public FormResourceDepartment(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormResDepZamowienia zamowieniaFrom = new FormResDepZamowienia(db);
            zamowieniaFrom.ShowDialog();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            FormResDepMagazyny magazynFrom = new FormResDepMagazyny(db);
            magazynFrom.ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {

        }

        private void DzialZasobowFORM_Load(object sender, EventArgs e)
        {

        }
    }
}
