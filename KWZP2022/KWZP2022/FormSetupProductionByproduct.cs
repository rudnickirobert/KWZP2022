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
    public partial class FormSetupProductionByproduct : Form
    {
        KWZPEntities db;
        public FormSetupProductionByproduct(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            ComboBox();
        }
        private void showData()
        {
            var datavProces = from v_Proces_polprodukt_czynnosc in db.v_Proces_polprodukt_czynnosc
                              select new
                              {
                                  v_Proces_polprodukt_czynnosc.Półprodukt,
                                  v_Proces_polprodukt_czynnosc.Czynność,
                                  v_Proces_polprodukt_czynnosc.Czas_wytwarzania__h_
                              };
            dtbDataStart.DataSource = db.v_Proces_polprodukt_czynnosc.ToList();
            this.dtbDataStart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ComboBox()
        {
            cbPolprodukt.DataSource = this.db.Slownik_polprodukt.ToList();
            cbPolprodukt.ValueMember = "ID_polprodukt";
            cbPolprodukt.DisplayMember = "Nazwa";
            cbCzynnoscProdukcyjna.DataSource = this.db.Czynnosc_produkcyjna.ToList();
            cbCzynnoscProdukcyjna.ValueMember = "ID_czynnosc_produkcyjna";
            cbCzynnoscProdukcyjna.DisplayMember = "Nazwa";
            cbSzacowanyCzas.DataSource = this.db.Proces_polprodukt_czynnosc.ToList();
            cbSzacowanyCzas.ValueMember = "ID_proces_polprodukt";
            cbSzacowanyCzas.DisplayMember = "Czas_trwania";
        }

        private void btnDodajProces_Click(object sender, EventArgs e)
        {
            if (cbPolprodukt.Text.Length > 0 && cbCzynnoscProdukcyjna.Text.Length > 0 && cbSzacowanyCzas.Text.Length > 0)
            {
                Produkt produkt = new Produkt();
                produkt.Nazwa_produkt = cbPolprodukt.Text;
                Czynnosc_produkcyjna czynnosc_produkcyjna = new Czynnosc_produkcyjna();
                czynnosc_produkcyjna.Nazwa = cbCzynnoscProdukcyjna.Text;
                Proces_produkt_czynnosc proces = new Proces_produkt_czynnosc();
                proces.Czas_trwania = Int32.Parse(cbSzacowanyCzas.Text);
                db.Produkt.Add(produkt);
                db.Czynnosc_produkcyjna.Add(czynnosc_produkcyjna);
                db.Proces_produkt_czynnosc.Add(proces);
                db.SaveChanges();
                MessageBox.Show("Dodano nowy proces!","Informacja", MessageBoxButtons.OK);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
