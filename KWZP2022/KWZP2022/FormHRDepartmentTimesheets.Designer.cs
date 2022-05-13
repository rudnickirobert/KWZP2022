namespace KWZP2022
{
    partial class FormHRDepartmentTimesheets
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
            this.btnDodajNieobecnosc = new System.Windows.Forms.Button();
            this.dgvNieobecnosc = new System.Windows.Forms.DataGridView();
            this.dtDO = new System.Windows.Forms.DateTimePicker();
            this.dtOD = new System.Windows.Forms.DateTimePicker();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.cmbNieobecnosc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNieobecnosc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajNieobecnosc
            // 
            this.btnDodajNieobecnosc.BackColor = System.Drawing.Color.Red;
            this.btnDodajNieobecnosc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNieobecnosc.Location = new System.Drawing.Point(539, 78);
            this.btnDodajNieobecnosc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajNieobecnosc.Name = "btnDodajNieobecnosc";
            this.btnDodajNieobecnosc.Size = new System.Drawing.Size(86, 36);
            this.btnDodajNieobecnosc.TabIndex = 29;
            this.btnDodajNieobecnosc.Text = "Dodaj";
            this.btnDodajNieobecnosc.UseVisualStyleBackColor = false;
            this.btnDodajNieobecnosc.Click += new System.EventHandler(this.btnDodajNieobecnosc_Click);
            // 
            // dgvNieobecnosc
            // 
            this.dgvNieobecnosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNieobecnosc.Location = new System.Drawing.Point(40, 209);
            this.dgvNieobecnosc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNieobecnosc.Name = "dgvNieobecnosc";
            this.dgvNieobecnosc.RowHeadersWidth = 51;
            this.dgvNieobecnosc.RowTemplate.Height = 24;
            this.dgvNieobecnosc.Size = new System.Drawing.Size(721, 250);
            this.dgvNieobecnosc.TabIndex = 28;
            // 
            // dtDO
            // 
            this.dtDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDO.Location = new System.Drawing.Point(251, 163);
            this.dtDO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtDO.Name = "dtDO";
            this.dtDO.Size = new System.Drawing.Size(151, 20);
            this.dtDO.TabIndex = 27;
            // 
            // dtOD
            // 
            this.dtOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOD.Location = new System.Drawing.Point(251, 118);
            this.dtOD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtOD.Name = "dtOD";
            this.dtOD.Size = new System.Drawing.Size(151, 20);
            this.dtOD.TabIndex = 26;
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(251, 29);
            this.cmbPracownik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(141, 21);
            this.cmbPracownik.TabIndex = 25;
            this.cmbPracownik.Text = " ";
            // 
            // cmbNieobecnosc
            // 
            this.cmbNieobecnosc.FormattingEnabled = true;
            this.cmbNieobecnosc.Location = new System.Drawing.Point(251, 77);
            this.cmbNieobecnosc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNieobecnosc.Name = "cmbNieobecnosc";
            this.cmbNieobecnosc.Size = new System.Drawing.Size(141, 21);
            this.cmbNieobecnosc.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(35, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(35, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Rodzaj nieobecności";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pracownik";
            // 
            // FormHRDepartmentTimesheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnDodajNieobecnosc);
            this.Controls.Add(this.dgvNieobecnosc);
            this.Controls.Add(this.dtDO);
            this.Controls.Add(this.dtOD);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.cmbNieobecnosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHRDepartmentTimesheets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nieobecności";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNieobecnosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajNieobecnosc;
        private System.Windows.Forms.DataGridView dgvNieobecnosc;
        private System.Windows.Forms.DateTimePicker dtDO;
        private System.Windows.Forms.DateTimePicker dtOD;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.ComboBox cmbNieobecnosc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}