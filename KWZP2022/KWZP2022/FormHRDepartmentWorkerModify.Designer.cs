namespace KWZP2022
{
    partial class FormHRDepartmentWorkerModify2
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
            this.dgvpracownik = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDataDoEmail = new System.Windows.Forms.CheckBox();
            this.cbDataDoNrTelefonu = new System.Windows.Forms.CheckBox();
            this.cbDataDo = new System.Windows.Forms.CheckBox();
            this.dpracownikdo = new System.Windows.Forms.DateTimePicker();
            this.dpracownikod = new System.Windows.Forms.DateTimePicker();
            this.demaildo = new System.Windows.Forms.DateTimePicker();
            this.demailod = new System.Windows.Forms.DateTimePicker();
            this.dnrdo = new System.Windows.Forms.DateTimePicker();
            this.dnrod = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNumer = new System.Windows.Forms.TextBox();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.tblokal = new System.Windows.Forms.TextBox();
            this.tbBudynek = new System.Windows.Forms.TextBox();
            this.tbUlica = new System.Windows.Forms.TextBox();
            this.tbMiejscowosc = new System.Windows.Forms.TextBox();
            this.cbWyksztalcenie = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.tbNrdowodu = new System.Windows.Forms.TextBox();
            this.tbPracownikImie = new System.Windows.Forms.TextBox();
            this.tbPracownikNazwisko = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpracownik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpracownik
            // 
            this.dgvpracownik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpracownik.Location = new System.Drawing.Point(27, 492);
            this.dgvpracownik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvpracownik.Name = "dgvpracownik";
            this.dgvpracownik.RowHeadersWidth = 51;
            this.dgvpracownik.RowTemplate.Height = 24;
            this.dgvpracownik.Size = new System.Drawing.Size(1244, 350);
            this.dgvpracownik.TabIndex = 185;
            this.dgvpracownik.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvpracownik_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(989, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 184;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(757, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 23);
            this.label11.TabIndex = 183;
            this.label11.Text = "Nr telefonu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(347, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 182;
            this.label10.Text = "Kod pocztowy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(424, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 181;
            this.label9.Text = "Lokal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(396, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 180;
            this.label8.Text = "Budynek:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(429, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 179;
            this.label7.Text = "Ulica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(358, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 178;
            this.label6.Text = "Miejscowość:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 177;
            this.label5.Text = "Wykształcenie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(83, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 176;
            this.label4.Text = "Pesel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(37, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 175;
            this.label3.Text = "Nr dowodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(87, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 174;
            this.label2.Text = "Imię:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 173;
            this.label1.Text = "Nazwisko:";
            // 
            // cbDataDoEmail
            // 
            this.cbDataDoEmail.AutoSize = true;
            this.cbDataDoEmail.Location = new System.Drawing.Point(1171, 268);
            this.cbDataDoEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDataDoEmail.Name = "cbDataDoEmail";
            this.cbDataDoEmail.Size = new System.Drawing.Size(15, 14);
            this.cbDataDoEmail.TabIndex = 172;
            this.cbDataDoEmail.UseVisualStyleBackColor = true;
            // 
            // cbDataDoNrTelefonu
            // 
            this.cbDataDoNrTelefonu.AutoSize = true;
            this.cbDataDoNrTelefonu.Location = new System.Drawing.Point(939, 268);
            this.cbDataDoNrTelefonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDataDoNrTelefonu.Name = "cbDataDoNrTelefonu";
            this.cbDataDoNrTelefonu.Size = new System.Drawing.Size(15, 14);
            this.cbDataDoNrTelefonu.TabIndex = 171;
            this.cbDataDoNrTelefonu.UseVisualStyleBackColor = true;
            // 
            // cbDataDo
            // 
            this.cbDataDo.AutoSize = true;
            this.cbDataDo.Location = new System.Drawing.Point(312, 425);
            this.cbDataDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDataDo.Name = "cbDataDo";
            this.cbDataDo.Size = new System.Drawing.Size(15, 14);
            this.cbDataDo.TabIndex = 170;
            this.cbDataDo.UseVisualStyleBackColor = true;
            // 
            // dpracownikdo
            // 
            this.dpracownikdo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpracownikdo.Location = new System.Drawing.Point(133, 425);
            this.dpracownikdo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpracownikdo.Name = "dpracownikdo";
            this.dpracownikdo.Size = new System.Drawing.Size(172, 22);
            this.dpracownikdo.TabIndex = 169;
            // 
            // dpracownikod
            // 
            this.dpracownikod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpracownikod.Location = new System.Drawing.Point(133, 350);
            this.dpracownikod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpracownikod.Name = "dpracownikod";
            this.dpracownikod.Size = new System.Drawing.Size(172, 22);
            this.dpracownikod.TabIndex = 168;
            // 
            // demaildo
            // 
            this.demaildo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.demaildo.Location = new System.Drawing.Point(992, 268);
            this.demaildo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.demaildo.Name = "demaildo";
            this.demaildo.Size = new System.Drawing.Size(172, 22);
            this.demaildo.TabIndex = 167;
            // 
            // demailod
            // 
            this.demailod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.demailod.Location = new System.Drawing.Point(992, 196);
            this.demailod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.demailod.Name = "demailod";
            this.demailod.Size = new System.Drawing.Size(172, 22);
            this.demailod.TabIndex = 166;
            // 
            // dnrdo
            // 
            this.dnrdo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dnrdo.Location = new System.Drawing.Point(760, 268);
            this.dnrdo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dnrdo.Name = "dnrdo";
            this.dnrdo.Size = new System.Drawing.Size(172, 22);
            this.dnrdo.TabIndex = 165;
            // 
            // dnrod
            // 
            this.dnrod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dnrod.Location = new System.Drawing.Point(760, 196);
            this.dnrod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dnrod.Name = "dnrod";
            this.dnrod.Size = new System.Drawing.Size(172, 22);
            this.dnrod.TabIndex = 164;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(992, 132);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(172, 22);
            this.tbEmail.TabIndex = 163;
            // 
            // tbNumer
            // 
            this.tbNumer.Location = new System.Drawing.Point(760, 132);
            this.tbNumer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumer.Name = "tbNumer";
            this.tbNumer.Size = new System.Drawing.Size(172, 22);
            this.tbNumer.TabIndex = 162;
            // 
            // tbKod
            // 
            this.tbKod.Location = new System.Drawing.Point(493, 64);
            this.tbKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(172, 22);
            this.tbKod.TabIndex = 161;
            // 
            // tblokal
            // 
            this.tblokal.Location = new System.Drawing.Point(493, 267);
            this.tblokal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblokal.Name = "tblokal";
            this.tblokal.Size = new System.Drawing.Size(172, 22);
            this.tblokal.TabIndex = 160;
            // 
            // tbBudynek
            // 
            this.tbBudynek.Location = new System.Drawing.Point(493, 197);
            this.tbBudynek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBudynek.Name = "tbBudynek";
            this.tbBudynek.Size = new System.Drawing.Size(172, 22);
            this.tbBudynek.TabIndex = 159;
            // 
            // tbUlica
            // 
            this.tbUlica.Location = new System.Drawing.Point(493, 129);
            this.tbUlica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUlica.Name = "tbUlica";
            this.tbUlica.Size = new System.Drawing.Size(172, 22);
            this.tbUlica.TabIndex = 158;
            // 
            // tbMiejscowosc
            // 
            this.tbMiejscowosc.Location = new System.Drawing.Point(493, 11);
            this.tbMiejscowosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMiejscowosc.Name = "tbMiejscowosc";
            this.tbMiejscowosc.Size = new System.Drawing.Size(172, 22);
            this.tbMiejscowosc.TabIndex = 157;
            // 
            // cbWyksztalcenie
            // 
            this.cbWyksztalcenie.FormattingEnabled = true;
            this.cbWyksztalcenie.Location = new System.Drawing.Point(154, 268);
            this.cbWyksztalcenie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWyksztalcenie.Name = "cbWyksztalcenie";
            this.cbWyksztalcenie.Size = new System.Drawing.Size(172, 24);
            this.cbWyksztalcenie.TabIndex = 156;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(983, 430);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 46);
            this.btnSave.TabIndex = 155;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(154, 198);
            this.tbPesel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(172, 22);
            this.tbPesel.TabIndex = 154;
            // 
            // tbNrdowodu
            // 
            this.tbNrdowodu.Location = new System.Drawing.Point(154, 129);
            this.tbNrdowodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNrdowodu.Name = "tbNrdowodu";
            this.tbNrdowodu.Size = new System.Drawing.Size(172, 22);
            this.tbNrdowodu.TabIndex = 153;
            // 
            // tbPracownikImie
            // 
            this.tbPracownikImie.Location = new System.Drawing.Point(154, 63);
            this.tbPracownikImie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPracownikImie.Name = "tbPracownikImie";
            this.tbPracownikImie.Size = new System.Drawing.Size(172, 22);
            this.tbPracownikImie.TabIndex = 152;
            // 
            // tbPracownikNazwisko
            // 
            this.tbPracownikNazwisko.Location = new System.Drawing.Point(154, 11);
            this.tbPracownikNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPracownikNazwisko.Name = "tbPracownikNazwisko";
            this.tbPracownikNazwisko.Size = new System.Drawing.Size(172, 22);
            this.tbPracownikNazwisko.TabIndex = 151;
            // 
            // FormHRDepartmentWorkerModify2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1283, 875);
            this.Controls.Add(this.dgvpracownik);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDataDoEmail);
            this.Controls.Add(this.cbDataDoNrTelefonu);
            this.Controls.Add(this.cbDataDo);
            this.Controls.Add(this.dpracownikdo);
            this.Controls.Add(this.dpracownikod);
            this.Controls.Add(this.demaildo);
            this.Controls.Add(this.demailod);
            this.Controls.Add(this.dnrdo);
            this.Controls.Add(this.dnrod);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNumer);
            this.Controls.Add(this.tbKod);
            this.Controls.Add(this.tblokal);
            this.Controls.Add(this.tbBudynek);
            this.Controls.Add(this.tbUlica);
            this.Controls.Add(this.tbMiejscowosc);
            this.Controls.Add(this.cbWyksztalcenie);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPesel);
            this.Controls.Add(this.tbNrdowodu);
            this.Controls.Add(this.tbPracownikImie);
            this.Controls.Add(this.tbPracownikNazwisko);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHRDepartmentWorkerModify2";
            this.Text = "Zmiana danych pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpracownik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpracownik;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDataDoEmail;
        private System.Windows.Forms.CheckBox cbDataDoNrTelefonu;
        private System.Windows.Forms.CheckBox cbDataDo;
        private System.Windows.Forms.DateTimePicker dpracownikdo;
        private System.Windows.Forms.DateTimePicker dpracownikod;
        private System.Windows.Forms.DateTimePicker demaildo;
        private System.Windows.Forms.DateTimePicker demailod;
        private System.Windows.Forms.DateTimePicker dnrdo;
        private System.Windows.Forms.DateTimePicker dnrod;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNumer;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.TextBox tblokal;
        private System.Windows.Forms.TextBox tbBudynek;
        private System.Windows.Forms.TextBox tbUlica;
        private System.Windows.Forms.TextBox tbMiejscowosc;
        private System.Windows.Forms.ComboBox cbWyksztalcenie;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.TextBox tbNrdowodu;
        private System.Windows.Forms.TextBox tbPracownikImie;
        private System.Windows.Forms.TextBox tbPracownikNazwisko;
    }
}