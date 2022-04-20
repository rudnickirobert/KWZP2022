namespace KWZP2022
{
    partial class DzialZasobowFORM
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
            this.btnService = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnService
            // 
            this.btnService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnService.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnService.Location = new System.Drawing.Point(510, 516);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(300, 100);
            this.btnService.TabIndex = 5;
            this.btnService.Text = "Obsługi";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnWarehouse.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnWarehouse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWarehouse.Location = new System.Drawing.Point(510, 386);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(300, 100);
            this.btnWarehouse.TabIndex = 4;
            this.btnWarehouse.Text = "Magazyn";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder.Location = new System.Drawing.Point(510, 254);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(300, 100);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Zamówienia";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // DzialZasobowFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.unknown;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnOrder);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "DzialZasobowFORM";
            this.Text = "DzialZasobowFORM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnOrder;
    }
}