namespace KWZP2022
{
    partial class FormSalesDepartmentAlert
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
            this.dgvAlert = new System.Windows.Forms.DataGridView();
            this.textBoxContents = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTresc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReaded = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlert
            // 
            this.dgvAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlert.Location = new System.Drawing.Point(12, 32);
            this.dgvAlert.Name = "dgvAlert";
            this.dgvAlert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlert.Size = new System.Drawing.Size(193, 414);
            this.dgvAlert.TabIndex = 0;
            this.dgvAlert.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAlert_MouseClick);
            this.dgvAlert.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAlert_MouseDoubleClick);
            // 
            // textBoxContents
            // 
            this.textBoxContents.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBoxContents.Location = new System.Drawing.Point(211, 65);
            this.textBoxContents.Multiline = true;
            this.textBoxContents.Name = "textBoxContents";
            this.textBoxContents.Size = new System.Drawing.Size(571, 158);
            this.textBoxContents.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(682, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 82;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTresc
            // 
            this.lblTresc.AutoSize = true;
            this.lblTresc.BackColor = System.Drawing.Color.Transparent;
            this.lblTresc.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblTresc.Location = new System.Drawing.Point(453, 42);
            this.lblTresc.Name = "lblTresc";
            this.lblTresc.Size = new System.Drawing.Size(42, 20);
            this.lblTresc.TabIndex = 83;
            this.lblTresc.Text = "Treść";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Wybierz alert";
            // 
            // btnReaded
            // 
            this.btnReaded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReaded.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReaded.Location = new System.Drawing.Point(428, 229);
            this.btnReaded.Name = "btnReaded";
            this.btnReaded.Size = new System.Drawing.Size(100, 27);
            this.btnReaded.TabIndex = 85;
            this.btnReaded.Text = "Przeczytano";
            this.btnReaded.UseVisualStyleBackColor = true;
            this.btnReaded.Click += new System.EventHandler(this.btnReaded_Click);
            // 
            // FormSalesDepartmentAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnReaded);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTresc);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBoxContents);
            this.Controls.Add(this.dgvAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSalesDepartmentAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alerty";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlert;
        private System.Windows.Forms.TextBox textBoxContents;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTresc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReaded;
    }
}