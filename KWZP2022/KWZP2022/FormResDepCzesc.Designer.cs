namespace KWZP2022
{
    partial class FormResDepCzesc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepCzesc));
            this.cmbRodzajCzesc = new System.Windows.Forms.ComboBox();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.dgvCzesc = new System.Windows.Forms.DataGridView();
            this.txtNazwaCzesc = new System.Windows.Forms.TextBox();
            this.lblNazwaCzesc = new System.Windows.Forms.Label();
            this.lblRodzajCzesc = new System.Windows.Forms.Label();
            this.btnDodajParametr = new System.Windows.Forms.Button();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.btnDodajRodzaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesc)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRodzajCzesc
            // 
            this.cmbRodzajCzesc.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbRodzajCzesc.FormattingEnabled = true;
            this.cmbRodzajCzesc.Location = new System.Drawing.Point(262, 105);
            this.cmbRodzajCzesc.Name = "cmbRodzajCzesc";
            this.cmbRodzajCzesc.Size = new System.Drawing.Size(270, 40);
            this.cmbRodzajCzesc.TabIndex = 19;
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(59, 279);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(225, 37);
            this.btnAktualizuj.TabIndex = 18;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(59, 322);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(225, 37);
            this.btnUsun.TabIndex = 17;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(59, 236);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(225, 37);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdswiez.Location = new System.Drawing.Point(613, 163);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(170, 42);
            this.btnOdswiez.TabIndex = 15;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // dgvCzesc
            // 
            this.dgvCzesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzesc.Location = new System.Drawing.Point(326, 211);
            this.dgvCzesc.Name = "dgvCzesc";
            this.dgvCzesc.RowTemplate.Height = 24;
            this.dgvCzesc.Size = new System.Drawing.Size(457, 254);
            this.dgvCzesc.TabIndex = 14;
            this.dgvCzesc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCzesc_CellContentClick);
            // 
            // txtNazwaCzesc
            // 
            this.txtNazwaCzesc.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaCzesc.Location = new System.Drawing.Point(262, 29);
            this.txtNazwaCzesc.Name = "txtNazwaCzesc";
            this.txtNazwaCzesc.Size = new System.Drawing.Size(270, 39);
            this.txtNazwaCzesc.TabIndex = 13;
            // 
            // lblNazwaCzesc
            // 
            this.lblNazwaCzesc.AutoSize = true;
            this.lblNazwaCzesc.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwaCzesc.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaCzesc.Location = new System.Drawing.Point(39, 32);
            this.lblNazwaCzesc.Name = "lblNazwaCzesc";
            this.lblNazwaCzesc.Size = new System.Drawing.Size(179, 32);
            this.lblNazwaCzesc.TabIndex = 12;
            this.lblNazwaCzesc.Text = "Nazwa części";
            // 
            // lblRodzajCzesc
            // 
            this.lblRodzajCzesc.AutoSize = true;
            this.lblRodzajCzesc.BackColor = System.Drawing.Color.Transparent;
            this.lblRodzajCzesc.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRodzajCzesc.Location = new System.Drawing.Point(39, 108);
            this.lblRodzajCzesc.Name = "lblRodzajCzesc";
            this.lblRodzajCzesc.Size = new System.Drawing.Size(182, 32);
            this.lblRodzajCzesc.TabIndex = 11;
            this.lblRodzajCzesc.Text = "Rodzaj części";
            // 
            // btnDodajParametr
            // 
            this.btnDodajParametr.BackColor = System.Drawing.Color.Orange;
            this.btnDodajParametr.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodajParametr.Location = new System.Drawing.Point(59, 384);
            this.btnDodajParametr.Name = "btnDodajParametr";
            this.btnDodajParametr.Size = new System.Drawing.Size(225, 36);
            this.btnDodajParametr.TabIndex = 32;
            this.btnDodajParametr.Text = "Przypisz parametry";
            this.btnDodajParametr.UseVisualStyleBackColor = false;
            this.btnDodajParametr.Click += new System.EventHandler(this.btnDodajParametr_Click);
            // 
            // lblPodpisWidoku
            // 
            this.lblPodpisWidoku.AutoSize = true;
            this.lblPodpisWidoku.BackColor = System.Drawing.Color.Transparent;
            this.lblPodpisWidoku.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodpisWidoku.Location = new System.Drawing.Point(322, 186);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(68, 22);
            this.lblPodpisWidoku.TabIndex = 33;
            this.lblPodpisWidoku.Text = "Części";
            // 
            // btnDodajRodzaj
            // 
            this.btnDodajRodzaj.BackColor = System.Drawing.Color.Yellow;
            this.btnDodajRodzaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodajRodzaj.Location = new System.Drawing.Point(538, 108);
            this.btnDodajRodzaj.Name = "btnDodajRodzaj";
            this.btnDodajRodzaj.Size = new System.Drawing.Size(224, 37);
            this.btnDodajRodzaj.TabIndex = 57;
            this.btnDodajRodzaj.Text = "Dodaj nowy rodzaj";
            this.btnDodajRodzaj.UseVisualStyleBackColor = false;
            this.btnDodajRodzaj.Click += new System.EventHandler(this.btnDodajRodzaj_Click);
            // 
            // FormResDepCzesc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.btnDodajRodzaj);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnDodajParametr);
            this.Controls.Add(this.cmbRodzajCzesc);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dgvCzesc);
            this.Controls.Add(this.txtNazwaCzesc);
            this.Controls.Add(this.lblNazwaCzesc);
            this.Controls.Add(this.lblRodzajCzesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepCzesc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj część";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRodzajCzesc;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.DataGridView dgvCzesc;
        private System.Windows.Forms.TextBox txtNazwaCzesc;
        private System.Windows.Forms.Label lblNazwaCzesc;
        private System.Windows.Forms.Label lblRodzajCzesc;
        private System.Windows.Forms.Button btnDodajParametr;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.Button btnDodajRodzaj;
    }
}