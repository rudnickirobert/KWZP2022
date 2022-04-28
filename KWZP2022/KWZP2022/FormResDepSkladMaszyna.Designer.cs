
namespace KWZP2022
{
    partial class FormResDepSkladMaszyna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepSkladMaszyna));
            this.dgvCzesci = new System.Windows.Forms.DataGridView();
            this.dgvSklad = new System.Windows.Forms.DataGridView();
            this.lblCzesci = new System.Windows.Forms.Label();
            this.lblSkladMaszyna = new System.Windows.Forms.Label();
            this.btnPrzypisz = new System.Windows.Forms.Button();
            this.btnUsunPrzypisanie = new System.Windows.Forms.Button();
            this.lblFormSklad = new System.Windows.Forms.Label();
            this.btnDodajCzesc = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.numLiczbaCzesci = new System.Windows.Forms.NumericUpDown();
            this.lblLiczbaCzesci = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLiczbaCzesci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCzesci
            // 
            this.dgvCzesci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzesci.Location = new System.Drawing.Point(12, 86);
            this.dgvCzesci.Name = "dgvCzesci";
            this.dgvCzesci.Size = new System.Drawing.Size(379, 276);
            this.dgvCzesci.TabIndex = 0;
            // 
            // dgvSklad
            // 
            this.dgvSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSklad.Location = new System.Drawing.Point(415, 86);
            this.dgvSklad.Name = "dgvSklad";
            this.dgvSklad.Size = new System.Drawing.Size(369, 276);
            this.dgvSklad.TabIndex = 1;
            // 
            // lblCzesci
            // 
            this.lblCzesci.AutoSize = true;
            this.lblCzesci.BackColor = System.Drawing.Color.Transparent;
            this.lblCzesci.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblCzesci.Location = new System.Drawing.Point(12, 58);
            this.lblCzesci.Name = "lblCzesci";
            this.lblCzesci.Size = new System.Drawing.Size(78, 25);
            this.lblCzesci.TabIndex = 2;
            this.lblCzesci.Text = "Części";
            // 
            // lblSkladMaszyna
            // 
            this.lblSkladMaszyna.AutoSize = true;
            this.lblSkladMaszyna.BackColor = System.Drawing.Color.Transparent;
            this.lblSkladMaszyna.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblSkladMaszyna.Location = new System.Drawing.Point(410, 58);
            this.lblSkladMaszyna.Name = "lblSkladMaszyna";
            this.lblSkladMaszyna.Size = new System.Drawing.Size(246, 25);
            this.lblSkladMaszyna.TabIndex = 3;
            this.lblSkladMaszyna.Text = "Skład wybranej maszyny";
            // 
            // btnPrzypisz
            // 
            this.btnPrzypisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrzypisz.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzypisz.Location = new System.Drawing.Point(241, 389);
            this.btnPrzypisz.Name = "btnPrzypisz";
            this.btnPrzypisz.Size = new System.Drawing.Size(193, 45);
            this.btnPrzypisz.TabIndex = 4;
            this.btnPrzypisz.Text = "Przypisz część";
            this.btnPrzypisz.UseVisualStyleBackColor = false;
            this.btnPrzypisz.Click += new System.EventHandler(this.btnPrzypisz_Click);
            // 
            // btnUsunPrzypisanie
            // 
            this.btnUsunPrzypisanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUsunPrzypisanie.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunPrzypisanie.Location = new System.Drawing.Point(480, 389);
            this.btnUsunPrzypisanie.Name = "btnUsunPrzypisanie";
            this.btnUsunPrzypisanie.Size = new System.Drawing.Size(245, 45);
            this.btnUsunPrzypisanie.TabIndex = 5;
            this.btnUsunPrzypisanie.Text = "Usuń przypisanie";
            this.btnUsunPrzypisanie.UseVisualStyleBackColor = false;
            this.btnUsunPrzypisanie.Click += new System.EventHandler(this.btnUsunPrzypisanie_Click);
            // 
            // lblFormSklad
            // 
            this.lblFormSklad.AutoSize = true;
            this.lblFormSklad.BackColor = System.Drawing.Color.Transparent;
            this.lblFormSklad.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormSklad.Location = new System.Drawing.Point(6, 9);
            this.lblFormSklad.Name = "lblFormSklad";
            this.lblFormSklad.Size = new System.Drawing.Size(375, 32);
            this.lblFormSklad.TabIndex = 6;
            this.lblFormSklad.Text = "Określanie składu maszyny";
            // 
            // btnDodajCzesc
            // 
            this.btnDodajCzesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDodajCzesc.Font = new System.Drawing.Font("Arial", 12.25F);
            this.btnDodajCzesc.Location = new System.Drawing.Point(271, 51);
            this.btnDodajCzesc.Name = "btnDodajCzesc";
            this.btnDodajCzesc.Size = new System.Drawing.Size(120, 32);
            this.btnDodajCzesc.TabIndex = 7;
            this.btnDodajCzesc.Text = "Dodaj część";
            this.btnDodajCzesc.UseVisualStyleBackColor = false;
            this.btnDodajCzesc.Click += new System.EventHandler(this.btnDodajCzesc_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 12.25F);
            this.btnOdswiez.Location = new System.Drawing.Point(433, 12);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(120, 32);
            this.btnOdswiez.TabIndex = 8;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // numLiczbaCzesci
            // 
            this.numLiczbaCzesci.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numLiczbaCzesci.Location = new System.Drawing.Point(154, 414);
            this.numLiczbaCzesci.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLiczbaCzesci.Name = "numLiczbaCzesci";
            this.numLiczbaCzesci.Size = new System.Drawing.Size(70, 29);
            this.numLiczbaCzesci.TabIndex = 9;
            this.numLiczbaCzesci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLiczbaCzesci.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLiczbaCzesci
            // 
            this.lblLiczbaCzesci.AutoSize = true;
            this.lblLiczbaCzesci.BackColor = System.Drawing.Color.Transparent;
            this.lblLiczbaCzesci.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLiczbaCzesci.Location = new System.Drawing.Point(100, 389);
            this.lblLiczbaCzesci.Name = "lblLiczbaCzesci";
            this.lblLiczbaCzesci.Size = new System.Drawing.Size(124, 22);
            this.lblLiczbaCzesci.TabIndex = 10;
            this.lblLiczbaCzesci.Text = "Liczba części";
            // 
            // FormResDepSkladMaszyna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 497);
            this.Controls.Add(this.lblLiczbaCzesci);
            this.Controls.Add(this.numLiczbaCzesci);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodajCzesc);
            this.Controls.Add(this.lblFormSklad);
            this.Controls.Add(this.btnUsunPrzypisanie);
            this.Controls.Add(this.btnPrzypisz);
            this.Controls.Add(this.lblSkladMaszyna);
            this.Controls.Add(this.lblCzesci);
            this.Controls.Add(this.dgvSklad);
            this.Controls.Add(this.dgvCzesci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResDepSkladMaszyna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Określ skład maszyny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLiczbaCzesci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCzesci;
        private System.Windows.Forms.DataGridView dgvSklad;
        private System.Windows.Forms.Label lblCzesci;
        private System.Windows.Forms.Label lblSkladMaszyna;
        private System.Windows.Forms.Button btnPrzypisz;
        private System.Windows.Forms.Button btnUsunPrzypisanie;
        private System.Windows.Forms.Label lblFormSklad;
        private System.Windows.Forms.Button btnDodajCzesc;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.NumericUpDown numLiczbaCzesci;
        private System.Windows.Forms.Label lblLiczbaCzesci;
    }
}