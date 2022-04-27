namespace KWZP2022
{
    partial class FormStatystykiProdukcja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatystykiProdukcja));
            this.btnGodziny = new System.Windows.Forms.Button();
            this.btnKoszt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGodziny
            // 
            this.btnGodziny.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGodziny.Font = new System.Drawing.Font("Arial", 20F);
            this.btnGodziny.Location = new System.Drawing.Point(281, 144);
            this.btnGodziny.Name = "btnGodziny";
            this.btnGodziny.Size = new System.Drawing.Size(288, 147);
            this.btnGodziny.TabIndex = 0;
            this.btnGodziny.Text = "Ewidencja czasu pracy";
            this.btnGodziny.UseVisualStyleBackColor = false;
            this.btnGodziny.Click += new System.EventHandler(this.btnGodziny_Click);
            // 
            // btnKoszt
            // 
            this.btnKoszt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnKoszt.Font = new System.Drawing.Font("Arial", 20F);
            this.btnKoszt.Location = new System.Drawing.Point(707, 144);
            this.btnKoszt.Name = "btnKoszt";
            this.btnKoszt.Size = new System.Drawing.Size(288, 147);
            this.btnKoszt.TabIndex = 1;
            this.btnKoszt.Text = "Koszt produkcji";
            this.btnKoszt.UseVisualStyleBackColor = false;
            this.btnKoszt.Click += new System.EventHandler(this.btnKoszt_Click);
            // 
            // FormStatystykiProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnKoszt);
            this.Controls.Add(this.btnGodziny);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FormStatystykiProdukcja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statystyki działu produkcji";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGodziny;
        private System.Windows.Forms.Button btnKoszt;
    }
}