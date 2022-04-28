namespace KWZP2022
{
    partial class FormResDepMagazynNarzedzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepMagazynNarzedzi));
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajNarzedzie = new System.Windows.Forms.Button();
            this.dgvMagazynNarzedzie = new System.Windows.Forms.DataGridView();
            this.lblPodpisWidoku = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynNarzedzie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.Aqua;
            this.btnOdswiez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnOdswiez.Location = new System.Drawing.Point(658, 112);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(110, 33);
            this.btnOdswiez.TabIndex = 49;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 37);
            this.label1.TabIndex = 48;
            this.label1.Text = "Magazyn dostępnych narzędzi";
            // 
            // btnDodajNarzedzie
            // 
            this.btnDodajNarzedzie.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajNarzedzie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNarzedzie.Location = new System.Drawing.Point(37, 112);
            this.btnDodajNarzedzie.Name = "btnDodajNarzedzie";
            this.btnDodajNarzedzie.Size = new System.Drawing.Size(254, 42);
            this.btnDodajNarzedzie.TabIndex = 47;
            this.btnDodajNarzedzie.Text = "Złóż zamówienie narzędzi";
            this.btnDodajNarzedzie.UseVisualStyleBackColor = false;
            this.btnDodajNarzedzie.Click += new System.EventHandler(this.btnDodajNarzedzie_Click);
            // 
            // dgvMagazynNarzedzie
            // 
            this.dgvMagazynNarzedzie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynNarzedzie.Location = new System.Drawing.Point(37, 214);
            this.dgvMagazynNarzedzie.Name = "dgvMagazynNarzedzie";
            this.dgvMagazynNarzedzie.Size = new System.Drawing.Size(731, 241);
            this.dgvMagazynNarzedzie.TabIndex = 46;
            this.dgvMagazynNarzedzie.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagazynNarzedzie_CellDoubleClick);
            // 
            // lblPodpisWidoku
            // 
            this.lblPodpisWidoku.AutoSize = true;
            this.lblPodpisWidoku.BackColor = System.Drawing.Color.Transparent;
            this.lblPodpisWidoku.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodpisWidoku.Location = new System.Drawing.Point(33, 189);
            this.lblPodpisWidoku.Name = "lblPodpisWidoku";
            this.lblPodpisWidoku.Size = new System.Drawing.Size(159, 22);
            this.lblPodpisWidoku.TabIndex = 55;
            this.lblPodpisWidoku.Text = "Magazyn narzędzi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(191, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Kliknij dwukrotnie na narzędzie, aby zobaczyć jego historię zamówień.";
            // 
            // FormResDepMagazynNarzedzi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPodpisWidoku);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajNarzedzie);
            this.Controls.Add(this.dgvMagazynNarzedzie);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepMagazynNarzedzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Magazyn narzędzi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynNarzedzie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajNarzedzie;
        private System.Windows.Forms.DataGridView dgvMagazynNarzedzie;
        private System.Windows.Forms.Label lblPodpisWidoku;
        private System.Windows.Forms.Label label2;
    }
}