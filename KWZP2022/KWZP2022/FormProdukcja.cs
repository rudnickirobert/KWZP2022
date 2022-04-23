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
    public partial class FormProdukcja : Form
    {
        KWZPEntities db;
        public FormProdukcja(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnProdukty_Click(object sender, EventArgs e)
        {
            FormProdukt produktFrom = new FormProdukt(db);
            produktFrom.ShowDialog();
         
        }

        private void btnPolprodukty_Click(object sender, EventArgs e)
        {
            FormSkladProdukt polproduktForm = new FormSkladProdukt(db);
            polproduktForm.ShowDialog();
        }

        private void btnStanowiska_Click(object sender, EventArgs e)
        {
            FormSlownikStanowisko slownikStanowiskoForm = new FormSlownikStanowisko(db);
            slownikStanowiskoForm.ShowDialog();
        }

        private void btnWytwarzanie_Click(object sender, EventArgs e)
        {
            FormWytwarzanie wytwarzanieForm = new FormWytwarzanie(db);
            wytwarzanieForm.ShowDialog();
        }
    }
}
