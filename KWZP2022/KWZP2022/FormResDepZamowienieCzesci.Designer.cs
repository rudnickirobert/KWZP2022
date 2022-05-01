namespace KWZP2022
{
    partial class FormResDepZamowienieCzesci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepZamowienieCzesci));
            this.lvlZamowienieCzesc = new System.Windows.Forms.Label();
            this.dgvZamowienieCzesci = new System.Windows.Forms.DataGridView();
            this.btnDodajProducenta = new System.Windows.Forms.Button();
            this.btnDodajDostawca = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.numIlosc = new System.Windows.Forms.NumericUpDown();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblIlosc = new System.Windows.Forms.Label();
            this.cmbProducent = new System.Windows.Forms.ComboBox();
            this.lblProducent = new System.Windows.Forms.Label();
            this.cmbCzesc = new System.Windows.Forms.ComboBox();
            this.cmbDostawca = new System.Windows.Forms.ComboBox();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.lblCzesc = new System.Windows.Forms.Label();
            this.lblDostawca = new System.Windows.Forms.Label();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.btnDodajCzesc = new System.Windows.Forms.Button();
            this.btnDodajZamowienie = new System.Windows.Forms.Button();
            this.btnAktualizujStatus = new System.Windows.Forms.Button();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.btnOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieCzesci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIlosc)).BeginInit();
            this.SuspendLayout();
            // 
            // lvlZamowienieCzesc
            // 
            this.lvlZamowienieCzesc.AutoSize = true;
            this.lvlZamowienieCzesc.BackColor = System.Drawing.Color.Transparent;
            this.lvlZamowienieCzesc.Font = new System.Drawing.Font("Arial", 20F);
            this.lvlZamowienieCzesc.Location = new System.Drawing.Point(13, 9);
            this.lvlZamowienieCzesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlZamowienieCzesc.Name = "lvlZamowienieCzesc";
            this.lvlZamowienieCzesc.Size = new System.Drawing.Size(244, 32);
            this.lvlZamowienieCzesc.TabIndex = 20;
            this.lvlZamowienieCzesc.Text = "Zamówienie części";
            // 
            // dgvZamowienieCzesci
            // 
            this.dgvZamowienieCzesci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienieCzesci.Location = new System.Drawing.Point(13, 244);
            this.dgvZamowienieCzesci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZamowienieCzesci.Name = "dgvZamowienieCzesci";
            this.dgvZamowienieCzesci.RowHeadersWidth = 51;
            this.dgvZamowienieCzesci.Size = new System.Drawing.Size(772, 197);
            this.dgvZamowienieCzesci.TabIndex = 14;
            // 
            // btnDodajProducenta
            // 
            this.btnDodajProducenta.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajProducenta.Location = new System.Drawing.Point(358, 172);
            this.btnDodajProducenta.Name = "btnDodajProducenta";
            this.btnDodajProducenta.Size = new System.Drawing.Size(142, 32);
            this.btnDodajProducenta.TabIndex = 39;
            this.btnDodajProducenta.Text = "Dodaj nowego producenta";
            this.btnDodajProducenta.UseVisualStyleBackColor = false;
            this.btnDodajProducenta.Click += new System.EventHandler(this.btnDodajProducenta_Click);
            // 
            // btnDodajDostawca
            // 
            this.btnDodajDostawca.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajDostawca.Location = new System.Drawing.Point(358, 95);
            this.btnDodajDostawca.Name = "btnDodajDostawca";
            this.btnDodajDostawca.Size = new System.Drawing.Size(142, 32);
            this.btnDodajDostawca.TabIndex = 38;
            this.btnDodajDostawca.Text = "Dodaj nowego dostawcę";
            this.btnDodajDostawca.UseVisualStyleBackColor = false;
            this.btnDodajDostawca.Click += new System.EventHandler(this.btnDodajDostawca_Click);
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCena.Location = new System.Drawing.Point(578, 175);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(161, 32);
            this.txtCena.TabIndex = 37;
            this.txtCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCena_KeyPress);
            // 
            // numIlosc
            // 
            this.numIlosc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIlosc.Location = new System.Drawing.Point(578, 133);
            this.numIlosc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIlosc.Name = "numIlosc";
            this.numIlosc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numIlosc.Size = new System.Drawing.Size(161, 32);
            this.numIlosc.TabIndex = 36;
            this.numIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.BackColor = System.Drawing.Color.Transparent;
            this.lblCena.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCena.Location = new System.Drawing.Point(512, 178);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(60, 24);
            this.lblCena.TabIndex = 35;
            this.lblCena.Text = "Cena";
            // 
            // lblIlosc
            // 
            this.lblIlosc.AutoSize = true;
            this.lblIlosc.BackColor = System.Drawing.Color.Transparent;
            this.lblIlosc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIlosc.Location = new System.Drawing.Point(512, 138);
            this.lblIlosc.Name = "lblIlosc";
            this.lblIlosc.Size = new System.Drawing.Size(54, 24);
            this.lblIlosc.TabIndex = 34;
            this.lblIlosc.Text = "Ilość";
            // 
            // cmbProducent
            // 
            this.cmbProducent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbProducent.FormattingEnabled = true;
            this.cmbProducent.Location = new System.Drawing.Point(139, 172);
            this.cmbProducent.Name = "cmbProducent";
            this.cmbProducent.Size = new System.Drawing.Size(213, 32);
            this.cmbProducent.TabIndex = 33;
            // 
            // lblProducent
            // 
            this.lblProducent.AutoSize = true;
            this.lblProducent.BackColor = System.Drawing.Color.Transparent;
            this.lblProducent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProducent.Location = new System.Drawing.Point(24, 175);
            this.lblProducent.Name = "lblProducent";
            this.lblProducent.Size = new System.Drawing.Size(105, 24);
            this.lblProducent.TabIndex = 32;
            this.lblProducent.Text = "Producent";
            // 
            // cmbCzesc
            // 
            this.cmbCzesc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbCzesc.FormattingEnabled = true;
            this.cmbCzesc.Location = new System.Drawing.Point(139, 133);
            this.cmbCzesc.Name = "cmbCzesc";
            this.cmbCzesc.Size = new System.Drawing.Size(213, 32);
            this.cmbCzesc.TabIndex = 31;
            // 
            // cmbDostawca
            // 
            this.cmbDostawca.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbDostawca.FormattingEnabled = true;
            this.cmbDostawca.Location = new System.Drawing.Point(139, 95);
            this.cmbDostawca.Name = "cmbDostawca";
            this.cmbDostawca.Size = new System.Drawing.Size(213, 32);
            this.cmbDostawca.TabIndex = 30;
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(139, 57);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(361, 32);
            this.cmbPracownik.TabIndex = 29;
            // 
            // lblCzesc
            // 
            this.lblCzesc.AutoSize = true;
            this.lblCzesc.BackColor = System.Drawing.Color.Transparent;
            this.lblCzesc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzesc.Location = new System.Drawing.Point(26, 136);
            this.lblCzesc.Name = "lblCzesc";
            this.lblCzesc.Size = new System.Drawing.Size(68, 24);
            this.lblCzesc.TabIndex = 28;
            this.lblCzesc.Text = "Część";
            // 
            // lblDostawca
            // 
            this.lblDostawca.AutoSize = true;
            this.lblDostawca.BackColor = System.Drawing.Color.Transparent;
            this.lblDostawca.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDostawca.Location = new System.Drawing.Point(25, 98);
            this.lblDostawca.Name = "lblDostawca";
            this.lblDostawca.Size = new System.Drawing.Size(104, 24);
            this.lblDostawca.TabIndex = 27;
            this.lblDostawca.Text = "Dostawca";
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.BackColor = System.Drawing.Color.Transparent;
            this.lblPracownik.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPracownik.Location = new System.Drawing.Point(26, 60);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(107, 24);
            this.lblPracownik.TabIndex = 26;
            this.lblPracownik.Text = "Pracownik";
            // 
            // btnDodajCzesc
            // 
            this.btnDodajCzesc.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajCzesc.Location = new System.Drawing.Point(358, 133);
            this.btnDodajCzesc.Name = "btnDodajCzesc";
            this.btnDodajCzesc.Size = new System.Drawing.Size(142, 32);
            this.btnDodajCzesc.TabIndex = 25;
            this.btnDodajCzesc.Text = "Dodaj nową część";
            this.btnDodajCzesc.UseVisualStyleBackColor = false;
            this.btnDodajCzesc.Click += new System.EventHandler(this.btnDodajCzesc_Click);
            // 
            // btnDodajZamowienie
            // 
            this.btnDodajZamowienie.BackColor = System.Drawing.Color.Yellow;
            this.btnDodajZamowienie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZamowienie.Location = new System.Drawing.Point(300, 448);
            this.btnDodajZamowienie.Name = "btnDodajZamowienie";
            this.btnDodajZamowienie.Size = new System.Drawing.Size(216, 43);
            this.btnDodajZamowienie.TabIndex = 40;
            this.btnDodajZamowienie.Text = "Dodaj zamówienie";
            this.btnDodajZamowienie.UseVisualStyleBackColor = false;
            this.btnDodajZamowienie.Click += new System.EventHandler(this.btnDodajZamowienie_Click);
            // 
            // btnAktualizujStatus
            // 
            this.btnAktualizujStatus.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAktualizujStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAktualizujStatus.Location = new System.Drawing.Point(567, 451);
            this.btnAktualizujStatus.Name = "btnAktualizujStatus";
            this.btnAktualizujStatus.Size = new System.Drawing.Size(218, 36);
            this.btnAktualizujStatus.TabIndex = 60;
            this.btnAktualizujStatus.Text = "Aktualizuj status";
            this.btnAktualizujStatus.UseVisualStyleBackColor = false;
            this.btnAktualizujStatus.Click += new System.EventHandler(this.btnAktualizujStatus_Click);
            // 
            // lblPodpisWidoku
            // 
            this.lblPodpisWidoku.AutoSize = true;
            this.lblPodpisWidoku.BackColor = System.Drawing.Color.Transparent;
            this.lblPodpisWidoku.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPodpisWidoku.Location = new System.Drawing.Point(10, 222);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(141, 18);
            this.lblPodpisWidoku.TabIndex = 61;
            this.lblPodpisWidoku.Text = "Zamówienia części";
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnOdswiez.Location = new System.Drawing.Point(578, 57);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(134, 39);
            this.btnOdswiez.TabIndex = 62;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // FormResDepZamowienieCzesci
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 499);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnAktualizujStatus);
            this.Controls.Add(this.btnDodajZamowienie);
            this.Controls.Add(this.btnDodajProducenta);
            this.Controls.Add(this.btnDodajDostawca);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.numIlosc);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblIlosc);
            this.Controls.Add(this.cmbProducent);
            this.Controls.Add(this.lblProducent);
            this.Controls.Add(this.cmbCzesc);
            this.Controls.Add(this.cmbDostawca);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.lblCzesc);
            this.Controls.Add(this.lblDostawca);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.btnDodajCzesc);
            this.Controls.Add(this.lvlZamowienieCzesc);
            this.Controls.Add(this.dgvZamowienieCzesci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepZamowienieCzesci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zamówienie części";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieCzesci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIlosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlZamowienieCzesc;
        private System.Windows.Forms.DataGridView dgvZamowienieCzesci;
        private System.Windows.Forms.Button btnDodajProducenta;
        private System.Windows.Forms.Button btnDodajDostawca;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.NumericUpDown numIlosc;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblIlosc;
        private System.Windows.Forms.ComboBox cmbProducent;
        private System.Windows.Forms.Label lblProducent;
        private System.Windows.Forms.ComboBox cmbCzesc;
        private System.Windows.Forms.ComboBox cmbDostawca;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.Label lblCzesc;
        private System.Windows.Forms.Label lblDostawca;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.Button btnDodajCzesc;
        private System.Windows.Forms.Button btnDodajZamowienie;
        private System.Windows.Forms.Button btnAktualizujStatus;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.Button btnOdswiez;
    }
}