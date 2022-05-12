namespace KWZP2022
{
    partial class FormHRDepartmentNewSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRDepartmentNewSalary));
            this.lblIDPracownik = new System.Windows.Forms.Label();
            this.cbIDpracownik = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dSalary = new System.Windows.Forms.DateTimePicker();
            this.btnSaveSalary = new System.Windows.Forms.Button();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDPracownik
            // 
            this.lblIDPracownik.AutoSize = true;
            this.lblIDPracownik.Location = new System.Drawing.Point(388, 59);
            this.lblIDPracownik.Name = "lblIDPracownik";
            this.lblIDPracownik.Size = new System.Drawing.Size(76, 13);
            this.lblIDPracownik.TabIndex = 52;
            this.lblIDPracownik.Text = "ID pracownika";
            // 
            // cbIDpracownik
            // 
            this.cbIDpracownik.FormattingEnabled = true;
            this.cbIDpracownik.Location = new System.Drawing.Point(519, 56);
            this.cbIDpracownik.Name = "cbIDpracownik";
            this.cbIDpracownik.Size = new System.Drawing.Size(121, 21);
            this.cbIDpracownik.TabIndex = 51;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(388, 102);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 13);
            this.lblDate.TabIndex = 53;
            this.lblDate.Text = "Data wypłaty";
            // 
            // dSalary
            // 
            this.dSalary.Location = new System.Drawing.Point(519, 102);
            this.dSalary.Name = "dSalary";
            this.dSalary.Size = new System.Drawing.Size(121, 20);
            this.dSalary.TabIndex = 54;
            // 
            // btnSaveSalary
            // 
            this.btnSaveSalary.Location = new System.Drawing.Point(534, 153);
            this.btnSaveSalary.Name = "btnSaveSalary";
            this.btnSaveSalary.Size = new System.Drawing.Size(106, 23);
            this.btnSaveSalary.TabIndex = 55;
            this.btnSaveSalary.Text = "Zapisz wypłatę";
            this.btnSaveSalary.UseVisualStyleBackColor = true;
            this.btnSaveSalary.Click += new System.EventHandler(this.btnSaveSalary_Click);
            // 
            // dgvSalary
            // 
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Location = new System.Drawing.Point(12, 200);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.Size = new System.Drawing.Size(1217, 390);
            this.dgvSalary.TabIndex = 56;
            // 
            // FormHRDepartmentNewSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.dgvSalary);
            this.Controls.Add(this.btnSaveSalary);
            this.Controls.Add(this.dSalary);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblIDPracownik);
            this.Controls.Add(this.cbIDpracownik);
            this.DoubleBuffered = true;
            this.Name = "FormHRDepartmentNewSalary";
            this.Text = "Dodawanie wypłaty";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDPracownik;
        private System.Windows.Forms.ComboBox cbIDpracownik;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dSalary;
        private System.Windows.Forms.Button btnSaveSalary;
        private System.Windows.Forms.DataGridView dgvSalary;
    }
}