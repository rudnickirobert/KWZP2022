﻿namespace KWZP2022
{
    partial class FormResDepMagazyny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepMagazyny));
            this.btnMagazyn_maszyna = new System.Windows.Forms.Button();
            this.btnMagazyn_narzedzie = new System.Windows.Forms.Button();
            this.btnMagazyn_czesc = new System.Windows.Forms.Button();
            this.btnMagazyn_material = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMagazyn_maszyna
            // 
            this.btnMagazyn_maszyna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagazyn_maszyna.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnMagazyn_maszyna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMagazyn_maszyna.Location = new System.Drawing.Point(710, 445);
            this.btnMagazyn_maszyna.Margin = new System.Windows.Forms.Padding(4);
            this.btnMagazyn_maszyna.Name = "btnMagazyn_maszyna";
            this.btnMagazyn_maszyna.Size = new System.Drawing.Size(258, 92);
            this.btnMagazyn_maszyna.TabIndex = 13;
            this.btnMagazyn_maszyna.Text = "Magazyn maszyn";
            this.btnMagazyn_maszyna.UseVisualStyleBackColor = true;
            // 
            // btnMagazyn_narzedzie
            // 
            this.btnMagazyn_narzedzie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagazyn_narzedzie.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnMagazyn_narzedzie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMagazyn_narzedzie.Location = new System.Drawing.Point(396, 445);
            this.btnMagazyn_narzedzie.Margin = new System.Windows.Forms.Padding(4);
            this.btnMagazyn_narzedzie.Name = "btnMagazyn_narzedzie";
            this.btnMagazyn_narzedzie.Size = new System.Drawing.Size(258, 92);
            this.btnMagazyn_narzedzie.TabIndex = 12;
            this.btnMagazyn_narzedzie.Text = "Magazyn narzędzi";
            this.btnMagazyn_narzedzie.UseVisualStyleBackColor = true;
            // 
            // btnMagazyn_czesc
            // 
            this.btnMagazyn_czesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagazyn_czesc.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnMagazyn_czesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMagazyn_czesc.Location = new System.Drawing.Point(710, 328);
            this.btnMagazyn_czesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnMagazyn_czesc.Name = "btnMagazyn_czesc";
            this.btnMagazyn_czesc.Size = new System.Drawing.Size(258, 92);
            this.btnMagazyn_czesc.TabIndex = 11;
            this.btnMagazyn_czesc.Text = "Magazyn części";
            this.btnMagazyn_czesc.UseVisualStyleBackColor = true;
            // 
            // btnMagazyn_material
            // 
            this.btnMagazyn_material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagazyn_material.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnMagazyn_material.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMagazyn_material.Location = new System.Drawing.Point(396, 328);
            this.btnMagazyn_material.Margin = new System.Windows.Forms.Padding(4);
            this.btnMagazyn_material.Name = "btnMagazyn_material";
            this.btnMagazyn_material.Size = new System.Drawing.Size(258, 92);
            this.btnMagazyn_material.TabIndex = 10;
            this.btnMagazyn_material.Text = "Magazyn materiałów";
            this.btnMagazyn_material.UseVisualStyleBackColor = true;
            // 
            // FormResDepMagazyny
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.btnMagazyn_maszyna);
            this.Controls.Add(this.btnMagazyn_narzedzie);
            this.Controls.Add(this.btnMagazyn_czesc);
            this.Controls.Add(this.btnMagazyn_material);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormResDepMagazyny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Magazyny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMagazyn_maszyna;
        private System.Windows.Forms.Button btnMagazyn_narzedzie;
        private System.Windows.Forms.Button btnMagazyn_czesc;
        private System.Windows.Forms.Button btnMagazyn_material;
    }
}