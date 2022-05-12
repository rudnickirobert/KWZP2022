namespace KWZP2022
{
    partial class FormSalesDepartmentAddSales
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
            this.lblNrSale = new System.Windows.Forms.Label();
            this.textBoxNrSale = new System.Windows.Forms.TextBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.dtpSaleBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSaleEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateOfPayment = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSaleArrangement = new System.Windows.Forms.ComboBox();
            this.btnAddNewSale = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSalesDetails = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrSale
            // 
            this.lblNrSale.AutoSize = true;
            this.lblNrSale.BackColor = System.Drawing.Color.Transparent;
            this.lblNrSale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrSale.Location = new System.Drawing.Point(450, 78);
            this.lblNrSale.Name = "lblNrSale";
            this.lblNrSale.Size = new System.Drawing.Size(119, 20);
            this.lblNrSale.TabIndex = 11;
            this.lblNrSale.Text = "Numer sprzedaży:";
            // 
            // textBoxNrSale
            // 
            this.textBoxNrSale.Enabled = false;
            this.textBoxNrSale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNrSale.Location = new System.Drawing.Point(630, 75);
            this.textBoxNrSale.Name = "textBoxNrSale";
            this.textBoxNrSale.Size = new System.Drawing.Size(152, 26);
            this.textBoxNrSale.TabIndex = 10;
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(12, 12);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(380, 450);
            this.dgvSales.TabIndex = 14;
            this.dgvSales.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSales_MouseDoubleClick);
            // 
            // dtpSaleBegin
            // 
            this.dtpSaleBegin.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSaleBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleBegin.Location = new System.Drawing.Point(630, 153);
            this.dtpSaleBegin.Name = "dtpSaleBegin";
            this.dtpSaleBegin.Size = new System.Drawing.Size(152, 26);
            this.dtpSaleBegin.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(450, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data sprzedaży początek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(450, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data sprzedaży koniec:";
            // 
            // dtpSaleEnd
            // 
            this.dtpSaleEnd.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpSaleEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleEnd.Location = new System.Drawing.Point(630, 193);
            this.dtpSaleEnd.Name = "dtpSaleEnd";
            this.dtpSaleEnd.Size = new System.Drawing.Size(152, 26);
            this.dtpSaleEnd.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(450, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Termin zapłaty:";
            // 
            // dtpDateOfPayment
            // 
            this.dtpDateOfPayment.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpDateOfPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfPayment.Location = new System.Drawing.Point(630, 235);
            this.dtpDateOfPayment.Name = "dtpDateOfPayment";
            this.dtpDateOfPayment.Size = new System.Drawing.Size(152, 26);
            this.dtpDateOfPayment.TabIndex = 19;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(630, 275);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(152, 28);
            this.comboBoxPaymentMethod.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(450, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Forma płatności:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(450, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Umowa sprzedaży:";
            // 
            // comboBoxSaleArrangement
            // 
            this.comboBoxSaleArrangement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSaleArrangement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSaleArrangement.FormattingEnabled = true;
            this.comboBoxSaleArrangement.Location = new System.Drawing.Point(630, 113);
            this.comboBoxSaleArrangement.Name = "comboBoxSaleArrangement";
            this.comboBoxSaleArrangement.Size = new System.Drawing.Size(152, 28);
            this.comboBoxSaleArrangement.TabIndex = 23;
            this.comboBoxSaleArrangement.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSaleArrangement_SelectionChangeCommitted);
            // 
            // btnAddNewSale
            // 
            this.btnAddNewSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewSale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewSale.Location = new System.Drawing.Point(454, 348);
            this.btnAddNewSale.Name = "btnAddNewSale";
            this.btnAddNewSale.Size = new System.Drawing.Size(328, 27);
            this.btnAddNewSale.TabIndex = 82;
            this.btnAddNewSale.Text = "Dodaj sprzedaż";
            this.btnAddNewSale.UseVisualStyleBackColor = true;
            this.btnAddNewSale.Click += new System.EventHandler(this.btnAddNewSale_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(682, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 81;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSalesDetails
            // 
            this.btnSalesDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesDetails.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalesDetails.Location = new System.Drawing.Point(454, 400);
            this.btnSalesDetails.Name = "btnSalesDetails";
            this.btnSalesDetails.Size = new System.Drawing.Size(328, 27);
            this.btnSalesDetails.TabIndex = 83;
            this.btnSalesDetails.Text = "Przejdź do szczegółów sprzedaży >>";
            this.btnSalesDetails.UseVisualStyleBackColor = true;
            this.btnSalesDetails.Click += new System.EventHandler(this.btnSalesDetails_Click);
            // 
            // btnModify
            // 
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Location = new System.Drawing.Point(454, 452);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(166, 27);
            this.btnModify.TabIndex = 84;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // FormSalesDepartmentAddSales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSalesDetails);
            this.Controls.Add(this.btnAddNewSale);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSaleArrangement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateOfPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpSaleEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSaleBegin);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.lblNrSale);
            this.Controls.Add(this.textBoxNrSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSalesDepartmentAddSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie nowej sprzedaży";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNrSale;
        private System.Windows.Forms.TextBox textBoxNrSale;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DateTimePicker dtpSaleBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSaleEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateOfPayment;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSaleArrangement;
        private System.Windows.Forms.Button btnAddNewSale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSalesDetails;
        private System.Windows.Forms.Button btnModify;
    }
}