using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            hideAllCharts();
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
            chartProceedsDate.Series["ProceedsDate"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            chartProceedsDate.Series["ProceedsDate"].YValueMembers = "Zarobek_z_dnia";
            chartProceedsDate.Series["ProceedsDate"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
        private void chartAmountSoldProductsData()
        {
            List<v_Zarobek_miesiac_suma> chartColumnData = this.db.v_Zarobek_miesiac_suma.ToList();
            chartAmountSoldProducts.DataSource = chartColumnData;
            chartAmountSoldProducts.Series["SalesMonth"].XValueMember = "Miesiąc";
            chartAmountSoldProducts.Series["SalesMonth"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartAmountSoldProducts.Series["SalesMonth"].YValueMembers = "Zarobek_na_miesiąc";
            chartAmountSoldProducts.Series["SalesMonth"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            chartLineDate();
        }
        private void hideAllCharts()
        {
            chartAmountSoldProducts.Hide();
            chartProceeds.Hide();
            labelDateFrom.Hide();
            dtpSTART.Hide();
            labelDateTo.Hide();
            dtpSTOP.Hide();
            btnGenerateChart.Hide();
            chartProceedsDate.Hide();
        }

        private void btnDayProceeds_Click(object sender, EventArgs e)
        {
            hideAllCharts();
            chartLineDate();
            labelDateFrom.Show();
            dtpSTART.Show();
            labelDateTo.Show();
            dtpSTOP.Show();
            btnGenerateChart.Show();
            chartProceedsDate.Show();
        }

        private void btnProductsProceeds_Click(object sender, EventArgs e)
        {
            hideAllCharts();
            chartRing();
            chartProceeds.Show();
        }

        private void btnMonthProceeds_Click(object sender, EventArgs e)
        {
            hideAllCharts();
            chartAmountSoldProductsData();
            chartAmountSoldProducts.Show();
        }
    }
}
