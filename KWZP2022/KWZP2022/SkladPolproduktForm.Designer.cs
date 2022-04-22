namespace KWZP2022
{
    partial class SkladPolproduktForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkladPolproduktForm));
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSkladPolprodukt = new System.Windows.Forms.DataGridView();
            this.dgvPolprodukt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.txtPolprodukt = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladPolprodukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIlosc
            // 
            this.txtIlosc.Font = new System.Drawing.Font("Arial", 20F);
            this.txtIlosc.Location = new System.Drawing.Point(141, 247);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(224, 38);
            this.txtIlosc.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20F);
            this.label3.Location = new System.Drawing.Point(25, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ilość [g]:";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Enabled = false;
            this.txtMaterial.Font = new System.Drawing.Font("Arial", 20F);
            this.txtMaterial.Location = new System.Drawing.Point(31, 164);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(334, 38);
            this.txtMaterial.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Materiał:";
            // 
            // dgvSkladPolprodukt
            // 
            this.dgvSkladPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladPolprodukt.Location = new System.Drawing.Point(427, 408);
            this.dgvSkladPolprodukt.Name = "dgvSkladPolprodukt";
            this.dgvSkladPolprodukt.Size = new System.Drawing.Size(813, 279);
            this.dgvSkladPolprodukt.TabIndex = 28;
            this.dgvSkladPolprodukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladPolprodukt_CellContentClick);
            // 
            // dgvPolprodukt
            // 
            this.dgvPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolprodukt.Location = new System.Drawing.Point(906, 80);
            this.dgvPolprodukt.Name = "dgvPolprodukt";
            this.dgvPolprodukt.Size = new System.Drawing.Size(334, 313);
            this.dgvPolprodukt.TabIndex = 27;
            this.dgvPolprodukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolprodukt_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Półprodukt:";
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(31, 477);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 25;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(31, 546);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 24;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(31, 617);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 23;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // txtPolprodukt
            // 
            this.txtPolprodukt.Enabled = false;
            this.txtPolprodukt.Font = new System.Drawing.Font("Arial", 20F);
            this.txtPolprodukt.Location = new System.Drawing.Point(31, 59);
            this.txtPolprodukt.Name = "txtPolprodukt";
            this.txtPolprodukt.Size = new System.Drawing.Size(334, 38);
            this.txtPolprodukt.TabIndex = 22;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(31, 408);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 21;
            this.btnDodaj.Text = "Powiąż";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Location = new System.Drawing.Point(427, 80);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.Size = new System.Drawing.Size(434, 313);
            this.dgvMaterial.TabIndex = 20;
            this.dgvMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellContentClick);
            // 
            // SkladPolproduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSkladPolprodukt);
            this.Controls.Add(this.dgvPolprodukt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.txtPolprodukt);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvMaterial);
            this.Name = "SkladPolproduktForm";
            this.Text = "Skład Półproduktów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladPolprodukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSkladPolprodukt;
        private System.Windows.Forms.DataGridView dgvPolprodukt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.TextBox txtPolprodukt;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvMaterial;
    }
}