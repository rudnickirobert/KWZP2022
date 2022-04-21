namespace KWZP2022
{
    partial class FormSalesDepartmentOrders
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdOrder = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(515, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Podaj nr zamówienia:";
            // 
            // textBoxIdOrder
            // 
            this.textBoxIdOrder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdOrder.Location = new System.Drawing.Point(519, 68);
            this.textBoxIdOrder.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdOrder.Name = "textBoxIdOrder";
            this.textBoxIdOrder.Size = new System.Drawing.Size(201, 30);
            this.textBoxIdOrder.TabIndex = 30;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(27, 158);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1190, 442);
            this.dgvOrders.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(574, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 30);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormSalesDepartmentOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1280, 706);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdOrder);
            this.Name = "FormSalesDepartmentOrders";
            this.Text = "FormSalesDepartmentOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnSearch;
    }
}