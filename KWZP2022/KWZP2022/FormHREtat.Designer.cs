namespace KWZP2022
{
    partial class FormHREtat
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
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnPositions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.Aqua;
            this.btnDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartments.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDepartments.Location = new System.Drawing.Point(164, 276);
            this.btnDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(467, 123);
            this.btnDepartments.TabIndex = 12;
            this.btnDepartments.Text = "Działy";
            this.btnDepartments.UseVisualStyleBackColor = false;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnPositions
            // 
            this.btnPositions.BackColor = System.Drawing.Color.Red;
            this.btnPositions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPositions.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPositions.Location = new System.Drawing.Point(164, 92);
            this.btnPositions.Margin = new System.Windows.Forms.Padding(4);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(467, 123);
            this.btnPositions.TabIndex = 11;
            this.btnPositions.Text = "Stanowiska produkcyjne";
            this.btnPositions.UseVisualStyleBackColor = false;
            this.btnPositions.Click += new System.EventHandler(this.btnPositions_Click);
            // 
            // FormHREtat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnDepartments);
            this.Controls.Add(this.btnPositions);
            this.Name = "FormHREtat";
            this.Text = "Etaty";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnPositions;
    }
}