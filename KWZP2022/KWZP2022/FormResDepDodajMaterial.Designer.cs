﻿namespace KWZP2022
{
    partial class FormResDepDodajMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepDodajMaterial));
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtNazwaRodzaj = new System.Windows.Forms.TextBox();
            this.btnDodajRodzaj = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(31, 79);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(91, 27);
            this.lblNazwa.TabIndex = 4;
            this.lblNazwa.Text = "Nazwa ";
            // 
            // txtNazwaRodzaj
            // 
            this.txtNazwaRodzaj.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaRodzaj.Location = new System.Drawing.Point(159, 71);
            this.txtNazwaRodzaj.Name = "txtNazwaRodzaj";
            this.txtNazwaRodzaj.Size = new System.Drawing.Size(324, 35);
            this.txtNazwaRodzaj.TabIndex = 3;
            // 
            // btnDodajRodzaj
            // 
            this.btnDodajRodzaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodajRodzaj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajRodzaj.Location = new System.Drawing.Point(36, 125);
            this.btnDodajRodzaj.Name = "btnDodajRodzaj";
            this.btnDodajRodzaj.Size = new System.Drawing.Size(239, 37);
            this.btnDodajRodzaj.TabIndex = 21;
            this.btnDodajRodzaj.Text = "Dodaj nowy rodzaj";
            this.btnDodajRodzaj.UseVisualStyleBackColor = false;
            this.btnDodajRodzaj.Click += new System.EventHandler(this.btnDodajRodzaj_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.Ivory;
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(281, 125);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(157, 37);
            this.btnOdswiez.TabIndex = 63;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // FormResDepDodajMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 291);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodajRodzaj);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.txtNazwaRodzaj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepDodajMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie nowego rodzaju materiału";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwaRodzaj;
        private System.Windows.Forms.Button btnDodajRodzaj;
        private System.Windows.Forms.Button btnOdswiez;
    }
}