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
    public partial class FormSetupProductionByproduct : Form
    {
        KWZPEntities db;
        public FormSetupProductionByproduct(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            comboBoxAddValue();
        }
        private void showData()
        {
            dgvDataStart.DataSource = db.v_Proces_polprodukt_czynnosc_projekt.ToList();
            dgvDataStart.Columns["ID_półproduktu"].Visible = false;
            this.dgvDataStart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void comboBoxAddValue()
        {
            cbPolprodukt.DataSource = this.db.Slownik_polprodukt.ToList();
            cbPolprodukt.ValueMember = "ID_polprodukt";
            cbPolprodukt.DisplayMember = "Nazwa";
            cbCzynnoscProdukcyjna.DataSource = this.db.Czynnosc_produkcyjna.ToList();
            cbCzynnoscProdukcyjna.ValueMember = "ID_czynnosc_produkcyjna";
            cbCzynnoscProdukcyjna.DisplayMember = "Nazwa";
        }
        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            FormSetupProductionActivity formSetupProductionActivity = new FormSetupProductionActivity(db);
            formSetupProductionActivity.ShowDialog();
        }

        private void btnDodajProces_Click(object sender, EventArgs e)
        {
            Proces_polprodukt_czynnosc procesPolproduktCzynnosc = new Proces_polprodukt_czynnosc();
            procesPolproduktCzynnosc.ID_polprodukt = (int)cbPolprodukt.SelectedValue;
            procesPolproduktCzynnosc.ID_czynnosc_produkcyjna = (int)cbCzynnoscProdukcyjna.SelectedValue;
            procesPolproduktCzynnosc.Czas_trwania = Convert.ToInt32(txtCzas.Text);
            db.Proces_polprodukt_czynnosc.Add(procesPolproduktCzynnosc);
            db.SaveChanges();
            showData();
            MessageBox.Show("Dodano nowy proces!", "Informacja", MessageBoxButtons.OK);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void dgvDataStart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_proces_polprodukt = int.Parse(this.dgvDataStart.CurrentRow.Cells[0].Value.ToString());
            Proces_polprodukt_czynnosc edycjaProces = this.db.Proces_polprodukt_czynnosc.Single(a => a.ID_czynnosc_produkcyjna == id_proces_polprodukt);
            cbPolprodukt.Text = edycjaProces.Slownik_polprodukt.ToString();
        }
    }
}
