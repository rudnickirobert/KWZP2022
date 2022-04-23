namespace KWZP2022
{
    partial class FormSetupProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetupProduction));
            this.btnSPDProduct = new System.Windows.Forms.Button();
            this.btnSPDByproduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSPDProduct
            // 
            this.btnSPDProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPDProduct.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSPDProduct.Location = new System.Drawing.Point(406, 158);
            this.btnSPDProduct.Name = "btnSPDProduct";
            this.btnSPDProduct.Size = new System.Drawing.Size(350, 100);
            this.btnSPDProduct.TabIndex = 4;
            this.btnSPDProduct.Text = "Proces wykonania produktu";
            this.btnSPDProduct.UseVisualStyleBackColor = true;
            this.btnSPDProduct.Click += new System.EventHandler(this.btnSPDProduct_Click);
            // 
            // btnSPDByproduct
            // 
            this.btnSPDByproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPDByproduct.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSPDByproduct.Location = new System.Drawing.Point(406, 365);
            this.btnSPDByproduct.Name = "btnSPDByproduct";
            this.btnSPDByproduct.Size = new System.Drawing.Size(350, 100);
            this.btnSPDByproduct.TabIndex = 5;
            this.btnSPDByproduct.Text = "Proces wykonania półproduktu";
            this.btnSPDByproduct.UseVisualStyleBackColor = true;
            this.btnSPDByproduct.Click += new System.EventHandler(this.btnSPDByproduct_Click);
            // 
            // FormSetupProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnSPDByproduct);
            this.Controls.Add(this.btnSPDProduct);
            this.Name = "FormSetupProduction";
            this.Text = "FormSetupProduction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSPDProduct;
        private System.Windows.Forms.Button btnSPDByproduct;
    }
}