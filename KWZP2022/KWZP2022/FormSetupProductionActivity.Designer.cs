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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetupProductionActivity));
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.btnEditActivity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivity
            // 
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Location = new System.Drawing.Point(333, 49);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.Size = new System.Drawing.Size(449, 430);
            this.dgvActivity.TabIndex = 0;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // txtActivity
            // 
            this.txtActivity.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtActivity.Location = new System.Drawing.Point(12, 85);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(229, 30);
            this.txtActivity.TabIndex = 1;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddActivity.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAddActivity.Location = new System.Drawing.Point(12, 191);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(229, 37);
            this.btnAddActivity.TabIndex = 49;
            this.btnAddActivity.Text = "Dodaj ";
            this.btnAddActivity.UseVisualStyleBackColor = false;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // btnEditActivity
            // 
            this.btnEditActivity.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditActivity.Font = new System.Drawing.Font("Arial", 15F);
            this.btnEditActivity.Location = new System.Drawing.Point(12, 311);
            this.btnEditActivity.Name = "btnEditActivity";
            this.btnEditActivity.Size = new System.Drawing.Size(229, 37);
            this.btnEditActivity.TabIndex = 50;
            this.btnEditActivity.Text = "Edytuj";
            this.btnEditActivity.UseVisualStyleBackColor = false;
            this.btnEditActivity.Click += new System.EventHandler(this.btnEditActivity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Czynność produkcyjna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(378, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Wybierz czynność z listy w celu jej edycji";
            // 
            // FormSetupProductionActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditActivity);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.dgvActivity);
            this.Name = "FormSetupProductionActivity";
            this.Text = "FormSetupProductionActivity";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Button btnEditActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}