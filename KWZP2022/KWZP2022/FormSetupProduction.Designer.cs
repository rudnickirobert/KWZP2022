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
            this.btnSPDByproduct = new System.Windows.Forms.Button();
            this.btnSPDProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSPDByproduct
            // 
            this.btnSPDByproduct.BackColor = System.Drawing.Color.Cyan;
            this.btnSPDByproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPDByproduct.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSPDByproduct.Location = new System.Drawing.Point(296, 380);
            this.btnSPDByproduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSPDByproduct.Name = "btnSPDByproduct";
            this.btnSPDByproduct.Size = new System.Drawing.Size(467, 123);
            this.btnSPDByproduct.TabIndex = 9;
            this.btnSPDByproduct.Text = "Proces wykonania półproduktu";
            this.btnSPDByproduct.UseVisualStyleBackColor = false;
            this.btnSPDByproduct.Click += new System.EventHandler(this.btnSPDByproduct_Click);
            // 
            // btnSPDProduct
            // 
            this.btnSPDProduct.BackColor = System.Drawing.Color.Red;
            this.btnSPDProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPDProduct.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSPDProduct.Location = new System.Drawing.Point(296, 126);
            this.btnSPDProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSPDProduct.Name = "btnSPDProduct";
            this.btnSPDProduct.Size = new System.Drawing.Size(467, 123);
            this.btnSPDProduct.TabIndex = 8;
            this.btnSPDProduct.Text = "Proces wykonania produktu";
            this.btnSPDProduct.UseVisualStyleBackColor = false;
            this.btnSPDProduct.Click += new System.EventHandler(this.btnSPDProduct_Click);
            // 
            // FormSetupProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(1059, 629);
            this.Controls.Add(this.btnSPDByproduct);
            this.Controls.Add(this.btnSPDProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSetupProduction";
            this.Text = "Procesy wykonania";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSPDByproduct;
        private System.Windows.Forms.Button btnSPDProduct;
    }
}