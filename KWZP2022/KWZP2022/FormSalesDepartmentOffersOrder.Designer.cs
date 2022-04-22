namespace KWZP2022
{
    partial class FormSalesDepartmentOffersOrder
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
            this.dgvOffers = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOffers = new System.Windows.Forms.TextBox();
            this.btnOffers = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOffers
            // 
            this.dgvOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffers.Location = new System.Drawing.Point(7, 170);
            this.dgvOffers.Name = "dgvOffers";
            this.dgvOffers.RowHeadersWidth = 51;
            this.dgvOffers.RowTemplate.Height = 24;
            this.dgvOffers.Size = new System.Drawing.Size(1150, 342);
            this.dgvOffers.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(492, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Wprowadź nr zamówienia";
            // 
            // textBoxOffers
            // 
            this.textBoxOffers.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOffers.Location = new System.Drawing.Point(496, 76);
            this.textBoxOffers.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOffers.Name = "textBoxOffers";
            this.textBoxOffers.Size = new System.Drawing.Size(201, 30);
            this.textBoxOffers.TabIndex = 51;
            // 
            // btnOffers
            // 
            this.btnOffers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOffers.Location = new System.Drawing.Point(496, 112);
            this.btnOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(201, 30);
            this.btnOffers.TabIndex = 50;
            this.btnOffers.Text = "Wyszukaj oferty";
            this.btnOffers.UseVisualStyleBackColor = true;
            this.btnOffers.Click += new System.EventHandler(this.btnOffers_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(956, 517);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(201, 30);
            this.btnRefresh.TabIndex = 53;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // FormSalesDepartmentOffersOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 577);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOffers);
            this.Controls.Add(this.btnOffers);
            this.Controls.Add(this.dgvOffers);
            this.Name = "FormSalesDepartmentOffersOrder";
            this.Text = "FormSalesDepartmentOffers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOffers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOffers;
        private System.Windows.Forms.Button btnOffers;
        private System.Windows.Forms.Button btnRefresh;
    }
}