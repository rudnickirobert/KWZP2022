namespace KWZP2022
{
    partial class FormUsunStanowisko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsunStanowisko));
            this.dgvStanowisko = new System.Windows.Forms.DataGridView();
            this.btnUsun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanowisko)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanowisko
            // 
            this.dgvStanowisko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanowisko.Location = new System.Drawing.Point(98, 98);
            this.dgvStanowisko.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStanowisko.Name = "dgvStanowisko";
            this.dgvStanowisko.RowHeadersWidth = 51;
            this.dgvStanowisko.RowTemplate.Height = 24;
            this.dgvStanowisko.Size = new System.Drawing.Size(580, 341);
            this.dgvStanowisko.TabIndex = 0;
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(98, 54);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(175, 39);
            this.btnUsun.TabIndex = 1;
            this.btnUsun.Text = "Usuń stanowisko";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // FormUsunStanowisko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 501);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.dgvStanowisko);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUsunStanowisko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuń stanowisko";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanowisko)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStanowisko;
        private System.Windows.Forms.Button btnUsun;
    }
}