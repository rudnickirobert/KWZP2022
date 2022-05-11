namespace KWZP2022
{
    partial class FormResDepStatystykiObslug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepStatystykiObslug));
            this.cmbStanowisko = new System.Windows.Forms.ComboBox();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.chartServices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartServices)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStanowisko
            // 
            this.cmbStanowisko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStanowisko.FormattingEnabled = true;
            this.cmbStanowisko.Location = new System.Drawing.Point(201, 59);
            this.cmbStanowisko.Name = "cmbStanowisko";
            this.cmbStanowisko.Size = new System.Drawing.Size(354, 26);
            this.cmbStanowisko.TabIndex = 1;
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.BackColor = System.Drawing.Color.Transparent;
            this.lblStanowisko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStanowisko.Location = new System.Drawing.Point(26, 61);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(169, 19);
            this.lblStanowisko.TabIndex = 2;
            this.lblStanowisko.Text = "Wybierz stanowisko:";
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.BackColor = System.Drawing.Color.Lime;
            this.btnGeneruj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGeneruj.Location = new System.Drawing.Point(574, 59);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(140, 47);
            this.btnGeneruj.TabIndex = 3;
            this.btnGeneruj.Text = "Generuj wykres";
            this.btnGeneruj.UseVisualStyleBackColor = false;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // chartServices
            // 
            this.chartServices.BackColor = System.Drawing.Color.Transparent;
            this.chartServices.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartServices.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartServices.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chartServices.Legends.Add(legend1);
            this.chartServices.Location = new System.Drawing.Point(39, 124);
            this.chartServices.Name = "chartServices";
            this.chartServices.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Transparent;
            series1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Services";
            this.chartServices.Series.Add(series1);
            this.chartServices.Size = new System.Drawing.Size(692, 370);
            this.chartServices.TabIndex = 4;
            this.chartServices.Text = "chart1";
            // 
            // FormResDepStatystykiObslug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(801, 499);
            this.Controls.Add(this.chartServices);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.lblStanowisko);
            this.Controls.Add(this.cmbStanowisko);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepStatystykiObslug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statystyki obsług dla stanowiska";
            ((System.ComponentModel.ISupportInitialize)(this.chartServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStanowisko;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartServices;
    }
}