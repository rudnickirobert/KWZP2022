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
    public partial class FormKosztProdukcja : Form
    {
        KWZPEntities db;
        public FormKosztProdukcja(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initComboboxProdukt();

        }

        private void initComboboxProdukt()
        {
            cbProdukt.DataSource = db.Produkt.ToList();
            cbProdukt.ValueMember = "ID_produkt";
            cbProdukt.DisplayMember = "Nazwa_produkt";
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            int produktID = int.Parse(cbProdukt.SelectedValue.ToString());
            dgvSkladProdukt.DataSource = 0;
            System.Linq.IQueryable vSkladProdukt = db.v_Sklad_produkt_ewidencja.Where(a => a.ID_produkt == produktID);
            int vSkladProduktInt = vSkladProdukt.Cast<v_Sklad_produkt_ewidencja>().Where(a => a.ID_produkt > 0).Count();
            if (vSkladProduktInt > 0)
            {
                dgvSkladProdukt.DataSource = vSkladProdukt.Cast<v_Sklad_produkt_ewidencja>().ToList();
                this.dgvSkladProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

    }
}
