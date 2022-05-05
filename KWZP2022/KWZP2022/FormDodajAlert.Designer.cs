
namespace KWZP2022
{
    partial class FormDodajAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajAlert));
            this.btnDodajAlert = new System.Windows.Forms.Button();
            this.cmbDzial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTresc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDodajAlert
            // 
            this.btnDodajAlert.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajAlert.Font = new System.Drawing.Font("Arial", 18F);
            this.btnDodajAlert.Location = new System.Drawing.Point(245, 254);
            this.btnDodajAlert.Name = "btnDodajAlert";
            this.btnDodajAlert.Size = new System.Drawing.Size(177, 63);
            this.btnDodajAlert.TabIndex = 0;
            this.btnDodajAlert.Text = "Dodaj alert";
            this.btnDodajAlert.UseVisualStyleBackColor = false;
            this.btnDodajAlert.Click += new System.EventHandler(this.btnDodajAlert_Click);
            // 
            // cmbDzial
            // 
            this.cmbDzial.Font = new System.Drawing.Font("Arial", 14F);
            this.cmbDzial.FormattingEnabled = true;
            this.cmbDzial.Location = new System.Drawing.Point(133, 42);
            this.cmbDzial.Name = "cmbDzial";
            this.cmbDzial.Size = new System.Drawing.Size(375, 30);
            this.cmbDzial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dział";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F);
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Treść";
            // 
            // txtTresc
            // 
            this.txtTresc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTresc.Location = new System.Drawing.Point(133, 102);
            this.txtTresc.Name = "txtTresc";
            this.txtTresc.Size = new System.Drawing.Size(375, 146);
            this.txtTresc.TabIndex = 4;
            this.txtTresc.Text = "";
            // 
            // FormDodajAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 355);
            this.Controls.Add(this.txtTresc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDzial);
            this.Controls.Add(this.btnDodajAlert);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDodajAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajAlert;
        private System.Windows.Forms.ComboBox cmbDzial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtTresc;
    }
}