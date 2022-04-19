namespace KWZP2022
{
    partial class Dzial_produkcyjnyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dzial_produkcyjnyForm));
            this.btnProdukty = new System.Windows.Forms.Button();
            this.btnCzynnosciProdukcyjne = new System.Windows.Forms.Button();
            this.btnPolprodukty = new System.Windows.Forms.Button();
            this.btnStanowiska = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdukty
            // 
            this.btnProdukty.Font = new System.Drawing.Font("Arial", 25F);
            this.btnProdukty.Location = new System.Drawing.Point(126, 77);
            this.btnProdukty.Name = "btnProdukty";
            this.btnProdukty.Size = new System.Drawing.Size(394, 80);
            this.btnProdukty.TabIndex = 0;
            this.btnProdukty.Text = "Produkty";
            this.btnProdukty.UseVisualStyleBackColor = true;
            this.btnProdukty.Click += new System.EventHandler(this.btnProdukty_Click);
            // 
            // btnCzynnosciProdukcyjne
            // 
            this.btnCzynnosciProdukcyjne.Font = new System.Drawing.Font("Arial", 25F);
            this.btnCzynnosciProdukcyjne.Location = new System.Drawing.Point(126, 360);
            this.btnCzynnosciProdukcyjne.Name = "btnCzynnosciProdukcyjne";
            this.btnCzynnosciProdukcyjne.Size = new System.Drawing.Size(394, 80);
            this.btnCzynnosciProdukcyjne.TabIndex = 1;
            this.btnCzynnosciProdukcyjne.Text = "Czynności produkcyjne";
            this.btnCzynnosciProdukcyjne.UseVisualStyleBackColor = true;
            // 
            // btnPolprodukty
            // 
            this.btnPolprodukty.Font = new System.Drawing.Font("Arial", 25F);
            this.btnPolprodukty.Location = new System.Drawing.Point(126, 218);
            this.btnPolprodukty.Name = "btnPolprodukty";
            this.btnPolprodukty.Size = new System.Drawing.Size(394, 80);
            this.btnPolprodukty.TabIndex = 2;
            this.btnPolprodukty.Text = "Półprodukty";
            this.btnPolprodukty.UseVisualStyleBackColor = true;
            // 
            // btnStanowiska
            // 
            this.btnStanowiska.Font = new System.Drawing.Font("Arial", 25F);
            this.btnStanowiska.Location = new System.Drawing.Point(126, 496);
            this.btnStanowiska.Name = "btnStanowiska";
            this.btnStanowiska.Size = new System.Drawing.Size(394, 80);
            this.btnStanowiska.TabIndex = 3;
            this.btnStanowiska.Text = "Stanowiska produkcyjne";
            this.btnStanowiska.UseVisualStyleBackColor = true;
            // 
            // Dzial_produkcyjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnStanowiska);
            this.Controls.Add(this.btnPolprodukty);
            this.Controls.Add(this.btnCzynnosciProdukcyjne);
            this.Controls.Add(this.btnProdukty);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dzial_produkcyjny";
            this.Text = "Dział PRODUKCYJNY";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdukty;
        private System.Windows.Forms.Button btnCzynnosciProdukcyjne;
        private System.Windows.Forms.Button btnPolprodukty;
        private System.Windows.Forms.Button btnStanowiska;
    }
}