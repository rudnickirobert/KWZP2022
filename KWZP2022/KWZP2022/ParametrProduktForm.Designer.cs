﻿namespace KWZP2022
{
    partial class ParametrProduktForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdukt = new System.Windows.Forms.TextBox();
            this.txtParametrProdukt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZakresDolny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZakresGorny = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvProdukt = new System.Windows.Forms.DataGridView();
            this.dgvRodzajParametr = new System.Windows.Forms.DataGridView();
            this.dgvvParametrProdukt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajParametr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvParametrProdukt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkt";
            // 
            // txtProdukt
            // 
            this.txtProdukt.Enabled = false;
            this.txtProdukt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProdukt.Location = new System.Drawing.Point(28, 78);
            this.txtProdukt.Name = "txtProdukt";
            this.txtProdukt.Size = new System.Drawing.Size(297, 26);
            this.txtProdukt.TabIndex = 1;
            // 
            // txtParametrProdukt
            // 
            this.txtParametrProdukt.Enabled = false;
            this.txtParametrProdukt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParametrProdukt.Location = new System.Drawing.Point(28, 166);
            this.txtParametrProdukt.Name = "txtParametrProdukt";
            this.txtParametrProdukt.Size = new System.Drawing.Size(297, 26);
            this.txtParametrProdukt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parametr produktu";
            // 
            // txtZakresDolny
            // 
            this.txtZakresDolny.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZakresDolny.Location = new System.Drawing.Point(28, 280);
            this.txtZakresDolny.Name = "txtZakresDolny";
            this.txtZakresDolny.Size = new System.Drawing.Size(297, 26);
            this.txtZakresDolny.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zakres dolny";
            // 
            // txtZakresGorny
            // 
            this.txtZakresGorny.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZakresGorny.Location = new System.Drawing.Point(28, 366);
            this.txtZakresGorny.Name = "txtZakresGorny";
            this.txtZakresGorny.Size = new System.Drawing.Size(297, 26);
            this.txtZakresGorny.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Zakres górny";
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Enabled = false;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(28, 524);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 13;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(28, 585);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 12;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(28, 643);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 11;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(28, 465);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvProdukt
            // 
            this.dgvProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukt.Location = new System.Drawing.Point(454, 66);
            this.dgvProdukt.Name = "dgvProdukt";
            this.dgvProdukt.Size = new System.Drawing.Size(472, 223);
            this.dgvProdukt.TabIndex = 14;
            this.dgvProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukt_CellContentClick);
            // 
            // dgvRodzajParametr
            // 
            this.dgvRodzajParametr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRodzajParametr.Location = new System.Drawing.Point(946, 66);
            this.dgvRodzajParametr.Name = "dgvRodzajParametr";
            this.dgvRodzajParametr.Size = new System.Drawing.Size(231, 223);
            this.dgvRodzajParametr.TabIndex = 15;
            this.dgvRodzajParametr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRodzajParametr_CellContentClick);
            // 
            // dgvvParametrProdukt
            // 
            this.dgvvParametrProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvParametrProdukt.Location = new System.Drawing.Point(454, 295);
            this.dgvvParametrProdukt.MultiSelect = false;
            this.dgvvParametrProdukt.Name = "dgvvParametrProdukt";
            this.dgvvParametrProdukt.Size = new System.Drawing.Size(798, 404);
            this.dgvvParametrProdukt.TabIndex = 18;
            this.dgvvParametrProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvParametrProdukt_CellContentClick);
            // 
            // ParametrProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.dgvvParametrProdukt);
            this.Controls.Add(this.dgvRodzajParametr);
            this.Controls.Add(this.dgvProdukt);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtZakresGorny);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZakresDolny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParametrProdukt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdukt);
            this.Controls.Add(this.label1);
            this.Name = "ParametrProduktForm";
            this.Text = "ParametrProduktForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajParametr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvParametrProdukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdukt;
        private System.Windows.Forms.TextBox txtParametrProdukt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZakresDolny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZakresGorny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvProdukt;
        private System.Windows.Forms.DataGridView dgvRodzajParametr;
        private System.Windows.Forms.DataGridView dgvvParametrProdukt;
    }
}