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
    public partial class CzasPracyPM_Form : Form
    {
        KWZPEntities db;
        public CzasPracyPM_Form(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
    }
}
