﻿namespace KWZP2022
{
    partial class FormResDepMagazynMaszyn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepMagazynMaszyn));
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajMaszyna = new System.Windows.Forms.Button();
            this.dgvMagazynMaszyna = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynMaszyna)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.Aqua;
            this.btnOdswiez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnOdswiez.Location = new System.Drawing.Point(657, 113);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(110, 33);
            this.btnOdswiez.TabIndex = 53;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 37);
            this.label1.TabIndex = 52;
            this.label1.Text = "Magazyn dostępnych maszyn";
            // 
            // btnDodajMaszyna
            // 
            this.btnDodajMaszyna.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajMaszyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajMaszyna.Location = new System.Drawing.Point(36, 113);
            this.btnDodajMaszyna.Name = "btnDodajMaszyna";
            this.btnDodajMaszyna.Size = new System.Drawing.Size(254, 42);
            this.btnDodajMaszyna.TabIndex = 51;
            this.btnDodajMaszyna.Text = "Złóż zamówienie maszyny";
            this.btnDodajMaszyna.UseVisualStyleBackColor = false;
            this.btnDodajMaszyna.Click += new System.EventHandler(this.btnDodajMaszyna_Click);
            // 
            // dgvMagazynMaszyna
            // 
            this.dgvMagazynMaszyna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynMaszyna.Location = new System.Drawing.Point(36, 192);
            this.dgvMagazynMaszyna.Name = "dgvMagazynMaszyna";
            this.dgvMagazynMaszyna.Size = new System.Drawing.Size(731, 264);
            this.dgvMagazynMaszyna.TabIndex = 50;
            // 
            // FormResDepMagazynMaszyn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 496);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajMaszyna);
            this.Controls.Add(this.dgvMagazynMaszyna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepMagazynMaszyn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Magazyn maszyn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynMaszyna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajMaszyna;
        private System.Windows.Forms.DataGridView dgvMagazynMaszyna;
    }
}