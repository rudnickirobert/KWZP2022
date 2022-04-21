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
    public partial class DZFormMagMaszynWszystko : Form
    {
        KWZPEntities db;
        private object dgvMaszynaWszystko;

        public DZFormMagMaszynWszystko(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridViewMaszyna();
        }

        private void dgvMaszynyWszystko_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void DZFormMagMaszynWszystko_Load(object sender, EventArgs e)
        {
            // Ten wiersz kodu wczytuje dane do tabeli
            this.v_Magazyn_maszyn_wszystkoTableAdapter.Fill(this.kWZPDataSet.v_Magazyn_maszyn_wszystko);

        }
        private void initDataGridViewMaszyna()
        {
            this.v_Magazyn_maszyn_wszystkoTableAdapter.Fill(this.kWZPDataSet.v_Magazyn_maszyn_wszystko);
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDataGridViewMaszyna();
        }

        private void dgvMaszynyWszystko_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormDZHistoriaZamowien formzamow = new FormDZHistoriaZamowien(db);
            formzamow.ShowDialog();

        }
    }
}
