namespace KWZP2022
{
    partial class FormSalesDepartmentClientRemoveClient
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
            this.dgvClientRemove = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInstr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientRemove
            // 
            this.dgvClientRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientRemove.Location = new System.Drawing.Point(12, 88);
            this.dgvClientRemove.Name = "dgvClientRemove";
            this.dgvClientRemove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientRemove.Size = new System.Drawing.Size(770, 358);
            this.dgvClientRemove.TabIndex = 0;
            this.dgvClientRemove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientRemove_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(682, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInstr
            // 
            this.lblInstr.AutoSize = true;
            this.lblInstr.BackColor = System.Drawing.Color.Transparent;
            this.lblInstr.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblInstr.Location = new System.Drawing.Point(12, 65);
            this.lblInstr.Name = "lblInstr";
            this.lblInstr.Size = new System.Drawing.Size(293, 20);
            this.lblInstr.TabIndex = 102;
            this.lblInstr.Text = "Kliknij  na klienta z listy, którego chcesz usunąć";
            // 
            // FormSalesDepartmentClientRemoveClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.lblInstr);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvClientRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSalesDepartmentClientRemoveClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuwanie klienta z bazy danych";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInstr;
    }
}