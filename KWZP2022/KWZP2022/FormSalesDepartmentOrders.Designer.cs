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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSurnameClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameEmployee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSurnameEmployee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTypeOrder = new System.Windows.Forms.TextBox();
            this.btnOffers = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(262, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Numer zamówienia:";
            // 
            // textBoxIdOrder
            // 
            this.textBoxIdOrder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdOrder.Location = new System.Drawing.Point(266, 35);
            this.textBoxIdOrder.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdOrder.Name = "textBoxIdOrder";
            this.textBoxIdOrder.Size = new System.Drawing.Size(201, 30);
            this.textBoxIdOrder.TabIndex = 30;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(27, 158);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1189, 442);
            this.dgvOrders.TabIndex = 38;
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrders.Location = new System.Drawing.Point(736, 103);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(147, 30);
            this.btnOrders.TabIndex = 39;
            this.btnOrders.Text = "Szukaj";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click_1);
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetails.Location = new System.Drawing.Point(983, 103);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(125, 33);
            this.btnDetails.TabIndex = 40;
            this.btnDetails.Text = "Szczegóły";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nazwisko klienta:";
            // 
            // textBoxSurnameClient
            // 
            this.textBoxSurnameClient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSurnameClient.Location = new System.Drawing.Point(27, 33);
            this.textBoxSurnameClient.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurnameClient.Name = "textBoxSurnameClient";
            this.textBoxSurnameClient.Size = new System.Drawing.Size(201, 30);
            this.textBoxSurnameClient.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(23, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Imię klienta:";
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNameClient.Location = new System.Drawing.Point(27, 103);
            this.textBoxNameClient.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(201, 30);
            this.textBoxNameClient.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(491, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "Imię pracownika:";
            // 
            // textBoxNameEmployee
            // 
            this.textBoxNameEmployee.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNameEmployee.Location = new System.Drawing.Point(495, 105);
            this.textBoxNameEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameEmployee.Name = "textBoxNameEmployee";
            this.textBoxNameEmployee.Size = new System.Drawing.Size(201, 30);
            this.textBoxNameEmployee.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(491, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nazwisko pracownika:";
            // 
            // textBoxSurnameEmployee
            // 
            this.textBoxSurnameEmployee.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSurnameEmployee.Location = new System.Drawing.Point(495, 35);
            this.textBoxSurnameEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurnameEmployee.Name = "textBoxSurnameEmployee";
            this.textBoxSurnameEmployee.Size = new System.Drawing.Size(201, 30);
            this.textBoxSurnameEmployee.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(262, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 51;
            this.label7.Text = "Typ zamówienia:";
            // 
            // textBoxTypeOrder
            // 
            this.textBoxTypeOrder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTypeOrder.Location = new System.Drawing.Point(266, 105);
            this.textBoxTypeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTypeOrder.Name = "textBoxTypeOrder";
            this.textBoxTypeOrder.Size = new System.Drawing.Size(201, 30);
            this.textBoxTypeOrder.TabIndex = 50;
            // 
            // btnOffers
            // 
            this.btnOffers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOffers.Location = new System.Drawing.Point(1116, 103);
            this.btnOffers.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(100, 33);
            this.btnOffers.TabIndex = 52;
            this.btnOffers.Text = "Oferty";
            this.btnOffers.UseVisualStyleBackColor = true;
            this.btnOffers.Click += new System.EventHandler(this.btnOffers_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(736, 68);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 30);
            this.btnRefresh.TabIndex = 53;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormSalesDepartmentOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1280, 706);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOffers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTypeOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNameEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSurnameEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSurnameClient);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSalesDepartmentOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSalesDepartmentOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSurnameClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNameEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSurnameEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTypeOrder;
        private System.Windows.Forms.Button btnOffers;
        private System.Windows.Forms.Button btnRefresh;
    }
}