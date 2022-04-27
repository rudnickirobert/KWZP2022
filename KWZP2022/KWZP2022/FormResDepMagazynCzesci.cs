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
    public partial class FormResDepMagazynCzesci : Form
    {
        KWZPEntities db;
        public FormResDepMagazynCzesci(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }
        private void btnDodajCzesc_Click(object sender, EventArgs e)
        {
            FormResDepZamowienieCzesci czescForm = new FormResDepZamowienieCzesci(db);
            czescForm.ShowDialog();
        }
        private void initDataGridView()
        {
            dgvMagazynCzesc.DataSource = db.v_Magazyn_czesci_aktualny.ToList();
            dgvMagazynCzesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridView();
        }
    }
}
