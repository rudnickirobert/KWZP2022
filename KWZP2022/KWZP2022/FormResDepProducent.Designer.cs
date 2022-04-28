namespace KWZP2022
{
    partial class FormResDepProducent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepProducent));
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvProducent = new System.Windows.Forms.DataGridView();
            this.numNrbudynku = new System.Windows.Forms.NumericUpDown();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtMiejscowosc = new System.Windows.Forms.TextBox();
            this.lblKodpocztowy = new System.Windows.Forms.Label();
            this.lblNrbudynku = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.lblMiejscowosc = new System.Windows.Forms.Label();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.mtxtKodPocztowy = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrbudynku)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(836, 187);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 27;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(836, 268);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 26;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(836, 108);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 25;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvProducent
            // 
            this.dgvProducent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducent.Location = new System.Drawing.Point(45, 390);
            this.dgvProducent.Name = "dgvProducent";
            this.dgvProducent.Size = new System.Drawing.Size(1195, 272);
            this.dgvProducent.TabIndex = 24;
            this.dgvProducent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducent_CellClick);
            // 
            // numNrbudynku
            // 
            this.numNrbudynku.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numNrbudynku.Location = new System.Drawing.Point(293, 218);
            this.numNrbudynku.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNrbudynku.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNrbudynku.Name = "numNrbudynku";
            this.numNrbudynku.Size = new System.Drawing.Size(214, 44);
            this.numNrbudynku.TabIndex = 22;
            this.numNrbudynku.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtUlica
            // 
            this.txtUlica.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUlica.Location = new System.Drawing.Point(293, 163);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(455, 44);
            this.txtUlica.TabIndex = 21;
            // 
            // txtMiejscowosc
            // 
            this.txtMiejscowosc.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMiejscowosc.Location = new System.Drawing.Point(293, 106);
            this.txtMiejscowosc.Name = "txtMiejscowosc";
            this.txtMiejscowosc.Size = new System.Drawing.Size(455, 44);
            this.txtMiejscowosc.TabIndex = 20;
            // 
            // lblKodpocztowy
            // 
            this.lblKodpocztowy.AutoSize = true;
            this.lblKodpocztowy.BackColor = System.Drawing.Color.Transparent;
            this.lblKodpocztowy.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKodpocztowy.Location = new System.Drawing.Point(39, 288);
            this.lblKodpocztowy.Name = "lblKodpocztowy";
            this.lblKodpocztowy.Size = new System.Drawing.Size(208, 36);
            this.lblKodpocztowy.TabIndex = 19;
            this.lblKodpocztowy.Text = "Kod pocztowy";
            // 
            // lblNrbudynku
            // 
            this.lblNrbudynku.AutoSize = true;
            this.lblNrbudynku.BackColor = System.Drawing.Color.Transparent;
            this.lblNrbudynku.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrbudynku.Location = new System.Drawing.Point(70, 226);
            this.lblNrbudynku.Name = "lblNrbudynku";
            this.lblNrbudynku.Size = new System.Drawing.Size(177, 36);
            this.lblNrbudynku.TabIndex = 18;
            this.lblNrbudynku.Text = "Nr budynku";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(293, 50);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(455, 44);
            this.txtNazwa.TabIndex = 17;
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.BackColor = System.Drawing.Color.Transparent;
            this.lblUlica.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlica.Location = new System.Drawing.Point(162, 171);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(85, 36);
            this.lblUlica.TabIndex = 16;
            this.lblUlica.Text = "Ulica";
            // 
            // lblMiejscowosc
            // 
            this.lblMiejscowosc.AutoSize = true;
            this.lblMiejscowosc.BackColor = System.Drawing.Color.Transparent;
            this.lblMiejscowosc.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiejscowosc.Location = new System.Drawing.Point(53, 109);
            this.lblMiejscowosc.Name = "lblMiejscowosc";
            this.lblMiejscowosc.Size = new System.Drawing.Size(194, 36);
            this.lblMiejscowosc.TabIndex = 15;
            this.lblMiejscowosc.Text = "Miejscowość";
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(137, 53);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(110, 36);
            this.lblNazwa.TabIndex = 14;
            this.lblNazwa.Text = "Nazwa";
            // 
            // lblPodpisWidoku
            // 
            this.lblPodpisWidoku.AutoSize = true;
            this.lblPodpisWidoku.BackColor = System.Drawing.Color.Transparent;
            this.lblPodpisWidoku.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodpisWidoku.Location = new System.Drawing.Point(41, 365);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(106, 22);
            this.lblPodpisWidoku.TabIndex = 57;
            this.lblPodpisWidoku.Text = "Producenci";
            // 
            // mtxtKodPocztowy
            // 
            this.mtxtKodPocztowy.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtxtKodPocztowy.Location = new System.Drawing.Point(293, 285);
            this.mtxtKodPocztowy.Mask = "00-000";
            this.mtxtKodPocztowy.Name = "mtxtKodPocztowy";
            this.mtxtKodPocztowy.Size = new System.Drawing.Size(133, 44);
            this.mtxtKodPocztowy.TabIndex = 58;
            // 
            // FormResDepProducent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1278, 713);
            this.Controls.Add(this.mtxtKodPocztowy);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvProducent);
            this.Controls.Add(this.numNrbudynku);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtMiejscowosc);
            this.Controls.Add(this.lblKodpocztowy);
            this.Controls.Add(this.lblNrbudynku);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.lblUlica);
            this.Controls.Add(this.lblMiejscowosc);
            this.Controls.Add(this.lblNazwa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepProducent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj producenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrbudynku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvProducent;
        private System.Windows.Forms.NumericUpDown numNrbudynku;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtMiejscowosc;
        private System.Windows.Forms.Label lblKodpocztowy;
        private System.Windows.Forms.Label lblNrbudynku;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.Label lblMiejscowosc;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.MaskedTextBox mtxtKodPocztowy;
    }
}