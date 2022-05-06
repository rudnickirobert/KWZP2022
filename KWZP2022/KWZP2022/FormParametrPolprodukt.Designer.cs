namespace KWZP2022
{
    partial class FormParametrPolprodukt
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
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.dgvvParametrPolprodukt = new System.Windows.Forms.DataGridView();
            this.dgvRodzajParametr = new System.Windows.Forms.DataGridView();
            this.dgvPolprodukt = new System.Windows.Forms.DataGridView();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtZakresGorny = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZakresDolny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParametrPolprodukt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPolprodukt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNowyParametr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvParametrPolprodukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajParametr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(23, 628);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 48;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // dgvvParametrPolprodukt
            // 
            this.dgvvParametrPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvParametrPolprodukt.Location = new System.Drawing.Point(454, 334);
            this.dgvvParametrPolprodukt.MultiSelect = false;
            this.dgvvParametrPolprodukt.Name = "dgvvParametrPolprodukt";
            this.dgvvParametrPolprodukt.Size = new System.Drawing.Size(798, 374);
            this.dgvvParametrPolprodukt.TabIndex = 47;
            this.dgvvParametrPolprodukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvParametrPolprodukt_CellContentClick);
            // 
            // dgvRodzajParametr
            // 
            this.dgvRodzajParametr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRodzajParametr.Location = new System.Drawing.Point(978, 91);
            this.dgvRodzajParametr.Name = "dgvRodzajParametr";
            this.dgvRodzajParametr.Size = new System.Drawing.Size(258, 212);
            this.dgvRodzajParametr.TabIndex = 46;
            this.dgvRodzajParametr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRodzajParametr_CellContentClick);
            // 
            // dgvPolprodukt
            // 
            this.dgvPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolprodukt.Location = new System.Drawing.Point(454, 91);
            this.dgvPolprodukt.Name = "dgvPolprodukt";
            this.dgvPolprodukt.Size = new System.Drawing.Size(472, 212);
            this.dgvPolprodukt.TabIndex = 45;
            this.dgvPolprodukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolprodukt_CellContentClick);
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(23, 508);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 44;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(23, 569);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 43;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(23, 449);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 42;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtZakresGorny
            // 
            this.txtZakresGorny.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZakresGorny.Location = new System.Drawing.Point(23, 350);
            this.txtZakresGorny.Name = "txtZakresGorny";
            this.txtZakresGorny.Size = new System.Drawing.Size(398, 39);
            this.txtZakresGorny.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 40;
            this.label4.Text = "Zakres górny";
            // 
            // txtZakresDolny
            // 
            this.txtZakresDolny.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZakresDolny.Location = new System.Drawing.Point(23, 264);
            this.txtZakresDolny.Name = "txtZakresDolny";
            this.txtZakresDolny.Size = new System.Drawing.Size(398, 39);
            this.txtZakresDolny.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "Zakres dolny";
            // 
            // txtParametrPolprodukt
            // 
            this.txtParametrPolprodukt.Enabled = false;
            this.txtParametrPolprodukt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParametrPolprodukt.Location = new System.Drawing.Point(23, 150);
            this.txtParametrPolprodukt.Name = "txtParametrPolprodukt";
            this.txtParametrPolprodukt.Size = new System.Drawing.Size(398, 39);
            this.txtParametrPolprodukt.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Parametr półproduktu";
            // 
            // txtPolprodukt
            // 
            this.txtPolprodukt.Enabled = false;
            this.txtPolprodukt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPolprodukt.Location = new System.Drawing.Point(23, 62);
            this.txtPolprodukt.Name = "txtPolprodukt";
            this.txtPolprodukt.Size = new System.Drawing.Size(398, 39);
            this.txtPolprodukt.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Półprodukt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(449, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Wybierz półprodukt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.Location = new System.Drawing.Point(973, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "Wybierz parametr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 16F);
            this.label7.Location = new System.Drawing.Point(449, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Parametry półproduktów";
            // 
            // btnNowyParametr
            // 
            this.btnNowyParametr.Font = new System.Drawing.Font("Arial", 15F);
            this.btnNowyParametr.Location = new System.Drawing.Point(454, 12);
            this.btnNowyParametr.Name = "btnNowyParametr";
            this.btnNowyParametr.Size = new System.Drawing.Size(293, 37);
            this.btnNowyParametr.TabIndex = 52;
            this.btnNowyParametr.Text = "Dodaj nowy parametr";
            this.btnNowyParametr.UseVisualStyleBackColor = true;
            this.btnNowyParametr.Click += new System.EventHandler(this.btnNowyParametr_Click);
            // 
            // FormParametrPolprodukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnNowyParametr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dgvvParametrPolprodukt);
            this.Controls.Add(this.dgvRodzajParametr);
            this.Controls.Add(this.dgvPolprodukt);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtZakresGorny);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZakresDolny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParametrPolprodukt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPolprodukt);
            this.Controls.Add(this.label1);
            this.Name = "FormParametrPolprodukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parametr";
            ((System.ComponentModel.ISupportInitialize)(this.dgvvParametrPolprodukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajParametr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.DataGridView dgvvParametrPolprodukt;
        private System.Windows.Forms.DataGridView dgvRodzajParametr;
        private System.Windows.Forms.DataGridView dgvPolprodukt;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtZakresGorny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZakresDolny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParametrPolprodukt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPolprodukt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNowyParametr;
    }
}