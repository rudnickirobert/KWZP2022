namespace KWZP2022
{
    partial class FormSalesDepartmentClientRemoveClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesDepartmentClientRemoveClient));
            this.dgvClientRemove = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientRemove
            // 
            this.dgvClientRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientRemove.Location = new System.Drawing.Point(12, 62);
            this.dgvClientRemove.Name = "dgvClientRemove";
            this.dgvClientRemove.Size = new System.Drawing.Size(770, 384);
            this.dgvClientRemove.TabIndex = 0;
            this.dgvClientRemove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientRemove_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(682, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormSalesDepartmentClientRemoveClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvClientRemove);
            this.Name = "FormSalesDepartmentClientRemoveClient";
            this.Text = "FormSalesDepartmentClientRemoveClient";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientRemove;
        private System.Windows.Forms.Button btnClose;
    }
}