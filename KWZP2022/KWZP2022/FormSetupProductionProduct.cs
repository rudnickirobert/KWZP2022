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
    public partial class FormSetupProductionProduct : Form
    {
        KWZPEntities db;
        public FormSetupProductionProduct(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            ComboBox();
        }
        private void showData()
        {
            dtbDataStart.DataSource = db.v_Proces_wytwarzanie_produkt.ToList();
            this.dtbDataStart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ComboBox()
        {
            cbProdukt.DataSource = this.db.Produkts.ToList();
            cbProdukt.ValueMember = "ID_produkt";
            cbProdukt.DisplayMember = "Nazwa_produkt";
            cbCzynnoscProdukcyjna.DataSource = this.db.Czynnosc_produkcyjna.ToList();
            cbCzynnoscProdukcyjna.ValueMember = "ID_czynnosc_produkcyjna";
            cbCzynnoscProdukcyjna.DisplayMember = "Nazwa";
            cbSzacowanyCzas.DataSource = this.db.Proces_produkt_czynnosc.ToList();
            cbSzacowanyCzas.ValueMember = "ID_proces_produkt";
            cbSzacowanyCzas.DisplayMember = "Czas_trwania";
        }
        private void btnDodajPrcoes_Click(object sender, EventArgs e)
        {
            if (cbProdukt.Text.Length > 0 && cbCzynnoscProdukcyjna.Text.Length > 0 && cbSzacowanyCzas.Text.Length > 0 )
            {
                Produkt produkt = new Produkt();
                produkt.Nazwa_produkt = cbProdukt.Text;    
                Czynnosc_produkcyjna czynnosc_produkcyjna = new Czynnosc_produkcyjna();
                czynnosc_produkcyjna.Nazwa = cbCzynnoscProdukcyjna.Text;
                Proces_produkt_czynnosc proces = new Proces_produkt_czynnosc();
                proces.Czas_trwania = Int32.Parse(cbSzacowanyCzas.Text);
                db.Produkts.Add(produkt);
                db.Czynnosc_produkcyjna.Add(czynnosc_produkcyjna);
                db.Proces_produkt_czynnosc.Add(proces);
                db.SaveChanges();
                MessageBox.Show("Dodano nowy proces!", "Informacja", MessageBoxButtons.OK);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            FormSetupProductionActivity formSetupProductionActivity = new FormSetupProductionActivity(db);
            formSetupProductionActivity.ShowDialog();
        }
    }
}