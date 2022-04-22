
namespace KWZP2022
{
    partial class FormSalesDepartmentOrderDetails
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
            this.dgvOD = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.textBoxOD = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOD
            // 
            this.dgvOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOD.Location = new System.Drawing.Point(44, 173);
            this.dgvOD.Name = "dgvOD";
            this.dgvOD.Size = new System.Drawing.Size(426, 233);
            this.dgvOD.TabIndex = 0;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(503, 96);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(234, 273);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Wyświetl";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // textBoxOD
            // 
            this.textBoxOD.Location = new System.Drawing.Point(80, 77);
            this.textBoxOD.Name = "textBoxOD";
            this.textBoxOD.Size = new System.Drawing.Size(100, 20);
            this.textBoxOD.TabIndex = 2;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(65, 51);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(127, 13);
            this.lblOrderNumber.TabIndex = 3;
            this.lblOrderNumber.Text = "Podaj numer zamówienia:";
            // 
            // FormSalesDepartmentOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.textBoxOD);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dgvOD);
            this.Name = "FormSalesDepartmentOrderDetails";
            this.Text = "FormSalesDepartmentOrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOD;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.TextBox textBoxOD;
        private System.Windows.Forms.Label lblOrderNumber;
    }
}