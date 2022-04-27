namespace KWZP2022
{
    partial class FormHR
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
            this.btnEtat = new System.Windows.Forms.Button();
            this.btnHRWorkes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEtat
            // 
            this.btnEtat.BackColor = System.Drawing.Color.Aqua;
            this.btnEtat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtat.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEtat.Location = new System.Drawing.Point(153, 263);
            this.btnEtat.Margin = new System.Windows.Forms.Padding(4);
            this.btnEtat.Name = "btnEtat";
            this.btnEtat.Size = new System.Drawing.Size(467, 123);
            this.btnEtat.TabIndex = 10;
            this.btnEtat.Text = "Etaty";
            this.btnEtat.UseVisualStyleBackColor = false;
            this.btnEtat.Click += new System.EventHandler(this.btnEtat_Click);
            // 
            // btnHRWorkes
            // 
            this.btnHRWorkes.BackColor = System.Drawing.Color.Red;
            this.btnHRWorkes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHRWorkes.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHRWorkes.Location = new System.Drawing.Point(153, 79);
            this.btnHRWorkes.Margin = new System.Windows.Forms.Padding(4);
            this.btnHRWorkes.Name = "btnHRWorkes";
            this.btnHRWorkes.Size = new System.Drawing.Size(467, 123);
            this.btnHRWorkes.TabIndex = 9;
            this.btnHRWorkes.Text = "Pracownicy i umowy";
            this.btnHRWorkes.UseVisualStyleBackColor = false;
            this.btnHRWorkes.Click += new System.EventHandler(this.btnHRWorkes_Click);
            // 
            // FormHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnEtat);
            this.Controls.Add(this.btnHRWorkes);
            this.Name = "FormHR";
            this.Text = "HR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEtat;
        private System.Windows.Forms.Button btnHRWorkes;
    }
}