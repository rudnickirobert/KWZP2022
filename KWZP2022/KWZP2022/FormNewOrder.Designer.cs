namespace KWZP2022
{
    partial class FormNewOrder
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNoTelClient = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateOrder = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOrderType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNewOrderDetails = new System.Windows.Forms.Button();
            this.btnCommercialOffer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnClose.Location = new System.Drawing.Point(702, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewClient.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAddNewClient.Location = new System.Drawing.Point(612, 150);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(170, 28);
            this.btnAddNewClient.TabIndex = 1;
            this.btnAddNewClient.Text = "Dodaj nowego klienta";
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(20, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaj numer telefonu:";
            // 
            // textBoxNoTelClient
            // 
            this.textBoxNoTelClient.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxNoTelClient.Location = new System.Drawing.Point(24, 110);
            this.textBoxNoTelClient.Name = "textBoxNoTelClient";
            this.textBoxNoTelClient.Size = new System.Drawing.Size(143, 26);
            this.textBoxNoTelClient.TabIndex = 3;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnNewOrder.Location = new System.Drawing.Point(588, 300);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(195, 28);
            this.btnNewOrder.TabIndex = 4;
            this.btnNewOrder.Text = "Dodaj nowe zamówienie";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(24, 43);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(143, 28);
            this.comboBoxEmployee.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pracownik przyjmujący zamówienie:";
            // 
            // dtpDateOrder
            // 
            this.dtpDateOrder.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOrder.Location = new System.Drawing.Point(24, 173);
            this.dtpDateOrder.Name = "dtpDateOrder";
            this.dtpDateOrder.Size = new System.Drawing.Size(143, 26);
            this.dtpDateOrder.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data zamówienia:";
            // 
            // comboBoxOrderType
            // 
            this.comboBoxOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderType.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxOrderType.FormattingEnabled = true;
            this.comboBoxOrderType.Location = new System.Drawing.Point(294, 43);
            this.comboBoxOrderType.Name = "comboBoxOrderType";
            this.comboBoxOrderType.Size = new System.Drawing.Size(143, 28);
            this.comboBoxOrderType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(290, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Typ zamówienia:";
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProduct.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnNewProduct.Location = new System.Drawing.Point(612, 100);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(170, 28);
            this.btnNewProduct.TabIndex = 15;
            this.btnNewProduct.Text = "Dodaj nowy produkt";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(170, 451);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 28);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(24, 218);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(523, 227);
            this.dgvOrders.TabIndex = 17;
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRemove.Location = new System.Drawing.Point(377, 451);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(170, 28);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNewOrderDetails
            // 
            this.btnNewOrderDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrderDetails.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnNewOrderDetails.Location = new System.Drawing.Point(588, 250);
            this.btnNewOrderDetails.Name = "btnNewOrderDetails";
            this.btnNewOrderDetails.Size = new System.Drawing.Size(195, 28);
            this.btnNewOrderDetails.TabIndex = 19;
            this.btnNewOrderDetails.Text = "Dodaj szczegóły zamówienia";
            this.btnNewOrderDetails.UseVisualStyleBackColor = true;
            this.btnNewOrderDetails.Click += new System.EventHandler(this.btnNewOrderDetails_Click);
            // 
            // btnCommercialOffer
            // 
            this.btnCommercialOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommercialOffer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnCommercialOffer.Location = new System.Drawing.Point(588, 380);
            this.btnCommercialOffer.Name = "btnCommercialOffer";
            this.btnCommercialOffer.Size = new System.Drawing.Size(195, 28);
            this.btnCommercialOffer.TabIndex = 20;
            this.btnCommercialOffer.Text = "Przejdź do oferty >>";
            this.btnCommercialOffer.UseVisualStyleBackColor = true;
            this.btnCommercialOffer.Click += new System.EventHandler(this.btnCommercialOffer_Click);
            // 
            // FormNewOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnCommercialOffer);
            this.Controls.Add(this.btnNewOrderDetails);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOrderType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.textBoxNoTelClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewClient);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowe zamówienie";
            this.Activated += new System.EventHandler(this.FormNewOrder_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNoTelClient;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOrderType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNewOrderDetails;
        private System.Windows.Forms.Button btnCommercialOffer;
    }
}