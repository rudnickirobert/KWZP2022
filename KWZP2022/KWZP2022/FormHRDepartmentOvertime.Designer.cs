namespace KWZP2022
{
    partial class FormHRDepartmentOvertime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRDepartmentOvertime));
            this.btnDodajNadgodziny = new System.Windows.Forms.Button();
            this.dgvNadgodziny = new System.Windows.Forms.DataGridView();
            this.dtnadgodziny = new System.Windows.Forms.DateTimePicker();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCzasNadgodzin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNadgodziny)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajNadgodziny
            // 
            this.btnDodajNadgodziny.BackColor = System.Drawing.Color.Red;
            this.btnDodajNadgodziny.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNadgodziny.Location = new System.Drawing.Point(804, 126);
            this.btnDodajNadgodziny.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajNadgodziny.Name = "btnDodajNadgodziny";
            this.btnDodajNadgodziny.Size = new System.Drawing.Size(86, 36);
            this.btnDodajNadgodziny.TabIndex = 39;
            this.btnDodajNadgodziny.Text = "Dodaj";
            this.btnDodajNadgodziny.UseVisualStyleBackColor = false;
            this.btnDodajNadgodziny.Click += new System.EventHandler(this.btnDodajNadgodziny_Click);
            // 
            // dgvNadgodziny
            // 
            this.dgvNadgodziny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNadgodziny.Location = new System.Drawing.Point(44, 285);
            this.dgvNadgodziny.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNadgodziny.Name = "dgvNadgodziny";
            this.dgvNadgodziny.RowHeadersWidth = 51;
            this.dgvNadgodziny.RowTemplate.Height = 24;
            this.dgvNadgodziny.Size = new System.Drawing.Size(1164, 311);
            this.dgvNadgodziny.TabIndex = 38;
            // 
            // dtnadgodziny
            // 
            this.dtnadgodziny.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnadgodziny.Location = new System.Drawing.Point(492, 142);
            this.dtnadgodziny.Margin = new System.Windows.Forms.Padding(2);
            this.dtnadgodziny.Name = "dtnadgodziny";
            this.dtnadgodziny.Size = new System.Drawing.Size(151, 20);
            this.dtnadgodziny.TabIndex = 36;
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(493, 102);
            this.cmbPracownik.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(141, 21);
            this.cmbPracownik.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(298, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(298, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pracownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(298, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Czas w [h]";
            // 
            // tbCzasNadgodzin
            // 
            this.tbCzasNadgodzin.Location = new System.Drawing.Point(492, 184);
            this.tbCzasNadgodzin.Name = "tbCzasNadgodzin";
            this.tbCzasNadgodzin.Size = new System.Drawing.Size(100, 20);
            this.tbCzasNadgodzin.TabIndex = 41;
            // 
            // FormHRDepartmentOvertime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.tbCzasNadgodzin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajNadgodziny);
            this.Controls.Add(this.dgvNadgodziny);
            this.Controls.Add(this.dtnadgodziny);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FormHRDepartmentOvertime";
            this.Text = "Nowe nadgodziny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNadgodziny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajNadgodziny;
        private System.Windows.Forms.DataGridView dgvNadgodziny;
        private System.Windows.Forms.DateTimePicker dtnadgodziny;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCzasNadgodzin;
    }
}