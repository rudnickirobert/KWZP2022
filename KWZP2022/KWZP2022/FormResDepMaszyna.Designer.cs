namespace KWZP2022
{
    partial class FormResDepMaszyna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepMaszyna));
            this.cmbRodzajMaszyna = new System.Windows.Forms.ComboBox();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.dgvMaszyna = new System.Windows.Forms.DataGridView();
            this.txtNazwaMaszyna = new System.Windows.Forms.TextBox();
            this.lblNazwaMaszyna = new System.Windows.Forms.Label();
            this.lblRodzajMaszyna = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKosztRBG = new System.Windows.Forms.TextBox();
            this.btnDodajParametr = new System.Windows.Forms.Button();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.btnSkladMaszyna = new System.Windows.Forms.Button();
            this.btnNowyRodzaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyna)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRodzajMaszyna
            // 
            this.cmbRodzajMaszyna.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbRodzajMaszyna.FormattingEnabled = true;
            this.cmbRodzajMaszyna.Location = new System.Drawing.Point(251, 76);
            this.cmbRodzajMaszyna.Name = "cmbRodzajMaszyna";
            this.cmbRodzajMaszyna.Size = new System.Drawing.Size(270, 40);
            this.cmbRodzajMaszyna.TabIndex = 28;
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(34, 252);
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
            this.btnUsun.Location = new System.Drawing.Point(34, 295);
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
            this.btnDodaj.Location = new System.Drawing.Point(34, 209);
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
            this.btnOdswiez.Location = new System.Drawing.Point(602, 161);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(170, 42);
            this.btnOdswiez.TabIndex = 24;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // dgvMaszyna
            // 
            this.dgvMaszyna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszyna.Location = new System.Drawing.Point(315, 209);
            this.dgvMaszyna.Name = "dgvMaszyna";
            this.dgvMaszyna.RowTemplate.Height = 24;
            this.dgvMaszyna.Size = new System.Drawing.Size(457, 258);
            this.dgvMaszyna.TabIndex = 23;
            this.dgvMaszyna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaszyna_CellContentClick);
            // 
            // txtNazwaMaszyna
            // 
            this.txtNazwaMaszyna.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaMaszyna.Location = new System.Drawing.Point(251, 31);
            this.txtNazwaMaszyna.Name = "txtNazwaMaszyna";
            this.txtNazwaMaszyna.Size = new System.Drawing.Size(270, 39);
            this.txtNazwaMaszyna.TabIndex = 22;
            // 
            // lblNazwaMaszyna
            // 
            this.lblNazwaMaszyna.AutoSize = true;
            this.lblNazwaMaszyna.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwaMaszyna.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaMaszyna.Location = new System.Drawing.Point(28, 34);
            this.lblNazwaMaszyna.Name = "lblNazwaMaszyna";
            this.lblNazwaMaszyna.Size = new System.Drawing.Size(210, 32);
            this.lblNazwaMaszyna.TabIndex = 21;
            this.lblNazwaMaszyna.Text = "Nazwa maszyny";
            // 
            // lblRodzajMaszyna
            // 
            this.lblRodzajMaszyna.AutoSize = true;
            this.lblRodzajMaszyna.BackColor = System.Drawing.Color.Transparent;
            this.lblRodzajMaszyna.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRodzajMaszyna.Location = new System.Drawing.Point(28, 79);
            this.lblRodzajMaszyna.Name = "lblRodzajMaszyna";
            this.lblRodzajMaszyna.Size = new System.Drawing.Size(213, 32);
            this.lblRodzajMaszyna.TabIndex = 20;
            this.lblRodzajMaszyna.Text = "Rodzaj maszyny";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Koszt RBG";
            // 
            // txtKosztRBG
            // 
            this.txtKosztRBG.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKosztRBG.Location = new System.Drawing.Point(251, 123);
            this.txtKosztRBG.Name = "txtKosztRBG";
            this.txtKosztRBG.Size = new System.Drawing.Size(270, 39);
            this.txtKosztRBG.TabIndex = 30;
            this.txtKosztRBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKosztRBG_KeyPress);
            // 
            // btnDodajParametr
            // 
            this.btnDodajParametr.BackColor = System.Drawing.Color.Orange;
            this.btnDodajParametr.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajParametr.Location = new System.Drawing.Point(34, 411);
            this.btnDodajParametr.Name = "btnDodajParametr";
            this.btnDodajParametr.Size = new System.Drawing.Size(219, 42);
            this.btnDodajParametr.TabIndex = 31;
            this.btnDodajParametr.Text = "Przypisz parametry";
            this.btnDodajParametr.UseVisualStyleBackColor = false;
            this.btnDodajParametr.Click += new System.EventHandler(this.btnDodajParametr_Click);
            // 
            // lblPodpisWidoku
            // 
            this.lblPodpisWidoku.AutoSize = true;
            this.lblPodpisWidoku.BackColor = System.Drawing.Color.Transparent;
            this.lblPodpisWidoku.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodpisWidoku.Location = new System.Drawing.Point(311, 184);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(82, 22);
            this.lblPodpisWidoku.TabIndex = 55;
            this.lblPodpisWidoku.Text = "Maszyny";
            // 
            // btnSkladMaszyna
            // 
            this.btnSkladMaszyna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSkladMaszyna.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkladMaszyna.Location = new System.Drawing.Point(34, 363);
            this.btnSkladMaszyna.Name = "btnSkladMaszyna";
            this.btnSkladMaszyna.Size = new System.Drawing.Size(170, 42);
            this.btnSkladMaszyna.TabIndex = 56;
            this.btnSkladMaszyna.Text = "Określ skład";
            this.btnSkladMaszyna.UseVisualStyleBackColor = false;
            this.btnSkladMaszyna.Click += new System.EventHandler(this.btnSkladMaszyna_Click);
            // 
            // btnNowyRodzaj
            // 
            this.btnNowyRodzaj.BackColor = System.Drawing.Color.Yellow;
            this.btnNowyRodzaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnNowyRodzaj.Location = new System.Drawing.Point(527, 79);
            this.btnNowyRodzaj.Name = "btnNowyRodzaj";
            this.btnNowyRodzaj.Size = new System.Drawing.Size(224, 37);
            this.btnNowyRodzaj.TabIndex = 57;
            this.btnNowyRodzaj.Text = "Dodaj nowy rodzaj";
            this.btnNowyRodzaj.UseVisualStyleBackColor = false;
            this.btnNowyRodzaj.Click += new System.EventHandler(this.btnNowyRodzaj_Click);
            // 
            // FormResDepMaszyna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.btnNowyRodzaj);
            this.Controls.Add(this.btnSkladMaszyna);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnDodajParametr);
            this.Controls.Add(this.txtKosztRBG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRodzajMaszyna);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dgvMaszyna);
            this.Controls.Add(this.txtNazwaMaszyna);
            this.Controls.Add(this.lblNazwaMaszyna);
            this.Controls.Add(this.lblRodzajMaszyna);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepMaszyna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj Maszynę";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRodzajMaszyna;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.DataGridView dgvMaszyna;
        private System.Windows.Forms.TextBox txtNazwaMaszyna;
        private System.Windows.Forms.Label lblNazwaMaszyna;
        private System.Windows.Forms.Label lblRodzajMaszyna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKosztRBG;
        private System.Windows.Forms.Button btnDodajParametr;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.Button btnSkladMaszyna;
        private System.Windows.Forms.Button btnNowyRodzaj;
    }
}