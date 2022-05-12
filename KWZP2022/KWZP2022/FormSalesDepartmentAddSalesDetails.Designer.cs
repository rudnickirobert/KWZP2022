namespace KWZP2022
{
    partial class FormSalesDepartmentAddSalesDetails
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
            this.btnAddNewSale = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTax = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.lblNrSale = new System.Windows.Forms.Label();
            this.comboBoxNoSale = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxNoTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSalesDetails = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewSale
            // 
            this.btnAddNewSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewSale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewSale.Location = new System.Drawing.Point(431, 360);
            this.btnAddNewSale.Name = "btnAddNewSale";
            this.btnAddNewSale.Size = new System.Drawing.Size(351, 27);
            this.btnAddNewSale.TabIndex = 98;
            this.btnAddNewSale.Text = "Dodaj szczegół sprzedaży";
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
            this.btnClose.TabIndex = 97;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(427, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Ilość produktów:";
            // 
            // comboBoxTax
            // 
            this.comboBoxTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTax.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTax.FormattingEnabled = true;
            this.comboBoxTax.Location = new System.Drawing.Point(576, 155);
            this.comboBoxTax.Name = "comboBoxTax";
            this.comboBoxTax.Size = new System.Drawing.Size(206, 28);
            this.comboBoxTax.TabIndex = 93;
            this.comboBoxTax.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTax_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(427, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "Wybierz podatek:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(427, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "Wybierz produkt:";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(12, 12);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(380, 209);
            this.dgvOrderDetails.TabIndex = 86;
            // 
            // lblNrSale
            // 
            this.lblNrSale.AutoSize = true;
            this.lblNrSale.BackColor = System.Drawing.Color.Transparent;
            this.lblNrSale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrSale.Location = new System.Drawing.Point(427, 78);
            this.lblNrSale.Name = "lblNrSale";
            this.lblNrSale.Size = new System.Drawing.Size(119, 20);
            this.lblNrSale.TabIndex = 85;
            this.lblNrSale.Text = "Numer sprzedaży:";
            // 
            // comboBoxNoSale
            // 
            this.comboBoxNoSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoSale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNoSale.FormattingEnabled = true;
            this.comboBoxNoSale.Location = new System.Drawing.Point(576, 75);
            this.comboBoxNoSale.Name = "comboBoxNoSale";
            this.comboBoxNoSale.Size = new System.Drawing.Size(206, 28);
            this.comboBoxNoSale.TabIndex = 99;
            this.comboBoxNoSale.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNoSale_SelectionChangeCommitted);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(576, 115);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(206, 28);
            this.comboBoxProduct.TabIndex = 100;
            this.comboBoxProduct.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProduct_SelectionChangeCommitted);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxAmount.Location = new System.Drawing.Point(576, 195);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(206, 26);
            this.textBoxAmount.TabIndex = 102;
            // 
            // textBoxNoTel
            // 
            this.textBoxNoTel.Enabled = false;
            this.textBoxNoTel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxNoTel.Location = new System.Drawing.Point(576, 275);
            this.textBoxNoTel.Name = "textBoxNoTel";
            this.textBoxNoTel.Size = new System.Drawing.Size(206, 26);
            this.textBoxNoTel.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(427, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Numer telefonu klienta:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxPrice.Location = new System.Drawing.Point(576, 235);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(206, 26);
            this.textBoxPrice.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(427, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Kwota za sztukę:";
            // 
            // dgvSalesDetails
            // 
            this.dgvSalesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesDetails.Location = new System.Drawing.Point(12, 247);
            this.dgvSalesDetails.Name = "dgvSalesDetails";
            this.dgvSalesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesDetails.Size = new System.Drawing.Size(380, 209);
            this.dgvSalesDetails.TabIndex = 107;
            this.dgvSalesDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSalesDetails_MouseDoubleClick);
            // 
            // btnModify
            // 
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Location = new System.Drawing.Point(431, 452);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(166, 27);
            this.btnModify.TabIndex = 108;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 20);
            this.label6.TabIndex = 109;
            this.label6.Text = "Kliknij dwukrotnie na szczegół, który chcesz zmodyfikować:";
            // 
            // FormSalesDepartmentAddSalesDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dgvSalesDetails);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNoTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxNoSale);
            this.Controls.Add(this.btnAddNewSale);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.lblNrSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSalesDepartmentAddSalesDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie szczegółów sprzedaży";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewSale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label lblNrSale;
        private System.Windows.Forms.ComboBox comboBoxNoSale;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxNoTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSalesDetails;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label6;
    }
}