namespace KWZP2022
{
    partial class FormCzasPracyProdukcja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCzasPracyProdukcja));
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCzasOd = new System.Windows.Forms.DateTimePicker();
            this.dtpCzasDo = new System.Windows.Forms.DateTimePicker();
            this.dgvWytwarzaniePolprodukt = new System.Windows.Forms.DataGridView();
            this.dgvWytwarzanieProdukt = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzaniePolprodukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzanieProdukt)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPracownik
            // 
            this.cbPracownik.Font = new System.Drawing.Font("Arial", 15F);
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(24, 68);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(292, 31);
            this.cbPracownik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybór pracownika:";
            // 
            // dtpCzasOd
            // 
            this.dtpCzasOd.Font = new System.Drawing.Font("Arial", 15F);
            this.dtpCzasOd.Location = new System.Drawing.Point(24, 196);
            this.dtpCzasOd.Name = "dtpCzasOd";
            this.dtpCzasOd.Size = new System.Drawing.Size(239, 30);
            this.dtpCzasOd.TabIndex = 2;
            // 
            // dtpCzasDo
            // 
            this.dtpCzasDo.Font = new System.Drawing.Font("Arial", 15F);
            this.dtpCzasDo.Location = new System.Drawing.Point(24, 276);
            this.dtpCzasDo.Name = "dtpCzasDo";
            this.dtpCzasDo.Size = new System.Drawing.Size(239, 30);
            this.dtpCzasDo.TabIndex = 3;
            // 
            // dgvWytwarzaniePolprodukt
            // 
            this.dgvWytwarzaniePolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWytwarzaniePolprodukt.Location = new System.Drawing.Point(356, 42);
            this.dgvWytwarzaniePolprodukt.Name = "dgvWytwarzaniePolprodukt";
            this.dgvWytwarzaniePolprodukt.Size = new System.Drawing.Size(896, 319);
            this.dgvWytwarzaniePolprodukt.TabIndex = 6;
            // 
            // dgvWytwarzanieProdukt
            // 
            this.dgvWytwarzanieProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWytwarzanieProdukt.Location = new System.Drawing.Point(356, 385);
            this.dgvWytwarzanieProdukt.Name = "dgvWytwarzanieProdukt";
            this.dgvWytwarzanieProdukt.Size = new System.Drawing.Size(896, 319);
            this.dgvWytwarzanieProdukt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15F);
            this.label2.Location = new System.Drawing.Point(20, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Okres od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15F);
            this.label3.Location = new System.Drawing.Point(20, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Okres do:";
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGeneruj.Font = new System.Drawing.Font("Arial", 20F);
            this.btnGeneruj.Location = new System.Drawing.Point(24, 351);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(292, 57);
            this.btnGeneruj.TabIndex = 10;
            this.btnGeneruj.Text = "Generuj ";
            this.btnGeneruj.UseVisualStyleBackColor = false;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(20, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Suma przepracowanych godzin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(54, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "w wybranym okresie:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.BackColor = System.Drawing.Color.Transparent;
            this.lblSum.Font = new System.Drawing.Font("Arial", 20F);
            this.lblSum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSum.Location = new System.Drawing.Point(93, 526);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(52, 32);
            this.lblSum.TabIndex = 13;
            this.lblSum.Text = "0 h";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCzasPracyProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvWytwarzanieProdukt);
            this.Controls.Add(this.dgvWytwarzaniePolprodukt);
            this.Controls.Add(this.dtpCzasDo);
            this.Controls.Add(this.dtpCzasOd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPracownik);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "FormCzasPracyProdukcja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Czas pracy pracowników działu produkcji";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzaniePolprodukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzanieProdukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCzasOd;
        private System.Windows.Forms.DateTimePicker dtpCzasDo;
        private System.Windows.Forms.DataGridView dgvWytwarzaniePolprodukt;
        private System.Windows.Forms.DataGridView dgvWytwarzanieProdukt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSum;
    }
}