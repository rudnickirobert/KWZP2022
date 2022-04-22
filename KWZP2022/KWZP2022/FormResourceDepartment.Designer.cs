namespace KWZP2022
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
            this.btnService.Location = new System.Drawing.Point(444, 510);
            this.btnService.Margin = new System.Windows.Forms.Padding(4);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(400, 123);
            this.btnService.TabIndex = 5;
            this.btnService.Text = "Obsługi";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWarehouse.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnWarehouse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWarehouse.Location = new System.Drawing.Point(444, 369);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(400, 123);
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
            this.btnOrder.Location = new System.Drawing.Point(444, 222);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(400, 123);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Zamówienia";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // FormResourceDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.unknown;
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnOrder);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormResourceDepartment";
            this.Text = "Dział Zasobów";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnOrder;
    }
}