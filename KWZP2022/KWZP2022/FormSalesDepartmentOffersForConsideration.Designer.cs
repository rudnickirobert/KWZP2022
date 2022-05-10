namespace KWZP2022
{
    partial class FormSalesDepartmentOffersForConsideration
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
            this.dgvOffersForConsideration = new System.Windows.Forms.DataGridView();
            this.comboBoxOffers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffersForConsideration)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOffersForConsideration
            // 
            this.dgvOffersForConsideration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffersForConsideration.Location = new System.Drawing.Point(12, 128);
            this.dgvOffersForConsideration.Name = "dgvOffersForConsideration";
            this.dgvOffersForConsideration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOffersForConsideration.Size = new System.Drawing.Size(770, 299);
            this.dgvOffersForConsideration.TabIndex = 0;
            this.dgvOffersForConsideration.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvOffersForConsideration_MouseDoubleClick);
            // 
            // comboBoxOffers
            // 
            this.comboBoxOffers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOffers.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.comboBoxOffers.FormattingEnabled = true;
            this.comboBoxOffers.Location = new System.Drawing.Point(154, 53);
            this.comboBoxOffers.Name = "comboBoxOffers";
            this.comboBoxOffers.Size = new System.Drawing.Size(121, 28);
            this.comboBoxOffers.TabIndex = 1;
            this.comboBoxOffers.SelectionChangeCommitted += new System.EventHandler(this.comboBoxOffers_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer zamówienia:";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnClose.Location = new System.Drawing.Point(702, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 28);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(324, 451);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 28);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormSalesDepartmentOffersForConsideration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOffers);
            this.Controls.Add(this.dgvOffersForConsideration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSalesDepartmentOffersForConsideration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rozpatrzenie ofert handlowych";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffersForConsideration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOffersForConsideration;
        private System.Windows.Forms.ComboBox comboBoxOffers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
    }
}