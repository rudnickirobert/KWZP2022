namespace KWZP2022
{
    partial class FormResDepServicesWorkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepServicesWorkers));
            this.dgvObsluga = new System.Windows.Forms.DataGridView();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.cmbObsluga = new System.Windows.Forms.ComboBox();
            this.lblObsluga = new System.Windows.Forms.Label();
            this.btnDodajPracownika = new System.Windows.Forms.Button();
            this.btnUsunPracownika = new System.Windows.Forms.Button();
            this.btnEdytujPracownika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObsluga
            // 
            this.dgvObsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObsluga.Location = new System.Drawing.Point(22, 149);
            this.dgvObsluga.Name = "dgvObsluga";
            this.dgvObsluga.Size = new System.Drawing.Size(753, 293);
            this.dgvObsluga.TabIndex = 0;
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(137, 12);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(407, 32);
            this.cmbPracownik.TabIndex = 31;
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.BackColor = System.Drawing.Color.Transparent;
            this.lblPracownik.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPracownik.Location = new System.Drawing.Point(9, 20);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(107, 24);
            this.lblPracownik.TabIndex = 30;
            this.lblPracownik.Text = "Pracownik";
            // 
            // cmbObsluga
            // 
            this.cmbObsluga.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbObsluga.FormattingEnabled = true;
            this.cmbObsluga.Location = new System.Drawing.Point(137, 50);
            this.cmbObsluga.Name = "cmbObsluga";
            this.cmbObsluga.Size = new System.Drawing.Size(407, 32);
            this.cmbObsluga.TabIndex = 33;
            // 
            // lblObsluga
            // 
            this.lblObsluga.AutoSize = true;
            this.lblObsluga.BackColor = System.Drawing.Color.Transparent;
            this.lblObsluga.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObsluga.Location = new System.Drawing.Point(9, 53);
            this.lblObsluga.Name = "lblObsluga";
            this.lblObsluga.Size = new System.Drawing.Size(86, 24);
            this.lblObsluga.TabIndex = 32;
            this.lblObsluga.Text = "Obsługa";
            // 
            // btnDodajPracownika
            // 
            this.btnDodajPracownika.BackColor = System.Drawing.Color.Lime;
            this.btnDodajPracownika.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPracownika.Location = new System.Drawing.Point(22, 100);
            this.btnDodajPracownika.Name = "btnDodajPracownika";
            this.btnDodajPracownika.Size = new System.Drawing.Size(216, 43);
            this.btnDodajPracownika.TabIndex = 80;
            this.btnDodajPracownika.Text = "Dodaj Pracownika";
            this.btnDodajPracownika.UseVisualStyleBackColor = false;
            this.btnDodajPracownika.Click += new System.EventHandler(this.btnDodajPracownika_Click);
            // 
            // btnUsunPracownika
            // 
            this.btnUsunPracownika.BackColor = System.Drawing.Color.Red;
            this.btnUsunPracownika.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunPracownika.Location = new System.Drawing.Point(466, 100);
            this.btnUsunPracownika.Name = "btnUsunPracownika";
            this.btnUsunPracownika.Size = new System.Drawing.Size(216, 43);
            this.btnUsunPracownika.TabIndex = 81;
            this.btnUsunPracownika.Text = "Usuń Pracownika";
            this.btnUsunPracownika.UseVisualStyleBackColor = false;
            this.btnUsunPracownika.Click += new System.EventHandler(this.btnUsunPracownika_Click);
            // 
            // btnEdytujPracownika
            // 
            this.btnEdytujPracownika.BackColor = System.Drawing.Color.Yellow;
            this.btnEdytujPracownika.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytujPracownika.Location = new System.Drawing.Point(244, 100);
            this.btnEdytujPracownika.Name = "btnEdytujPracownika";
            this.btnEdytujPracownika.Size = new System.Drawing.Size(216, 43);
            this.btnEdytujPracownika.TabIndex = 82;
            this.btnEdytujPracownika.Text = "Edytuj Pracownika";
            this.btnEdytujPracownika.UseVisualStyleBackColor = false;
            this.btnEdytujPracownika.Click += new System.EventHandler(this.btnEdytujPracownika_Click);
            // 
            // FormResDepServicesWorkers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.btnEdytujPracownika);
            this.Controls.Add(this.btnUsunPracownika);
            this.Controls.Add(this.btnDodajPracownika);
            this.Controls.Add(this.cmbObsluga);
            this.Controls.Add(this.lblObsluga);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.dgvObsluga);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepServicesWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Przypisywanie pracowników";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObsluga;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.ComboBox cmbObsluga;
        private System.Windows.Forms.Label lblObsluga;
        private System.Windows.Forms.Button btnDodajPracownika;
        private System.Windows.Forms.Button btnUsunPracownika;
        private System.Windows.Forms.Button btnEdytujPracownika;
    }
}