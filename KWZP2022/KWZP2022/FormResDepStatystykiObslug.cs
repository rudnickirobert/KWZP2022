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
    public partial class FormResDepStatystykiObslug : Form
    {
        KWZPEntities db;
        public FormResDepStatystykiObslug(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            chartServices.Hide();
            cmbStanowisko.DataSource = db.v_Stanowisko_produkcyjne.ToList();
            cmbStanowisko.DisplayMember = "Nazwa_stanowiska";
            cmbStanowisko.ValueMember = "ID";
        }
        private void chartRing()
        {
            int stanowiskoID = (int)cmbStanowisko.SelectedValue;
            List<v_Obslugi_zakonczone_suma> chartServicesData = this.db.v_Obslugi_zakonczone_suma.Where(a => a.Nr_stanowiska==stanowiskoID).ToList();
            chartServices.DataSource = chartServicesData;
            chartServices.Series["Services"].XValueMember = "Obsługa";
            chartServices.Series["Services"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartServices.Series["Services"].YValueMembers = "Ilość";
            chartServices.Series["Services"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            chartRing();
            chartServices.Show();
        }
    }
}
