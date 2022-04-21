
namespace KWZP2022
{
    partial class Ewidencja_czasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ewidencja_czasForm));
            this.dgvCzasPracownik = new System.Windows.Forms.DataGridView();
            this.lblCzasPracownik = new System.Windows.Forms.Label();
            this.dgvCzasMaszyna = new System.Windows.Forms.DataGridView();
            this.lblCzasMaszyn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzasPracownik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzasMaszyna)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCzasPracownik
            // 
            this.dgvCzasPracownik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzasPracownik.Location = new System.Drawing.Point(12, 59);
            this.dgvCzasPracownik.Name = "dgvCzasPracownik";
            this.dgvCzasPracownik.Size = new System.Drawing.Size(1255, 274);
            this.dgvCzasPracownik.TabIndex = 0;
            // 
            // lblCzasPracownik
            // 
            this.lblCzasPracownik.AutoSize = true;
            this.lblCzasPracownik.BackColor = System.Drawing.Color.Transparent;
            this.lblCzasPracownik.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzasPracownik.Location = new System.Drawing.Point(12, 9);
            this.lblCzasPracownik.Name = "lblCzasPracownik";
            this.lblCzasPracownik.Size = new System.Drawing.Size(672, 33);
            this.lblCzasPracownik.TabIndex = 1;
            this.lblCzasPracownik.Text = "Tygodniowy czas pracy pracowników - wytwarzanie";
            // 
            // dgvCzasMaszyna
            // 
            this.dgvCzasMaszyna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzasMaszyna.Location = new System.Drawing.Point(12, 400);
            this.dgvCzasMaszyna.Name = "dgvCzasMaszyna";
            this.dgvCzasMaszyna.Size = new System.Drawing.Size(1255, 273);
            this.dgvCzasMaszyna.TabIndex = 2;
            // 
            // lblCzasMaszyn
            // 
            this.lblCzasMaszyn.AutoSize = true;
            this.lblCzasMaszyn.BackColor = System.Drawing.Color.Transparent;
            this.lblCzasMaszyn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzasMaszyn.Location = new System.Drawing.Point(12, 351);
            this.lblCzasMaszyn.Name = "lblCzasMaszyn";
            this.lblCzasMaszyn.Size = new System.Drawing.Size(603, 33);
            this.lblCzasMaszyn.TabIndex = 3;
            this.lblCzasMaszyn.Text = "Tygodniowy czas pracy maszyn - wytwarzanie";
            // 
            // Ewidencja_czasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 711);
            this.Controls.Add(this.lblCzasMaszyn);
            this.Controls.Add(this.dgvCzasMaszyna);
            this.Controls.Add(this.lblCzasPracownik);
            this.Controls.Add(this.dgvCzasPracownik);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Ewidencja_czasForm";
            this.Text = "Ewidencja czasu pracy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzasPracownik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzasMaszyna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCzasPracownik;
        private System.Windows.Forms.Label lblCzasPracownik;
        private System.Windows.Forms.DataGridView dgvCzasMaszyna;
        private System.Windows.Forms.Label lblCzasMaszyn;
    }
}