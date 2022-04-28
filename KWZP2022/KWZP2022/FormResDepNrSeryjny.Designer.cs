namespace KWZP2022
{
    partial class FormResDepNrSeryjny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepNrSeryjny));
            this.dgvNumerSeryjny = new System.Windows.Forms.DataGridView();
            this.lblNazwaNumer = new System.Windows.Forms.Label();
            this.btnDodajNumer = new System.Windows.Forms.Button();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.mtxtNumerSeryjny = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerSeryjny)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNumerSeryjny
            // 
            this.dgvNumerSeryjny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumerSeryjny.Location = new System.Drawing.Point(37, 76);
            this.dgvNumerSeryjny.Name = "dgvNumerSeryjny";
            this.dgvNumerSeryjny.Size = new System.Drawing.Size(713, 176);
            this.dgvNumerSeryjny.TabIndex = 0;
            // 
            // lblNazwaNumer
            // 
            this.lblNazwaNumer.AutoSize = true;
            this.lblNazwaNumer.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwaNumer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaNumer.Location = new System.Drawing.Point(31, 284);
            this.lblNazwaNumer.Name = "lblNazwaNumer";
            this.lblNazwaNumer.Size = new System.Drawing.Size(190, 32);
            this.lblNazwaNumer.TabIndex = 1;
            this.lblNazwaNumer.Text = "Numer seryjny";
            // 
            // btnDodajNumer
            // 
            this.btnDodajNumer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajNumer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNumer.Location = new System.Drawing.Point(235, 349);
            this.btnDodajNumer.Name = "btnDodajNumer";
            this.btnDodajNumer.Size = new System.Drawing.Size(234, 43);
            this.btnDodajNumer.TabIndex = 3;
            this.btnDodajNumer.Text = "Dodaj numer seryjny";
            this.btnDodajNumer.UseVisualStyleBackColor = false;
            this.btnDodajNumer.Click += new System.EventHandler(this.btnDodajNumer_Click);
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 14F);
            this.lblNazwa.Location = new System.Drawing.Point(33, 51);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(429, 22);
            this.lblNazwa.TabIndex = 4;
            this.lblNazwa.Text = "Lista maszyn bez przypisanego numeru seryjnego";
            // 
            // mtxtNumerSeryjny
            // 
            this.mtxtNumerSeryjny.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtxtNumerSeryjny.Location = new System.Drawing.Point(235, 284);
            this.mtxtNumerSeryjny.Mask = "000-000";
            this.mtxtNumerSeryjny.Name = "mtxtNumerSeryjny";
            this.mtxtNumerSeryjny.Size = new System.Drawing.Size(126, 32);
            this.mtxtNumerSeryjny.TabIndex = 5;
            // 
            // FormResDepNrSeryjny
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 494);
            this.Controls.Add(this.mtxtNumerSeryjny);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.btnDodajNumer);
            this.Controls.Add(this.lblNazwaNumer);
            this.Controls.Add(this.dgvNumerSeryjny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepNrSeryjny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Numer seryjny maszyny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerSeryjny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNumerSeryjny;
        private System.Windows.Forms.Label lblNazwaNumer;
        private System.Windows.Forms.Button btnDodajNumer;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.MaskedTextBox mtxtNumerSeryjny;
    }
}