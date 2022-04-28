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
            this.btnSetupProduction = new System.Windows.Forms.Button();
            this.btnHRDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetupProduction
            // 
            this.btnSetupProduction.BackColor = System.Drawing.Color.Aqua;
            this.btnSetupProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetupProduction.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetupProduction.Location = new System.Drawing.Point(300, 308);
            this.btnSetupProduction.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetupProduction.Name = "btnSetupProduction";
            this.btnSetupProduction.Size = new System.Drawing.Size(467, 123);
            this.btnSetupProduction.TabIndex = 8;
            this.btnSetupProduction.Text = "Dział przygotowania produkcji";
            this.btnSetupProduction.UseVisualStyleBackColor = false;
            this.btnSetupProduction.Click += new System.EventHandler(this.btnSetupProduction_Click);
            // 
            // btnHRDepartment
            // 
            this.btnHRDepartment.BackColor = System.Drawing.Color.Red;
            this.btnHRDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHRDepartment.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHRDepartment.Location = new System.Drawing.Point(300, 124);
            this.btnHRDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnHRDepartment.Name = "btnHRDepartment";
            this.btnHRDepartment.Size = new System.Drawing.Size(467, 123);
            this.btnHRDepartment.TabIndex = 7;
            this.btnHRDepartment.Text = "Dział zasobów ludzkich HR";
            this.btnHRDepartment.UseVisualStyleBackColor = false;
            this.btnHRDepartment.Click += new System.EventHandler(this.btnHRDepartment_Click);
            // 
            // FormHRandSetupProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(1059, 604);
            this.Controls.Add(this.btnSetupProduction);
            this.Controls.Add(this.btnHRDepartment);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHRandSetupProduction";
            this.Text = "HR i Dzial przygotowania produkcji";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetupProduction;
        private System.Windows.Forms.Button btnHRDepartment;
    }
}