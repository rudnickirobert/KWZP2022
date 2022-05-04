namespace KWZP2022
{
    partial class FormResDepDodajJednostka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepDodajJednostka));
            this.btnDodajJednostka = new System.Windows.Forms.Button();
            this.lblSkrot = new System.Windows.Forms.Label();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtNazwaJednostka = new System.Windows.Forms.TextBox();
            this.txtSkrot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDodajJednostka
            // 
            this.btnDodajJednostka.BackColor = System.Drawing.Color.LightGreen;
            this.btnDodajJednostka.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajJednostka.Location = new System.Drawing.Point(239, 192);
            this.btnDodajJednostka.Name = "btnDodajJednostka";
            this.btnDodajJednostka.Size = new System.Drawing.Size(239, 34);
            this.btnDodajJednostka.TabIndex = 27;
            this.btnDodajJednostka.Text = "Dodaj nową jednostkę";
            this.btnDodajJednostka.UseVisualStyleBackColor = false;
            this.btnDodajJednostka.Click += new System.EventHandler(this.btnDodajJednostka_Click);
            // 
            // lblSkrot
            // 
            this.lblSkrot.AutoSize = true;
            this.lblSkrot.BackColor = System.Drawing.Color.Transparent;
            this.lblSkrot.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSkrot.Location = new System.Drawing.Point(145, 133);
            this.lblSkrot.Name = "lblSkrot";
            this.lblSkrot.Size = new System.Drawing.Size(68, 27);
            this.lblSkrot.TabIndex = 25;
            this.lblSkrot.Text = "Skrót";
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(26, 76);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(187, 27);
            this.lblNazwa.TabIndex = 23;
            this.lblNazwa.Text = "Nazwa jednostki";
            // 
            // txtNazwaJednostka
            // 
            this.txtNazwaJednostka.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaJednostka.Location = new System.Drawing.Point(239, 73);
            this.txtNazwaJednostka.Name = "txtNazwaJednostka";
            this.txtNazwaJednostka.Size = new System.Drawing.Size(239, 35);
            this.txtNazwaJednostka.TabIndex = 22;
            // 
            // txtSkrot
            // 
            this.txtSkrot.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSkrot.Location = new System.Drawing.Point(239, 130);
            this.txtSkrot.Name = "txtSkrot";
            this.txtSkrot.Size = new System.Drawing.Size(239, 35);
            this.txtSkrot.TabIndex = 28;
            // 
            // FormResDepDodajJednostka
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 298);
            this.Controls.Add(this.txtSkrot);
            this.Controls.Add(this.btnDodajJednostka);
            this.Controls.Add(this.lblSkrot);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.txtNazwaJednostka);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepDodajJednostka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj jednostkę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajJednostka;
        private System.Windows.Forms.Label lblSkrot;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwaJednostka;
        private System.Windows.Forms.TextBox txtSkrot;
    }
}