﻿namespace KWZP2022
{
    partial class FormResourceDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResourceDepartment));
            this.btnService = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblResDep = new System.Windows.Forms.Label();
            this.lblMotto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnService.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnService.Location = new System.Drawing.Point(507, 501);
            this.btnService.Margin = new System.Windows.Forms.Padding(4);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(400, 123);
            this.btnService.TabIndex = 5;
            this.btnService.Text = "Obsługi";
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWarehouse.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWarehouse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWarehouse.Location = new System.Drawing.Point(507, 370);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(400, 123);
            this.btnWarehouse.TabIndex = 4;
            this.btnWarehouse.Text = "Magazyn";
            this.btnWarehouse.UseVisualStyleBackColor = false;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder.Location = new System.Drawing.Point(507, 239);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(400, 123);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Zamówienia";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblResDep
            // 
            this.lblResDep.AutoSize = true;
            this.lblResDep.BackColor = System.Drawing.Color.Transparent;
            this.lblResDep.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResDep.ForeColor = System.Drawing.Color.Black;
            this.lblResDep.Location = new System.Drawing.Point(12, 9);
            this.lblResDep.Name = "lblResDep";
            this.lblResDep.Size = new System.Drawing.Size(748, 75);
            this.lblResDep.TabIndex = 7;
            this.lblResDep.Text = "Dział zasobów i dostaw";
            // 
            // lblMotto
            // 
            this.lblMotto.AutoSize = true;
            this.lblMotto.BackColor = System.Drawing.Color.Transparent;
            this.lblMotto.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMotto.ForeColor = System.Drawing.Color.Black;
            this.lblMotto.Location = new System.Drawing.Point(112, 84);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Size = new System.Drawing.Size(336, 57);
            this.lblMotto.TabIndex = 8;
            this.lblMotto.Text = "Znani z działania";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormResourceDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.unknown;
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMotto);
            this.Controls.Add(this.lblResDep);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnOrder);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormResourceDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dział zasobów";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblResDep;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}