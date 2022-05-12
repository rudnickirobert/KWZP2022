namespace KWZP2022
{
    partial class FormResDepZamowienieMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepZamowienieMaterial));
            this.btnDodajMaterial = new System.Windows.Forms.Button();
            this.dgvZamowienieMaterial = new System.Windows.Forms.DataGridView();
            this.LblPracownik = new System.Windows.Forms.Label();
            this.lblDostawca = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.cmbDostawca = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbProducent = new System.Windows.Forms.ComboBox();
            this.lblProducent = new System.Windows.Forms.Label();
            this.lblWaga = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.numWaga = new System.Windows.Forms.NumericUpDown();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnDodajDostawca = new System.Windows.Forms.Button();
            this.btnDodajProducenta = new System.Windows.Forms.Button();
            this.btnDodajZamowienie = new System.Windows.Forms.Button();
            this.lvlZamowienieMaterial = new System.Windows.Forms.Label();
            this.btnAktualizujStatus = new System.Windows.Forms.Button();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.dgvMissingMaterials = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissingMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajMaterial
            // 
            this.btnDodajMaterial.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajMaterial.Location = new System.Drawing.Point(454, 130);
            this.btnDodajMaterial.Name = "btnDodajMaterial";
            this.btnDodajMaterial.Size = new System.Drawing.Size(167, 32);
            this.btnDodajMaterial.TabIndex = 0;
            this.btnDodajMaterial.Text = "Dodaj nowy materiał";
            this.btnDodajMaterial.UseVisualStyleBackColor = false;
            this.btnDodajMaterial.Click += new System.EventHandler(this.btnDodajMaterial_Click);
            // 
            // dgvZamowienieMaterial
            // 
            this.dgvZamowienieMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienieMaterial.Location = new System.Drawing.Point(19, 242);
            this.dgvZamowienieMaterial.Name = "dgvZamowienieMaterial";
            this.dgvZamowienieMaterial.RowHeadersWidth = 51;
            this.dgvZamowienieMaterial.RowTemplate.Height = 24;
            this.dgvZamowienieMaterial.Size = new System.Drawing.Size(923, 216);
            this.dgvZamowienieMaterial.TabIndex = 1;
            // 
            // LblPracownik
            // 
            this.LblPracownik.AutoSize = true;
            this.LblPracownik.BackColor = System.Drawing.Color.Transparent;
            this.LblPracownik.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPracownik.Location = new System.Drawing.Point(23, 57);
            this.LblPracownik.Name = "LblPracownik";
            this.LblPracownik.Size = new System.Drawing.Size(107, 24);
            this.LblPracownik.TabIndex = 2;
            this.LblPracownik.Text = "Pracownik";
            // 
            // lblDostawca
            // 
            this.lblDostawca.AutoSize = true;
            this.lblDostawca.BackColor = System.Drawing.Color.Transparent;
            this.lblDostawca.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDostawca.Location = new System.Drawing.Point(22, 95);
            this.lblDostawca.Name = "lblDostawca";
            this.lblDostawca.Size = new System.Drawing.Size(104, 24);
            this.lblDostawca.TabIndex = 7;
            this.lblDostawca.Text = "Dostawca";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.BackColor = System.Drawing.Color.Transparent;
            this.lblMaterial.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaterial.Location = new System.Drawing.Point(23, 133);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(85, 24);
            this.lblMaterial.TabIndex = 9;
            this.lblMaterial.Text = "Materiał";
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(136, 54);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(485, 32);
            this.cmbPracownik.TabIndex = 11;
            // 
            // cmbDostawca
            // 
            this.cmbDostawca.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbDostawca.FormattingEnabled = true;
            this.cmbDostawca.Location = new System.Drawing.Point(136, 92);
            this.cmbDostawca.Name = "cmbDostawca";
            this.cmbDostawca.Size = new System.Drawing.Size(312, 32);
            this.cmbDostawca.TabIndex = 13;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(136, 130);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(312, 32);
            this.cmbMaterial.TabIndex = 14;
            // 
            // cmbProducent
            // 
            this.cmbProducent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbProducent.FormattingEnabled = true;
            this.cmbProducent.Location = new System.Drawing.Point(136, 169);
            this.cmbProducent.Name = "cmbProducent";
            this.cmbProducent.Size = new System.Drawing.Size(312, 32);
            this.cmbProducent.TabIndex = 16;
            // 
            // lblProducent
            // 
            this.lblProducent.AutoSize = true;
            this.lblProducent.BackColor = System.Drawing.Color.Transparent;
            this.lblProducent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProducent.Location = new System.Drawing.Point(21, 172);
            this.lblProducent.Name = "lblProducent";
            this.lblProducent.Size = new System.Drawing.Size(105, 24);
            this.lblProducent.TabIndex = 15;
            this.lblProducent.Text = "Producent";
            // 
            // lblWaga
            // 
            this.lblWaga.AutoSize = true;
            this.lblWaga.BackColor = System.Drawing.Color.Transparent;
            this.lblWaga.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWaga.Location = new System.Drawing.Point(647, 133);
            this.lblWaga.Name = "lblWaga";
            this.lblWaga.Size = new System.Drawing.Size(93, 24);
            this.lblWaga.TabIndex = 17;
            this.lblWaga.Text = "Masa (g)";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.BackColor = System.Drawing.Color.Transparent;
            this.lblCena.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCena.Location = new System.Drawing.Point(647, 173);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(60, 24);
            this.lblCena.TabIndex = 19;
            this.lblCena.Text = "Cena";
            // 
            // numWaga
            // 
            this.numWaga.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numWaga.Location = new System.Drawing.Point(749, 131);
            this.numWaga.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numWaga.Name = "numWaga";
            this.numWaga.Size = new System.Drawing.Size(161, 32);
            this.numWaga.TabIndex = 21;
            this.numWaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCena.Location = new System.Drawing.Point(749, 170);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(161, 32);
            this.txtCena.TabIndex = 22;
            this.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCena_KeyPress);
            // 
            // btnDodajDostawca
            // 
            this.btnDodajDostawca.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajDostawca.Location = new System.Drawing.Point(454, 92);
            this.btnDodajDostawca.Name = "btnDodajDostawca";
            this.btnDodajDostawca.Size = new System.Drawing.Size(167, 32);
            this.btnDodajDostawca.TabIndex = 23;
            this.btnDodajDostawca.Text = "Dodaj nowego dostawcę";
            this.btnDodajDostawca.UseVisualStyleBackColor = false;
            this.btnDodajDostawca.Click += new System.EventHandler(this.btnDodajDostawca_Click);
            // 
            // btnDodajProducenta
            // 
            this.btnDodajProducenta.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajProducenta.Location = new System.Drawing.Point(454, 168);
            this.btnDodajProducenta.Name = "btnDodajProducenta";
            this.btnDodajProducenta.Size = new System.Drawing.Size(167, 32);
            this.btnDodajProducenta.TabIndex = 24;
            this.btnDodajProducenta.Text = "Dodaj nowego producenta";
            this.btnDodajProducenta.UseVisualStyleBackColor = false;
            this.btnDodajProducenta.Click += new System.EventHandler(this.btnDodajProducenta_Click);
            // 
            // btnDodajZamowienie
            // 
            this.btnDodajZamowienie.BackColor = System.Drawing.Color.Yellow;
            this.btnDodajZamowienie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZamowienie.Location = new System.Drawing.Point(377, 474);
            this.btnDodajZamowienie.Name = "btnDodajZamowienie";
            this.btnDodajZamowienie.Size = new System.Drawing.Size(216, 43);
            this.btnDodajZamowienie.TabIndex = 25;
            this.btnDodajZamowienie.Text = "Dodaj zamówienie";
            this.btnDodajZamowienie.UseVisualStyleBackColor = false;
            this.btnDodajZamowienie.Click += new System.EventHandler(this.btnDodajZamowienie_Click);
            // 
            // lvlZamowienieMaterial
            // 
            this.lvlZamowienieMaterial.AutoSize = true;
            this.lvlZamowienieMaterial.BackColor = System.Drawing.Color.Transparent;
            this.lvlZamowienieMaterial.Font = new System.Drawing.Font("Arial", 20F);
            this.lvlZamowienieMaterial.Location = new System.Drawing.Point(13, 9);
            this.lvlZamowienieMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlZamowienieMaterial.Name = "lvlZamowienieMaterial";
            this.lvlZamowienieMaterial.Size = new System.Drawing.Size(278, 32);
            this.lvlZamowienieMaterial.TabIndex = 26;
            this.lvlZamowienieMaterial.Text = "Zamówienie materiału";
            // 
            // btnAktualizujStatus
            // 
            this.btnAktualizujStatus.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAktualizujStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAktualizujStatus.Location = new System.Drawing.Point(695, 477);
            this.btnAktualizujStatus.Name = "btnAktualizujStatus";
            this.btnAktualizujStatus.Size = new System.Drawing.Size(249, 36);
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
            this.lblPodpisWidoku.Location = new System.Drawing.Point(16, 221);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(177, 18);
            this.lblPodpisWidoku.TabIndex = 62;
            this.lblPodpisWidoku.Text = "Zamówienia materiałów:";
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnOdswiez.Location = new System.Drawing.Point(810, 70);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(134, 39);
            this.btnOdswiez.TabIndex = 63;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // dgvMissingMaterials
            // 
            this.dgvMissingMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissingMaterials.Location = new System.Drawing.Point(990, 120);
            this.dgvMissingMaterials.Name = "dgvMissingMaterials";
            this.dgvMissingMaterials.Size = new System.Drawing.Size(303, 338);
            this.dgvMissingMaterials.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(986, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Brakujący materiał:";
            // 
            // FormResDepZamowienieMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1305, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMissingMaterials);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnAktualizujStatus);
            this.Controls.Add(this.lvlZamowienieMaterial);
            this.Controls.Add(this.btnDodajZamowienie);
            this.Controls.Add(this.btnDodajProducenta);
            this.Controls.Add(this.btnDodajDostawca);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.numWaga);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblWaga);
            this.Controls.Add(this.cmbProducent);
            this.Controls.Add(this.lblProducent);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbDostawca);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblDostawca);
            this.Controls.Add(this.LblPracownik);
            this.Controls.Add(this.dgvZamowienieMaterial);
            this.Controls.Add(this.btnDodajMaterial);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepZamowienieMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zamówienie materiału";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissingMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajMaterial;
        private System.Windows.Forms.DataGridView dgvZamowienieMaterial;
        private System.Windows.Forms.Label LblPracownik;
        private System.Windows.Forms.Label lblDostawca;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.ComboBox cmbDostawca;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbProducent;
        private System.Windows.Forms.Label lblProducent;
        private System.Windows.Forms.Label lblWaga;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.NumericUpDown numWaga;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button btnDodajDostawca;
        private System.Windows.Forms.Button btnDodajProducenta;
        private System.Windows.Forms.Button btnDodajZamowienie;
        private System.Windows.Forms.Label lvlZamowienieMaterial;
        private System.Windows.Forms.Button btnAktualizujStatus;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.DataGridView dgvMissingMaterials;
        private System.Windows.Forms.Label label1;
    }
}