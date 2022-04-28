namespace KWZP2022
{
    partial class FormHRDepartmentWorkerContractNew
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
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.cbRContractType = new System.Windows.Forms.ComboBox();
            this.cbWorkingTime = new System.Windows.Forms.ComboBox();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.dgvpracownik = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbDateTo = new System.Windows.Forms.CheckBox();
            this.dWorkerTo = new System.Windows.Forms.DateTimePicker();
            this.dWorkerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnAddnewcontract = new System.Windows.Forms.Button();
            this.dgvEtat = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpracownik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtat)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(30, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 158;
            this.label4.Text = "Etat:";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(186, 220);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(184, 22);
            this.tbSalary.TabIndex = 157;
            // 
            // cbRContractType
            // 
            this.cbRContractType.FormattingEnabled = true;
            this.cbRContractType.Location = new System.Drawing.Point(186, 124);
            this.cbRContractType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRContractType.Name = "cbRContractType";
            this.cbRContractType.Size = new System.Drawing.Size(184, 24);
            this.cbRContractType.TabIndex = 156;
            // 
            // cbWorkingTime
            // 
            this.cbWorkingTime.FormattingEnabled = true;
            this.cbWorkingTime.Location = new System.Drawing.Point(186, 71);
            this.cbWorkingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWorkingTime.Name = "cbWorkingTime";
            this.cbWorkingTime.Size = new System.Drawing.Size(184, 24);
            this.cbWorkingTime.TabIndex = 155;
            // 
            // cbWorker
            // 
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(186, 18);
            this.cbWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(184, 24);
            this.cbWorker.TabIndex = 154;
            // 
            // cbEtat
            // 
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Location = new System.Drawing.Point(186, 174);
            this.cbEtat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.Size = new System.Drawing.Size(184, 24);
            this.cbEtat.TabIndex = 153;
            // 
            // dgvpracownik
            // 
            this.dgvpracownik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpracownik.Location = new System.Drawing.Point(12, 328);
            this.dgvpracownik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvpracownik.Name = "dgvpracownik";
            this.dgvpracownik.RowHeadersWidth = 51;
            this.dgvpracownik.RowTemplate.Height = 24;
            this.dgvpracownik.Size = new System.Drawing.Size(840, 372);
            this.dgvpracownik.TabIndex = 151;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(29, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 150;
            this.label5.Text = "Wynagrodzenie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 149;
            this.label3.Text = "Rodzaj umowy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 148;
            this.label2.Text = "Wymiar pracy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 147;
            this.label1.Text = "Pracownik:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1433, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 46);
            this.btnClose.TabIndex = 146;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbDateTo
            // 
            this.cbDateTo.AutoSize = true;
            this.cbDateTo.Location = new System.Drawing.Point(365, 302);
            this.cbDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDateTo.Name = "cbDateTo";
            this.cbDateTo.Size = new System.Drawing.Size(15, 14);
            this.cbDateTo.TabIndex = 145;
            this.cbDateTo.UseVisualStyleBackColor = true;
            // 
            // dWorkerTo
            // 
            this.dWorkerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dWorkerTo.Location = new System.Drawing.Point(186, 302);
            this.dWorkerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dWorkerTo.Name = "dWorkerTo";
            this.dWorkerTo.Size = new System.Drawing.Size(172, 22);
            this.dWorkerTo.TabIndex = 144;
            // 
            // dWorkerFrom
            // 
            this.dWorkerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dWorkerFrom.Location = new System.Drawing.Point(186, 267);
            this.dWorkerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dWorkerFrom.Name = "dWorkerFrom";
            this.dWorkerFrom.Size = new System.Drawing.Size(172, 22);
            this.dWorkerFrom.TabIndex = 143;
            // 
            // btnAddnewcontract
            // 
            this.btnAddnewcontract.BackColor = System.Drawing.Color.Red;
            this.btnAddnewcontract.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddnewcontract.Location = new System.Drawing.Point(445, 140);
            this.btnAddnewcontract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddnewcontract.Name = "btnAddnewcontract";
            this.btnAddnewcontract.Size = new System.Drawing.Size(115, 46);
            this.btnAddnewcontract.TabIndex = 142;
            this.btnAddnewcontract.Text = "Zapisz";
            this.btnAddnewcontract.UseVisualStyleBackColor = false;
            this.btnAddnewcontract.Click += new System.EventHandler(this.btnAddnewcontract_Click);
            // 
            // dgvEtat
            // 
            this.dgvEtat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtat.Location = new System.Drawing.Point(877, 109);
            this.dgvEtat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEtat.Name = "dgvEtat";
            this.dgvEtat.Size = new System.Drawing.Size(374, 496);
            this.dgvEtat.TabIndex = 160;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1011, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 161;
            this.label6.Text = "Dostępne etaty:";
            // 
            // FormHRDepartmentWorkerContractNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvEtat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.cbRContractType);
            this.Controls.Add(this.cbWorkingTime);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.cbEtat);
            this.Controls.Add(this.dgvpracownik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbDateTo);
            this.Controls.Add(this.dWorkerTo);
            this.Controls.Add(this.dWorkerFrom);
            this.Controls.Add(this.btnAddnewcontract);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHRDepartmentWorkerContractNew";
            this.Text = "Dodaj nową umowę";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpracownik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.ComboBox cbRContractType;
        private System.Windows.Forms.ComboBox cbWorkingTime;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.DataGridView dgvpracownik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbDateTo;
        private System.Windows.Forms.DateTimePicker dWorkerTo;
        private System.Windows.Forms.DateTimePicker dWorkerFrom;
        private System.Windows.Forms.Button btnAddnewcontract;
        private System.Windows.Forms.DataGridView dgvEtat;
        private System.Windows.Forms.Label label6;
    }
}