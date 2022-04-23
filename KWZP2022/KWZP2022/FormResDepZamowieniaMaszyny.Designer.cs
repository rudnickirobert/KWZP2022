namespace KWZP2022
{
    partial class FormResDepZamowieniaMaszyny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepZamowieniaMaszyny));
            this.btnDodajZamowienie = new System.Windows.Forms.Button();
            this.btnDodajProducenta = new System.Windows.Forms.Button();
            this.btnDodajDostawca = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.numIlosc = new System.Windows.Forms.NumericUpDown();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblIlosc = new System.Windows.Forms.Label();
            this.cmbProducent = new System.Windows.Forms.ComboBox();
            this.lblProducent = new System.Windows.Forms.Label();
            this.cmbMaszyna = new System.Windows.Forms.ComboBox();
            this.cmbDostawca = new System.Windows.Forms.ComboBox();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.lblMaszyna = new System.Windows.Forms.Label();
            this.lblDostawca = new System.Windows.Forms.Label();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.btnDodajMaszyna = new System.Windows.Forms.Button();
            this.lvlZamowienieMaszyna = new System.Windows.Forms.Label();
            this.dgvZamowienieMaszyna = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieMaszyna)).BeginInit();
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
            this.btnDodajProducenta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajProducenta.Location = new System.Drawing.Point(359, 171);
            this.btnDodajProducenta.Name = "btnDodajProducenta";
            this.btnDodajProducenta.Size = new System.Drawing.Size(142, 32);
            this.btnDodajProducenta.TabIndex = 57;
            this.btnDodajProducenta.Text = "Dodaj nowego producenta";
            this.btnDodajProducenta.UseVisualStyleBackColor = false;
            // 
            // btnDodajDostawca
            // 
            this.btnDodajDostawca.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajDostawca.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDostawca.Location = new System.Drawing.Point(359, 94);
            this.btnDodajDostawca.Name = "btnDodajDostawca";
            this.btnDodajDostawca.Size = new System.Drawing.Size(142, 32);
            this.btnDodajDostawca.TabIndex = 56;
            this.btnDodajDostawca.Text = "Dodaj nowego dostawcę";
            this.btnDodajDostawca.UseVisualStyleBackColor = false;
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
            // numIlosc
            // 
            this.numIlosc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIlosc.Location = new System.Drawing.Point(579, 132);
            this.numIlosc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIlosc.Name = "numIlosc";
            this.numIlosc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numIlosc.Size = new System.Drawing.Size(161, 32);
            this.numIlosc.TabIndex = 54;
            this.numIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lblIlosc
            // 
            this.lblIlosc.AutoSize = true;
            this.lblIlosc.BackColor = System.Drawing.Color.Transparent;
            this.lblIlosc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIlosc.Location = new System.Drawing.Point(513, 137);
            this.lblIlosc.Name = "lblIlosc";
            this.lblIlosc.Size = new System.Drawing.Size(54, 24);
            this.lblIlosc.TabIndex = 52;
            this.lblIlosc.Text = "Ilość";
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
            // cmbMaszyna
            // 
            this.cmbMaszyna.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMaszyna.FormattingEnabled = true;
            this.cmbMaszyna.Location = new System.Drawing.Point(140, 132);
            this.cmbMaszyna.Name = "cmbMaszyna";
            this.cmbMaszyna.Size = new System.Drawing.Size(213, 32);
            this.cmbMaszyna.TabIndex = 49;
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
            this.cmbPracownik.Size = new System.Drawing.Size(213, 32);
            this.cmbPracownik.TabIndex = 47;
            // 
            // lblMaszyna
            // 
            this.lblMaszyna.AutoSize = true;
            this.lblMaszyna.BackColor = System.Drawing.Color.Transparent;
            this.lblMaszyna.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaszyna.Location = new System.Drawing.Point(27, 135);
            this.lblMaszyna.Name = "lblMaszyna";
            this.lblMaszyna.Size = new System.Drawing.Size(93, 24);
            this.lblMaszyna.TabIndex = 46;
            this.lblMaszyna.Text = "Maszyna";
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
            // btnDodajMaszyna
            // 
            this.btnDodajMaszyna.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajMaszyna.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajMaszyna.Location = new System.Drawing.Point(359, 132);
            this.btnDodajMaszyna.Name = "btnDodajMaszyna";
            this.btnDodajMaszyna.Size = new System.Drawing.Size(142, 32);
            this.btnDodajMaszyna.TabIndex = 43;
            this.btnDodajMaszyna.Text = "Dodaj nową część";
            this.btnDodajMaszyna.UseVisualStyleBackColor = false;
            this.btnDodajMaszyna.Click += new System.EventHandler(this.btnDodajMaszyna_Click);
            // 
            // lvlZamowienieMaszyna
            // 
            this.lvlZamowienieMaszyna.AutoSize = true;
            this.lvlZamowienieMaszyna.BackColor = System.Drawing.Color.Transparent;
            this.lvlZamowienieMaszyna.Font = new System.Drawing.Font("Arial", 20F);
            this.lvlZamowienieMaszyna.Location = new System.Drawing.Point(14, 8);
            this.lvlZamowienieMaszyna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlZamowienieMaszyna.Name = "lvlZamowienieMaszyna";
            this.lvlZamowienieMaszyna.Size = new System.Drawing.Size(274, 32);
            this.lvlZamowienieMaszyna.TabIndex = 42;
            this.lvlZamowienieMaszyna.Text = "Zamówienie maszyny";
            // 
            // dgvZamowienieMaszyna
            // 
            this.dgvZamowienieMaszyna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienieMaszyna.Location = new System.Drawing.Point(14, 232);
            this.dgvZamowienieMaszyna.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZamowienieMaszyna.Name = "dgvZamowienieMaszyna";
            this.dgvZamowienieMaszyna.RowHeadersWidth = 51;
            this.dgvZamowienieMaszyna.Size = new System.Drawing.Size(772, 208);
            this.dgvZamowienieMaszyna.TabIndex = 41;
            // 
            // FormResDepZamowieniaMaszyny
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.btnDodajZamowienie);
            this.Controls.Add(this.btnDodajProducenta);
            this.Controls.Add(this.btnDodajDostawca);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.numIlosc);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblIlosc);
            this.Controls.Add(this.cmbProducent);
            this.Controls.Add(this.lblProducent);
            this.Controls.Add(this.cmbMaszyna);
            this.Controls.Add(this.cmbDostawca);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.lblMaszyna);
            this.Controls.Add(this.lblDostawca);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.btnDodajMaszyna);
            this.Controls.Add(this.lvlZamowienieMaszyna);
            this.Controls.Add(this.dgvZamowienieMaszyna);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepZamowieniaMaszyny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zamówienia Maszyny";
            ((System.ComponentModel.ISupportInitialize)(this.numIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieMaszyna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZamowienie;
        private System.Windows.Forms.Button btnDodajProducenta;
        private System.Windows.Forms.Button btnDodajDostawca;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.NumericUpDown numIlosc;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblIlosc;
        private System.Windows.Forms.ComboBox cmbProducent;
        private System.Windows.Forms.Label lblProducent;
        private System.Windows.Forms.ComboBox cmbMaszyna;
        private System.Windows.Forms.ComboBox cmbDostawca;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.Label lblMaszyna;
        private System.Windows.Forms.Label lblDostawca;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.Button btnDodajMaszyna;
        private System.Windows.Forms.Label lvlZamowienieMaszyna;
        private System.Windows.Forms.DataGridView dgvZamowienieMaszyna;
    }
}