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
    public partial class FormKontrolaJakosciGauss : Form
    {
        KWZPEntities db;
        public FormKontrolaJakosciGauss(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            this.db = new KWZPEntities();
            initDataGridViewProdukt();
        }

        private void initDataGridViewProdukt()
        {
            dgvProdukt.DataSource = db.Produkt.ToList();
            dgvProdukt.Columns["Parametr_produkt"].Visible = false;
            dgvProdukt.Columns["Proces_produkt_czynnosc"].Visible = false;
            dgvProdukt.Columns["Sklad_produkt"].Visible = false;
            dgvProdukt.Columns["Sklad_produkt_material"].Visible = false;
            dgvProdukt.Columns["Szczegoly_sprzedaz"].Visible = false;
            dgvProdukt.Columns["Zamowienie_szczegol"].Visible = false;
            dgvProdukt.Columns["Zwrot"].Visible = false;
            this.dgvProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdukt.Text = dgvProdukt.CurrentRow.Cells[1].Value.ToString();
            int produktID = int.Parse(dgvProdukt.CurrentRow.Cells[0].Value.ToString());
            dgvParametr.DataSource = 0;
            dgvParametr.DataSource = db.v_Parametry_produkt.Where(a => a.ID_produkt == produktID).ToList();
            dgvParametr.Columns["ID_produkt"].Visible = false;
            dgvParametr.Columns["Produkt"].Visible = false;
            dgvParametr.Columns["Wymiar_minimalny"].Visible = false;
            dgvParametr.Columns["Wymiar_maksymalny"].Visible = false;
            dgvParametr.Columns["Jednostka"].Visible = false;
            this.dgvParametr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initChartGauss()
        {
            if (String.IsNullOrEmpty(txtProdukt.Text) || String.IsNullOrEmpty(txtParametr.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                int produktID = int.Parse(dgvProdukt.CurrentRow.Cells[0].Value.ToString());
                int parametrID = int.Parse(dgvParametr.CurrentRow.Cells[0].Value.ToString());
                List<v_Kontrola_parametr_gauss_wykres> chartLineData = db.v_Kontrola_parametr_gauss_wykres.Where(a => a.ID_produkt == produktID && a.ID_parametr_produkt == parametrID).ToList();
                chrtGauss.DataSource = chartLineData;
                chrtGauss.Series[0].LegendText = "Rezultat";
                chrtGauss.Series[0].XValueMember = "Wartość";
                chrtGauss.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chrtGauss.Series[0].YValueMembers = "Ilość";
                chrtGauss.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            }
            
        }

        private void dgvParametr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtParametr.Text = dgvParametr.CurrentRow.Cells[3].Value.ToString();
            txtDol.Text = dgvParametr.CurrentRow.Cells[4].Value.ToString();
            txtGora.Text = dgvParametr.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            initChartGauss();
        }
    }
}
