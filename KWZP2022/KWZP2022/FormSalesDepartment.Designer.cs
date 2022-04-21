namespace KWZP2022
{
    partial class FormSalesDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesDepartment));
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnOrder.Location = new System.Drawing.Point(696, 324);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(400, 123);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Zamówienia";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClient
            // 
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnClient.Location = new System.Drawing.Point(696, 486);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(400, 123);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Klient";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnSale
            // 
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnSale.Location = new System.Drawing.Point(696, 646);
            this.btnSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(400, 123);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Sprzedaż";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // FormSalesDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1685, 875);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSalesDepartment";
            this.Text = "Dział handlowy i marketingu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnSale;
    }
}