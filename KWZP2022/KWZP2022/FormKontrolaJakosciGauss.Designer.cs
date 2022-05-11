namespace KWZP2022
{
    partial class FormKontrolaJakosciGauss
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
            System.Windows.Forms.Button btnGeneruj;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProdukt = new System.Windows.Forms.DataGridView();
            this.dgvParametr = new System.Windows.Forms.DataGridView();
            this.txtProdukt = new System.Windows.Forms.TextBox();
            this.txtParametr = new System.Windows.Forms.TextBox();
            this.chrtGauss = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtDol = new System.Windows.Forms.TextBox();
            this.txtGora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            btnGeneruj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGauss)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneruj
            // 
            btnGeneruj.BackColor = System.Drawing.Color.LightSkyBlue;
            btnGeneruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            btnGeneruj.Location = new System.Drawing.Point(12, 366);
            btnGeneruj.Name = "btnGeneruj";
            btnGeneruj.Size = new System.Drawing.Size(283, 134);
            btnGeneruj.TabIndex = 76;
            btnGeneruj.Text = "Rozkład Normalny";
            btnGeneruj.UseVisualStyleBackColor = false;
            btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Wybierz produkt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(312, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Wybierz parametr:";
            // 
            // dgvProdukt
            // 
            this.dgvProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukt.Location = new System.Drawing.Point(24, 81);
            this.dgvProdukt.Name = "dgvProdukt";
            this.dgvProdukt.Size = new System.Drawing.Size(272, 199);
            this.dgvProdukt.TabIndex = 77;
            this.dgvProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukt_CellContentClick);
            // 
            // dgvParametr
            // 
            this.dgvParametr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametr.Location = new System.Drawing.Point(317, 81);
            this.dgvParametr.Name = "dgvParametr";
            this.dgvParametr.Size = new System.Drawing.Size(272, 199);
            this.dgvParametr.TabIndex = 78;
            this.dgvParametr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParametr_CellContentClick);
            // 
            // txtProdukt
            // 
            this.txtProdukt.Enabled = false;
            this.txtProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdukt.Location = new System.Drawing.Point(24, 307);
            this.txtProdukt.Name = "txtProdukt";
            this.txtProdukt.Size = new System.Drawing.Size(272, 30);
            this.txtProdukt.TabIndex = 79;
            // 
            // txtParametr
            // 
            this.txtParametr.Enabled = false;
            this.txtParametr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametr.Location = new System.Drawing.Point(317, 307);
            this.txtParametr.Name = "txtParametr";
            this.txtParametr.Size = new System.Drawing.Size(272, 30);
            this.txtParametr.TabIndex = 80;
            // 
            // chrtGauss
            // 
            this.chrtGauss.BackColor = System.Drawing.Color.Transparent;
            this.chrtGauss.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chrtGauss.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chrtGauss.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtGauss.Legends.Add(legend1);
            this.chrtGauss.Location = new System.Drawing.Point(595, 81);
            this.chrtGauss.Name = "chrtGauss";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtGauss.Series.Add(series1);
            this.chrtGauss.Size = new System.Drawing.Size(670, 597);
            this.chrtGauss.TabIndex = 81;
            this.chrtGauss.Text = "chart1";
            // 
            // txtDol
            // 
            this.txtDol.Enabled = false;
            this.txtDol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDol.Location = new System.Drawing.Point(317, 391);
            this.txtDol.Name = "txtDol";
            this.txtDol.Size = new System.Drawing.Size(145, 30);
            this.txtDol.TabIndex = 82;
            // 
            // txtGora
            // 
            this.txtGora.Enabled = false;
            this.txtGora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGora.Location = new System.Drawing.Point(317, 470);
            this.txtGora.Name = "txtGora";
            this.txtGora.Size = new System.Drawing.Size(145, 30);
            this.txtGora.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.Location = new System.Drawing.Point(312, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Zakres dolny:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(312, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "Zakres górny";
            // 
            // FormKontrolaJakosciGauss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.txtGora);
            this.Controls.Add(this.txtDol);
            this.Controls.Add(this.chrtGauss);
            this.Controls.Add(this.txtParametr);
            this.Controls.Add(this.txtProdukt);
            this.Controls.Add(this.dgvParametr);
            this.Controls.Add(this.dgvProdukt);
            this.Controls.Add(btnGeneruj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKontrolaJakosciGauss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rozkład Normalny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGauss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProdukt;
        private System.Windows.Forms.DataGridView dgvParametr;
        private System.Windows.Forms.TextBox txtProdukt;
        private System.Windows.Forms.TextBox txtParametr;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtGauss;
        private System.Windows.Forms.TextBox txtDol;
        private System.Windows.Forms.TextBox txtGora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}