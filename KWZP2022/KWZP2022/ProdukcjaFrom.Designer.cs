namespace KWZP2022
{
    partial class ProdukcjaFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdukcjaFrom));
            this.btnProdukty = new System.Windows.Forms.Button();
            this.btnPolprodukty = new System.Windows.Forms.Button();
            this.btnStanowiska = new System.Windows.Forms.Button();
            this.btnParpol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdukty
            // 
            this.btnProdukty.Font = new System.Drawing.Font("Arial", 20F);
            this.btnProdukty.Location = new System.Drawing.Point(81, 45);
            this.btnProdukty.Name = "btnProdukty";
            this.btnProdukty.Size = new System.Drawing.Size(337, 123);
            this.btnProdukty.TabIndex = 0;
            this.btnProdukty.Text = "Produkty";
            this.btnProdukty.UseVisualStyleBackColor = true;
            this.btnProdukty.Click += new System.EventHandler(this.btnProdukty_Click);
            // 
            // btnPolprodukty
            // 
            this.btnPolprodukty.Font = new System.Drawing.Font("Arial", 20F);
            this.btnPolprodukty.Location = new System.Drawing.Point(81, 200);
            this.btnPolprodukty.Name = "btnPolprodukty";
            this.btnPolprodukty.Size = new System.Drawing.Size(337, 123);
            this.btnPolprodukty.TabIndex = 1;
            this.btnPolprodukty.Text = "Półprodukty";
            this.btnPolprodukty.UseVisualStyleBackColor = true;
            this.btnPolprodukty.Click += new System.EventHandler(this.btnPolprodukty_Click);
            // 
            // btnStanowiska
            // 
            this.btnStanowiska.Font = new System.Drawing.Font("Arial", 20F);
            this.btnStanowiska.Location = new System.Drawing.Point(81, 362);
            this.btnStanowiska.Name = "btnStanowiska";
            this.btnStanowiska.Size = new System.Drawing.Size(337, 123);
            this.btnStanowiska.TabIndex = 2;
            this.btnStanowiska.Text = "Stanowiska produkcyjne";
            this.btnStanowiska.UseVisualStyleBackColor = true;
            this.btnStanowiska.Click += new System.EventHandler(this.btnStanowiska_Click);
            // 
            // btnParpol
            // 
            this.btnParpol.Font = new System.Drawing.Font("Arial", 20F);
            this.btnParpol.Location = new System.Drawing.Point(81, 508);
            this.btnParpol.Name = "btnParpol";
            this.btnParpol.Size = new System.Drawing.Size(337, 123);
            this.btnParpol.TabIndex = 3;
            this.btnParpol.Text = "Parametr półprodukt";
            this.btnParpol.UseVisualStyleBackColor = true;
            this.btnParpol.Click += new System.EventHandler(this.btnParpol_Click);
            // 
            // ProdukcjaFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnParpol);
            this.Controls.Add(this.btnStanowiska);
            this.Controls.Add(this.btnPolprodukty);
            this.Controls.Add(this.btnProdukty);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "ProdukcjaFrom";
            this.Text = "Dział Produkcyjny ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdukty;
        private System.Windows.Forms.Button btnPolprodukty;
        private System.Windows.Forms.Button btnStanowiska;
        private System.Windows.Forms.Button btnParpol;
    }
}