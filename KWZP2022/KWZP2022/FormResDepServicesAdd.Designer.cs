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
            this.btnPrzypiszPracownika = new System.Windows.Forms.Button();
            this.cmbStanowisko = new System.Windows.Forms.ComboBox();
            this.cmbObsluga = new System.Windows.Forms.ComboBox();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.lblObsluga = new System.Windows.Forms.Label();
            this.lblNowaObsluga = new System.Windows.Forms.Label();
            this.dgvTrwajaceObslugi = new System.Windows.Forms.DataGridView();
            this.dtpDataOd = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btnDodajWymiana = new System.Windows.Forms.Button();
            this.txtUwagi = new System.Windows.Forms.RichTextBox();
            this.lblUwagi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrwajaceObslugi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrzypiszPracownika
            // 
            this.btnPrzypiszPracownika.BackColor = System.Drawing.Color.Yellow;
            this.btnPrzypiszPracownika.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzypiszPracownika.Location = new System.Drawing.Point(572, 143);
            this.btnPrzypiszPracownika.Name = "btnPrzypiszPracownika";
            this.btnPrzypiszPracownika.Size = new System.Drawing.Size(216, 71);
            this.btnPrzypiszPracownika.TabIndex = 76;
            this.btnPrzypiszPracownika.Text = "Przypisz Pracowników";
            this.btnPrzypiszPracownika.UseVisualStyleBackColor = false;
            this.btnPrzypiszPracownika.Click += new System.EventHandler(this.btnPrzypiszPracownika_Click);
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
            this.cmbObsluga.SelectedValueChanged += new System.EventHandler(this.cmbObsluga_SelectedValueChanged);
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
            this.lblNowaObsluga.Size = new System.Drawing.Size(270, 32);
            this.lblNowaObsluga.TabIndex = 60;
            this.lblNowaObsluga.Text = "Dodawanie Obsługi";
            // 
            // dgvTrwajaceObslugi
            // 
            this.dgvTrwajaceObslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrwajaceObslugi.Location = new System.Drawing.Point(275, 231);
            this.dgvTrwajaceObslugi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTrwajaceObslugi.Name = "dgvTrwajaceObslugi";
            this.dgvTrwajaceObslugi.RowHeadersWidth = 51;
            this.dgvTrwajaceObslugi.Size = new System.Drawing.Size(511, 209);
            this.dgvTrwajaceObslugi.TabIndex = 59;
            // 
            // dtpDataOd
            // 
            this.dtpDataOd.CustomFormat = "yyyy-MM-dd";
            this.dtpDataOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataOd.Location = new System.Drawing.Point(198, 143);
            this.dtpDataOd.Name = "dtpDataOd";
            this.dtpDataOd.Size = new System.Drawing.Size(126, 22);
            this.dtpDataOd.TabIndex = 77;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.Location = new System.Drawing.Point(20, 143);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(172, 24);
            this.lblData.TabIndex = 78;
            this.lblData.Text = "Data rozpoczęcia";
            // 
            // btnDodajWymiana
            // 
            this.btnDodajWymiana.BackColor = System.Drawing.Color.Lime;
            this.btnDodajWymiana.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajWymiana.Location = new System.Drawing.Point(570, 83);
            this.btnDodajWymiana.Name = "btnDodajWymiana";
            this.btnDodajWymiana.Size = new System.Drawing.Size(216, 43);
            this.btnDodajWymiana.TabIndex = 79;
            this.btnDodajWymiana.Text = "Dodaj Wymianę";
            this.btnDodajWymiana.UseVisualStyleBackColor = false;
            this.btnDodajWymiana.Click += new System.EventHandler(this.btnDodajWymiana_Click);
            // 
            // txtUwagi
            // 
            this.txtUwagi.Location = new System.Drawing.Point(24, 209);
            this.txtUwagi.Name = "txtUwagi";
            this.txtUwagi.Size = new System.Drawing.Size(244, 231);
            this.txtUwagi.TabIndex = 80;
            this.txtUwagi.Text = "";
            // 
            // lblUwagi
            // 
            this.lblUwagi.AutoSize = true;
            this.lblUwagi.BackColor = System.Drawing.Color.Transparent;
            this.lblUwagi.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUwagi.Location = new System.Drawing.Point(20, 182);
            this.lblUwagi.Name = "lblUwagi";
            this.lblUwagi.Size = new System.Drawing.Size(73, 24);
            this.lblUwagi.TabIndex = 81;
            this.lblUwagi.Text = "Uwagi:";
            // 
            // FormResDepServicesAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.lblUwagi);
            this.Controls.Add(this.txtUwagi);
            this.Controls.Add(this.btnDodajWymiana);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpDataOd);
            this.Controls.Add(this.btnPrzypiszPracownika);
            this.Controls.Add(this.cmbStanowisko);
            this.Controls.Add(this.cmbObsluga);
            this.Controls.Add(this.lblStanowisko);
            this.Controls.Add(this.lblObsluga);
            this.Controls.Add(this.lblNowaObsluga);
            this.Controls.Add(this.dgvTrwajaceObslugi);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepServicesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie nowej obsługi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrwajaceObslugi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrzypiszPracownika;
        private System.Windows.Forms.ComboBox cmbStanowisko;
        private System.Windows.Forms.ComboBox cmbObsluga;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.Label lblObsluga;
        private System.Windows.Forms.Label lblNowaObsluga;
        private System.Windows.Forms.DataGridView dgvTrwajaceObslugi;
        private System.Windows.Forms.DateTimePicker dtpDataOd;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnDodajWymiana;
        private System.Windows.Forms.RichTextBox txtUwagi;
        private System.Windows.Forms.Label lblUwagi;
    }
}