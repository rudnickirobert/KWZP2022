﻿namespace KWZP2022
{
    partial class FormResDepParametryMaszyna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepParametryMaszyna));
            this.btnWczytajParametr = new System.Windows.Forms.Button();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtZakresDol = new System.Windows.Forms.TextBox();
            this.txtZakresGora = new System.Windows.Forms.TextBox();
            this.cmbParametr = new System.Windows.Forms.ComboBox();
            this.lblZakresdol = new System.Windows.Forms.Label();
            this.lblZakresgora = new System.Windows.Forms.Label();
            this.lblParametr = new System.Windows.Forms.Label();
            this.cmbMaszyna = new System.Windows.Forms.ComboBox();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.dgvParametrMaszyna = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrMaszyna)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWczytajParametr
            // 
            this.btnWczytajParametr.BackColor = System.Drawing.Color.Violet;
            this.btnWczytajParametr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnWczytajParametr.Location = new System.Drawing.Point(221, 36);
            this.btnWczytajParametr.Name = "btnWczytajParametr";
            this.btnWczytajParametr.Size = new System.Drawing.Size(181, 35);
            this.btnWczytajParametr.TabIndex = 35;
            this.btnWczytajParametr.Text = "Wczytaj parametry";
            this.btnWczytajParametr.UseVisualStyleBackColor = false;
            this.btnWczytajParametr.Click += new System.EventHandler(this.btnWczytajParametr_Click);
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(498, 373);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(225, 37);
            this.btnAktualizuj.TabIndex = 34;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(498, 425);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(225, 37);
            this.btnUsun.TabIndex = 33;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(498, 312);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(225, 37);
            this.btnDodaj.TabIndex = 32;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtZakresDol
            // 
            this.txtZakresDol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtZakresDol.Location = new System.Drawing.Point(191, 373);
            this.txtZakresDol.Name = "txtZakresDol";
            this.txtZakresDol.Size = new System.Drawing.Size(168, 32);
            this.txtZakresDol.TabIndex = 31;
            // 
            // txtZakresGora
            // 
            this.txtZakresGora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtZakresGora.Location = new System.Drawing.Point(191, 424);
            this.txtZakresGora.Name = "txtZakresGora";
            this.txtZakresGora.Size = new System.Drawing.Size(168, 32);
            this.txtZakresGora.TabIndex = 30;
            // 
            // cmbParametr
            // 
            this.cmbParametr.Font = new System.Drawing.Font("Arial", 16.25F);
            this.cmbParametr.FormattingEnabled = true;
            this.cmbParametr.Location = new System.Drawing.Point(191, 315);
            this.cmbParametr.Name = "cmbParametr";
            this.cmbParametr.Size = new System.Drawing.Size(237, 33);
            this.cmbParametr.TabIndex = 29;
            // 
            // lblZakresdol
            // 
            this.lblZakresdol.AutoSize = true;
            this.lblZakresdol.BackColor = System.Drawing.Color.Transparent;
            this.lblZakresdol.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblZakresdol.Location = new System.Drawing.Point(29, 379);
            this.lblZakresdol.Name = "lblZakresdol";
            this.lblZakresdol.Size = new System.Drawing.Size(111, 25);
            this.lblZakresdol.TabIndex = 28;
            this.lblZakresdol.Text = "Zakres dół";
            // 
            // lblZakresgora
            // 
            this.lblZakresgora.AutoSize = true;
            this.lblZakresgora.BackColor = System.Drawing.Color.Transparent;
            this.lblZakresgora.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblZakresgora.Location = new System.Drawing.Point(29, 431);
            this.lblZakresgora.Name = "lblZakresgora";
            this.lblZakresgora.Size = new System.Drawing.Size(126, 25);
            this.lblZakresgora.TabIndex = 27;
            this.lblZakresgora.Text = "Zakres góra";
            // 
            // lblParametr
            // 
            this.lblParametr.AutoSize = true;
            this.lblParametr.BackColor = System.Drawing.Color.Transparent;
            this.lblParametr.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParametr.Location = new System.Drawing.Point(28, 312);
            this.lblParametr.Name = "lblParametr";
            this.lblParametr.Size = new System.Drawing.Size(124, 32);
            this.lblParametr.TabIndex = 26;
            this.lblParametr.Text = "Parametr";
            // 
            // cmbMaszyna
            // 
            this.cmbMaszyna.Font = new System.Drawing.Font("Arial", 16.25F);
            this.cmbMaszyna.FormattingEnabled = true;
            this.cmbMaszyna.Location = new System.Drawing.Point(34, 83);
            this.cmbMaszyna.Name = "cmbMaszyna";
            this.cmbMaszyna.Size = new System.Drawing.Size(338, 33);
            this.cmbMaszyna.TabIndex = 25;
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 20.25F);
            this.lblNazwa.Location = new System.Drawing.Point(28, 39);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(123, 32);
            this.lblNazwa.TabIndex = 24;
            this.lblNazwa.Text = "Maszyna";
            // 
            // dgvParametrMaszyna
            // 
            this.dgvParametrMaszyna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametrMaszyna.Location = new System.Drawing.Point(32, 128);
            this.dgvParametrMaszyna.Name = "dgvParametrMaszyna";
            this.dgvParametrMaszyna.Size = new System.Drawing.Size(738, 161);
            this.dgvParametrMaszyna.TabIndex = 23;
            // 
            // FormRedDepParametryMaszyna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 498);
            this.Controls.Add(this.btnWczytajParametr);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtZakresDol);
            this.Controls.Add(this.txtZakresGora);
            this.Controls.Add(this.cmbParametr);
            this.Controls.Add(this.lblZakresdol);
            this.Controls.Add(this.lblZakresgora);
            this.Controls.Add(this.lblParametr);
            this.Controls.Add(this.cmbMaszyna);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.dgvParametrMaszyna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRedDepParametryMaszyna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parametry maszyny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrMaszyna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWczytajParametr;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtZakresDol;
        private System.Windows.Forms.TextBox txtZakresGora;
        private System.Windows.Forms.ComboBox cmbParametr;
        private System.Windows.Forms.Label lblZakresdol;
        private System.Windows.Forms.Label lblZakresgora;
        private System.Windows.Forms.Label lblParametr;
        private System.Windows.Forms.ComboBox cmbMaszyna;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.DataGridView dgvParametrMaszyna;
    }
}