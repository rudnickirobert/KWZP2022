﻿namespace KWZP2022
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartAmountSoldProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProceeds = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProceedsDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpSTART = new System.Windows.Forms.DateTimePicker();
            this.dtpSTOP = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateChart = new System.Windows.Forms.Button();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmountSoldProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProceeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProceedsDate)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAmountSoldProducts
            // 
            this.chartAmountSoldProducts.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartAmountSoldProducts.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            legend4.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartAmountSoldProducts.Legends.Add(legend4);
            this.chartAmountSoldProducts.Location = new System.Drawing.Point(16, 97);
            this.chartAmountSoldProducts.Name = "chartAmountSoldProducts";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Goldenrod;
            series4.Legend = "Legend1";
            series4.Name = "SalesMonth";
            this.chartAmountSoldProducts.Series.Add(series4);
            this.chartAmountSoldProducts.Size = new System.Drawing.Size(1220, 600);
            this.chartAmountSoldProducts.TabIndex = 0;
            this.chartAmountSoldProducts.Text = "chart1";
            title4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            title4.Name = "Title1";
            title4.Text = "Liczba sprzedanych produktów w miesiącu";
            this.chartAmountSoldProducts.Titles.Add(title4);
            // 
            // chartProceeds
            // 
            this.chartProceeds.BackColor = System.Drawing.Color.Transparent;
            this.chartProceeds.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartProceeds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartProceeds.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartProceeds.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chartProceeds.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.Name = "Legend1";
            legend5.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartProceeds.Legends.Add(legend5);
            this.chartProceeds.Location = new System.Drawing.Point(16, 97);
            this.chartProceeds.Name = "chartProceeds";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            series5.LabelForeColor = System.Drawing.Color.Transparent;
            series5.Legend = "Legend1";
            series5.Name = "Proceeds";
            series5.YValuesPerPoint = 4;
            this.chartProceeds.Series.Add(series5);
            this.chartProceeds.Size = new System.Drawing.Size(1220, 600);
            this.chartProceeds.TabIndex = 1;
            this.chartProceeds.Text = "chart2";
            title5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            title5.Name = "Title1";
            title5.Text = "Przychód z produktu";
            this.chartProceeds.Titles.Add(title5);
            // 
            // chartProceedsDate
            // 
            this.chartProceedsDate.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.chartProceedsDate.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            legend6.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartProceedsDate.Legends.Add(legend6);
            this.chartProceedsDate.Location = new System.Drawing.Point(16, 97);
            this.chartProceedsDate.Name = "chartProceedsDate";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Goldenrod;
            series6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            series6.Legend = "Legend1";
            series6.Name = "ProceedsDate";
            this.chartProceedsDate.Series.Add(series6);
            this.chartProceedsDate.Size = new System.Drawing.Size(1220, 600);
            this.chartProceedsDate.TabIndex = 2;
            this.chartProceedsDate.Text = "chart1";
            title6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            title6.Name = "Title1";
            title6.Text = "Przychód";
            this.chartProceedsDate.Titles.Add(title6);
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
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btn.Location = new System.Drawing.Point(356, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(160, 30);
            this.btn.TabIndex = 10;
            this.btn.Text = "Dienne przychody";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.button2.Location = new System.Drawing.Point(545, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Przychody produktów";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.button3.Location = new System.Drawing.Point(732, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Miesięczne przychody";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormSalesDepartmentSalesStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn);
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
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}