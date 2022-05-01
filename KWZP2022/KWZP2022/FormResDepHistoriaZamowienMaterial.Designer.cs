namespace KWZP2022
{
    partial class FormResDepHistoriaZamowienMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepHistoriaZamowienMaterial));
            this.dgvHistoria = new System.Windows.Forms.DataGridView();
            this.btnNoweZam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistoria
            // 
            this.dgvHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoria.Location = new System.Drawing.Point(66, 129);
            this.dgvHistoria.Name = "dgvHistoria";
            this.dgvHistoria.Size = new System.Drawing.Size(641, 320);
            this.dgvHistoria.TabIndex = 0;
            // 
            // btnNoweZam
            // 
            this.btnNoweZam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNoweZam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoweZam.Location = new System.Drawing.Point(66, 74);
            this.btnNoweZam.Name = "btnNoweZam";
            this.btnNoweZam.Size = new System.Drawing.Size(118, 49);
            this.btnNoweZam.TabIndex = 1;
            this.btnNoweZam.Text = "Dodaj nowe zamówienie";
            this.btnNoweZam.UseVisualStyleBackColor = false;
            this.btnNoweZam.Click += new System.EventHandler(this.btnNoweZam_Click);
            // 
            // FormResDepHistoriaZamowienMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnNoweZam);
            this.Controls.Add(this.dgvHistoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepHistoriaZamowienMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historia Zamówień";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistoria;
        private System.Windows.Forms.Button btnNoweZam;
    }
}