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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRodzajMaterial
            // 
            this.lblRodzajMaterial.AutoSize = true;
            this.lblRodzajMaterial.Location = new System.Drawing.Point(40, 119);
            this.lblRodzajMaterial.Name = "lblRodzajMaterial";
            this.lblRodzajMaterial.Size = new System.Drawing.Size(177, 31);
            this.lblRodzajMaterial.TabIndex = 0;
            this.lblRodzajMaterial.Text = "Rodzaj materiału";
            // 
            // lblNazwaMaterial
            // 
            this.lblNazwaMaterial.AutoSize = true;
            this.lblNazwaMaterial.Location = new System.Drawing.Point(40, 43);
            this.lblNazwaMaterial.Name = "lblNazwaMaterial";
            this.lblNazwaMaterial.Size = new System.Drawing.Size(176, 31);
            this.lblNazwaMaterial.TabIndex = 1;
            this.lblNazwaMaterial.Text = "Nazwa materiału";
            // 
            // txtNazwaMaterial
            // 
            this.txtNazwaMaterial.Location = new System.Drawing.Point(263, 43);
            this.txtNazwaMaterial.Name = "txtNazwaMaterial";
            this.txtNazwaMaterial.Size = new System.Drawing.Size(270, 38);
            this.txtNazwaMaterial.TabIndex = 2;
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterial.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterial.Location = new System.Drawing.Point(420, 216);
            this.dgvMaterial.Name = "dgvMaterial";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterial.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaterial.RowTemplate.Height = 24;
            this.dgvMaterial.Size = new System.Drawing.Size(527, 256);
            this.dgvMaterial.TabIndex = 5;
            this.dgvMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellClick);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(702, 156);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(245, 42);
            this.btnOdswiez.TabIndex = 6;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(46, 275);
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
            this.btnUsun.Location = new System.Drawing.Point(46, 336);
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
            this.btnDodaj.Location = new System.Drawing.Point(46, 216);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbRodzajMaterial
            // 
            this.cmbRodzajMaterial.FormattingEnabled = true;
            this.cmbRodzajMaterial.Location = new System.Drawing.Point(263, 119);
            this.cmbRodzajMaterial.Name = "cmbRodzajMaterial";
            this.cmbRodzajMaterial.Size = new System.Drawing.Size(270, 39);
            this.cmbRodzajMaterial.TabIndex = 10;
            // 
            // FormResDepMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(959, 541);
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
            this.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormResDepMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormResDepMaterial";
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
    }
}