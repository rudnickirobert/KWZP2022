namespace KWZP2022
{
    partial class FormHRDeprtmentRemoweWorker
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
            this.dgvWorkerRemowe = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerRemowe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkerRemowe
            // 
            this.dgvWorkerRemowe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkerRemowe.Location = new System.Drawing.Point(24, 113);
            this.dgvWorkerRemowe.Name = "dgvWorkerRemowe";
            this.dgvWorkerRemowe.RowHeadersWidth = 51;
            this.dgvWorkerRemowe.RowTemplate.Height = 24;
            this.dgvWorkerRemowe.Size = new System.Drawing.Size(1221, 451);
            this.dgvWorkerRemowe.TabIndex = 1;
            this.dgvWorkerRemowe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvWorkerRemove_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1170, 63);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Usuń";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormHRDeprtmentRemoweWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 576);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvWorkerRemowe);
            this.Name = "FormHRDeprtmentRemoweWorker";
            this.Text = "FormHRDeprtmentRemoweWorker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerRemowe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkerRemowe;
        private System.Windows.Forms.Button btnClose;
    }
}