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
    public partial class WytwarzanieForm : Form
    {
        KWZPEntities db;
        public WytwarzanieForm(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            refreshScreen();
        }

        private void refreshScreen()
        {
            initDataGridViewWytwarzanie();
        }

        private void initDataGridViewWytwarzanie()
        {
            dgvWytwarzanie.DataSource = db.v_Wytwarzanie.ToList();
            this.dgvWytwarzanie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
/*            dgvWytwarzanie.Columns["Parametr_polprodukt"].Visible = false;
            dgvWytwarzanie.Columns["Proces_polprodukt_czynnosc"].Visible = false;
            dgvWytwarzanie.Columns["Sklad_polprodukt"].Visible = false;
            dgvWytwarzanie.Columns["Sklad_produkt"].Visible = false;*/
        }

        private void initComboboxData()
        {
            cbPracownik.DataSource = db.v_Pracownik.ToList();
        }

    }
}
