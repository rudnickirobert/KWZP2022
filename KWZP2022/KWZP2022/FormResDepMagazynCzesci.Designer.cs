namespace KWZP2022
{
    partial class FormResDepMagazynCzesci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepMagazynCzesci));
            this.lblNazwa = new System.Windows.Forms.Label();
            this.btnDodajCzesc = new System.Windows.Forms.Button();
            this.dgvMagazynCzesc = new System.Windows.Forms.DataGridView();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynCzesc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblNazwa.Location = new System.Drawing.Point(30, 40);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(444, 37);
            this.lblNazwa.TabIndex = 43;
            this.lblNazwa.Text = "Magazyn dostępnych części";
            // 
            // btnDodajCzesc
            // 
            this.btnDodajCzesc.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajCzesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajCzesc.Location = new System.Drawing.Point(37, 113);
            this.btnDodajCzesc.Name = "btnDodajCzesc";
            this.btnDodajCzesc.Size = new System.Drawing.Size(254, 42);
            this.btnDodajCzesc.TabIndex = 42;
            this.btnDodajCzesc.Text = "Zlóż zamówienie części";
            this.btnDodajCzesc.UseVisualStyleBackColor = false;
            this.btnDodajCzesc.Click += new System.EventHandler(this.btnDodajCzesc_Click);
            // 
            // dgvMagazynCzesc
            // 
            this.dgvMagazynCzesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynCzesc.Location = new System.Drawing.Point(37, 206);
            this.dgvMagazynCzesc.Name = "dgvMagazynCzesc";
            this.dgvMagazynCzesc.Size = new System.Drawing.Size(731, 250);
            this.dgvMagazynCzesc.TabIndex = 41;
            this.dgvMagazynCzesc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagazynCzesc_CellDoubleClick);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.Aqua;
            this.btnOdswiez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnOdswiez.Location = new System.Drawing.Point(658, 122);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(110, 33);
            this.btnOdswiez.TabIndex = 44;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // lblPodpisWidoku
            // 
            this.lblPodpisWidoku.AutoSize = true;
            this.lblPodpisWidoku.BackColor = System.Drawing.Color.Transparent;
            this.lblPodpisWidoku.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodpisWidoku.Location = new System.Drawing.Point(33, 181);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(143, 22);
            this.lblPodpisWidoku.TabIndex = 45;
            this.lblPodpisWidoku.Text = "Magazyn części";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(213, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Kliknij dwukrotnie na część, aby zobaczyć jej historię zamówień.";
            // 
            // FormResDepMagazynCzesci
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.btnDodajCzesc);
            this.Controls.Add(this.dgvMagazynCzesc);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepMagazynCzesci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Magazyn części";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynCzesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Button btnDodajCzesc;
        private System.Windows.Forms.DataGridView dgvMagazynCzesc;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.Label label2;
    }
}