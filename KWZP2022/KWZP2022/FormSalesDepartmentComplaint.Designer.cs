
namespace KWZP2022
{
    partial class FormSalesDepartmentComplaint
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
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAddReturn.Location = new System.Drawing.Point(321, 449);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(152, 30);
            this.btnAddReturn.TabIndex = 0;
            this.btnAddReturn.Text = "Dodaj Zwrot";
            this.btnAddReturn.UseVisualStyleBackColor = true;
            // 
            // FormSalesDepartmentComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnAddReturn);
            this.Name = "FormSalesDepartmentComplaint";
            this.Text = "Reklamacja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddReturn;
    }
}