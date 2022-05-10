namespace KWZP2022
{
    partial class FormResDepMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepMaterial));
            this.lblRodzajMaterial = new System.Windows.Forms.Label();
            this.lblNazwaMaterial = new System.Windows.Forms.Label();
            this.txtNazwaMaterial = new System.Windows.Forms.TextBox();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbRodzajMaterial = new System.Windows.Forms.ComboBox();
            this.btnDodajParametr = new System.Windows.Forms.Button();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.btnDodajRodzaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRodzajMaterial
            // 
            this.lblRodzajMaterial.AutoSize = true;
            this.lblRodzajMaterial.BackColor = System.Drawing.Color.Transparent;
            this.lblRodzajMaterial.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRodzajMaterial.Location = new System.Drawing.Point(40, 119);
            this.lblRodzajMaterial.Name = "lblRodzajMaterial";
            this.lblRodzajMaterial.Size = new System.Drawing.Size(217, 32);
            this.lblRodzajMaterial.TabIndex = 0;
            this.lblRodzajMaterial.Text = "Rodzaj materiału";
            // 
            // lblNazwaMaterial
            // 
            this.lblNazwaMaterial.AutoSize = true;
            this.lblNazwaMaterial.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwaMaterial.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaMaterial.Location = new System.Drawing.Point(40, 43);
            this.lblNazwaMaterial.Name = "lblNazwaMaterial";
            this.lblNazwaMaterial.Size = new System.Drawing.Size(214, 32);
            this.lblNazwaMaterial.TabIndex = 1;
            this.lblNazwaMaterial.Text = "Nazwa materiału";
            // 
            // txtNazwaMaterial
            // 
            this.txtNazwaMaterial.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaMaterial.Location = new System.Drawing.Point(263, 40);
            this.txtNazwaMaterial.Name = "txtNazwaMaterial";
            this.txtNazwaMaterial.Size = new System.Drawing.Size(270, 39);
            this.txtNazwaMaterial.TabIndex = 2;
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Location = new System.Drawing.Point(420, 244);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowTemplate.Height = 24;
            this.dgvMaterial.Size = new System.Drawing.Size(527, 248);
            this.dgvMaterial.TabIndex = 5;
            this.dgvMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellClick);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdswiez.Location = new System.Drawing.Point(811, 199);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(136, 39);
            this.btnOdswiez.TabIndex = 6;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(46, 287);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 9;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(46, 330);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 8;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(46, 244);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbRodzajMaterial
            // 
            this.cmbRodzajMaterial.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbRodzajMaterial.FormattingEnabled = true;
            this.cmbRodzajMaterial.Location = new System.Drawing.Point(263, 116);
            this.cmbRodzajMaterial.Name = "cmbRodzajMaterial";
            this.cmbRodzajMaterial.Size = new System.Drawing.Size(270, 40);
            this.cmbRodzajMaterial.TabIndex = 10;
            // 
            // btnDodajParametr
            // 
            this.btnDodajParametr.BackColor = System.Drawing.Color.Orange;
            this.btnDodajParametr.Font = new System.Drawing.Font("Arial", 16F);
            this.btnDodajParametr.Location = new System.Drawing.Point(94, 383);
            this.btnDodajParametr.Name = "btnDodajParametr";
            this.btnDodajParametr.Size = new System.Drawing.Size(242, 37);
            this.btnDodajParametr.TabIndex = 11;
            this.btnDodajParametr.Text = "Przypisz parametry";
            this.btnDodajParametr.UseVisualStyleBackColor = false;
            this.btnDodajParametr.Click += new System.EventHandler(this.btnDodajParametr_Click);
            // 
            // lblPodpisWidoku
            // 
            this.lblPodpisWidoku.AutoSize = true;
            this.lblPodpisWidoku.BackColor = System.Drawing.Color.Transparent;
            this.lblPodpisWidoku.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodpisWidoku.Location = new System.Drawing.Point(416, 219);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(84, 22);
            this.lblPodpisWidoku.TabIndex = 55;
            this.lblPodpisWidoku.Text = "Materiały";
            // 
            // btnDodajRodzaj
            // 
            this.btnDodajRodzaj.BackColor = System.Drawing.Color.Yellow;
            this.btnDodajRodzaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodajRodzaj.Location = new System.Drawing.Point(539, 119);
            this.btnDodajRodzaj.Name = "btnDodajRodzaj";
            this.btnDodajRodzaj.Size = new System.Drawing.Size(224, 37);
            this.btnDodajRodzaj.TabIndex = 56;
            this.btnDodajRodzaj.Text = "Dodaj nowy rodzaj";
            this.btnDodajRodzaj.UseVisualStyleBackColor = false;
            this.btnDodajRodzaj.Click += new System.EventHandler(this.btnDodajRodzaj_Click);
            // 
            // FormResDepMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(959, 541);
            this.Controls.Add(this.btnDodajRodzaj);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnDodajParametr);
            this.Controls.Add(this.cmbRodzajMaterial);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dgvMaterial);
            this.Controls.Add(this.txtNazwaMaterial);
            this.Controls.Add(this.lblNazwaMaterial);
            this.Controls.Add(this.lblRodzajMaterial);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj materiał";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRodzajMaterial;
        private System.Windows.Forms.Label lblNazwaMaterial;
        private System.Windows.Forms.TextBox txtNazwaMaterial;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbRodzajMaterial;
        private System.Windows.Forms.Button btnDodajParametr;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.Button btnDodajRodzaj;
    }
}