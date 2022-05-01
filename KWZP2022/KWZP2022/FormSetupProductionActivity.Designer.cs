namespace KWZP2022
{
    partial class FormSetupProductionActivity
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditActivity = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(504, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Wybierz czynność z listy w celu jej edycji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Czynność produkcyjna";
            // 
            // btnEditActivity
            // 
            this.btnEditActivity.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditActivity.Font = new System.Drawing.Font("Arial", 15F);
            this.btnEditActivity.Location = new System.Drawing.Point(16, 383);
            this.btnEditActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditActivity.Name = "btnEditActivity";
            this.btnEditActivity.Size = new System.Drawing.Size(305, 46);
            this.btnEditActivity.TabIndex = 62;
            this.btnEditActivity.Text = "Edytuj";
            this.btnEditActivity.UseVisualStyleBackColor = false;
            this.btnEditActivity.Click += new System.EventHandler(this.btnEditActivity_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddActivity.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAddActivity.Location = new System.Drawing.Point(16, 235);
            this.btnAddActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(305, 46);
            this.btnAddActivity.TabIndex = 61;
            this.btnAddActivity.Text = "Dodaj ";
            this.btnAddActivity.UseVisualStyleBackColor = false;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // txtActivity
            // 
            this.txtActivity.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtActivity.Location = new System.Drawing.Point(16, 105);
            this.txtActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(304, 30);
            this.txtActivity.TabIndex = 60;
            // 
            // dgvActivity
            // 
            this.dgvActivity.Location = new System.Drawing.Point(444, 60);
            this.dgvActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.Size = new System.Drawing.Size(599, 529);
            this.dgvActivity.TabIndex = 59;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // FormSetupProductionActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(1059, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditActivity);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.dgvActivity);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSetupProductionActivity";
            this.Text = "Dodaj czynnosc produkcyjna";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditActivity;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.DataGridView dgvActivity;
    }
}