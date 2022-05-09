namespace KWZP2022
{
    partial class FormSalesDepartmentSalesStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartAmountSoldProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProceeds = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProceedsDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpSTART = new System.Windows.Forms.DateTimePicker();
            this.dtpSTOP = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateChart = new System.Windows.Forms.Button();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.btnDayProceeds = new System.Windows.Forms.Button();
            this.btnProductsProceeds = new System.Windows.Forms.Button();
            this.btnMonthProceeds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmountSoldProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProceeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProceedsDate)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAmountSoldProducts
            // 
            this.chartAmountSoldProducts.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartAmountSoldProducts.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartAmountSoldProducts.Legends.Add(legend1);
            this.chartAmountSoldProducts.Location = new System.Drawing.Point(16, 97);
            this.chartAmountSoldProducts.Name = "chartAmountSoldProducts";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Goldenrod;
            series1.Legend = "Legend1";
            series1.Name = "SalesMonth";
            this.chartAmountSoldProducts.Series.Add(series1);
            this.chartAmountSoldProducts.Size = new System.Drawing.Size(1220, 600);
            this.chartAmountSoldProducts.TabIndex = 0;
            this.chartAmountSoldProducts.Text = "chart1";
            title1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            title1.Name = "Title1";
            title1.Text = "Bilans miesięczny";
            this.chartAmountSoldProducts.Titles.Add(title1);
            // 
            // chartProceeds
            // 
            this.chartProceeds.BackColor = System.Drawing.Color.Transparent;
            this.chartProceeds.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartProceeds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartProceeds.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartProceeds.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartProceeds.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            legend2.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartProceeds.Legends.Add(legend2);
            this.chartProceeds.Location = new System.Drawing.Point(16, 97);
            this.chartProceeds.Name = "chartProceeds";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            series2.LabelForeColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Proceeds";
            series2.YValuesPerPoint = 4;
            this.chartProceeds.Series.Add(series2);
            this.chartProceeds.Size = new System.Drawing.Size(1220, 600);
            this.chartProceeds.TabIndex = 1;
            this.chartProceeds.Text = "chart2";
            title2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            title2.Name = "Title1";
            title2.Text = "Przychód z produktu";
            this.chartProceeds.Titles.Add(title2);
            // 
            // chartProceedsDate
            // 
            this.chartProceedsDate.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartProceedsDate.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            legend3.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartProceedsDate.Legends.Add(legend3);
            this.chartProceedsDate.Location = new System.Drawing.Point(16, 97);
            this.chartProceedsDate.Name = "chartProceedsDate";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Goldenrod;
            series3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            series3.Legend = "Legend1";
            series3.Name = "ProceedsDate";
            this.chartProceedsDate.Series.Add(series3);
            this.chartProceedsDate.Size = new System.Drawing.Size(1220, 600);
            this.chartProceedsDate.TabIndex = 2;
            this.chartProceedsDate.Text = "chart1";
            title3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            title3.Name = "Title1";
            title3.Text = "Przychód";
            this.chartProceedsDate.Titles.Add(title3);
            // 
            // dtpSTART
            // 
            this.dtpSTART.CalendarFont = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSTART.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSTART.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSTART.Location = new System.Drawing.Point(72, 83);
            this.dtpSTART.Name = "dtpSTART";
            this.dtpSTART.Size = new System.Drawing.Size(104, 26);
            this.dtpSTART.TabIndex = 3;
            // 
            // dtpSTOP
            // 
            this.dtpSTOP.CalendarFont = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSTOP.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSTOP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSTOP.Location = new System.Drawing.Point(272, 83);
            this.dtpSTOP.Name = "dtpSTOP";
            this.dtpSTOP.Size = new System.Drawing.Size(104, 26);
            this.dtpSTOP.TabIndex = 4;
            // 
            // btnGenerateChart
            // 
            this.btnGenerateChart.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnGenerateChart.Location = new System.Drawing.Point(428, 81);
            this.btnGenerateChart.Name = "btnGenerateChart";
            this.btnGenerateChart.Size = new System.Drawing.Size(122, 30);
            this.btnGenerateChart.TabIndex = 6;
            this.btnGenerateChart.Text = "Generuj wykres";
            this.btnGenerateChart.UseVisualStyleBackColor = true;
            this.btnGenerateChart.Click += new System.EventHandler(this.btnGenerateChart_Click);
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelDateFrom.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.labelDateFrom.Location = new System.Drawing.Point(7, 86);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(59, 20);
            this.labelDateFrom.TabIndex = 7;
            this.labelDateFrom.Text = "Data od:";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.BackColor = System.Drawing.Color.Transparent;
            this.labelDateTo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.labelDateTo.Location = new System.Drawing.Point(207, 86);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(59, 20);
            this.labelDateTo.TabIndex = 8;
            this.labelDateTo.Text = "Data do:";
            // 
            // btnDayProceeds
            // 
            this.btnDayProceeds.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnDayProceeds.Location = new System.Drawing.Point(356, 12);
            this.btnDayProceeds.Name = "btnDayProceeds";
            this.btnDayProceeds.Size = new System.Drawing.Size(160, 30);
            this.btnDayProceeds.TabIndex = 10;
            this.btnDayProceeds.Text = "Dzienne przychody";
            this.btnDayProceeds.UseVisualStyleBackColor = true;
            this.btnDayProceeds.Click += new System.EventHandler(this.btnDayProceeds_Click);
            // 
            // btnProductsProceeds
            // 
            this.btnProductsProceeds.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnProductsProceeds.Location = new System.Drawing.Point(545, 12);
            this.btnProductsProceeds.Name = "btnProductsProceeds";
            this.btnProductsProceeds.Size = new System.Drawing.Size(160, 30);
            this.btnProductsProceeds.TabIndex = 11;
            this.btnProductsProceeds.Text = "Przychody produktów";
            this.btnProductsProceeds.UseVisualStyleBackColor = true;
            this.btnProductsProceeds.Click += new System.EventHandler(this.btnProductsProceeds_Click);
            // 
            // btnMonthProceeds
            // 
            this.btnMonthProceeds.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnMonthProceeds.Location = new System.Drawing.Point(732, 12);
            this.btnMonthProceeds.Name = "btnMonthProceeds";
            this.btnMonthProceeds.Size = new System.Drawing.Size(160, 30);
            this.btnMonthProceeds.TabIndex = 12;
            this.btnMonthProceeds.Text = "Bilans miesięczny";
            this.btnMonthProceeds.UseVisualStyleBackColor = true;
            this.btnMonthProceeds.Click += new System.EventHandler(this.btnMonthProceeds_Click);
            // 
            // FormSalesDepartmentSalesStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnMonthProceeds);
            this.Controls.Add(this.btnProductsProceeds);
            this.Controls.Add(this.btnDayProceeds);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.btnGenerateChart);
            this.Controls.Add(this.dtpSTOP);
            this.Controls.Add(this.dtpSTART);
            this.Controls.Add(this.chartProceedsDate);
            this.Controls.Add(this.chartProceeds);
            this.Controls.Add(this.chartAmountSoldProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSalesDepartmentSalesStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statystyki sprzedaży";
            ((System.ComponentModel.ISupportInitialize)(this.chartAmountSoldProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProceeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProceedsDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmountSoldProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProceeds;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProceedsDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpSTART;
        private System.Windows.Forms.DateTimePicker dtpSTOP;
        private System.Windows.Forms.Button btnGenerateChart;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Button btnDayProceeds;
        private System.Windows.Forms.Button btnProductsProceeds;
        private System.Windows.Forms.Button btnMonthProceeds;
    }
}