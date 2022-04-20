namespace KWZP2022
{
    partial class Form_maszyny
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
            this.dgvMaszyny = new System.Windows.Forms.DataGridView();
            this.btnSkladMaszyna = new System.Windows.Forms.Button();
            this.btnParametrMaszyna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaszyny
            // 
            this.dgvMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszyny.Location = new System.Drawing.Point(13, 13);
            this.dgvMaszyny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMaszyny.Name = "dgvMaszyny";
            this.dgvMaszyny.Size = new System.Drawing.Size(598, 287);
            this.dgvMaszyny.TabIndex = 0;
            // 
            // btnSkladMaszyna
            // 
            this.btnSkladMaszyna.Location = new System.Drawing.Point(18, 331);
            this.btnSkladMaszyna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSkladMaszyna.Name = "btnSkladMaszyna";
            this.btnSkladMaszyna.Size = new System.Drawing.Size(285, 65);
            this.btnSkladMaszyna.TabIndex = 1;
            this.btnSkladMaszyna.Text = "Sprawdź skład maszyny";
            this.btnSkladMaszyna.UseVisualStyleBackColor = true;
            // 
            // btnParametrMaszyna
            // 
            this.btnParametrMaszyna.Location = new System.Drawing.Point(326, 331);
            this.btnParametrMaszyna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnParametrMaszyna.Name = "btnParametrMaszyna";
            this.btnParametrMaszyna.Size = new System.Drawing.Size(285, 65);
            this.btnParametrMaszyna.TabIndex = 2;
            this.btnParametrMaszyna.Text = "Sprawdź parametry maszyny";
            this.btnParametrMaszyna.UseVisualStyleBackColor = true;
            // 
            // Form_maszyny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnParametrMaszyna);
            this.Controls.Add(this.btnSkladMaszyna);
            this.Controls.Add(this.dgvMaszyny);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_maszyny";
            this.Text = "Maszyny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaszyny;
        private System.Windows.Forms.Button btnSkladMaszyna;
        private System.Windows.Forms.Button btnParametrMaszyna;
    }
}