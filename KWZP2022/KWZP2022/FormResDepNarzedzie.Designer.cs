namespace KWZP2022
{
    partial class FormResDepNarzedzie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepNarzedzie));
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.dgvNarzedzie = new System.Windows.Forms.DataGridView();
            this.txtNazwaNarzedzie = new System.Windows.Forms.TextBox();
            this.lblNazwaNarzedzie = new System.Windows.Forms.Label();
            this.btnDodajParametr = new System.Windows.Forms.Button();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(48, 219);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(225, 37);
            this.btnAktualizuj.TabIndex = 27;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(48, 262);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(225, 37);
            this.btnUsun.TabIndex = 26;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(48, 176);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(225, 37);
            this.btnDodaj.TabIndex = 25;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdswiez.Location = new System.Drawing.Point(602, 128);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(170, 42);
            this.btnOdswiez.TabIndex = 24;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // dgvNarzedzie
            // 
            this.dgvNarzedzie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarzedzie.Location = new System.Drawing.Point(319, 176);
            this.dgvNarzedzie.Name = "dgvNarzedzie";
            this.dgvNarzedzie.RowTemplate.Height = 24;
            this.dgvNarzedzie.Size = new System.Drawing.Size(453, 296);
            this.dgvNarzedzie.TabIndex = 23;
            this.dgvNarzedzie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarzedzie_CellClick);
            // 
            // txtNazwaNarzedzie
            // 
            this.txtNazwaNarzedzie.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaNarzedzie.Location = new System.Drawing.Point(251, 31);
            this.txtNazwaNarzedzie.Name = "txtNazwaNarzedzie";
            this.txtNazwaNarzedzie.Size = new System.Drawing.Size(322, 39);
            this.txtNazwaNarzedzie.TabIndex = 22;
            // 
            // lblNazwaNarzedzie
            // 
            this.lblNazwaNarzedzie.AutoSize = true;
            this.lblNazwaNarzedzie.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwaNarzedzie.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaNarzedzie.Location = new System.Drawing.Point(28, 34);
            this.lblNazwaNarzedzie.Name = "lblNazwaNarzedzie";
            this.lblNazwaNarzedzie.Size = new System.Drawing.Size(220, 32);
            this.lblNazwaNarzedzie.TabIndex = 21;
            this.lblNazwaNarzedzie.Text = "Nazwa narzędzia";
            // 
            // btnDodajParametr
            // 
            this.btnDodajParametr.BackColor = System.Drawing.Color.Orange;
            this.btnDodajParametr.Font = new System.Drawing.Font("Arial", 16F);
            this.btnDodajParametr.Location = new System.Drawing.Point(48, 339);
            this.btnDodajParametr.Name = "btnDodajParametr";
            this.btnDodajParametr.Size = new System.Drawing.Size(225, 37);
            this.btnDodajParametr.TabIndex = 28;
            this.btnDodajParametr.Text = "Przypisz parametry";
            this.btnDodajParametr.UseVisualStyleBackColor = false;
            this.btnDodajParametr.Click += new System.EventHandler(this.btnDodajParametr_Click);
            // 
            // lblPodpisWidoku
            // 
            this.lblPodpisWidoku.AutoSize = true;
            this.lblPodpisWidoku.BackColor = System.Drawing.Color.Transparent;
            this.lblPodpisWidoku.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodpisWidoku.Location = new System.Drawing.Point(315, 151);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(93, 22);
            this.lblPodpisWidoku.TabIndex = 56;
            this.lblPodpisWidoku.Text = "Narzędzia";
            // 
            // FormResDepNarzedzie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnDodajParametr);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dgvNarzedzie);
            this.Controls.Add(this.txtNazwaNarzedzie);
            this.Controls.Add(this.lblNazwaNarzedzie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepNarzedzie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj narzędzie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.DataGridView dgvNarzedzie;
        private System.Windows.Forms.TextBox txtNazwaNarzedzie;
        private System.Windows.Forms.Label lblNazwaNarzedzie;
        private System.Windows.Forms.Button btnDodajParametr;
        private System.Windows.Forms.Label lblPodpisWidoku;
    }
}