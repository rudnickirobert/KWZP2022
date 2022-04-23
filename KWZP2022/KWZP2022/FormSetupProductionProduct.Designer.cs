
namespace KWZP2022
{
    partial class FormSetupProductionProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetupProductionProduct));
            this.dtbDataStart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAktualizujProces = new System.Windows.Forms.Button();
            this.btnDodajPrcoes = new System.Windows.Forms.Button();
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.cbCzynnoscProdukcyjna = new System.Windows.Forms.ComboBox();
            this.cbSzacowanyCzas = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtbDataStart)).BeginInit();
            this.SuspendLayout();
            // 
            // dtbDataStart
            // 
            this.dtbDataStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbDataStart.Location = new System.Drawing.Point(11, 162);
            this.dtbDataStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtbDataStart.Name = "dtbDataStart";
            this.dtbDataStart.RowTemplate.Height = 24;
            this.dtbDataStart.Size = new System.Drawing.Size(1242, 538);
            this.dtbDataStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(348, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produkt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(518, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Czynność produkcyjna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(772, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Szacowany czas";
            // 
            // btnAktualizujProces
            // 
            this.btnAktualizujProces.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizujProces.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizujProces.Location = new System.Drawing.Point(862, 109);
            this.btnAktualizujProces.Name = "btnAktualizujProces";
            this.btnAktualizujProces.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizujProces.TabIndex = 22;
            this.btnAktualizujProces.Text = "Aktualizacja";
            this.btnAktualizujProces.UseVisualStyleBackColor = false;
            // 
            // btnDodajPrcoes
            // 
            this.btnDodajPrcoes.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodajPrcoes.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodajPrcoes.Location = new System.Drawing.Point(92, 109);
            this.btnDodajPrcoes.Name = "btnDodajPrcoes";
            this.btnDodajPrcoes.Size = new System.Drawing.Size(334, 37);
            this.btnDodajPrcoes.TabIndex = 21;
            this.btnDodajPrcoes.Text = "Dodaj nowy proces";
            this.btnDodajPrcoes.UseVisualStyleBackColor = false;
            this.btnDodajPrcoes.Click += new System.EventHandler(this.btnDodajPrcoes_Click);
            // 
            // cbProdukt
            // 
            this.cbProdukt.FormattingEnabled = true;
            this.cbProdukt.Location = new System.Drawing.Point(309, 42);
            this.cbProdukt.Margin = new System.Windows.Forms.Padding(2);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(152, 21);
            this.cbProdukt.TabIndex = 23;
            // 
            // cbCzynnoscProdukcyjna
            // 
            this.cbCzynnoscProdukcyjna.FormattingEnabled = true;
            this.cbCzynnoscProdukcyjna.Location = new System.Drawing.Point(542, 45);
            this.cbCzynnoscProdukcyjna.Margin = new System.Windows.Forms.Padding(2);
            this.cbCzynnoscProdukcyjna.Name = "cbCzynnoscProdukcyjna";
            this.cbCzynnoscProdukcyjna.Size = new System.Drawing.Size(152, 21);
            this.cbCzynnoscProdukcyjna.TabIndex = 24;
            // 
            // cbSzacowanyCzas
            // 
            this.cbSzacowanyCzas.FormattingEnabled = true;
            this.cbSzacowanyCzas.Location = new System.Drawing.Point(776, 45);
            this.cbSzacowanyCzas.Margin = new System.Windows.Forms.Padding(2);
            this.cbSzacowanyCzas.Name = "cbSzacowanyCzas";
            this.cbSzacowanyCzas.Size = new System.Drawing.Size(152, 21);
            this.cbSzacowanyCzas.TabIndex = 27;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReset.Font = new System.Drawing.Font("Arial", 15F);
            this.btnReset.Location = new System.Drawing.Point(477, 109);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(334, 37);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Odśwież";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormSetupProductionProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbSzacowanyCzas);
            this.Controls.Add(this.cbCzynnoscProdukcyjna);
            this.Controls.Add(this.cbProdukt);
            this.Controls.Add(this.btnAktualizujProces);
            this.Controls.Add(this.btnDodajPrcoes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtbDataStart);
            this.DoubleBuffered = true;
            this.Name = "FormSetupProductionProduct";
            this.Text = "Dział Przygotowania Produkcji";
            ((System.ComponentModel.ISupportInitialize)(this.dtbDataStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtbDataStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAktualizujProces;
        private System.Windows.Forms.Button btnDodajPrcoes;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.ComboBox cbCzynnoscProdukcyjna;
        private System.Windows.Forms.ComboBox cbSzacowanyCzas;
        private System.Windows.Forms.Button btnReset;
    }
}