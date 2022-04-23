﻿namespace KWZP2022.Forms
{
    partial class FormDepartments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartments));
            this.btnProductionDepartment = new System.Windows.Forms.Button();
            this.btnSalesDepartment = new System.Windows.Forms.Button();
            this.btnResourceDeparment = new System.Windows.Forms.Button();
            this.btnHumanRsDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductionDepartment
            // 
            this.btnProductionDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductionDepartment.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProductionDepartment.Location = new System.Drawing.Point(527, 417);
            this.btnProductionDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductionDepartment.Name = "btnProductionDepartment";
            this.btnProductionDepartment.Size = new System.Drawing.Size(400, 123);
            this.btnProductionDepartment.TabIndex = 4;
            this.btnProductionDepartment.Text = "Dział produkcji";
            this.btnProductionDepartment.UseVisualStyleBackColor = true;
            this.btnProductionDepartment.Click += new System.EventHandler(this.btnProductionDepartment_Click);
            // 
            // btnSalesDepartment
            // 
            this.btnSalesDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesDepartment.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalesDepartment.Location = new System.Drawing.Point(985, 417);
            this.btnSalesDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesDepartment.Name = "btnSalesDepartment";
            this.btnSalesDepartment.Size = new System.Drawing.Size(400, 123);
            this.btnSalesDepartment.TabIndex = 5;
            this.btnSalesDepartment.Text = "Dział handlowy i marketingu";
            this.btnSalesDepartment.UseVisualStyleBackColor = true;
            this.btnSalesDepartment.Click += new System.EventHandler(this.btnSalesDepartment_Click);
            // 
            // btnResourceDeparment
            // 
            this.btnResourceDeparment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResourceDeparment.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResourceDeparment.Location = new System.Drawing.Point(527, 606);
            this.btnResourceDeparment.Margin = new System.Windows.Forms.Padding(4);
            this.btnResourceDeparment.Name = "btnResourceDeparment";
            this.btnResourceDeparment.Size = new System.Drawing.Size(400, 123);
            this.btnResourceDeparment.TabIndex = 6;
            this.btnResourceDeparment.Text = "Dział zasobów i dostaw";
            this.btnResourceDeparment.UseVisualStyleBackColor = true;
            this.btnResourceDeparment.Click += new System.EventHandler(this.btnResourceDeparment_Click);
            // 
            // btnHumanRsDepartment
            // 
            this.btnHumanRsDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHumanRsDepartment.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHumanRsDepartment.Location = new System.Drawing.Point(985, 606);
            this.btnHumanRsDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnHumanRsDepartment.Name = "btnHumanRsDepartment";
            this.btnHumanRsDepartment.Size = new System.Drawing.Size(400, 123);
            this.btnHumanRsDepartment.TabIndex = 7;
            this.btnHumanRsDepartment.Text = "Dział kadr i przygotowania produkcji";
            this.btnHumanRsDepartment.UseVisualStyleBackColor = true;
            // 
            // FormDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1685, 875);
            this.Controls.Add(this.btnHumanRsDepartment);
            this.Controls.Add(this.btnResourceDeparment);
            this.Controls.Add(this.btnSalesDepartment);
            this.Controls.Add(this.btnProductionDepartment);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDepartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Działy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductionDepartment;
        private System.Windows.Forms.Button btnSalesDepartment;
        private System.Windows.Forms.Button btnResourceDeparment;
        private System.Windows.Forms.Button btnHumanRsDepartment;
    }
}