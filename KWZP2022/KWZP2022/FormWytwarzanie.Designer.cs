namespace KWZP2022
{
    partial class FormWytwarzanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWytwarzanie));
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvWytwarzaniePolprodukt = new System.Windows.Forms.DataGridView();
            this.dtpDataOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDo = new System.Windows.Forms.DateTimePicker();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.dgvWytwarzanieProdukt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProcesProdukt = new System.Windows.Forms.DataGridView();
            this.dgvProcesPolprodukt = new System.Windows.Forms.DataGridView();
            this.dgvZamowienieSzczegol = new System.Windows.Forms.DataGridView();
            this.cbZamowienie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSzukanyProduktID = new System.Windows.Forms.TextBox();
            this.txtSzukanyProduktNazwa = new System.Windows.Forms.TextBox();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWybranyID = new System.Windows.Forms.TextBox();
            this.txtWybrany = new System.Windows.Forms.TextBox();
            this.dtpCzasOd = new System.Windows.Forms.DateTimePicker();
            this.dtpCzasDo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzaniePolprodukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzanieProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesPolprodukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieSzczegol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Enabled = false;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(12, 480);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 16;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(12, 549);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 15;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(12, 620);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 14;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(12, 411);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvWytwarzaniePolprodukt
            // 
            this.dgvWytwarzaniePolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWytwarzaniePolprodukt.Location = new System.Drawing.Point(378, 522);
            this.dgvWytwarzaniePolprodukt.Name = "dgvWytwarzaniePolprodukt";
            this.dgvWytwarzaniePolprodukt.Size = new System.Drawing.Size(874, 177);
            this.dgvWytwarzaniePolprodukt.TabIndex = 17;
            // 
            // dtpDataOd
            // 
            this.dtpDataOd.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDataOd.Location = new System.Drawing.Point(12, 236);
            this.dtpDataOd.Name = "dtpDataOd";
            this.dtpDataOd.Size = new System.Drawing.Size(200, 26);
            this.dtpDataOd.TabIndex = 18;
            // 
            // dtpDataDo
            // 
            this.dtpDataDo.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDataDo.Location = new System.Drawing.Point(12, 323);
            this.dtpDataDo.Name = "dtpDataDo";
            this.dtpDataDo.Size = new System.Drawing.Size(200, 26);
            this.dtpDataDo.TabIndex = 19;
            // 
            // cbPracownik
            // 
            this.cbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(12, 54);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(260, 28);
            this.cbPracownik.TabIndex = 20;
            // 
            // dgvWytwarzanieProdukt
            // 
            this.dgvWytwarzanieProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWytwarzanieProdukt.Location = new System.Drawing.Point(378, 333);
            this.dgvWytwarzanieProdukt.Name = "dgvWytwarzanieProdukt";
            this.dgvWytwarzanieProdukt.Size = new System.Drawing.Size(874, 177);
            this.dgvWytwarzanieProdukt.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pracownik:";
            // 
            // cbStanowisko
            // 
            this.cbStanowisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStanowisko.FormattingEnabled = true;
            this.cbStanowisko.Location = new System.Drawing.Point(12, 123);
            this.cbStanowisko.Name = "cbStanowisko";
            this.cbStanowisko.Size = new System.Drawing.Size(260, 28);
            this.cbStanowisko.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Stanowisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(7, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Data rozpoczęcia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(7, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data zakończenia:";
            // 
            // dgvProcesProdukt
            // 
            this.dgvProcesProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesProdukt.Location = new System.Drawing.Point(378, 11);
            this.dgvProcesProdukt.Name = "dgvProcesProdukt";
            this.dgvProcesProdukt.Size = new System.Drawing.Size(329, 259);
            this.dgvProcesProdukt.TabIndex = 28;
            this.dgvProcesProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesProdukt_CellContentClick);
            // 
            // dgvProcesPolprodukt
            // 
            this.dgvProcesPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesPolprodukt.Location = new System.Drawing.Point(731, 12);
            this.dgvProcesPolprodukt.Name = "dgvProcesPolprodukt";
            this.dgvProcesPolprodukt.Size = new System.Drawing.Size(521, 259);
            this.dgvProcesPolprodukt.TabIndex = 29;
            this.dgvProcesPolprodukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesPolprodukt_CellContentClick);
            // 
            // dgvZamowienieSzczegol
            // 
            this.dgvZamowienieSzczegol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienieSzczegol.Location = new System.Drawing.Point(1286, 88);
            this.dgvZamowienieSzczegol.Name = "dgvZamowienieSzczegol";
            this.dgvZamowienieSzczegol.Size = new System.Drawing.Size(447, 220);
            this.dgvZamowienieSzczegol.TabIndex = 30;
            this.dgvZamowienieSzczegol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZamowienieSzczegol_CellContentClick);
            // 
            // cbZamowienie
            // 
            this.cbZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbZamowienie.FormattingEnabled = true;
            this.cbZamowienie.Location = new System.Drawing.Point(1286, 54);
            this.cbZamowienie.Name = "cbZamowienie";
            this.cbZamowienie.Size = new System.Drawing.Size(447, 28);
            this.cbZamowienie.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(1281, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Zamówienie:";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSzukaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnSzukaj.Location = new System.Drawing.Point(1516, 11);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(217, 37);
            this.btnSzukaj.TabIndex = 33;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(1319, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Przygotowanie procesu produkcyjnego dla:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(1319, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(1551, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Nazwa produktu";
            // 
            // txtSzukanyProduktID
            // 
            this.txtSzukanyProduktID.Enabled = false;
            this.txtSzukanyProduktID.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSzukanyProduktID.Location = new System.Drawing.Point(1324, 411);
            this.txtSzukanyProduktID.Name = "txtSzukanyProduktID";
            this.txtSzukanyProduktID.Size = new System.Drawing.Size(46, 30);
            this.txtSzukanyProduktID.TabIndex = 37;
            // 
            // txtSzukanyProduktNazwa
            // 
            this.txtSzukanyProduktNazwa.Enabled = false;
            this.txtSzukanyProduktNazwa.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSzukanyProduktNazwa.Location = new System.Drawing.Point(1431, 411);
            this.txtSzukanyProduktNazwa.Name = "txtSzukanyProduktNazwa";
            this.txtSzukanyProduktNazwa.Size = new System.Drawing.Size(273, 30);
            this.txtSzukanyProduktNazwa.TabIndex = 38;
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAkceptuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAkceptuj.Location = new System.Drawing.Point(1324, 462);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(380, 37);
            this.btnAkceptuj.TabIndex = 39;
            this.btnAkceptuj.Text = "Akceptuj wybór";
            this.btnAkceptuj.UseVisualStyleBackColor = false;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(373, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Rozpoczynasz proces produkcyjny dla:";
            // 
            // txtWybranyID
            // 
            this.txtWybranyID.Enabled = false;
            this.txtWybranyID.Font = new System.Drawing.Font("Arial", 15F);
            this.txtWybranyID.Location = new System.Drawing.Point(731, 291);
            this.txtWybranyID.Name = "txtWybranyID";
            this.txtWybranyID.Size = new System.Drawing.Size(46, 30);
            this.txtWybranyID.TabIndex = 41;
            // 
            // txtWybrany
            // 
            this.txtWybrany.Enabled = false;
            this.txtWybrany.Font = new System.Drawing.Font("Arial", 15F);
            this.txtWybrany.Location = new System.Drawing.Point(796, 291);
            this.txtWybrany.Name = "txtWybrany";
            this.txtWybrany.Size = new System.Drawing.Size(273, 30);
            this.txtWybrany.TabIndex = 42;
            // 
            // dtpCzasOd
            // 
            this.dtpCzasOd.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpCzasOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCzasOd.Location = new System.Drawing.Point(228, 236);
            this.dtpCzasOd.Name = "dtpCzasOd";
            this.dtpCzasOd.Size = new System.Drawing.Size(118, 26);
            this.dtpCzasOd.TabIndex = 43;
            // 
            // dtpCzasDo
            // 
            this.dtpCzasDo.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpCzasDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCzasDo.Location = new System.Drawing.Point(228, 323);
            this.dtpCzasDo.Name = "dtpCzasDo";
            this.dtpCzasDo.Size = new System.Drawing.Size(118, 26);
            this.dtpCzasDo.TabIndex = 44;
            // 
            // FormWytwarzanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1735, 711);
            this.Controls.Add(this.dtpCzasDo);
            this.Controls.Add(this.dtpCzasOd);
            this.Controls.Add(this.txtWybrany);
            this.Controls.Add(this.txtWybranyID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.txtSzukanyProduktNazwa);
            this.Controls.Add(this.txtSzukanyProduktID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbZamowienie);
            this.Controls.Add(this.dgvZamowienieSzczegol);
            this.Controls.Add(this.dgvProcesPolprodukt);
            this.Controls.Add(this.dgvProcesProdukt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStanowisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWytwarzanieProdukt);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.dtpDataDo);
            this.Controls.Add(this.dtpDataOd);
            this.Controls.Add(this.dgvWytwarzaniePolprodukt);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FormWytwarzanie";
            this.Text = "Wytwarzanie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzaniePolprodukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzanieProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesPolprodukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieSzczegol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvWytwarzaniePolprodukt;
        private System.Windows.Forms.DateTimePicker dtpDataOd;
        private System.Windows.Forms.DateTimePicker dtpDataDo;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.DataGridView dgvWytwarzanieProdukt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProcesProdukt;
        private System.Windows.Forms.DataGridView dgvProcesPolprodukt;
        private System.Windows.Forms.DataGridView dgvZamowienieSzczegol;
        private System.Windows.Forms.ComboBox cbZamowienie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSzukanyProduktID;
        private System.Windows.Forms.TextBox txtSzukanyProduktNazwa;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWybranyID;
        private System.Windows.Forms.TextBox txtWybrany;
        private System.Windows.Forms.DateTimePicker dtpCzasOd;
        private System.Windows.Forms.DateTimePicker dtpCzasDo;
    }
}