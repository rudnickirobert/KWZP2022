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
    public partial class ProcesWytwarzanieProduktForm : Form
    {
        KWZPEntities db;
        public ProcesWytwarzanieProduktForm(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;

            initDataGridViewProcesWytwarzanieProdukt();
        }
        private void initDataGridViewProcesWytwarzanieProdukt()
        {
            dgvProcesWytwarzanieProdukt.DataSource = db.v_Proces_wytwarzanie_produkt.ToList();
            this.dgvProcesWytwarzanieProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProcesWytwarzanieProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }



        private void btnDodajProcesProdukt_Click(object sender, EventArgs e)
        {

        }

        private void dgvProcesWytwarzanieProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbNazwaProduktu.Text = this.dgvProcesWytwarzanieProdukt.CurrentRow.Cells[0].Value.ToString();
            txtbCzynnoscProdukcyjna.Text = this.dgvProcesWytwarzanieProdukt.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
