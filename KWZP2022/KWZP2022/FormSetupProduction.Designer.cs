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
            this.btnSPDByproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPDByproduct.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSPDByproduct.Location = new System.Drawing.Point(222, 309);
            this.btnSPDByproduct.Name = "btnSPDByproduct";
            this.btnSPDByproduct.Size = new System.Drawing.Size(350, 100);
            this.btnSPDByproduct.TabIndex = 9;
            this.btnSPDByproduct.Text = "Proces wykonania półproduktu";
            this.btnSPDByproduct.UseVisualStyleBackColor = true;
            // 
            // btnSPDProduct
            // 
            this.btnSPDProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPDProduct.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSPDProduct.Location = new System.Drawing.Point(222, 102);
            this.btnSPDProduct.Name = "btnSPDProduct";
            this.btnSPDProduct.Size = new System.Drawing.Size(350, 100);
            this.btnSPDProduct.TabIndex = 8;
            this.btnSPDProduct.Text = "Proces wykonania produktu";
            this.btnSPDProduct.UseVisualStyleBackColor = true;
            // 
            // FormSetupProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 511);
            this.Controls.Add(this.btnSPDByproduct);
            this.Controls.Add(this.btnSPDProduct);
            this.Name = "FormSetupProduction";
            this.Text = "FormSetupProduction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSPDByproduct;
        private System.Windows.Forms.Button btnSPDProduct;
    }
}