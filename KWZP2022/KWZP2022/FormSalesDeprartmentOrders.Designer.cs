
namespace KWZP2022
{
    partial class FormSalesDeprartmentOrders
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblSurnameClient = new System.Windows.Forms.Label();
            this.lblIdOrder = new System.Windows.Forms.Label();
            this.lblSurnameEmployee = new System.Windows.Forms.Label();
            this.lblNameClient = new System.Windows.Forms.Label();
            this.lblTypeOrder = new System.Windows.Forms.Label();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.textBoxSurnameClient = new System.Windows.Forms.TextBox();
            this.textBoxSurnameEmployee = new System.Windows.Forms.TextBox();
            this.textBoxIdOrder = new System.Windows.Forms.TextBox();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.textBoxTypeOrder = new System.Windows.Forms.TextBox();
            this.textBoxNameEmployee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(477, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(477, 111);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 15;
            this.btnOrders.Text = "Szukaj";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click_1);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(583, 78);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 16;
            this.btnDetails.Text = "Szczegóły";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(696, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 154);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(770, 282);
            this.dgvOrders.TabIndex = 19;
            // 
            // lblSurnameClient
            // 
            this.lblSurnameClient.AutoSize = true;
            this.lblSurnameClient.BackColor = System.Drawing.Color.Transparent;
            this.lblSurnameClient.ForeColor = System.Drawing.Color.Black;
            this.lblSurnameClient.Location = new System.Drawing.Point(12, 30);
            this.lblSurnameClient.Name = "lblSurnameClient";
            this.lblSurnameClient.Size = new System.Drawing.Size(90, 13);
            this.lblSurnameClient.TabIndex = 20;
            this.lblSurnameClient.Text = "Nazwisko klienta:";
            // 
            // lblIdOrder
            // 
            this.lblIdOrder.AutoSize = true;
            this.lblIdOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblIdOrder.ForeColor = System.Drawing.Color.Black;
            this.lblIdOrder.Location = new System.Drawing.Point(164, 30);
            this.lblIdOrder.Name = "lblIdOrder";
            this.lblIdOrder.Size = new System.Drawing.Size(99, 13);
            this.lblIdOrder.TabIndex = 21;
            this.lblIdOrder.Text = "Numer zamówienia:";
            // 
            // lblSurnameEmployee
            // 
            this.lblSurnameEmployee.AutoSize = true;
            this.lblSurnameEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblSurnameEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblSurnameEmployee.Location = new System.Drawing.Point(312, 30);
            this.lblSurnameEmployee.Name = "lblSurnameEmployee";
            this.lblSurnameEmployee.Size = new System.Drawing.Size(111, 13);
            this.lblSurnameEmployee.TabIndex = 22;
            this.lblSurnameEmployee.Text = "Nazwisko pracownika";
            // 
            // lblNameClient
            // 
            this.lblNameClient.AutoSize = true;
            this.lblNameClient.BackColor = System.Drawing.Color.Transparent;
            this.lblNameClient.ForeColor = System.Drawing.Color.Black;
            this.lblNameClient.Location = new System.Drawing.Point(12, 97);
            this.lblNameClient.Name = "lblNameClient";
            this.lblNameClient.Size = new System.Drawing.Size(63, 13);
            this.lblNameClient.TabIndex = 23;
            this.lblNameClient.Text = "Imię klienta:";
            // 
            // lblTypeOrder
            // 
            this.lblTypeOrder.AutoSize = true;
            this.lblTypeOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeOrder.ForeColor = System.Drawing.Color.Black;
            this.lblTypeOrder.Location = new System.Drawing.Point(164, 97);
            this.lblTypeOrder.Name = "lblTypeOrder";
            this.lblTypeOrder.Size = new System.Drawing.Size(86, 13);
            this.lblTypeOrder.TabIndex = 24;
            this.lblTypeOrder.Text = "Typ zamówienia:";
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblNameEmployee.Location = new System.Drawing.Point(312, 97);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(84, 13);
            this.lblNameEmployee.TabIndex = 25;
            this.lblNameEmployee.Text = "Imię pracownika";
            // 
            // textBoxSurnameClient
            // 
            this.textBoxSurnameClient.Location = new System.Drawing.Point(15, 48);
            this.textBoxSurnameClient.Name = "textBoxSurnameClient";
            this.textBoxSurnameClient.Size = new System.Drawing.Size(125, 20);
            this.textBoxSurnameClient.TabIndex = 26;
            // 
            // textBoxSurnameEmployee
            // 
            this.textBoxSurnameEmployee.Location = new System.Drawing.Point(315, 48);
            this.textBoxSurnameEmployee.Name = "textBoxSurnameEmployee";
            this.textBoxSurnameEmployee.Size = new System.Drawing.Size(125, 20);
            this.textBoxSurnameEmployee.TabIndex = 27;
            // 
            // textBoxIdOrder
            // 
            this.textBoxIdOrder.Location = new System.Drawing.Point(167, 48);
            this.textBoxIdOrder.Name = "textBoxIdOrder";
            this.textBoxIdOrder.Size = new System.Drawing.Size(125, 20);
            this.textBoxIdOrder.TabIndex = 28;
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Location = new System.Drawing.Point(15, 113);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(125, 20);
            this.textBoxNameClient.TabIndex = 29;
            // 
            // textBoxTypeOrder
            // 
            this.textBoxTypeOrder.Location = new System.Drawing.Point(167, 113);
            this.textBoxTypeOrder.Name = "textBoxTypeOrder";
            this.textBoxTypeOrder.Size = new System.Drawing.Size(125, 20);
            this.textBoxTypeOrder.TabIndex = 30;
            // 
            // textBoxNameEmployee
            // 
            this.textBoxNameEmployee.Location = new System.Drawing.Point(315, 113);
            this.textBoxNameEmployee.Name = "textBoxNameEmployee";
            this.textBoxNameEmployee.Size = new System.Drawing.Size(125, 20);
            this.textBoxNameEmployee.TabIndex = 31;
            // 
            // FormSalesDeprartmentOrders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.textBoxNameEmployee);
            this.Controls.Add(this.textBoxTypeOrder);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.textBoxIdOrder);
            this.Controls.Add(this.textBoxSurnameEmployee);
            this.Controls.Add(this.textBoxSurnameClient);
            this.Controls.Add(this.lblNameEmployee);
            this.Controls.Add(this.lblTypeOrder);
            this.Controls.Add(this.lblNameClient);
            this.Controls.Add(this.lblSurnameEmployee);
            this.Controls.Add(this.lblIdOrder);
            this.Controls.Add(this.lblSurnameClient);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnRefresh);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSalesDeprartmentOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zamówienia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblSurnameClient;
        private System.Windows.Forms.Label lblIdOrder;
        private System.Windows.Forms.Label lblSurnameEmployee;
        private System.Windows.Forms.Label lblNameClient;
        private System.Windows.Forms.Label lblTypeOrder;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.TextBox textBoxSurnameClient;
        private System.Windows.Forms.TextBox textBoxSurnameEmployee;
        private System.Windows.Forms.TextBox textBoxIdOrder;
        private System.Windows.Forms.TextBox textBoxNameClient;
        private System.Windows.Forms.TextBox textBoxTypeOrder;
        private System.Windows.Forms.TextBox textBoxNameEmployee;
    }
}