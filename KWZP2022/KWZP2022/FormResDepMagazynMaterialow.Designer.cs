namespace KWZP2022
{
    partial class FormResDepMagazynMaterialow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepMagazynMaterialow));
            this.dgvMagazynMaterial = new System.Windows.Forms.DataGridView();
            this.btnDodajMaterial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMagazynMaterial
            // 
            this.dgvMagazynMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynMaterial.Location = new System.Drawing.Point(35, 187);
            this.dgvMagazynMaterial.Name = "dgvMagazynMaterial";
            this.dgvMagazynMaterial.Size = new System.Drawing.Size(731, 264);
            this.dgvMagazynMaterial.TabIndex = 0;
            // 
            // btnDodajMaterial
            // 
            this.btnDodajMaterial.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajMaterial.Location = new System.Drawing.Point(35, 108);
            this.btnDodajMaterial.Name = "btnDodajMaterial";
            this.btnDodajMaterial.Size = new System.Drawing.Size(254, 42);
            this.btnDodajMaterial.TabIndex = 39;
            this.btnDodajMaterial.Text = "Złóż zamówienie materiału";
            this.btnDodajMaterial.UseVisualStyleBackColor = false;
            this.btnDodajMaterial.Click += new System.EventHandler(this.btnDodajMaterial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "Magazyn dostępnych materiałów";
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.Aqua;
            this.btnOdswiez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnOdswiez.Location = new System.Drawing.Point(656, 108);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(110, 33);
            this.btnOdswiez.TabIndex = 45;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // FormResDepMagazynMaterialow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 498);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajMaterial);
            this.Controls.Add(this.dgvMagazynMaterial);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepMagazynMaterialow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Magazyn materiałów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagazynMaterial;
        private System.Windows.Forms.Button btnDodajMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdswiez;
    }
}