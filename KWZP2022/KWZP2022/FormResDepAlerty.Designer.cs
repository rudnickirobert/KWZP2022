
namespace KWZP2022
{
    partial class FormResDepAlerty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepAlerty));
            this.dgvAlerty = new System.Windows.Forms.DataGridView();
            this.btnDodajAlert = new System.Windows.Forms.Button();
            this.btnOdczytano = new System.Windows.Forms.Button();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.btnOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlerty
            // 
            this.dgvAlerty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlerty.Location = new System.Drawing.Point(12, 100);
            this.dgvAlerty.Name = "dgvAlerty";
            this.dgvAlerty.Size = new System.Drawing.Size(697, 251);
            this.dgvAlerty.TabIndex = 0;
            // 
            // btnDodajAlert
            // 
            this.btnDodajAlert.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDodajAlert.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnDodajAlert.Location = new System.Drawing.Point(12, 12);
            this.btnDodajAlert.Name = "btnDodajAlert";
            this.btnDodajAlert.Size = new System.Drawing.Size(201, 40);
            this.btnDodajAlert.TabIndex = 1;
            this.btnDodajAlert.Text = "Dodaj alert";
            this.btnDodajAlert.UseVisualStyleBackColor = false;
            this.btnDodajAlert.Click += new System.EventHandler(this.btnDodajAlert_Click);
            // 
            // btnOdczytano
            // 
            this.btnOdczytano.BackColor = System.Drawing.Color.Gold;
            this.btnOdczytano.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdczytano.Location = new System.Drawing.Point(219, 12);
            this.btnOdczytano.Name = "btnOdczytano";
            this.btnOdczytano.Size = new System.Drawing.Size(204, 40);
            this.btnOdczytano.TabIndex = 2;
            this.btnOdczytano.Text = "Odczytano";
            this.btnOdczytano.UseVisualStyleBackColor = false;
            this.btnOdczytano.Click += new System.EventHandler(this.btnOdczytano_Click);
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 16F);
            this.lblNazwa.Location = new System.Drawing.Point(12, 72);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(202, 25);
            this.lblNazwa.TabIndex = 3;
            this.lblNazwa.Text = "Nieodczytane alerty";
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnOdswiez.Location = new System.Drawing.Point(429, 13);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(134, 39);
            this.btnOdswiez.TabIndex = 4;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // FormResDepAlerty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 385);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.btnOdczytano);
            this.Controls.Add(this.btnDodajAlert);
            this.Controls.Add(this.dgvAlerty);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepAlerty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alerty";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlerty;
        private System.Windows.Forms.Button btnDodajAlert;
        private System.Windows.Forms.Button btnOdczytano;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Button btnOdswiez;
    }
}