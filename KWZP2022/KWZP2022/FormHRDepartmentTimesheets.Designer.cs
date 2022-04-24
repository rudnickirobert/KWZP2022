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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRDepartmentTimesheets));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNieobecnosc = new System.Windows.Forms.ComboBox();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.dtOD = new System.Windows.Forms.DateTimePicker();
            this.dtDO = new System.Windows.Forms.DateTimePicker();
            this.dgvNieobecnosc = new System.Windows.Forms.DataGridView();
            this.btnDodajNieobecnosc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNieobecnosc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pracownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rodzaj nieobecności";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(30, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(30, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data do";
            // 
            // cmbNieobecnosc
            // 
            this.cmbNieobecnosc.FormattingEnabled = true;
            this.cmbNieobecnosc.Location = new System.Drawing.Point(317, 85);
            this.cmbNieobecnosc.Name = "cmbNieobecnosc";
            this.cmbNieobecnosc.Size = new System.Drawing.Size(187, 24);
            this.cmbNieobecnosc.TabIndex = 4;
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(317, 37);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(187, 24);
            this.cmbPracownik.TabIndex = 5;
            // 
            // dtOD
            // 
            this.dtOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOD.Location = new System.Drawing.Point(317, 136);
            this.dtOD.Name = "dtOD";
            this.dtOD.Size = new System.Drawing.Size(200, 22);
            this.dtOD.TabIndex = 6;
            // 
            // dtDO
            // 
            this.dtDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDO.Location = new System.Drawing.Point(317, 191);
            this.dtDO.Name = "dtDO";
            this.dtDO.Size = new System.Drawing.Size(200, 22);
            this.dtDO.TabIndex = 7;
            // 
            // dgvNieobecnosc
            // 
            this.dgvNieobecnosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNieobecnosc.Location = new System.Drawing.Point(34, 251);
            this.dgvNieobecnosc.Name = "dgvNieobecnosc";
            this.dgvNieobecnosc.RowHeadersWidth = 51;
            this.dgvNieobecnosc.RowTemplate.Height = 24;
            this.dgvNieobecnosc.Size = new System.Drawing.Size(483, 235);
            this.dgvNieobecnosc.TabIndex = 8;
            // 
            // btnDodajNieobecnosc
            // 
            this.btnDodajNieobecnosc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNieobecnosc.Location = new System.Drawing.Point(626, 74);
            this.btnDodajNieobecnosc.Name = "btnDodajNieobecnosc";
            this.btnDodajNieobecnosc.Size = new System.Drawing.Size(115, 44);
            this.btnDodajNieobecnosc.TabIndex = 9;
            this.btnDodajNieobecnosc.Text = "Dodaj";
            this.btnDodajNieobecnosc.UseVisualStyleBackColor = true;
            this.btnDodajNieobecnosc.Click += new System.EventHandler(this.btnDodajNieobecnosc_Click);
            // 
            // FormHRDepartmentTimesheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 498);
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
            this.Text = "Nieobecność";
            this.Load += new System.EventHandler(this.FormHRDepartmentTimesheets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNieobecnosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNieobecnosc;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.DateTimePicker dtOD;
        private System.Windows.Forms.DateTimePicker dtDO;
        private System.Windows.Forms.DataGridView dgvNieobecnosc;
        private System.Windows.Forms.Button btnDodajNieobecnosc;
    }
}