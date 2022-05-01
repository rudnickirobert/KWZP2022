namespace KWZP2022
{
    partial class FormResDepServicesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepServicesAdd));
            this.cmbStanowisko = new System.Windows.Forms.ComboBox();
            this.cmbObsluga = new System.Windows.Forms.ComboBox();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.lblObsluga = new System.Windows.Forms.Label();
            this.lblNowaObsluga = new System.Windows.Forms.Label();
            this.btnDodajObsluge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStanowisko
            // 
            this.cmbStanowisko.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStanowisko.FormattingEnabled = true;
            this.cmbStanowisko.Location = new System.Drawing.Point(144, 99);
            this.cmbStanowisko.Name = "cmbStanowisko";
            this.cmbStanowisko.Size = new System.Drawing.Size(364, 32);
            this.cmbStanowisko.TabIndex = 67;
            // 
            // cmbObsluga
            // 
            this.cmbObsluga.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbObsluga.FormattingEnabled = true;
            this.cmbObsluga.Location = new System.Drawing.Point(144, 61);
            this.cmbObsluga.Name = "cmbObsluga";
            this.cmbObsluga.Size = new System.Drawing.Size(364, 32);
            this.cmbObsluga.TabIndex = 66;
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.BackColor = System.Drawing.Color.Transparent;
            this.lblStanowisko.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStanowisko.Location = new System.Drawing.Point(20, 102);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(118, 24);
            this.lblStanowisko.TabIndex = 64;
            this.lblStanowisko.Text = "Stanowisko";
            // 
            // lblObsluga
            // 
            this.lblObsluga.AutoSize = true;
            this.lblObsluga.BackColor = System.Drawing.Color.Transparent;
            this.lblObsluga.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObsluga.Location = new System.Drawing.Point(20, 64);
            this.lblObsluga.Name = "lblObsluga";
            this.lblObsluga.Size = new System.Drawing.Size(86, 24);
            this.lblObsluga.TabIndex = 63;
            this.lblObsluga.Text = "Obsługa";
            // 
            // lblNowaObsluga
            // 
            this.lblNowaObsluga.AutoSize = true;
            this.lblNowaObsluga.BackColor = System.Drawing.Color.Transparent;
            this.lblNowaObsluga.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNowaObsluga.Location = new System.Drawing.Point(14, 8);
            this.lblNowaObsluga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNowaObsluga.Name = "lblNowaObsluga";
            this.lblNowaObsluga.Size = new System.Drawing.Size(271, 32);
            this.lblNowaObsluga.TabIndex = 60;
            this.lblNowaObsluga.Text = "Dodawanie Obsługi";
            // 
            // btnDodajObsluge
            // 
            this.btnDodajObsluge.BackColor = System.Drawing.Color.Lime;
            this.btnDodajObsluge.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajObsluge.Location = new System.Drawing.Point(24, 146);
            this.btnDodajObsluge.Name = "btnDodajObsluge";
            this.btnDodajObsluge.Size = new System.Drawing.Size(216, 43);
            this.btnDodajObsluge.TabIndex = 80;
            this.btnDodajObsluge.Text = "Dodaj Obsługę";
            this.btnDodajObsluge.UseVisualStyleBackColor = false;
            this.btnDodajObsluge.Click += new System.EventHandler(this.btnDodajObsluge_Click);
            // 
            // FormResDepServicesAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.Controls.Add(this.btnDodajObsluge);
            this.Controls.Add(this.cmbStanowisko);
            this.Controls.Add(this.cmbObsluga);
            this.Controls.Add(this.lblStanowisko);
            this.Controls.Add(this.lblObsluga);
            this.Controls.Add(this.lblNowaObsluga);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepServicesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie nowej obsługi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStanowisko;
        private System.Windows.Forms.ComboBox cmbObsluga;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.Label lblObsluga;
        private System.Windows.Forms.Label lblNowaObsluga;
        private System.Windows.Forms.Button btnDodajObsluge;
    }
}