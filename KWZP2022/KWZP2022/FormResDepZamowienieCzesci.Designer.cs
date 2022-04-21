namespace KWZP2022
{
    partial class FormResDepZamowienieCzesci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepZamowienieCzesci));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvZamowienieCzesci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieCzesci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Zamówienie części";
            // 
            // dgvZamowienieCzesci
            // 
            this.dgvZamowienieCzesci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienieCzesci.Location = new System.Drawing.Point(23, 251);
            this.dgvZamowienieCzesci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZamowienieCzesci.Name = "dgvZamowienieCzesci";
            this.dgvZamowienieCzesci.RowHeadersWidth = 51;
            this.dgvZamowienieCzesci.Size = new System.Drawing.Size(744, 179);
            this.dgvZamowienieCzesci.TabIndex = 14;
            // 
            // FormResDepZamowienieCzesci
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvZamowienieCzesci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormResDepZamowienieCzesci";
            this.Text = "FormResDepZamowienieCzesci";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieCzesci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZamowienieCzesci;
    }
}