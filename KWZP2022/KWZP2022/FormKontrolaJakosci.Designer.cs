namespace KWZP2022
{
    partial class FormKontrolaJakosci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKontrolaJakosci));
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvvParametrProdukt = new System.Windows.Forms.DataGridView();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.txtWartosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParametrProdukt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvvKontrolaProdukt = new System.Windows.Forms.DataGridView();
            this.cBPracownik = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBRodzajKontrola = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUwagi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dTPDataOd = new System.Windows.Forms.DateTimePicker();
            this.dTPDataDo = new System.Windows.Forms.DateTimePicker();
            this.dgvvKontrolaJakosciKolejka = new System.Windows.Forms.DataGridView();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.dTPCzasDo = new System.Windows.Forms.DateTimePicker();
            this.dTPCzasOd = new System.Windows.Forms.DateTimePicker();
            this.dgvPozytywne = new System.Windows.Forms.DataGridView();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.cbZamowienie = new System.Windows.Forms.ComboBox();
            this.btnWczytajZamowienie = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvRezultatKontroli = new System.Windows.Forms.DataGridView();
            this.btnGauss = new System.Windows.Forms.Button();
            this.txtKontrolaIlosc = new System.Windows.Forms.TextBox();
            this.btnRezultat = new System.Windows.Forms.Button();
            this.btnAlert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvParametrProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaJakosciKolejka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozytywne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatKontroli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(12, 605);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(212, 37);
            this.btnOdswiez.TabIndex = 39;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(12, 536);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(212, 37);
            this.btnDodaj.TabIndex = 36;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Produkt";
            // 
            // dgvvParametrProdukt
            // 
            this.dgvvParametrProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvParametrProdukt.Location = new System.Drawing.Point(681, 83);
            this.dgvvParametrProdukt.Name = "dgvvParametrProdukt";
            this.dgvvParametrProdukt.Size = new System.Drawing.Size(593, 290);
            this.dgvvParametrProdukt.TabIndex = 40;
            this.dgvvParametrProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvParametrProdukt_CellContentClick);
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAkceptuj.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAkceptuj.Location = new System.Drawing.Point(123, 15);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(101, 31);
            this.btnAkceptuj.TabIndex = 42;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = false;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // txtWartosc
            // 
            this.txtWartosc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartosc.Location = new System.Drawing.Point(12, 167);
            this.txtWartosc.Name = "txtWartosc";
            this.txtWartosc.Size = new System.Drawing.Size(212, 25);
            this.txtWartosc.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Wartość";
            // 
            // txtParametrProdukt
            // 
            this.txtParametrProdukt.Enabled = false;
            this.txtParametrProdukt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParametrProdukt.Location = new System.Drawing.Point(12, 110);
            this.txtParametrProdukt.Name = "txtParametrProdukt";
            this.txtParametrProdukt.Size = new System.Drawing.Size(212, 25);
            this.txtParametrProdukt.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Parametr produktu";
            // 
            // dgvvKontrolaProdukt
            // 
            this.dgvvKontrolaProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvKontrolaProdukt.Location = new System.Drawing.Point(1608, 379);
            this.dgvvKontrolaProdukt.Name = "dgvvKontrolaProdukt";
            this.dgvvKontrolaProdukt.Size = new System.Drawing.Size(25, 282);
            this.dgvvKontrolaProdukt.TabIndex = 47;
            this.dgvvKontrolaProdukt.Visible = false;
            // 
            // cBPracownik
            // 
            this.cBPracownik.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBPracownik.FormattingEnabled = true;
            this.cBPracownik.Location = new System.Drawing.Point(12, 235);
            this.cBPracownik.Name = "cBPracownik";
            this.cBPracownik.Size = new System.Drawing.Size(212, 25);
            this.cBPracownik.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Pracownik";
            // 
            // cBRodzajKontrola
            // 
            this.cBRodzajKontrola.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBRodzajKontrola.FormattingEnabled = true;
            this.cBRodzajKontrola.Location = new System.Drawing.Point(12, 292);
            this.cBRodzajKontrola.Name = "cBRodzajKontrola";
            this.cBRodzajKontrola.Size = new System.Drawing.Size(212, 25);
            this.cBRodzajKontrola.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(23, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Rodzaj kontroli";
            // 
            // txtUwagi
            // 
            this.txtUwagi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUwagi.Location = new System.Drawing.Point(12, 467);
            this.txtUwagi.Name = "txtUwagi";
            this.txtUwagi.Size = new System.Drawing.Size(212, 25);
            this.txtUwagi.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(23, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Uwagi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(23, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Data od";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(23, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Data do";
            // 
            // dTPDataOd
            // 
            this.dTPDataOd.Location = new System.Drawing.Point(12, 345);
            this.dTPDataOd.Name = "dTPDataOd";
            this.dTPDataOd.Size = new System.Drawing.Size(101, 20);
            this.dTPDataOd.TabIndex = 56;
            // 
            // dTPDataDo
            // 
            this.dTPDataDo.Location = new System.Drawing.Point(12, 407);
            this.dTPDataDo.Name = "dTPDataDo";
            this.dTPDataDo.Size = new System.Drawing.Size(101, 20);
            this.dTPDataDo.TabIndex = 57;
            // 
            // dgvvKontrolaJakosciKolejka
            // 
            this.dgvvKontrolaJakosciKolejka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvKontrolaJakosciKolejka.Location = new System.Drawing.Point(301, 83);
            this.dgvvKontrolaJakosciKolejka.Name = "dgvvKontrolaJakosciKolejka";
            this.dgvvKontrolaJakosciKolejka.Size = new System.Drawing.Size(349, 259);
            this.dgvvKontrolaJakosciKolejka.TabIndex = 58;
            this.dgvvKontrolaJakosciKolejka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvKontrolaJakosciKolejka_CellContentClick);
            // 
            // txtNazwa
            // 
            this.txtNazwa.Enabled = false;
            this.txtNazwa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(12, 52);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(212, 25);
            this.txtNazwa.TabIndex = 59;
            // 
            // dTPCzasDo
            // 
            this.dTPCzasDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPCzasDo.Location = new System.Drawing.Point(123, 407);
            this.dTPCzasDo.Name = "dTPCzasDo";
            this.dTPCzasDo.Size = new System.Drawing.Size(101, 20);
            this.dTPCzasDo.TabIndex = 61;
            // 
            // dTPCzasOd
            // 
            this.dTPCzasOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPCzasOd.Location = new System.Drawing.Point(123, 345);
            this.dTPCzasOd.Name = "dTPCzasOd";
            this.dTPCzasOd.Size = new System.Drawing.Size(101, 20);
            this.dTPCzasOd.TabIndex = 60;
            // 
            // dgvPozytywne
            // 
            this.dgvPozytywne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPozytywne.Location = new System.Drawing.Point(681, 421);
            this.dgvPozytywne.Name = "dgvPozytywne";
            this.dgvPozytywne.Size = new System.Drawing.Size(593, 290);
            this.dgvPozytywne.TabIndex = 62;
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.BackColor = System.Drawing.Color.Khaki;
            this.btnGeneruj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnGeneruj.Location = new System.Drawing.Point(301, 458);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(349, 37);
            this.btnGeneruj.TabIndex = 63;
            this.btnGeneruj.Text = "Pomiar Maszyna";
            this.btnGeneruj.UseVisualStyleBackColor = false;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // cbZamowienie
            // 
            this.cbZamowienie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbZamowienie.FormattingEnabled = true;
            this.cbZamowienie.Location = new System.Drawing.Point(301, 358);
            this.cbZamowienie.Name = "cbZamowienie";
            this.cbZamowienie.Size = new System.Drawing.Size(349, 25);
            this.cbZamowienie.TabIndex = 64;
            // 
            // btnWczytajZamowienie
            // 
            this.btnWczytajZamowienie.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnWczytajZamowienie.Font = new System.Drawing.Font("Arial", 15F);
            this.btnWczytajZamowienie.Location = new System.Drawing.Point(301, 407);
            this.btnWczytajZamowienie.Name = "btnWczytajZamowienie";
            this.btnWczytajZamowienie.Size = new System.Drawing.Size(349, 37);
            this.btnWczytajZamowienie.TabIndex = 65;
            this.btnWczytajZamowienie.Text = "Wczytaj produkty";
            this.btnWczytajZamowienie.UseVisualStyleBackColor = false;
            this.btnWczytajZamowienie.Click += new System.EventHandler(this.btnWczytajZamowienie_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 16F);
            this.label9.Location = new System.Drawing.Point(296, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 66;
            this.label9.Text = "Wybierz produkt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 16F);
            this.label10.Location = new System.Drawing.Point(676, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 25);
            this.label10.TabIndex = 67;
            this.label10.Text = "Wybierz parametr:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 16F);
            this.label11.Location = new System.Drawing.Point(676, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 25);
            this.label11.TabIndex = 68;
            this.label11.Text = "Produkty z pozytywną kontrolą";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 13F);
            this.label12.Location = new System.Drawing.Point(297, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 21);
            this.label12.TabIndex = 69;
            this.label12.Text = "Rezultat kontroli:";
            // 
            // dgvRezultatKontroli
            // 
            this.dgvRezultatKontroli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultatKontroli.Location = new System.Drawing.Point(301, 548);
            this.dgvRezultatKontroli.Name = "dgvRezultatKontroli";
            this.dgvRezultatKontroli.Size = new System.Drawing.Size(349, 123);
            this.dgvRezultatKontroli.TabIndex = 70;
            // 
            // btnGauss
            // 
            this.btnGauss.BackColor = System.Drawing.Color.Thistle;
            this.btnGauss.Font = new System.Drawing.Font("Arial", 15F);
            this.btnGauss.Location = new System.Drawing.Point(301, 677);
            this.btnGauss.Name = "btnGauss";
            this.btnGauss.Size = new System.Drawing.Size(349, 34);
            this.btnGauss.TabIndex = 71;
            this.btnGauss.Text = "Rozkład Normalny";
            this.btnGauss.UseVisualStyleBackColor = false;
            this.btnGauss.Click += new System.EventHandler(this.btnGauss_Click);
            // 
            // txtKontrolaIlosc
            // 
            this.txtKontrolaIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtKontrolaIlosc.Location = new System.Drawing.Point(550, 501);
            this.txtKontrolaIlosc.Name = "txtKontrolaIlosc";
            this.txtKontrolaIlosc.Size = new System.Drawing.Size(100, 38);
            this.txtKontrolaIlosc.TabIndex = 72;
            // 
            // btnRezultat
            // 
            this.btnRezultat.BackColor = System.Drawing.Color.Thistle;
            this.btnRezultat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRezultat.BackgroundImage")));
            this.btnRezultat.Font = new System.Drawing.Font("Arial", 15F);
            this.btnRezultat.Image = ((System.Drawing.Image)(resources.GetObject("btnRezultat.Image")));
            this.btnRezultat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRezultat.Location = new System.Drawing.Point(260, 637);
            this.btnRezultat.Name = "btnRezultat";
            this.btnRezultat.Size = new System.Drawing.Size(35, 34);
            this.btnRezultat.TabIndex = 73;
            this.btnRezultat.UseVisualStyleBackColor = false;
            this.btnRezultat.Click += new System.EventHandler(this.btnRezultat_Click);
            // 
            // btnAlert
            // 
            this.btnAlert.BackColor = System.Drawing.Color.LightYellow;
            this.btnAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAlert.Location = new System.Drawing.Point(920, 12);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(344, 63);
            this.btnAlert.TabIndex = 74;
            this.btnAlert.Text = "POWIADOM O REALIZACJI";
            this.btnAlert.UseVisualStyleBackColor = false;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // FormKontrolaJakosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1276, 714);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.btnRezultat);
            this.Controls.Add(this.txtKontrolaIlosc);
            this.Controls.Add(this.btnGauss);
            this.Controls.Add(this.dgvRezultatKontroli);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnWczytajZamowienie);
            this.Controls.Add(this.cbZamowienie);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.dgvPozytywne);
            this.Controls.Add(this.dTPCzasDo);
            this.Controls.Add(this.dTPCzasOd);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.dgvvKontrolaJakosciKolejka);
            this.Controls.Add(this.dTPDataDo);
            this.Controls.Add(this.dTPDataOd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUwagi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBRodzajKontrola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBPracownik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvvKontrolaProdukt);
            this.Controls.Add(this.txtWartosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParametrProdukt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.dgvvParametrProdukt);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Name = "FormKontrolaJakosci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kontrola jakości produktów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvvParametrProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaJakosciKolejka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozytywne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatKontroli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvvParametrProdukt;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.TextBox txtWartosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParametrProdukt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvvKontrolaProdukt;
        private System.Windows.Forms.ComboBox cBPracownik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBRodzajKontrola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUwagi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dTPDataOd;
        private System.Windows.Forms.DateTimePicker dTPDataDo;
        private System.Windows.Forms.DataGridView dgvvKontrolaJakosciKolejka;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.DateTimePicker dTPCzasDo;
        private System.Windows.Forms.DateTimePicker dTPCzasOd;
        private System.Windows.Forms.DataGridView dgvPozytywne;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.ComboBox cbZamowienie;
        private System.Windows.Forms.Button btnWczytajZamowienie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvRezultatKontroli;
        private System.Windows.Forms.Button btnGauss;
        private System.Windows.Forms.TextBox txtKontrolaIlosc;
        private System.Windows.Forms.Button btnRezultat;
        private System.Windows.Forms.Button btnAlert;
    }
}