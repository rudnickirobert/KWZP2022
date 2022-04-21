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
            this.btnOrder_narzedzie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder_narzedzie.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnOrder_narzedzie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder_narzedzie.Location = new System.Drawing.Point(393, 426);
            this.btnOrder_narzedzie.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder_narzedzie.Name = "btnOrder_narzedzie";
            this.btnOrder_narzedzie.Size = new System.Drawing.Size(258, 92);
            this.btnOrder_narzedzie.TabIndex = 8;
            this.btnOrder_narzedzie.Text = "Zamówienie narzędzia";
            this.btnOrder_narzedzie.UseVisualStyleBackColor = true;
            // 
            // btnOrder_czesc
            // 
            this.btnOrder_czesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder_czesc.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnOrder_czesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder_czesc.Location = new System.Drawing.Point(707, 309);
            this.btnOrder_czesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder_czesc.Name = "btnOrder_czesc";
            this.btnOrder_czesc.Size = new System.Drawing.Size(258, 92);
            this.btnOrder_czesc.TabIndex = 7;
            this.btnOrder_czesc.Text = "Zamówienie części";
            this.btnOrder_czesc.UseVisualStyleBackColor = true;
            // 
            // btnOrder_material
            // 
            this.btnOrder_material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder_material.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnOrder_material.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder_material.Location = new System.Drawing.Point(393, 309);
            this.btnOrder_material.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder_material.Name = "btnOrder_material";
            this.btnOrder_material.Size = new System.Drawing.Size(258, 92);
            this.btnOrder_material.TabIndex = 6;
            this.btnOrder_material.Text = "Zamówienie materiału";
            this.btnOrder_material.UseVisualStyleBackColor = true;
            // 
            // btnOrder_maszyna
            // 
            this.btnOrder_maszyna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder_maszyna.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnOrder_maszyna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder_maszyna.Location = new System.Drawing.Point(707, 426);
            this.btnOrder_maszyna.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder_maszyna.Name = "btnOrder_maszyna";
            this.btnOrder_maszyna.Size = new System.Drawing.Size(258, 92);
            this.btnOrder_maszyna.TabIndex = 9;
            this.btnOrder_maszyna.Text = "Zamówienie maszyny";
            this.btnOrder_maszyna.UseVisualStyleBackColor = true;
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
            this.Name = "FormResDepZamowienia";
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