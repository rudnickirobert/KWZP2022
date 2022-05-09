namespace KWZP2022
{
    partial class FormSalesDepartmentComplaintAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvComplaint = new System.Windows.Forms.DataGridView();
            this.cbAccept = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDesciption = new System.Windows.Forms.TextBox();
            this.cbDateComplaint = new System.Windows.Forms.CheckBox();
            this.dtpDateComplaint = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNoSale = new System.Windows.Forms.ComboBox();
            this.comboBoxNoProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxNoEmployee = new System.Windows.Forms.ComboBox();
            this.btnCheckComplaint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(302, 451);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 27);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(684, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 79;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvComplaint
            // 
            this.dgvComplaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaint.Location = new System.Drawing.Point(14, 268);
            this.dgvComplaint.Name = "dgvComplaint";
            this.dgvComplaint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaint.Size = new System.Drawing.Size(768, 167);
            this.dgvComplaint.TabIndex = 78;
            // 
            // cbAccept
            // 
            this.cbAccept.AutoSize = true;
            this.cbAccept.BackColor = System.Drawing.Color.Transparent;
            this.cbAccept.Font = new System.Drawing.Font("Arial", 12F);
            this.cbAccept.Location = new System.Drawing.Point(463, 99);
            this.cbAccept.Name = "cbAccept";
            this.cbAccept.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAccept.Size = new System.Drawing.Size(105, 22);
            this.cbAccept.TabIndex = 77;
            this.cbAccept.Text = "Akceptacja";
            this.cbAccept.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.Location = new System.Drawing.Point(215, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(215, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 75;
            this.label8.Text = "Ilość:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.textBoxAmount.Location = new System.Drawing.Point(218, 97);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(179, 23);
            this.textBoxAmount.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(215, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "Nazwa produktu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(215, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "Opis reklamacji:";
            // 
            // textBoxDesciption
            // 
            this.textBoxDesciption.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.textBoxDesciption.Location = new System.Drawing.Point(218, 161);
            this.textBoxDesciption.Multiline = true;
            this.textBoxDesciption.Name = "textBoxDesciption";
            this.textBoxDesciption.Size = new System.Drawing.Size(564, 67);
            this.textBoxDesciption.TabIndex = 70;
            // 
            // cbDateComplaint
            // 
            this.cbDateComplaint.AutoSize = true;
            this.cbDateComplaint.BackColor = System.Drawing.Color.Transparent;
            this.cbDateComplaint.Location = new System.Drawing.Point(152, 169);
            this.cbDateComplaint.Name = "cbDateComplaint";
            this.cbDateComplaint.Size = new System.Drawing.Size(15, 14);
            this.cbDateComplaint.TabIndex = 69;
            this.cbDateComplaint.UseVisualStyleBackColor = false;
            // 
            // dtpDateComplaint
            // 
            this.dtpDateComplaint.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDateComplaint.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateComplaint.Location = new System.Drawing.Point(15, 161);
            this.dtpDateComplaint.Name = "dtpDateComplaint";
            this.dtpDateComplaint.Size = new System.Drawing.Size(128, 26);
            this.dtpDateComplaint.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 68;
            this.label4.Text = "Data reklamacji:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nazwisko pracownika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Numer sprzedaży:";
            // 
            // comboBoxNoSale
            // 
            this.comboBoxNoSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoSale.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBoxNoSale.FormattingEnabled = true;
            this.comboBoxNoSale.Location = new System.Drawing.Point(14, 34);
            this.comboBoxNoSale.Name = "comboBoxNoSale";
            this.comboBoxNoSale.Size = new System.Drawing.Size(129, 24);
            this.comboBoxNoSale.TabIndex = 83;
            this.comboBoxNoSale.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNoSale_SelectionChangeCommitted);
            // 
            // comboBoxNoProduct
            // 
            this.comboBoxNoProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoProduct.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBoxNoProduct.FormattingEnabled = true;
            this.comboBoxNoProduct.Location = new System.Drawing.Point(218, 34);
            this.comboBoxNoProduct.Name = "comboBoxNoProduct";
            this.comboBoxNoProduct.Size = new System.Drawing.Size(179, 24);
            this.comboBoxNoProduct.TabIndex = 84;
            // 
            // comboBoxNoEmployee
            // 
            this.comboBoxNoEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoEmployee.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBoxNoEmployee.FormattingEnabled = true;
            this.comboBoxNoEmployee.Location = new System.Drawing.Point(14, 97);
            this.comboBoxNoEmployee.Name = "comboBoxNoEmployee";
            this.comboBoxNoEmployee.Size = new System.Drawing.Size(129, 24);
            this.comboBoxNoEmployee.TabIndex = 85;
            // 
            // btnCheckComplaint
            // 
            this.btnCheckComplaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckComplaint.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnCheckComplaint.Location = new System.Drawing.Point(218, 234);
            this.btnCheckComplaint.Name = "btnCheckComplaint";
            this.btnCheckComplaint.Size = new System.Drawing.Size(220, 28);
            this.btnCheckComplaint.TabIndex = 86;
            this.btnCheckComplaint.Text = "Sprawdź możliwość reklamacji";
            this.btnCheckComplaint.UseVisualStyleBackColor = true;
            this.btnCheckComplaint.Click += new System.EventHandler(this.btnCheckComplaint_Click);
            // 
            // FormSalesDepartmentComplaintAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnCheckComplaint);
            this.Controls.Add(this.comboBoxNoEmployee);
            this.Controls.Add(this.comboBoxNoProduct);
            this.Controls.Add(this.comboBoxNoSale);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvComplaint);
            this.Controls.Add(this.cbAccept);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDesciption);
            this.Controls.Add(this.cbDateComplaint);
            this.Controls.Add(this.dtpDateComplaint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSalesDepartmentComplaintAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj zwrot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvComplaint;
        private System.Windows.Forms.CheckBox cbAccept;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDesciption;
        private System.Windows.Forms.CheckBox cbDateComplaint;
        private System.Windows.Forms.DateTimePicker dtpDateComplaint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNoSale;
        private System.Windows.Forms.ComboBox comboBoxNoProduct;
        private System.Windows.Forms.ComboBox comboBoxNoEmployee;
        private System.Windows.Forms.Button btnCheckComplaint;
    }
}