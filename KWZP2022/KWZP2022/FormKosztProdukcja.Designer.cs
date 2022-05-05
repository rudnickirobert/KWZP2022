namespace KWZP2022
{
    partial class FormKosztProdukcja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKosztProdukcja));
            this.label1 = new System.Windows.Forms.Label();
            this.cbZamowienie = new System.Windows.Forms.ComboBox();
            this.dgvProcesProdukt = new System.Windows.Forms.DataGridView();
            this.dgvProcesPolprodukt = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.lblKoszt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesPolprodukt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybór zamowienia:";
            // 
            // cbZamowienie
            // 
            this.cbZamowienie.Font = new System.Drawing.Font("Arial", 15F);
            this.cbZamowienie.FormattingEnabled = true;
            this.cbZamowienie.Location = new System.Drawing.Point(36, 53);
            this.cbZamowienie.Name = "cbZamowienie";
            this.cbZamowienie.Size = new System.Drawing.Size(292, 31);
            this.cbZamowienie.TabIndex = 2;
            // 
            // dgvProcesProdukt
            // 
            this.dgvProcesProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesProdukt.Location = new System.Drawing.Point(36, 161);
            this.dgvProcesProdukt.Name = "dgvProcesProdukt";
            this.dgvProcesProdukt.Size = new System.Drawing.Size(603, 406);
            this.dgvProcesProdukt.TabIndex = 7;
            // 
            // dgvProcesPolprodukt
            // 
            this.dgvProcesPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesPolprodukt.Location = new System.Drawing.Point(660, 161);
            this.dgvProcesPolprodukt.Name = "dgvProcesPolprodukt";
            this.dgvProcesPolprodukt.Size = new System.Drawing.Size(592, 406);
            this.dgvProcesPolprodukt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(51, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Całkowity koszt wyprodukowania produktów wynosi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(32, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Procesy wytwarzania produktów";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(659, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Procesy wytwarzania półproduktów";
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGeneruj.Font = new System.Drawing.Font("Arial", 20F);
            this.btnGeneruj.Location = new System.Drawing.Point(379, 27);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(292, 57);
            this.btnGeneruj.TabIndex = 47;
            this.btnGeneruj.Text = "Generuj ";
            this.btnGeneruj.UseVisualStyleBackColor = false;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // btnOblicz
            // 
            this.btnOblicz.BackColor = System.Drawing.Color.Plum;
            this.btnOblicz.Font = new System.Drawing.Font("Arial", 20F);
            this.btnOblicz.Location = new System.Drawing.Point(300, 625);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(215, 59);
            this.btnOblicz.TabIndex = 49;
            this.btnOblicz.Text = "Oblicz koszt";
            this.btnOblicz.UseVisualStyleBackColor = false;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // lblKoszt
            // 
            this.lblKoszt.AutoSize = true;
            this.lblKoszt.BackColor = System.Drawing.Color.Transparent;
            this.lblKoszt.Font = new System.Drawing.Font("Arial", 20F);
            this.lblKoszt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKoszt.Location = new System.Drawing.Point(58, 638);
            this.lblKoszt.Name = "lblKoszt";
            this.lblKoszt.Size = new System.Drawing.Size(67, 32);
            this.lblKoszt.TabIndex = 50;
            this.lblKoszt.Text = "0.00";
            // 
            // FormKosztProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.lblKoszt);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProcesPolprodukt);
            this.Controls.Add(this.dgvProcesProdukt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbZamowienie);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FormKosztProdukcja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koszty produkcji";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesPolprodukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbZamowienie;
        private System.Windows.Forms.DataGridView dgvProcesProdukt;
        private System.Windows.Forms.DataGridView dgvProcesPolprodukt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label lblKoszt;
    }
}