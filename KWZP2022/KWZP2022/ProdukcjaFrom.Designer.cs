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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(337, 123);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(337, 123);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(81, 508);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(337, 123);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ProdukcjaFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProdukty);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "ProdukcjaFrom";
            this.Text = "Dział Produkcyjny ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdukty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}