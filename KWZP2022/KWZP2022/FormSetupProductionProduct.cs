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
            comboBoxAddValue();
        }
        private void showData()
        {
            dtbDataStart.DataSource = db.v_Proces_produkt_czynnosc_projekt.ToList();
            dtbDataStart.Columns["ID_Produktu"].Visible = false;
            this.dtbDataStart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void comboBoxAddValue()
        {
            cbProdukt.DataSource = this.db.Produkt.ToList();
            cbProdukt.ValueMember = "ID_produkt";
            cbProdukt.DisplayMember = "Nazwa_produkt";
            cbCzynnoscProdukcyjna.DataSource = this.db.Czynnosc_produkcyjna.ToList();
            cbCzynnoscProdukcyjna.ValueMember = "ID_czynnosc_produkcyjna";
            cbCzynnoscProdukcyjna.DisplayMember = "Nazwa";
        }
        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            FormSetupProductionActivity formSetupProductionActivity = new FormSetupProductionActivity(db);
            formSetupProductionActivity.ShowDialog();
        }

        private void btnDodajPrcoes_Click(object sender, EventArgs e)
        {
            Proces_produkt_czynnosc procesProduktCzynnosc = new Proces_produkt_czynnosc();
            procesProduktCzynnosc.ID_produkt = (int)cbProdukt.SelectedValue;
            procesProduktCzynnosc.ID_czynnosc_produkcyjna = (int)cbCzynnoscProdukcyjna.SelectedValue;
            procesProduktCzynnosc.Czas_trwania = Convert.ToInt32(txtCzas.Text);
            db.Proces_produkt_czynnosc.Add(procesProduktCzynnosc);
            db.SaveChanges();
            showData();
            MessageBox.Show("Dodano nowy proces!", "Informacja", MessageBoxButtons.OK);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
