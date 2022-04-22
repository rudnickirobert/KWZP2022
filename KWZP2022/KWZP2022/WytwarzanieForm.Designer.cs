namespace KWZP2022
{
    partial class WytwarzanieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WytwarzanieForm));
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvWytwarzanie = new System.Windows.Forms.DataGridView();
            this.dtpDataOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDo = new System.Windows.Forms.DateTimePicker();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzanie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Enabled = false;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(45, 477);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 16;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(45, 546);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 15;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(45, 617);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 14;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(45, 408);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dgvWytwarzanie
            // 
            this.dgvWytwarzanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWytwarzanie.Location = new System.Drawing.Point(467, 408);
            this.dgvWytwarzanie.Name = "dgvWytwarzanie";
            this.dgvWytwarzanie.Size = new System.Drawing.Size(759, 246);
            this.dgvWytwarzanie.TabIndex = 17;
            // 
            // dtpDataOd
            // 
            this.dtpDataOd.Location = new System.Drawing.Point(63, 247);
            this.dtpDataOd.Name = "dtpDataOd";
            this.dtpDataOd.Size = new System.Drawing.Size(200, 20);
            this.dtpDataOd.TabIndex = 18;
            // 
            // dtpDataDo
            // 
            this.dtpDataDo.Location = new System.Drawing.Point(63, 333);
            this.dtpDataDo.Name = "dtpDataDo";
            this.dtpDataDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDataDo.TabIndex = 19;
            // 
            // cbPracownik
            // 
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(63, 148);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(121, 21);
            this.cbPracownik.TabIndex = 20;
            // 
            // WytwarzanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.dtpDataDo);
            this.Controls.Add(this.dtpDataOd);
            this.Controls.Add(this.dgvWytwarzanie);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodaj);
            this.Name = "WytwarzanieForm";
            this.Text = "Wytwarzanie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzanie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvWytwarzanie;
        private System.Windows.Forms.DateTimePicker dtpDataOd;
        private System.Windows.Forms.DateTimePicker dtpDataDo;
        private System.Windows.Forms.ComboBox cbPracownik;
    }
}