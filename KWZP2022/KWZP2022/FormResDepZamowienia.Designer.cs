namespace KWZP2022
{
    partial class FormResDepZamowienia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepZamowienia));
            this.btnOrder_narzedzie = new System.Windows.Forms.Button();
            this.btnOrder_czesc = new System.Windows.Forms.Button();
            this.btnOrder_material = new System.Windows.Forms.Button();
            this.btnOrder_maszyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrder_narzedzie
            // 
            this.btnOrder_narzedzie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrder_narzedzie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder_narzedzie.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrder_narzedzie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder_narzedzie.Location = new System.Drawing.Point(356, 451);
            this.btnOrder_narzedzie.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder_narzedzie.Name = "btnOrder_narzedzie";
            this.btnOrder_narzedzie.Size = new System.Drawing.Size(316, 145);
            this.btnOrder_narzedzie.TabIndex = 8;
            this.btnOrder_narzedzie.Text = "Zamówienie narzędzia";
            this.btnOrder_narzedzie.UseVisualStyleBackColor = false;
            this.btnOrder_narzedzie.Click += new System.EventHandler(this.btnOrder_narzedzie_Click);
            // 
            // btnOrder_czesc
            // 
            this.btnOrder_czesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOrder_czesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder_czesc.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrder_czesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder_czesc.Location = new System.Drawing.Point(713, 276);
            this.btnOrder_czesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder_czesc.Name = "btnOrder_czesc";
            this.btnOrder_czesc.Size = new System.Drawing.Size(316, 145);
            this.btnOrder_czesc.TabIndex = 7;
            this.btnOrder_czesc.Text = "Zamówienie części";
            this.btnOrder_czesc.UseVisualStyleBackColor = false;
            this.btnOrder_czesc.Click += new System.EventHandler(this.btnOrder_czesc_Click);
            // 
            // btnOrder_material
            // 
            this.btnOrder_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOrder_material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder_material.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrder_material.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder_material.Location = new System.Drawing.Point(356, 276);
            this.btnOrder_material.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder_material.Name = "btnOrder_material";
            this.btnOrder_material.Size = new System.Drawing.Size(316, 145);
            this.btnOrder_material.TabIndex = 6;
            this.btnOrder_material.Text = "Zamówienie materiału";
            this.btnOrder_material.UseVisualStyleBackColor = false;
            this.btnOrder_material.Click += new System.EventHandler(this.btnOrder_material_Click);
            // 
            // btnOrder_maszyna
            // 
            this.btnOrder_maszyna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOrder_maszyna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder_maszyna.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrder_maszyna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder_maszyna.Location = new System.Drawing.Point(713, 451);
            this.btnOrder_maszyna.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder_maszyna.Name = "btnOrder_maszyna";
            this.btnOrder_maszyna.Size = new System.Drawing.Size(316, 145);
            this.btnOrder_maszyna.TabIndex = 9;
            this.btnOrder_maszyna.Text = "Zamówienie maszyny";
            this.btnOrder_maszyna.UseVisualStyleBackColor = false;
            this.btnOrder_maszyna.Click += new System.EventHandler(this.btnOrder_maszyna_Click);
            // 
            // FormResDepZamowienia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.btnOrder_maszyna);
            this.Controls.Add(this.btnOrder_narzedzie);
            this.Controls.Add(this.btnOrder_czesc);
            this.Controls.Add(this.btnOrder_material);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepZamowienia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zamówienia zasobów";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrder_narzedzie;
        private System.Windows.Forms.Button btnOrder_czesc;
        private System.Windows.Forms.Button btnOrder_material;
        private System.Windows.Forms.Button btnOrder_maszyna;
    }
}