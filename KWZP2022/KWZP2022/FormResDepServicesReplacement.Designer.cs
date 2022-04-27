namespace KWZP2022
{
    partial class FormResDepServicesReplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepServicesReplacement));
            this.btnEdytujWymiana = new System.Windows.Forms.Button();
            this.btnUsunWymiana = new System.Windows.Forms.Button();
            this.btnDodajWymiane = new System.Windows.Forms.Button();
            this.cmbObsluga = new System.Windows.Forms.ComboBox();
            this.lblObsluga = new System.Windows.Forms.Label();
            this.cmbCzesc = new System.Windows.Forms.ComboBox();
            this.lblCzesc = new System.Windows.Forms.Label();
            this.dgvWymianaCzesc = new System.Windows.Forms.DataGridView();
            this.cmbMaszyna = new System.Windows.Forms.ComboBox();
            this.lblMaszyna = new System.Windows.Forms.Label();
            this.btnZatwierdzObsluga = new System.Windows.Forms.Button();
            this.btnZatwierdzMaszyna = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWymianaCzesc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdytujWymiana
            // 
            this.btnEdytujWymiana.BackColor = System.Drawing.Color.Yellow;
            this.btnEdytujWymiana.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytujWymiana.Location = new System.Drawing.Point(563, 120);
            this.btnEdytujWymiana.Name = "btnEdytujWymiana";
            this.btnEdytujWymiana.Size = new System.Drawing.Size(216, 43);
            this.btnEdytujWymiana.TabIndex = 90;
            this.btnEdytujWymiana.Text = "Edytuj Wymianę";
            this.btnEdytujWymiana.UseVisualStyleBackColor = false;
            this.btnEdytujWymiana.Click += new System.EventHandler(this.btnEdytujWymiana_Click);
            // 
            // btnUsunWymiana
            // 
            this.btnUsunWymiana.BackColor = System.Drawing.Color.Red;
            this.btnUsunWymiana.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunWymiana.Location = new System.Drawing.Point(563, 169);
            this.btnUsunWymiana.Name = "btnUsunWymiana";
            this.btnUsunWymiana.Size = new System.Drawing.Size(216, 43);
            this.btnUsunWymiana.TabIndex = 89;
            this.btnUsunWymiana.Text = "Usuń Wymianę";
            this.btnUsunWymiana.UseVisualStyleBackColor = false;
            this.btnUsunWymiana.Click += new System.EventHandler(this.btnUsunWymiana_Click);
            // 
            // btnDodajWymiane
            // 
            this.btnDodajWymiane.BackColor = System.Drawing.Color.Lime;
            this.btnDodajWymiane.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajWymiane.Location = new System.Drawing.Point(563, 71);
            this.btnDodajWymiane.Name = "btnDodajWymiane";
            this.btnDodajWymiane.Size = new System.Drawing.Size(216, 43);
            this.btnDodajWymiane.TabIndex = 88;
            this.btnDodajWymiane.Text = "Dodaj Wymianę";
            this.btnDodajWymiane.UseVisualStyleBackColor = false;
            this.btnDodajWymiane.Visible = false;
            this.btnDodajWymiane.Click += new System.EventHandler(this.btnDodajWymiane_Click);
            // 
            // cmbObsluga
            // 
            this.cmbObsluga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbObsluga.FormattingEnabled = true;
            this.cmbObsluga.Location = new System.Drawing.Point(104, 77);
            this.cmbObsluga.Name = "cmbObsluga";
            this.cmbObsluga.Size = new System.Drawing.Size(311, 26);
            this.cmbObsluga.TabIndex = 87;
            // 
            // lblObsluga
            // 
            this.lblObsluga.AutoSize = true;
            this.lblObsluga.BackColor = System.Drawing.Color.Transparent;
            this.lblObsluga.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObsluga.Location = new System.Drawing.Point(12, 80);
            this.lblObsluga.Name = "lblObsluga";
            this.lblObsluga.Size = new System.Drawing.Size(86, 24);
            this.lblObsluga.TabIndex = 86;
            this.lblObsluga.Text = "Obsługa";
            // 
            // cmbCzesc
            // 
            this.cmbCzesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbCzesc.FormattingEnabled = true;
            this.cmbCzesc.Location = new System.Drawing.Point(104, 153);
            this.cmbCzesc.Name = "cmbCzesc";
            this.cmbCzesc.Size = new System.Drawing.Size(311, 26);
            this.cmbCzesc.TabIndex = 85;
            this.cmbCzesc.Visible = false;
            // 
            // lblCzesc
            // 
            this.lblCzesc.AutoSize = true;
            this.lblCzesc.BackColor = System.Drawing.Color.Transparent;
            this.lblCzesc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzesc.Location = new System.Drawing.Point(30, 156);
            this.lblCzesc.Name = "lblCzesc";
            this.lblCzesc.Size = new System.Drawing.Size(68, 24);
            this.lblCzesc.TabIndex = 84;
            this.lblCzesc.Text = "Część";
            this.lblCzesc.Visible = false;
            // 
            // dgvWymianaCzesc
            // 
            this.dgvWymianaCzesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWymianaCzesc.Location = new System.Drawing.Point(26, 218);
            this.dgvWymianaCzesc.Name = "dgvWymianaCzesc";
            this.dgvWymianaCzesc.Size = new System.Drawing.Size(753, 210);
            this.dgvWymianaCzesc.TabIndex = 83;
            this.dgvWymianaCzesc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWymianaCzesc_CellContentClick);
            // 
            // cmbMaszyna
            // 
            this.cmbMaszyna.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMaszyna.FormattingEnabled = true;
            this.cmbMaszyna.Location = new System.Drawing.Point(104, 115);
            this.cmbMaszyna.Name = "cmbMaszyna";
            this.cmbMaszyna.Size = new System.Drawing.Size(311, 26);
            this.cmbMaszyna.TabIndex = 92;
            this.cmbMaszyna.Visible = false;
            // 
            // lblMaszyna
            // 
            this.lblMaszyna.AutoSize = true;
            this.lblMaszyna.BackColor = System.Drawing.Color.Transparent;
            this.lblMaszyna.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaszyna.Location = new System.Drawing.Point(5, 118);
            this.lblMaszyna.Name = "lblMaszyna";
            this.lblMaszyna.Size = new System.Drawing.Size(93, 24);
            this.lblMaszyna.TabIndex = 91;
            this.lblMaszyna.Text = "Maszyna";
            this.lblMaszyna.Visible = false;
            // 
            // btnZatwierdzObsluga
            // 
            this.btnZatwierdzObsluga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZatwierdzObsluga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatwierdzObsluga.Location = new System.Drawing.Point(421, 74);
            this.btnZatwierdzObsluga.Name = "btnZatwierdzObsluga";
            this.btnZatwierdzObsluga.Size = new System.Drawing.Size(123, 33);
            this.btnZatwierdzObsluga.TabIndex = 93;
            this.btnZatwierdzObsluga.Text = "Zatwierdź Wybór";
            this.btnZatwierdzObsluga.UseVisualStyleBackColor = false;
            this.btnZatwierdzObsluga.Click += new System.EventHandler(this.btnZatwierdzObsluga_Click);
            // 
            // btnZatwierdzMaszyna
            // 
            this.btnZatwierdzMaszyna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZatwierdzMaszyna.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatwierdzMaszyna.Location = new System.Drawing.Point(421, 112);
            this.btnZatwierdzMaszyna.Name = "btnZatwierdzMaszyna";
            this.btnZatwierdzMaszyna.Size = new System.Drawing.Size(123, 33);
            this.btnZatwierdzMaszyna.TabIndex = 94;
            this.btnZatwierdzMaszyna.Text = "Zatwierdź Wybór";
            this.btnZatwierdzMaszyna.UseVisualStyleBackColor = false;
            this.btnZatwierdzMaszyna.Visible = false;
            this.btnZatwierdzMaszyna.Click += new System.EventHandler(this.btnZatwierdzMaszyna_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.Cyan;
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdswiez.Location = new System.Drawing.Point(647, 447);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(132, 39);
            this.btnOdswiez.TabIndex = 95;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // FormResDepServicesReplacement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnZatwierdzMaszyna);
            this.Controls.Add(this.btnZatwierdzObsluga);
            this.Controls.Add(this.cmbMaszyna);
            this.Controls.Add(this.lblMaszyna);
            this.Controls.Add(this.btnEdytujWymiana);
            this.Controls.Add(this.btnUsunWymiana);
            this.Controls.Add(this.btnDodajWymiane);
            this.Controls.Add(this.cmbObsluga);
            this.Controls.Add(this.lblObsluga);
            this.Controls.Add(this.cmbCzesc);
            this.Controls.Add(this.lblCzesc);
            this.Controls.Add(this.dgvWymianaCzesc);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepServicesReplacement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wymiana części";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWymianaCzesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdytujWymiana;
        private System.Windows.Forms.Button btnUsunWymiana;
        private System.Windows.Forms.Button btnDodajWymiane;
        private System.Windows.Forms.ComboBox cmbObsluga;
        private System.Windows.Forms.Label lblObsluga;
        private System.Windows.Forms.ComboBox cmbCzesc;
        private System.Windows.Forms.Label lblCzesc;
        private System.Windows.Forms.DataGridView dgvWymianaCzesc;
        private System.Windows.Forms.ComboBox cmbMaszyna;
        private System.Windows.Forms.Label lblMaszyna;
        private System.Windows.Forms.Button btnZatwierdzObsluga;
        private System.Windows.Forms.Button btnZatwierdzMaszyna;
        private System.Windows.Forms.Button btnOdswiez;
    }
}