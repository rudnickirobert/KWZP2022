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
    public partial class SkladPolproduktForm : Form
    {
        KWZPEntities db;
        public SkladPolproduktForm(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            refreshScreen();
        }

        private void refreshScreen()
        {
            initDataGridViewPolprodukt();
            initDataGridViewMaterial();
            initDataGridViewSkladPolprodukt();
        }

        private void initDataGridViewPolprodukt()
        {
            dgvPolprodukt.DataSource = db.Slownik_polprodukt.ToList();
            dgvPolprodukt.Columns["Parametr_polprodukt"].Visible = false;
            dgvPolprodukt.Columns["Proces_polprodukt_czynnosc"].Visible = false;
            dgvPolprodukt.Columns["Sklad_polprodukt"].Visible = false;
            dgvPolprodukt.Columns["Sklad_produkt"].Visible = false;
            this.dgvPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewMaterial()
        {
            dgvMaterial.DataSource = db.Material.ToList();
            dgvMaterial.Columns["ID_rodzaj_material"].Visible = false;
            dgvMaterial.Columns["Rodzaj_material"].Visible = false;
            dgvMaterial.Columns["Parametr_material"].Visible = false;
            dgvMaterial.Columns["Sklad_polprodukt"].Visible = false;
            dgvMaterial.Columns["Szczegoly_zamowienie_material"].Visible = false;
            dgvMaterial.Columns["Sklad_produkt_material"].Visible = false;
            this.dgvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void initDataGridViewSkladPolprodukt()
        {
            dgvSkladPolprodukt.DataSource = db.v_Sklad_polprodukt.ToList();

            this.dgvSkladPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void dgvPolprodukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPolprodukt.Text = dgvPolprodukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaterial.Text = dgvMaterial.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
