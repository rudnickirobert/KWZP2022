using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2022
{
    public partial class FormSalesDepartmentSalesStatistics : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentSalesStatistics(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            chartRing();
        }
        private void chartRing()
        {
            chartProceeds.DataSource = this.db.v_Sprzedaz_statystyki_produkty.ToList();
            chartProceeds.Series["Proceeds"].XValueMember = "Nazwa_produkt";
            chartProceeds.Series["Proceeds"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartProceeds.Series["Proceeds"].YValueMembers = "Całkowity_koszt";
            chartProceeds.Series["Proceeds"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
        private void chartLineDate()
        {   
            List<v_Sprzedaz_statystyki_zarobek_dnia> chartLineData = this.db.v_Sprzedaz_statystyki_zarobek_dnia.Where(a => (DbFunctions.TruncateTime(a.Data_sprzedaz_koniec) >= dtpSTART.Value.Date && DbFunctions.TruncateTime(a.Data_sprzedaz_koniec) <= dtpSTOP.Value.Date)).ToList();
            chartProceedsDate.DataSource = chartLineData;
            chartProceedsDate.Series["ProceedsDate"].XValueMember = "Data_sprzedaz_koniec";
            chartProceedsDate.Series["ProceedsDate"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTimeOffset;
            chartProceedsDate.Series["ProceedsDate"].YValueMembers = "Zarobek_z_dnia";
            chartProceedsDate.Series["ProceedsDate"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            chartLineDate();
        }
    }
}
