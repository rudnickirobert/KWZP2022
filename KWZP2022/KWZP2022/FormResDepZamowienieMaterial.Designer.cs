namespace KWZP2022
{
    partial class FormResDepZamowienieMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepZamowienieMaterial));
            this.btnDodajMaterial = new System.Windows.Forms.Button();
            this.dgvZamowienieMaterial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajMaterial
            // 
            this.btnDodajMaterial.Location = new System.Drawing.Point(439, 96);
            this.btnDodajMaterial.Name = "btnDodajMaterial";
            this.btnDodajMaterial.Size = new System.Drawing.Size(182, 45);
            this.btnDodajMaterial.TabIndex = 0;
            this.btnDodajMaterial.Text = "Dodaj materiał";
            this.btnDodajMaterial.UseVisualStyleBackColor = true;
            this.btnDodajMaterial.Click += new System.EventHandler(this.btnDodajMaterial_Click);
            // 
            // dgvZamowienieMaterial
            // 
            this.dgvZamowienieMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienieMaterial.Location = new System.Drawing.Point(53, 183);
            this.dgvZamowienieMaterial.Name = "dgvZamowienieMaterial";
            this.dgvZamowienieMaterial.RowTemplate.Height = 24;
            this.dgvZamowienieMaterial.Size = new System.Drawing.Size(678, 211);
            this.dgvZamowienieMaterial.TabIndex = 1;
            // 
            // FormResDepZamowienieMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvZamowienieMaterial);
            this.Controls.Add(this.btnDodajMaterial);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormResDepZamowienieMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormResDepZamowienieMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajMaterial;
        private System.Windows.Forms.DataGridView dgvZamowienieMaterial;
    }
}