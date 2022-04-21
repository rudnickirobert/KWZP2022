
namespace KWZP2022
{
    partial class FormHRandSetupProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRandSetupProduction));
            this.btnHRDepartment = new System.Windows.Forms.Button();
            this.btnSetupProduction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHRDepartment
            // 
            this.btnHRDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHRDepartment.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHRDepartment.Location = new System.Drawing.Point(430, 253);
            this.btnHRDepartment.Name = "btnHRDepartment";
            this.btnHRDepartment.Size = new System.Drawing.Size(350, 100);
            this.btnHRDepartment.TabIndex = 3;
            this.btnHRDepartment.Text = "Dział zasobów ludzkich HR";
            this.btnHRDepartment.UseVisualStyleBackColor = true;
            this.btnHRDepartment.Click += new System.EventHandler(this.btnHRDepartment_Click);
            // 
            // btnSetupProduction
            // 
            this.btnSetupProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetupProduction.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetupProduction.Location = new System.Drawing.Point(430, 402);
            this.btnSetupProduction.Name = "btnSetupProduction";
            this.btnSetupProduction.Size = new System.Drawing.Size(350, 100);
            this.btnSetupProduction.TabIndex = 4;
            this.btnSetupProduction.Text = "Dział przygotowania produkcji";
            this.btnSetupProduction.UseVisualStyleBackColor = true;
            this.btnSetupProduction.Click += new System.EventHandler(this.btnSetupProduction_Click);
            // 
            // FormHRandSetupProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnSetupProduction);
            this.Controls.Add(this.btnHRDepartment);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHRandSetupProduction";
            this.Text = "Dział Zasobów ludzkich i przygotowania produkcji";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHRDepartment;
        private System.Windows.Forms.Button btnSetupProduction;
    }
}