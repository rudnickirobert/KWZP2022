namespace KWZP2022
{
    partial class FormNewCommertialOffer
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNoOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGuarantee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOfferStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.btnAddNewOffer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.dtpDateOfImplementation = new System.Windows.Forms.DateTimePicker();
            this.textBoxPriceForMaterials = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPriceForOrder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckAvailableMaterials = new System.Windows.Forms.Button();
            this.dgvMissingMaterials = new System.Windows.Forms.DataGridView();
            this.btnAddAlert = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBoxPriceForMachines = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPriceForEmployee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissingMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pracownik tworzący ofertę handlową:";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(24, 41);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(430, 28);
            this.comboBoxEmployee.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(20, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numer zamówienia:";
            // 
            // comboBoxNoOrder
            // 
            this.comboBoxNoOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoOrder.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxNoOrder.FormattingEnabled = true;
            this.comboBoxNoOrder.Location = new System.Drawing.Point(24, 104);
            this.comboBoxNoOrder.Name = "comboBoxNoOrder";
            this.comboBoxNoOrder.Size = new System.Drawing.Size(430, 28);
            this.comboBoxNoOrder.TabIndex = 9;
            this.comboBoxNoOrder.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNoOrder_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.Location = new System.Drawing.Point(20, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gwarancja:";
            // 
            // comboBoxGuarantee
            // 
            this.comboBoxGuarantee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGuarantee.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxGuarantee.FormattingEnabled = true;
            this.comboBoxGuarantee.Location = new System.Drawing.Point(24, 166);
            this.comboBoxGuarantee.Name = "comboBoxGuarantee";
            this.comboBoxGuarantee.Size = new System.Drawing.Size(430, 28);
            this.comboBoxGuarantee.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(20, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Status oferty handlowej:";
            // 
            // comboBoxOfferStatus
            // 
            this.comboBoxOfferStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferStatus.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxOfferStatus.FormattingEnabled = true;
            this.comboBoxOfferStatus.Location = new System.Drawing.Point(24, 298);
            this.comboBoxOfferStatus.Name = "comboBoxOfferStatus";
            this.comboBoxOfferStatus.Size = new System.Drawing.Size(430, 28);
            this.comboBoxOfferStatus.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label5.Location = new System.Drawing.Point(20, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cena za całe zamówienie:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxPrice.Location = new System.Drawing.Point(24, 365);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(430, 26);
            this.textBoxPrice.TabIndex = 17;
            // 
            // btnAddNewOffer
            // 
            this.btnAddNewOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewOffer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAddNewOffer.Location = new System.Drawing.Point(24, 426);
            this.btnAddNewOffer.Name = "btnAddNewOffer";
            this.btnAddNewOffer.Size = new System.Drawing.Size(430, 28);
            this.btnAddNewOffer.TabIndex = 18;
            this.btnAddNewOffer.Text = "Stwórz nową ofertę handlową";
            this.btnAddNewOffer.UseVisualStyleBackColor = true;
            this.btnAddNewOffer.Click += new System.EventHandler(this.btnAddNewOffer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnClose.Location = new System.Drawing.Point(702, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 28);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletionDate.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblCompletionDate.Location = new System.Drawing.Point(20, 208);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(109, 20);
            this.lblCompletionDate.TabIndex = 20;
            this.lblCompletionDate.Text = "Termin realizacji:";
            // 
            // dtpDateOfImplementation
            // 
            this.dtpDateOfImplementation.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpDateOfImplementation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfImplementation.Location = new System.Drawing.Point(24, 231);
            this.dtpDateOfImplementation.Name = "dtpDateOfImplementation";
            this.dtpDateOfImplementation.Size = new System.Drawing.Size(215, 26);
            this.dtpDateOfImplementation.TabIndex = 21;
            // 
            // textBoxPriceForMaterials
            // 
            this.textBoxPriceForMaterials.Enabled = false;
            this.textBoxPriceForMaterials.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxPriceForMaterials.Location = new System.Drawing.Point(510, 76);
            this.textBoxPriceForMaterials.Name = "textBoxPriceForMaterials";
            this.textBoxPriceForMaterials.Size = new System.Drawing.Size(130, 26);
            this.textBoxPriceForMaterials.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label7.Location = new System.Drawing.Point(506, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Kwota za materiały:";
            // 
            // textBoxPriceForOrder
            // 
            this.textBoxPriceForOrder.Enabled = false;
            this.textBoxPriceForOrder.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxPriceForOrder.Location = new System.Drawing.Point(510, 179);
            this.textBoxPriceForOrder.Name = "textBoxPriceForOrder";
            this.textBoxPriceForOrder.Size = new System.Drawing.Size(272, 26);
            this.textBoxPriceForOrder.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label8.Location = new System.Drawing.Point(506, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sugerowana kwota sprzedaży:";
            // 
            // btnCheckAvailableMaterials
            // 
            this.btnCheckAvailableMaterials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAvailableMaterials.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnCheckAvailableMaterials.Location = new System.Drawing.Point(510, 231);
            this.btnCheckAvailableMaterials.Name = "btnCheckAvailableMaterials";
            this.btnCheckAvailableMaterials.Size = new System.Drawing.Size(272, 28);
            this.btnCheckAvailableMaterials.TabIndex = 26;
            this.btnCheckAvailableMaterials.Text = "Sprawdź dostępność materiałów";
            this.btnCheckAvailableMaterials.UseVisualStyleBackColor = true;
            this.btnCheckAvailableMaterials.Click += new System.EventHandler(this.btnCheckAvailableMaterials_Click);
            // 
            // dgvMissingMaterials
            // 
            this.dgvMissingMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissingMaterials.Location = new System.Drawing.Point(472, 298);
            this.dgvMissingMaterials.Name = "dgvMissingMaterials";
            this.dgvMissingMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMissingMaterials.Size = new System.Drawing.Size(310, 147);
            this.dgvMissingMaterials.TabIndex = 29;
            this.dgvMissingMaterials.Visible = false;
            // 
            // btnAddAlert
            // 
            this.btnAddAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAlert.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAddAlert.Location = new System.Drawing.Point(472, 451);
            this.btnAddAlert.Name = "btnAddAlert";
            this.btnAddAlert.Size = new System.Drawing.Size(139, 28);
            this.btnAddAlert.TabIndex = 30;
            this.btnAddAlert.Text = "Dodaj alert";
            this.btnAddAlert.UseVisualStyleBackColor = true;
            this.btnAddAlert.Visible = false;
            this.btnAddAlert.Click += new System.EventHandler(this.btnAddAlert_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblDescription.Location = new System.Drawing.Point(468, 275);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(281, 20);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Brakujące materiały do wszystkich zamówień:";
            this.lblDescription.Visible = false;
            // 
            // textBoxPriceForMachines
            // 
            this.textBoxPriceForMachines.Enabled = false;
            this.textBoxPriceForMachines.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxPriceForMachines.Location = new System.Drawing.Point(652, 78);
            this.textBoxPriceForMachines.Name = "textBoxPriceForMachines";
            this.textBoxPriceForMachines.Size = new System.Drawing.Size(130, 26);
            this.textBoxPriceForMachines.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label6.Location = new System.Drawing.Point(648, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Koszt pracy maszyn:";
            // 
            // textBoxPriceForEmployee
            // 
            this.textBoxPriceForEmployee.Enabled = false;
            this.textBoxPriceForEmployee.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxPriceForEmployee.Location = new System.Drawing.Point(510, 127);
            this.textBoxPriceForEmployee.Name = "textBoxPriceForEmployee";
            this.textBoxPriceForEmployee.Size = new System.Drawing.Size(130, 26);
            this.textBoxPriceForEmployee.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label9.Location = new System.Drawing.Point(506, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Koszt pracy pracownika:";
            // 
            // FormNewCommertialOffer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.textBoxPriceForEmployee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPriceForMachines);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnAddAlert);
            this.Controls.Add(this.dgvMissingMaterials);
            this.Controls.Add(this.btnCheckAvailableMaterials);
            this.Controls.Add(this.textBoxPriceForOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPriceForMaterials);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDateOfImplementation);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewOffer);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOfferStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGuarantee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNoOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNewCommertialOffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowa oferta handlowa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissingMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNoOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGuarantee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOfferStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button btnAddNewOffer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.DateTimePicker dtpDateOfImplementation;
        private System.Windows.Forms.TextBox textBoxPriceForMaterials;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPriceForOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckAvailableMaterials;
        private System.Windows.Forms.DataGridView dgvMissingMaterials;
        private System.Windows.Forms.Button btnAddAlert;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textBoxPriceForMachines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPriceForEmployee;
        private System.Windows.Forms.Label label9;
    }
}