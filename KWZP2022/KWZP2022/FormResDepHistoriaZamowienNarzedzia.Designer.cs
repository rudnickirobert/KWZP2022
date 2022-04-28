namespace KWZP2022
{
    partial class FormResDepHistoriaZamowienNarzedzia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepHistoriaZamowienNarzedzia));
            this.btnNoweZam = new System.Windows.Forms.Button();
            this.dgvHistoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNoweZam
            // 
            this.btnNoweZam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNoweZam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoweZam.Location = new System.Drawing.Point(80, 64);
            this.btnNoweZam.Name = "btnNoweZam";
            this.btnNoweZam.Size = new System.Drawing.Size(118, 49);
            this.btnNoweZam.TabIndex = 3;
            this.btnNoweZam.Text = "Dodaj nowe zamówienie";
            this.btnNoweZam.UseVisualStyleBackColor = false;
            this.btnNoweZam.Click += new System.EventHandler(this.btnNoweZam_Click);
            // 
            // dgvHistoria
            // 
            this.dgvHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoria.Location = new System.Drawing.Point(80, 119);
            this.dgvHistoria.Name = "dgvHistoria";
            this.dgvHistoria.Size = new System.Drawing.Size(641, 320);
            this.dgvHistoria.TabIndex = 2;
            // 
            // FormResDepHistoriaZamowienNarzedzia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnNoweZam);
            this.Controls.Add(this.dgvHistoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepHistoriaZamowienNarzedzia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historia Zamówień";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoweZam;
        private System.Windows.Forms.DataGridView dgvHistoria;
    }
}