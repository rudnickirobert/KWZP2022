﻿namespace KWZP2022
{
    partial class FormResDepDodajMaszyna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepDodajMaszyna));
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodajRodzaj = new System.Windows.Forms.Button();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtNazwaRodzaj = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.Ivory;
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(343, 257);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(157, 37);
            this.btnOdswiez.TabIndex = 67;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnDodajRodzaj
            // 
            this.btnDodajRodzaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodajRodzaj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajRodzaj.Location = new System.Drawing.Point(98, 257);
            this.btnDodajRodzaj.Name = "btnDodajRodzaj";
            this.btnDodajRodzaj.Size = new System.Drawing.Size(239, 37);
            this.btnDodajRodzaj.TabIndex = 66;
            this.btnDodajRodzaj.Text = "Dodaj nowy rodzaj";
            this.btnDodajRodzaj.UseVisualStyleBackColor = false;
            this.btnDodajRodzaj.Click += new System.EventHandler(this.btnDodajRodzaj_Click);
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(79, 71);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(91, 27);
            this.lblNazwa.TabIndex = 65;
            this.lblNazwa.Text = "Nazwa ";
            // 
            // txtNazwaRodzaj
            // 
            this.txtNazwaRodzaj.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaRodzaj.Location = new System.Drawing.Point(176, 63);
            this.txtNazwaRodzaj.Name = "txtNazwaRodzaj";
            this.txtNazwaRodzaj.Size = new System.Drawing.Size(324, 35);
            this.txtNazwaRodzaj.TabIndex = 64;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(176, 115);
            this.txtOpis.MaxLength = 50;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(324, 123);
            this.txtOpis.TabIndex = 68;
            this.txtOpis.Text = "";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.BackColor = System.Drawing.Color.Transparent;
            this.lblOpis.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(79, 115);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(62, 27);
            this.lblOpis.TabIndex = 69;
            this.lblOpis.Text = "Opis";
            // 
            // FormResDepDodajMaszyna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 363);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodajRodzaj);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.txtNazwaRodzaj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepDodajMaszyna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie nowego rodzaju maszyny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodajRodzaj;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwaRodzaj;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
    }
}