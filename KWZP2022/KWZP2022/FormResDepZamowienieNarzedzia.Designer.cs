namespace KWZP2022
{
    partial class FormResDepZamowienieNarzedzia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepZamowienieNarzedzia));
            this.btnDodajZamowienie = new System.Windows.Forms.Button();
            this.btnDodajProducenta = new System.Windows.Forms.Button();
            this.btnDodajDostawca = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.numSztuk = new System.Windows.Forms.NumericUpDown();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblSztuk = new System.Windows.Forms.Label();
            this.cmbProducent = new System.Windows.Forms.ComboBox();
            this.lblProducent = new System.Windows.Forms.Label();
            this.cmbNarzedzie = new System.Windows.Forms.ComboBox();
            this.cmbDostawca = new System.Windows.Forms.ComboBox();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.lblNarzedzie = new System.Windows.Forms.Label();
            this.lblDostawca = new System.Windows.Forms.Label();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.btnDodajNarzedzie = new System.Windows.Forms.Button();
            this.lvlZamowienieNarzedzia = new System.Windows.Forms.Label();
            this.dgvZamowienieNarzedzia = new System.Windows.Forms.DataGridView();
            this.btnAktualizujStatus = new System.Windows.Forms.Button();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.btnOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSztuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieNarzedzia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajZamowienie
            // 
            this.btnDodajZamowienie.BackColor = System.Drawing.Color.Yellow;
            this.btnDodajZamowienie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZamowienie.Location = new System.Drawing.Point(301, 447);
            this.btnDodajZamowienie.Name = "btnDodajZamowienie";
            this.btnDodajZamowienie.Size = new System.Drawing.Size(216, 43);
            this.btnDodajZamowienie.TabIndex = 58;
            this.btnDodajZamowienie.Text = "Dodaj zamówienie";
            this.btnDodajZamowienie.UseVisualStyleBackColor = false;
            this.btnDodajZamowienie.Click += new System.EventHandler(this.btnDodajZamowienie_Click);
            // 
            // btnDodajProducenta
            // 
            this.btnDodajProducenta.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajProducenta.Location = new System.Drawing.Point(359, 171);
            this.btnDodajProducenta.Name = "btnDodajProducenta";
            this.btnDodajProducenta.Size = new System.Drawing.Size(142, 32);
            this.btnDodajProducenta.TabIndex = 57;
            this.btnDodajProducenta.Text = "Dodaj nowego producenta";
            this.btnDodajProducenta.UseVisualStyleBackColor = false;
            this.btnDodajProducenta.Click += new System.EventHandler(this.btnDodajProducenta_Click);
            // 
            // btnDodajDostawca
            // 
            this.btnDodajDostawca.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajDostawca.Location = new System.Drawing.Point(359, 94);
            this.btnDodajDostawca.Name = "btnDodajDostawca";
            this.btnDodajDostawca.Size = new System.Drawing.Size(142, 32);
            this.btnDodajDostawca.TabIndex = 56;
            this.btnDodajDostawca.Text = "Dodaj nowego dostawcę";
            this.btnDodajDostawca.UseVisualStyleBackColor = false;
            this.btnDodajDostawca.Click += new System.EventHandler(this.btnDodajDostawca_Click);
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCena.Location = new System.Drawing.Point(579, 174);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(161, 32);
            this.txtCena.TabIndex = 55;
            this.txtCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCena_KeyPress);
            // 
            // numSztuk
            // 
            this.numSztuk.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numSztuk.Location = new System.Drawing.Point(579, 132);
            this.numSztuk.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSztuk.Name = "numSztuk";
            this.numSztuk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numSztuk.Size = new System.Drawing.Size(161, 32);
            this.numSztuk.TabIndex = 54;
            this.numSztuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.BackColor = System.Drawing.Color.Transparent;
            this.lblCena.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCena.Location = new System.Drawing.Point(513, 177);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(60, 24);
            this.lblCena.TabIndex = 53;
            this.lblCena.Text = "Cena";
            // 
            // lblSztuk
            // 
            this.lblSztuk.AutoSize = true;
            this.lblSztuk.BackColor = System.Drawing.Color.Transparent;
            this.lblSztuk.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSztuk.Location = new System.Drawing.Point(513, 137);
            this.lblSztuk.Name = "lblSztuk";
            this.lblSztuk.Size = new System.Drawing.Size(60, 24);
            this.lblSztuk.TabIndex = 52;
            this.lblSztuk.Text = "Sztuk";
            // 
            // cmbProducent
            // 
            this.cmbProducent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbProducent.FormattingEnabled = true;
            this.cmbProducent.Location = new System.Drawing.Point(140, 171);
            this.cmbProducent.Name = "cmbProducent";
            this.cmbProducent.Size = new System.Drawing.Size(213, 32);
            this.cmbProducent.TabIndex = 51;
            // 
            // lblProducent
            // 
            this.lblProducent.AutoSize = true;
            this.lblProducent.BackColor = System.Drawing.Color.Transparent;
            this.lblProducent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProducent.Location = new System.Drawing.Point(25, 174);
            this.lblProducent.Name = "lblProducent";
            this.lblProducent.Size = new System.Drawing.Size(105, 24);
            this.lblProducent.TabIndex = 50;
            this.lblProducent.Text = "Producent";
            // 
            // cmbNarzedzie
            // 
            this.cmbNarzedzie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbNarzedzie.FormattingEnabled = true;
            this.cmbNarzedzie.Location = new System.Drawing.Point(140, 132);
            this.cmbNarzedzie.Name = "cmbNarzedzie";
            this.cmbNarzedzie.Size = new System.Drawing.Size(213, 32);
            this.cmbNarzedzie.TabIndex = 49;
            // 
            // cmbDostawca
            // 
            this.cmbDostawca.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbDostawca.FormattingEnabled = true;
            this.cmbDostawca.Location = new System.Drawing.Point(140, 94);
            this.cmbDostawca.Name = "cmbDostawca";
            this.cmbDostawca.Size = new System.Drawing.Size(213, 32);
            this.cmbDostawca.TabIndex = 48;
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(140, 56);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(361, 32);
            this.cmbPracownik.TabIndex = 47;
            // 
            // lblNarzedzie
            // 
            this.lblNarzedzie.AutoSize = true;
            this.lblNarzedzie.BackColor = System.Drawing.Color.Transparent;
            this.lblNarzedzie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNarzedzie.Location = new System.Drawing.Point(27, 135);
            this.lblNarzedzie.Name = "lblNarzedzie";
            this.lblNarzedzie.Size = new System.Drawing.Size(101, 24);
            this.lblNarzedzie.TabIndex = 46;
            this.lblNarzedzie.Text = "Narzędzie";
            // 
            // lblDostawca
            // 
            this.lblDostawca.AutoSize = true;
            this.lblDostawca.BackColor = System.Drawing.Color.Transparent;
            this.lblDostawca.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDostawca.Location = new System.Drawing.Point(26, 97);
            this.lblDostawca.Name = "lblDostawca";
            this.lblDostawca.Size = new System.Drawing.Size(104, 24);
            this.lblDostawca.TabIndex = 45;
            this.lblDostawca.Text = "Dostawca";
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.BackColor = System.Drawing.Color.Transparent;
            this.lblPracownik.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPracownik.Location = new System.Drawing.Point(27, 59);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(107, 24);
            this.lblPracownik.TabIndex = 44;
            this.lblPracownik.Text = "Pracownik";
            // 
            // btnDodajNarzedzie
            // 
            this.btnDodajNarzedzie.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajNarzedzie.Location = new System.Drawing.Point(359, 132);
            this.btnDodajNarzedzie.Name = "btnDodajNarzedzie";
            this.btnDodajNarzedzie.Size = new System.Drawing.Size(142, 32);
            this.btnDodajNarzedzie.TabIndex = 43;
            this.btnDodajNarzedzie.Text = "Dodaj nowe narzędzie";
            this.btnDodajNarzedzie.UseVisualStyleBackColor = false;
            this.btnDodajNarzedzie.Click += new System.EventHandler(this.btnDodajNarzedzie_Click);
            // 
            // lvlZamowienieNarzedzia
            // 
            this.lvlZamowienieNarzedzia.AutoSize = true;
            this.lvlZamowienieNarzedzia.BackColor = System.Drawing.Color.Transparent;
            this.lvlZamowienieNarzedzia.Font = new System.Drawing.Font("Arial", 20F);
            this.lvlZamowienieNarzedzia.Location = new System.Drawing.Point(14, 8);
            this.lvlZamowienieNarzedzia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlZamowienieNarzedzia.Name = "lvlZamowienieNarzedzia";
            this.lvlZamowienieNarzedzia.Size = new System.Drawing.Size(284, 32);
            this.lvlZamowienieNarzedzia.TabIndex = 42;
            this.lvlZamowienieNarzedzia.Text = "Zamówienie narzędzia";
            // 
            // dgvZamowienieNarzedzia
            // 
            this.dgvZamowienieNarzedzia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienieNarzedzia.Location = new System.Drawing.Point(13, 239);
            this.dgvZamowienieNarzedzia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZamowienieNarzedzia.Name = "dgvZamowienieNarzedzia";
            this.dgvZamowienieNarzedzia.RowHeadersWidth = 51;
            this.dgvZamowienieNarzedzia.Size = new System.Drawing.Size(773, 201);
            this.dgvZamowienieNarzedzia.TabIndex = 41;
            // 
            // btnAktualizujStatus
            // 
            this.btnAktualizujStatus.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAktualizujStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAktualizujStatus.Location = new System.Drawing.Point(566, 454);
            this.btnAktualizujStatus.Name = "btnAktualizujStatus";
            this.btnAktualizujStatus.Size = new System.Drawing.Size(220, 36);
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
            this.lblPodpisWidoku.Location = new System.Drawing.Point(10, 217);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(155, 18);
            this.lblPodpisWidoku.TabIndex = 62;
            this.lblPodpisWidoku.Text = "Zamówienia narzędzi";
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnOdswiez.Location = new System.Drawing.Point(579, 56);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(134, 39);
            this.btnOdswiez.TabIndex = 63;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // FormResDepZamowienieNarzedzia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 498);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnAktualizujStatus);
            this.Controls.Add(this.btnDodajZamowienie);
            this.Controls.Add(this.btnDodajProducenta);
            this.Controls.Add(this.btnDodajDostawca);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.numSztuk);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblSztuk);
            this.Controls.Add(this.cmbProducent);
            this.Controls.Add(this.lblProducent);
            this.Controls.Add(this.cmbNarzedzie);
            this.Controls.Add(this.cmbDostawca);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.lblNarzedzie);
            this.Controls.Add(this.lblDostawca);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.btnDodajNarzedzie);
            this.Controls.Add(this.lvlZamowienieNarzedzia);
            this.Controls.Add(this.dgvZamowienieNarzedzia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepZamowienieNarzedzia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zamówienie narzędzia";
            ((System.ComponentModel.ISupportInitialize)(this.numSztuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieNarzedzia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZamowienie;
        private System.Windows.Forms.Button btnDodajProducenta;
        private System.Windows.Forms.Button btnDodajDostawca;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.NumericUpDown numSztuk;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblSztuk;
        private System.Windows.Forms.ComboBox cmbProducent;
        private System.Windows.Forms.Label lblProducent;
        private System.Windows.Forms.ComboBox cmbNarzedzie;
        private System.Windows.Forms.ComboBox cmbDostawca;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.Label lblNarzedzie;
        private System.Windows.Forms.Label lblDostawca;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.Button btnDodajNarzedzie;
        private System.Windows.Forms.Label lvlZamowienieNarzedzia;
        private System.Windows.Forms.DataGridView dgvZamowienieNarzedzia;
        private System.Windows.Forms.Button btnAktualizujStatus;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.Button btnOdswiez;
    }
}