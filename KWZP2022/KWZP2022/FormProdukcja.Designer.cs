namespace KWZP2022
{
    partial class FormProdukcja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdukcja));
            this.btnProdukty = new System.Windows.Forms.Button();
            this.btnPolprodukty = new System.Windows.Forms.Button();
            this.btnStanowiska = new System.Windows.Forms.Button();
            this.btnWytwarzanie = new System.Windows.Forms.Button();
            this.btnStaytystyki = new System.Windows.Forms.Button();
            this.btnKontrola = new System.Windows.Forms.Button();
            this.btnAlert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdukty
            // 
            this.btnProdukty.BackColor = System.Drawing.Color.BurlyWood;
            this.btnProdukty.Font = new System.Drawing.Font("Arial", 20F);
            this.btnProdukty.Location = new System.Drawing.Point(52, 94);
            this.btnProdukty.Name = "btnProdukty";
            this.btnProdukty.Size = new System.Drawing.Size(337, 123);
            this.btnProdukty.TabIndex = 0;
            this.btnProdukty.Text = "Produkty";
            this.btnProdukty.UseVisualStyleBackColor = false;
            this.btnProdukty.Click += new System.EventHandler(this.btnProdukty_Click);
            // 
            // btnPolprodukty
            // 
            this.btnPolprodukty.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPolprodukty.Font = new System.Drawing.Font("Arial", 20F);
            this.btnPolprodukty.Location = new System.Drawing.Point(52, 292);
            this.btnPolprodukty.Name = "btnPolprodukty";
            this.btnPolprodukty.Size = new System.Drawing.Size(337, 123);
            this.btnPolprodukty.TabIndex = 1;
            this.btnPolprodukty.Text = "Półprodukty";
            this.btnPolprodukty.UseVisualStyleBackColor = false;
            this.btnPolprodukty.Click += new System.EventHandler(this.btnPolprodukty_Click);
            // 
            // btnStanowiska
            // 
            this.btnStanowiska.BackColor = System.Drawing.Color.Khaki;
            this.btnStanowiska.Font = new System.Drawing.Font("Arial", 20F);
            this.btnStanowiska.Location = new System.Drawing.Point(52, 490);
            this.btnStanowiska.Name = "btnStanowiska";
            this.btnStanowiska.Size = new System.Drawing.Size(337, 123);
            this.btnStanowiska.TabIndex = 2;
            this.btnStanowiska.Text = "Stanowiska produkcyjne";
            this.btnStanowiska.UseVisualStyleBackColor = false;
            this.btnStanowiska.Click += new System.EventHandler(this.btnStanowiska_Click);
            // 
            // btnWytwarzanie
            // 
            this.btnWytwarzanie.BackColor = System.Drawing.Color.Chartreuse;
            this.btnWytwarzanie.Font = new System.Drawing.Font("Arial", 20F);
            this.btnWytwarzanie.Location = new System.Drawing.Point(458, 191);
            this.btnWytwarzanie.Name = "btnWytwarzanie";
            this.btnWytwarzanie.Size = new System.Drawing.Size(337, 123);
            this.btnWytwarzanie.TabIndex = 3;
            this.btnWytwarzanie.Text = "Wytwarzanie";
            this.btnWytwarzanie.UseVisualStyleBackColor = false;
            this.btnWytwarzanie.Click += new System.EventHandler(this.btnWytwarzanie_Click);
            // 
            // btnStaytystyki
            // 
            this.btnStaytystyki.BackColor = System.Drawing.Color.Beige;
            this.btnStaytystyki.Font = new System.Drawing.Font("Arial", 20F);
            this.btnStaytystyki.Location = new System.Drawing.Point(870, 105);
            this.btnStaytystyki.Name = "btnStaytystyki";
            this.btnStaytystyki.Size = new System.Drawing.Size(337, 123);
            this.btnStaytystyki.TabIndex = 5;
            this.btnStaytystyki.Text = "Statystyki";
            this.btnStaytystyki.UseVisualStyleBackColor = false;
            this.btnStaytystyki.Click += new System.EventHandler(this.btnStaytystyki_Click);
            // 
            // btnKontrola
            // 
            this.btnKontrola.BackColor = System.Drawing.Color.Crimson;
            this.btnKontrola.Font = new System.Drawing.Font("Arial", 20F);
            this.btnKontrola.Location = new System.Drawing.Point(458, 396);
            this.btnKontrola.Name = "btnKontrola";
            this.btnKontrola.Size = new System.Drawing.Size(337, 123);
            this.btnKontrola.TabIndex = 4;
            this.btnKontrola.Text = "Kontrola jakości";
            this.btnKontrola.UseVisualStyleBackColor = false;
            this.btnKontrola.Click += new System.EventHandler(this.btnKontrola_Click);
            // 
            // btnAlert
            // 
            this.btnAlert.BackColor = System.Drawing.Color.Yellow;
            this.btnAlert.Font = new System.Drawing.Font("Arial", 20F);
            this.btnAlert.Location = new System.Drawing.Point(870, 490);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(337, 123);
            this.btnAlert.TabIndex = 6;
            this.btnAlert.Text = "Alerty";
            this.btnAlert.UseVisualStyleBackColor = false;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // FormProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.btnStaytystyki);
            this.Controls.Add(this.btnWytwarzanie);
            this.Controls.Add(this.btnKontrola);
            this.Controls.Add(this.btnStanowiska);
            this.Controls.Add(this.btnPolprodukty);
            this.Controls.Add(this.btnProdukty);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "FormProdukcja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dział Produkcyjny ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdukty;
        private System.Windows.Forms.Button btnPolprodukty;
        private System.Windows.Forms.Button btnStanowiska;
        private System.Windows.Forms.Button btnWytwarzanie;
        private System.Windows.Forms.Button btnStaytystyki;
        private System.Windows.Forms.Button btnKontrola;
        private System.Windows.Forms.Button btnAlert;
    }
}