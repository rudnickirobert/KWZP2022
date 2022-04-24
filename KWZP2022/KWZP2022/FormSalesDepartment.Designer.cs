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
            this.btnComplaint = new System.Windows.Forms.Button();
            this.btnOffertsForConsideration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnOrder.Location = new System.Drawing.Point(366, 370);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(300, 100);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Zamówienia";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClient
            // 
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnClient.Location = new System.Drawing.Point(366, 502);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(300, 100);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Klient";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnSale
            // 
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnSale.Location = new System.Drawing.Point(707, 370);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(300, 100);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Sprzedaż";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnComplaint
            // 
            this.btnComplaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplaint.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnComplaint.Location = new System.Drawing.Point(707, 502);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(300, 100);
            this.btnComplaint.TabIndex = 3;
            this.btnComplaint.Text = "Reklamacja";
            this.btnComplaint.UseVisualStyleBackColor = true;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);
            // 
            // btnOffertsForConsideration
            // 
            this.btnOffertsForConsideration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOffertsForConsideration.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnOffertsForConsideration.Location = new System.Drawing.Point(366, 288);
            this.btnOffertsForConsideration.Name = "btnOffertsForConsideration";
            this.btnOffertsForConsideration.Size = new System.Drawing.Size(641, 50);
            this.btnOffertsForConsideration.TabIndex = 4;
            this.btnOffertsForConsideration.Text = "Oferty do rozpatrzenia";
            this.btnOffertsForConsideration.UseVisualStyleBackColor = true;
            this.btnOffertsForConsideration.Click += new System.EventHandler(this.btnOffertsForConsideration_Click);
            // 
            // FormSalesDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnOffertsForConsideration);
            this.Controls.Add(this.btnComplaint);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSalesDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dział handlowy i marketingu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnComplaint;
        private System.Windows.Forms.Button btnOffertsForConsideration;
    }
}