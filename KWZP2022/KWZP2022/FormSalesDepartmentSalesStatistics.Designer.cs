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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartAmountSoldProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProceeds = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProceedsDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpSTART = new System.Windows.Forms.DateTimePicker();
            this.dtpSTOP = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmountSoldProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProceeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProceedsDate)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAmountSoldProducts
            // 
            this.chartAmountSoldProducts.BackColor = System.Drawing.Color.Transparent;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.Name = "ChartArea1";
            this.chartAmountSoldProducts.ChartAreas.Add(chartArea10);
            legend10.BackColor = System.Drawing.Color.Transparent;
            legend10.Name = "Legend1";
            legend10.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartAmountSoldProducts.Legends.Add(legend10);
            this.chartAmountSoldProducts.Location = new System.Drawing.Point(12, 319);
            this.chartAmountSoldProducts.Name = "chartAmountSoldProducts";
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.Goldenrod;
            series10.Legend = "Legend1";
            series10.Name = "Liczba";
            this.chartAmountSoldProducts.Series.Add(series10);
            this.chartAmountSoldProducts.Size = new System.Drawing.Size(787, 380);
            this.chartAmountSoldProducts.TabIndex = 0;
            this.chartAmountSoldProducts.Text = "chart1";
            title10.Font = new System.Drawing.Font("Arial Narrow", 12F);
            title10.Name = "Title1";
            title10.Text = "Liczba sprzedanych produktów";
            this.chartAmountSoldProducts.Titles.Add(title10);
            // 
            // chartProceeds
            // 
            this.chartProceeds.BackColor = System.Drawing.Color.Transparent;
            chartArea11.BackColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            this.chartProceeds.ChartAreas.Add(chartArea11);
            legend11.BackColor = System.Drawing.Color.Transparent;
            legend11.Name = "Legend1";
            legend11.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartProceeds.Legends.Add(legend11);
            this.chartProceeds.Location = new System.Drawing.Point(805, 305);
            this.chartProceeds.Name = "chartProceeds";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            series11.LabelForeColor = System.Drawing.Color.Transparent;
            series11.Legend = "Legend1";
            series11.Name = "Proceeds";
            series11.YValuesPerPoint = 4;
            this.chartProceeds.Series.Add(series11);
            this.chartProceeds.Size = new System.Drawing.Size(447, 394);
            this.chartProceeds.TabIndex = 1;
            this.chartProceeds.Text = "chart2";
            title11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            title11.Name = "Title1";
            title11.Text = "Zarobek z produktu";
            this.chartProceeds.Titles.Add(title11);
            // 
            // chartProceedsDate
            // 
            this.chartProceedsDate.BackColor = System.Drawing.Color.Transparent;
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.chartProceedsDate.ChartAreas.Add(chartArea12);
            legend12.BackColor = System.Drawing.Color.Transparent;
            legend12.Enabled = false;
            legend12.Name = "Legend1";
            legend12.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartProceedsDate.Legends.Add(legend12);
            this.chartProceedsDate.Location = new System.Drawing.Point(12, 38);
            this.chartProceedsDate.Name = "chartProceedsDate";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series12.Color = System.Drawing.Color.Goldenrod;
            series12.Font = new System.Drawing.Font("Arial Narrow", 12F);
            series12.Legend = "Legend1";
            series12.Name = "ProceedsDate";
            this.chartProceedsDate.Series.Add(series12);
            this.chartProceedsDate.Size = new System.Drawing.Size(1240, 275);
            this.chartProceedsDate.TabIndex = 2;
            this.chartProceedsDate.Text = "chart1";
            title12.Font = new System.Drawing.Font("Arial Narrow", 12F);
            title12.Name = "Title1";
            title12.Text = "Dochód";
            this.chartProceedsDate.Titles.Add(title12);
            // 
            // dtpSTART
            // 
            this.dtpSTART.CalendarFont = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSTART.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSTART.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSTART.Location = new System.Drawing.Point(77, 6);
            this.dtpSTART.Name = "dtpSTART";
            this.dtpSTART.Size = new System.Drawing.Size(104, 26);
            this.dtpSTART.TabIndex = 3;
            // 
            // dtpSTOP
            // 
            this.dtpSTOP.CalendarFont = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSTOP.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSTOP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSTOP.Location = new System.Drawing.Point(277, 6);
            this.dtpSTOP.Name = "dtpSTOP";
            this.dtpSTOP.Size = new System.Drawing.Size(104, 26);
            this.dtpSTOP.TabIndex = 4;
            // 
            // btnGenerateChart
            // 
            this.btnGenerateChart.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnGenerateChart.Location = new System.Drawing.Point(433, 4);
            this.btnGenerateChart.Name = "btnGenerateChart";
            this.btnGenerateChart.Size = new System.Drawing.Size(122, 30);
            this.btnGenerateChart.TabIndex = 6;
            this.btnGenerateChart.Text = "Generuj wykres";
            this.btnGenerateChart.UseVisualStyleBackColor = true;
            this.btnGenerateChart.Click += new System.EventHandler(this.btnGenerateChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(212, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data do:";
            // 
            // FormSalesDepartmentSalesStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}