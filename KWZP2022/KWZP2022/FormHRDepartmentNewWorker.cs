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
    public partial class FormHRDepartmentNewWorker : Form
    {
        KWZPEntities db;
        public FormHRDepartmentNewWorker(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        
    }
}
