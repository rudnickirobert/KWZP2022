﻿using System;
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
    public partial class StartForm : Form
    {
        KWZPEntities1 db = new KWZPEntities1();

        public StartForm()
        {
            InitializeComponent();
            this.BackgroundImage=Properties.Resources.logo;
            label1.BackColor = System.Drawing.Color.Transparent;          
        }
       

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
