﻿namespace KWZP2022
{
    partial class FormResDepServicesExchanged
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepServicesExchanged));
            this.btnDodajWymiane = new System.Windows.Forms.Button();
            this.dgvObslugiWymiana = new System.Windows.Forms.DataGridView();
            this.dgvCzesci = new System.Windows.Forms.DataGridView();
            this.txtWybranaObsluga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaszyna = new System.Windows.Forms.Label();
            this.txtMaszynaWybrana = new System.Windows.Forms.TextBox();
            this.btnUsunWymiane = new System.Windows.Forms.Button();
            this.dgvMaszyny = new System.Windows.Forms.DataGridView();
            this.btnWyborObslugi = new System.Windows.Forms.Button();
            this.btnWyborMaszyny = new System.Windows.Forms.Button();
            this.dgvHistoriaWymian = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObslugiWymiana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaWymian)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajWymiane
            // 
            this.btnDodajWymiane.BackColor = System.Drawing.Color.Lime;
            this.btnDodajWymiane.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajWymiane.Location = new System.Drawing.Point(852, 164);
            this.btnDodajWymiane.Name = "btnDodajWymiane";
            this.btnDodajWymiane.Size = new System.Drawing.Size(134, 43);
            this.btnDodajWymiane.TabIndex = 91;
            this.btnDodajWymiane.Text = "Dodaj Wymianę";
            this.btnDodajWymiane.UseVisualStyleBackColor = false;
            this.btnDodajWymiane.Visible = false;
            this.btnDodajWymiane.Click += new System.EventHandler(this.btnDodajWymiane_Click);
            // 
            // dgvObslugiWymiana
            // 
            this.dgvObslugiWymiana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObslugiWymiana.Location = new System.Drawing.Point(13, 85);
            this.dgvObslugiWymiana.Name = "dgvObslugiWymiana";
            this.dgvObslugiWymiana.Size = new System.Drawing.Size(337, 288);
            this.dgvObslugiWymiana.TabIndex = 94;
            // 
            // dgvCzesci
            // 
            this.dgvCzesci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzesci.Location = new System.Drawing.Point(852, 213);
            this.dgvCzesci.Name = "dgvCzesci";
            this.dgvCzesci.Size = new System.Drawing.Size(414, 457);
            this.dgvCzesci.TabIndex = 98;
            // 
            // txtWybranaObsluga
            // 
            this.txtWybranaObsluga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWybranaObsluga.Location = new System.Drawing.Point(953, 83);
            this.txtWybranaObsluga.Name = "txtWybranaObsluga";
            this.txtWybranaObsluga.Size = new System.Drawing.Size(301, 26);
            this.txtWybranaObsluga.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(861, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 101;
            this.label1.Text = "Obsługa";
            // 
            // lblMaszyna
            // 
            this.lblMaszyna.AutoSize = true;
            this.lblMaszyna.BackColor = System.Drawing.Color.Transparent;
            this.lblMaszyna.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaszyna.Location = new System.Drawing.Point(861, 117);
            this.lblMaszyna.Name = "lblMaszyna";
            this.lblMaszyna.Size = new System.Drawing.Size(93, 24);
            this.lblMaszyna.TabIndex = 103;
            this.lblMaszyna.Text = "Maszyna";
            // 
            // txtMaszynaWybrana
            // 
            this.txtMaszynaWybrana.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMaszynaWybrana.Location = new System.Drawing.Point(953, 115);
            this.txtMaszynaWybrana.Name = "txtMaszynaWybrana";
            this.txtMaszynaWybrana.Size = new System.Drawing.Size(301, 26);
            this.txtMaszynaWybrana.TabIndex = 102;
            // 
            // btnUsunWymiane
            // 
            this.btnUsunWymiane.BackColor = System.Drawing.Color.Red;
            this.btnUsunWymiane.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunWymiane.Location = new System.Drawing.Point(1132, 164);
            this.btnUsunWymiane.Name = "btnUsunWymiane";
            this.btnUsunWymiane.Size = new System.Drawing.Size(134, 43);
            this.btnUsunWymiane.TabIndex = 105;
            this.btnUsunWymiane.Text = "Usuń Wymianę";
            this.btnUsunWymiane.UseVisualStyleBackColor = false;
            this.btnUsunWymiane.Visible = false;
            this.btnUsunWymiane.Click += new System.EventHandler(this.btnUsunWymiane_Click);
            // 
            // dgvMaszyny
            // 
            this.dgvMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszyny.Location = new System.Drawing.Point(397, 85);
            this.dgvMaszyny.Name = "dgvMaszyny";
            this.dgvMaszyny.Size = new System.Drawing.Size(351, 288);
            this.dgvMaszyny.TabIndex = 106;
            // 
            // btnWyborObslugi
            // 
            this.btnWyborObslugi.BackColor = System.Drawing.Color.Lime;
            this.btnWyborObslugi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyborObslugi.Location = new System.Drawing.Point(71, 36);
            this.btnWyborObslugi.Name = "btnWyborObslugi";
            this.btnWyborObslugi.Size = new System.Drawing.Size(212, 43);
            this.btnWyborObslugi.TabIndex = 107;
            this.btnWyborObslugi.Text = "Zatwierdź Wybór Obsługi";
            this.btnWyborObslugi.UseVisualStyleBackColor = false;
            this.btnWyborObslugi.Click += new System.EventHandler(this.btnWyborObslugi_Click);
            // 
            // btnWyborMaszyny
            // 
            this.btnWyborMaszyny.BackColor = System.Drawing.Color.Lime;
            this.btnWyborMaszyny.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyborMaszyny.Location = new System.Drawing.Point(460, 36);
            this.btnWyborMaszyny.Name = "btnWyborMaszyny";
            this.btnWyborMaszyny.Size = new System.Drawing.Size(212, 43);
            this.btnWyborMaszyny.TabIndex = 108;
            this.btnWyborMaszyny.Text = "Zatwierdź Wybór Maszyny";
            this.btnWyborMaszyny.UseVisualStyleBackColor = false;
            this.btnWyborMaszyny.Visible = false;
            this.btnWyborMaszyny.Click += new System.EventHandler(this.btnWyborMaszyny_Click);
            // 
            // dgvHistoriaWymian
            // 
            this.dgvHistoriaWymian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriaWymian.Location = new System.Drawing.Point(13, 382);
            this.dgvHistoriaWymian.Name = "dgvHistoriaWymian";
            this.dgvHistoriaWymian.Size = new System.Drawing.Size(735, 288);
            this.dgvHistoriaWymian.TabIndex = 109;
            // 
            // FormResDepServicesExchanged
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1280, 711);
            this.Controls.Add(this.dgvHistoriaWymian);
            this.Controls.Add(this.btnWyborMaszyny);
            this.Controls.Add(this.btnWyborObslugi);
            this.Controls.Add(this.dgvMaszyny);
            this.Controls.Add(this.btnUsunWymiane);
            this.Controls.Add(this.lblMaszyna);
            this.Controls.Add(this.txtMaszynaWybrana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWybranaObsluga);
            this.Controls.Add(this.dgvCzesci);
            this.Controls.Add(this.dgvObslugiWymiana);
            this.Controls.Add(this.btnDodajWymiane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepServicesExchanged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormResDepServicesExchanged";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObslugiWymiana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaWymian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajWymiane;
        private System.Windows.Forms.DataGridView dgvObslugiWymiana;
        private System.Windows.Forms.DataGridView dgvCzesci;
        private System.Windows.Forms.TextBox txtWybranaObsluga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaszyna;
        private System.Windows.Forms.TextBox txtMaszynaWybrana;
        private System.Windows.Forms.Button btnUsunWymiane;
        private System.Windows.Forms.DataGridView dgvMaszyny;
        private System.Windows.Forms.Button btnWyborObslugi;
        private System.Windows.Forms.Button btnWyborMaszyny;
        private System.Windows.Forms.DataGridView dgvHistoriaWymian;
    }
}