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
    public partial class FormKontrolaJakosci : Form
    {
        KWZPEntities db;
        public FormKontrolaJakosci(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridViewKontrolaProdukt();

        }

        private void initDataGridViewKontrolaProdukt()
        {

        }
    }
}