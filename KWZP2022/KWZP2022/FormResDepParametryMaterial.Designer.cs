namespace KWZP2022
{
    partial class FormResDepParametryMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepParametryMaterial));
            this.dgvParametrMaterial = new System.Windows.Forms.DataGridView();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblParametr = new System.Windows.Forms.Label();
            this.lblZakresgora = new System.Windows.Forms.Label();
            this.lblZakresdol = new System.Windows.Forms.Label();
            this.cmbParametr = new System.Windows.Forms.ComboBox();
            this.txtZakresGora = new System.Windows.Forms.TextBox();
            this.txtZakresDol = new System.Windows.Forms.TextBox();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnNowyParametr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParametrMaterial
            // 
            this.dgvParametrMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametrMaterial.Location = new System.Drawing.Point(37, 143);
            this.dgvParametrMaterial.Name = "dgvParametrMaterial";
            this.dgvParametrMaterial.Size = new System.Drawing.Size(738, 144);
            this.dgvParametrMaterial.TabIndex = 0;
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 20.25F);
            this.lblNazwa.Location = new System.Drawing.Point(31, 31);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(111, 32);
            this.lblNazwa.TabIndex = 1;
            this.lblNazwa.Text = "Materiał";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Font = new System.Drawing.Font("Arial", 16.25F);
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(37, 69);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(338, 33);
            this.cmbMaterial.TabIndex = 2;
            // 
            // lblParametr
            // 
            this.lblParametr.AutoSize = true;
            this.lblParametr.BackColor = System.Drawing.Color.Transparent;
            this.lblParametr.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParametr.Location = new System.Drawing.Point(33, 310);
            this.lblParametr.Name = "lblParametr";
            this.lblParametr.Size = new System.Drawing.Size(124, 32);
            this.lblParametr.TabIndex = 3;
            this.lblParametr.Text = "Parametr";
            // 
            // lblZakresgora
            // 
            this.lblZakresgora.AutoSize = true;
            this.lblZakresgora.BackColor = System.Drawing.Color.Transparent;
            this.lblZakresgora.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblZakresgora.Location = new System.Drawing.Point(34, 429);
            this.lblZakresgora.Name = "lblZakresgora";
            this.lblZakresgora.Size = new System.Drawing.Size(126, 25);
            this.lblZakresgora.TabIndex = 4;
            this.lblZakresgora.Text = "Zakres góra";
            // 
            // lblZakresdol
            // 
            this.lblZakresdol.AutoSize = true;
            this.lblZakresdol.BackColor = System.Drawing.Color.Transparent;
            this.lblZakresdol.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblZakresdol.Location = new System.Drawing.Point(34, 377);
            this.lblZakresdol.Name = "lblZakresdol";
            this.lblZakresdol.Size = new System.Drawing.Size(111, 25);
            this.lblZakresdol.TabIndex = 5;
            this.lblZakresdol.Text = "Zakres dół";
            // 
            // cmbParametr
            // 
            this.cmbParametr.Font = new System.Drawing.Font("Arial", 16.25F);
            this.cmbParametr.FormattingEnabled = true;
            this.cmbParametr.Location = new System.Drawing.Point(196, 313);
            this.cmbParametr.Name = "cmbParametr";
            this.cmbParametr.Size = new System.Drawing.Size(237, 33);
            this.cmbParametr.TabIndex = 6;
            // 
            // txtZakresGora
            // 
            this.txtZakresGora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtZakresGora.Location = new System.Drawing.Point(196, 422);
            this.txtZakresGora.Name = "txtZakresGora";
            this.txtZakresGora.Size = new System.Drawing.Size(168, 32);
            this.txtZakresGora.TabIndex = 7;
            this.txtZakresGora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZakresGora_KeyPress);
            // 
            // txtZakresDol
            // 
            this.txtZakresDol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtZakresDol.Location = new System.Drawing.Point(196, 371);
            this.txtZakresDol.Name = "txtZakresDol";
            this.txtZakresDol.Size = new System.Drawing.Size(168, 32);
            this.txtZakresDol.TabIndex = 8;
            this.txtZakresDol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZakresDol_KeyPress);
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(492, 404);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(225, 37);
            this.btnAktualizuj.TabIndex = 21;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(492, 447);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(225, 37);
            this.btnUsun.TabIndex = 20;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(492, 361);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(225, 37);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(194, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Wczytaj parametry";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // lblPodpisWidoku
            // 
            this.lblPodpisWidoku.AutoSize = true;
            this.lblPodpisWidoku.BackColor = System.Drawing.Color.Transparent;
            this.lblPodpisWidoku.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodpisWidoku.Location = new System.Drawing.Point(35, 118);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(177, 22);
            this.lblPodpisWidoku.TabIndex = 57;
            this.lblPodpisWidoku.Text = "Parametry materiału";
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.Ivory;
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(617, 71);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(147, 44);
            this.btnOdswiez.TabIndex = 61;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnNowyParametr
            // 
            this.btnNowyParametr.BackColor = System.Drawing.Color.Gold;
            this.btnNowyParametr.Font = new System.Drawing.Font("Arial", 15F);
            this.btnNowyParametr.Location = new System.Drawing.Point(492, 318);
            this.btnNowyParametr.Name = "btnNowyParametr";
            this.btnNowyParametr.Size = new System.Drawing.Size(225, 37);
            this.btnNowyParametr.TabIndex = 60;
            this.btnNowyParametr.Text = "Dodaj nowy parametr";
            this.btnNowyParametr.UseVisualStyleBackColor = false;
            this.btnNowyParametr.Click += new System.EventHandler(this.btnNowyParametr_Click);
            // 
            // FormResDepParametryMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 496);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnNowyParametr);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtZakresDol);
            this.Controls.Add(this.txtZakresGora);
            this.Controls.Add(this.cmbParametr);
            this.Controls.Add(this.lblZakresdol);
            this.Controls.Add(this.lblZakresgora);
            this.Controls.Add(this.lblParametr);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.dgvParametrMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepParametryMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parametry materiału";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParametrMaterial;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblParametr;
        private System.Windows.Forms.Label lblZakresgora;
        private System.Windows.Forms.Label lblZakresdol;
        private System.Windows.Forms.ComboBox cmbParametr;
        private System.Windows.Forms.TextBox txtZakresGora;
        private System.Windows.Forms.TextBox txtZakresDol;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnNowyParametr;
    }
}