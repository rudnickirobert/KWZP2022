namespace KWZP2022
{
    partial class FormSkladProdukt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSkladProdukt));
            this.btnSkladPolprodukt = new System.Windows.Forms.Button();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPolprodukt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSkladProdukt = new System.Windows.Forms.DataGridView();
            this.dgvProdukt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.txtNazwaProdukt = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPolprodukt = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkladPolprodukt
            // 
            this.btnSkladPolprodukt.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSkladPolprodukt.Font = new System.Drawing.Font("Arial", 15F);
            this.btnSkladPolprodukt.Location = new System.Drawing.Point(427, 12);
            this.btnSkladPolprodukt.Name = "btnSkladPolprodukt";
            this.btnSkladPolprodukt.Size = new System.Drawing.Size(434, 37);
            this.btnSkladPolprodukt.TabIndex = 35;
            this.btnSkladPolprodukt.Text = "Dodaj skład półproduktu";
            this.btnSkladPolprodukt.UseVisualStyleBackColor = false;
            this.btnSkladPolprodukt.Click += new System.EventHandler(this.btnSkladPolprodukt_Click);
            // 
            // txtIlosc
            // 
            this.txtIlosc.Font = new System.Drawing.Font("Arial", 20F);
            this.txtIlosc.Location = new System.Drawing.Point(110, 247);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(255, 38);
            this.txtIlosc.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20F);
            this.label3.Location = new System.Drawing.Point(25, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ilość:";
            // 
            // txtPolprodukt
            // 
            this.txtPolprodukt.Font = new System.Drawing.Font("Arial", 20F);
            this.txtPolprodukt.Location = new System.Drawing.Point(31, 164);
            this.txtPolprodukt.Name = "txtPolprodukt";
            this.txtPolprodukt.Size = new System.Drawing.Size(334, 38);
            this.txtPolprodukt.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nazwa półproduktu:";
            // 
            // dgvSkladProdukt
            // 
            this.dgvSkladProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladProdukt.Location = new System.Drawing.Point(427, 424);
            this.dgvSkladProdukt.Name = "dgvSkladProdukt";
            this.dgvSkladProdukt.RowHeadersWidth = 51;
            this.dgvSkladProdukt.Size = new System.Drawing.Size(813, 279);
            this.dgvSkladProdukt.TabIndex = 30;
            this.dgvSkladProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladProdukt_CellContentClick_1);
            // 
            // dgvProdukt
            // 
            this.dgvProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukt.Location = new System.Drawing.Point(427, 80);
            this.dgvProdukt.Name = "dgvProdukt";
            this.dgvProdukt.RowHeadersWidth = 51;
            this.dgvProdukt.Size = new System.Drawing.Size(334, 313);
            this.dgvProdukt.TabIndex = 29;
            this.dgvProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukt_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Produkt:";
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Enabled = false;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(31, 477);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 27;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(31, 546);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 26;
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
            this.btnOdswiez.TabIndex = 25;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // txtNazwaProdukt
            // 
            this.txtNazwaProdukt.Enabled = false;
            this.txtNazwaProdukt.Font = new System.Drawing.Font("Arial", 20F);
            this.txtNazwaProdukt.Location = new System.Drawing.Point(31, 59);
            this.txtNazwaProdukt.Name = "txtNazwaProdukt";
            this.txtNazwaProdukt.Size = new System.Drawing.Size(334, 38);
            this.txtNazwaProdukt.TabIndex = 24;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(31, 408);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Powiąż";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPolprodukt
            // 
            this.dgvPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolprodukt.Location = new System.Drawing.Point(818, 80);
            this.dgvPolprodukt.Name = "dgvPolprodukt";
            this.dgvPolprodukt.RowHeadersWidth = 51;
            this.dgvPolprodukt.Size = new System.Drawing.Size(434, 313);
            this.dgvPolprodukt.TabIndex = 22;
            this.dgvPolprodukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolprodukt_CellContentClick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.Location = new System.Drawing.Point(813, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Wybierz półprodukt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(422, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Wybierz produkt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.Location = new System.Drawing.Point(422, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Skład produktów";
            // 
            // FormSkladProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSkladPolprodukt);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPolprodukt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSkladProdukt);
            this.Controls.Add(this.dgvProdukt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.txtNazwaProdukt);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPolprodukt);
            this.Name = "FormSkladProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skład Produktów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSkladPolprodukt;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPolprodukt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSkladProdukt;
        private System.Windows.Forms.DataGridView dgvProdukt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.TextBox txtNazwaProdukt;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPolprodukt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}