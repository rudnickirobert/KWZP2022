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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRDepartmentWorkerContractNew));
            this.dgvpracownik = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dpracownikdo = new System.Windows.Forms.DateTimePicker();
            this.dpracownikod = new System.Windows.Forms.DateTimePicker();
            this.btnAddnewcontract = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.cbDzial = new System.Windows.Forms.ComboBox();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.cbWymiarPracy = new System.Windows.Forms.ComboBox();
            this.cbRodzajUmowy = new System.Windows.Forms.ComboBox();
            this.tbWynagrodzenie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpracownik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpracownik
            // 
            this.dgvpracownik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpracownik.Location = new System.Drawing.Point(91, 513);
            this.dgvpracownik.Name = "dgvpracownik";
            this.dgvpracownik.RowHeadersWidth = 51;
            this.dgvpracownik.RowTemplate.Height = 24;
            this.dgvpracownik.Size = new System.Drawing.Size(1244, 350);
            this.dgvpracownik.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 107;
            this.label5.Text = "Wynagrodzenie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Rodzaj umowy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Wymiar pracy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "Pracownik:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1429, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 45);
            this.btnClose.TabIndex = 102;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dpracownikdo
            // 
            this.dpracownikdo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpracownikdo.Location = new System.Drawing.Point(198, 445);
            this.dpracownikdo.Name = "dpracownikdo";
            this.dpracownikdo.Size = new System.Drawing.Size(172, 22);
            this.dpracownikdo.TabIndex = 98;
            // 
            // dpracownikod
            // 
            this.dpracownikod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpracownikod.Location = new System.Drawing.Point(198, 370);
            this.dpracownikod.Name = "dpracownikod";
            this.dpracownikod.Size = new System.Drawing.Size(172, 22);
            this.dpracownikod.TabIndex = 97;
            // 
            // btnAddnewcontract
            // 
            this.btnAddnewcontract.Location = new System.Drawing.Point(1047, 451);
            this.btnAddnewcontract.Name = "btnAddnewcontract";
            this.btnAddnewcontract.Size = new System.Drawing.Size(115, 45);
            this.btnAddnewcontract.TabIndex = 84;
            this.btnAddnewcontract.Text = "Zapisz";
            this.btnAddnewcontract.UseVisualStyleBackColor = true;
            this.btnAddnewcontract.Click += new System.EventHandler(this.btnAddnewcontract_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(376, 445);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 99;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbStanowisko
            // 
            this.cbStanowisko.FormattingEnabled = true;
            this.cbStanowisko.Location = new System.Drawing.Point(198, 243);
            this.cbStanowisko.Name = "cbStanowisko";
            this.cbStanowisko.Size = new System.Drawing.Size(184, 24);
            this.cbStanowisko.TabIndex = 116;
            // 
            // cbDzial
            // 
            this.cbDzial.FormattingEnabled = true;
            this.cbDzial.Location = new System.Drawing.Point(198, 187);
            this.cbDzial.Name = "cbDzial";
            this.cbDzial.Size = new System.Drawing.Size(184, 24);
            this.cbDzial.TabIndex = 117;
            // 
            // cbPracownik
            // 
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(198, 30);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(184, 24);
            this.cbPracownik.TabIndex = 118;
            // 
            // cbWymiarPracy
            // 
            this.cbWymiarPracy.FormattingEnabled = true;
            this.cbWymiarPracy.Location = new System.Drawing.Point(198, 82);
            this.cbWymiarPracy.Name = "cbWymiarPracy";
            this.cbWymiarPracy.Size = new System.Drawing.Size(184, 24);
            this.cbWymiarPracy.TabIndex = 119;
            // 
            // cbRodzajUmowy
            // 
            this.cbRodzajUmowy.FormattingEnabled = true;
            this.cbRodzajUmowy.Location = new System.Drawing.Point(198, 135);
            this.cbRodzajUmowy.Name = "cbRodzajUmowy";
            this.cbRodzajUmowy.Size = new System.Drawing.Size(184, 24);
            this.cbRodzajUmowy.TabIndex = 120;
            // 
            // tbWynagrodzenie
            // 
            this.tbWynagrodzenie.Location = new System.Drawing.Point(198, 294);
            this.tbWynagrodzenie.Name = "tbWynagrodzenie";
            this.tbWynagrodzenie.Size = new System.Drawing.Size(184, 22);
            this.tbWynagrodzenie.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 122;
            this.label4.Text = "Dzial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 123;
            this.label6.Text = "Stanowisko";
            // 
            // FormHRDepartmentWorkerContractNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1685, 875);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbWynagrodzenie);
            this.Controls.Add(this.cbRodzajUmowy);
            this.Controls.Add(this.cbWymiarPracy);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.cbDzial);
            this.Controls.Add(this.cbStanowisko);
            this.Controls.Add(this.dgvpracownik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dpracownikdo);
            this.Controls.Add(this.dpracownikod);
            this.Controls.Add(this.btnAddnewcontract);
            this.Name = "FormHRDepartmentWorkerContractNew";
            this.Text = "Nowa umowa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpracownik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpracownik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dpracownikdo;
        private System.Windows.Forms.DateTimePicker dpracownikod;
        private System.Windows.Forms.Button btnAddnewcontract;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.ComboBox cbDzial;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.ComboBox cbWymiarPracy;
        private System.Windows.Forms.ComboBox cbRodzajUmowy;
        private System.Windows.Forms.TextBox tbWynagrodzenie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}