namespace KWZP2022
{
    partial class FormKosztProdukcja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKosztProdukcja));
            this.label1 = new System.Windows.Forms.Label();
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.dgvSkladProdukt = new System.Windows.Forms.DataGridView();
            this.dgvCzynnosciProdukcyjne = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWybrany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeneruj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzynnosciProdukcyjne)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybór produktu:";
            // 
            // cbProdukt
            // 
            this.cbProdukt.Font = new System.Drawing.Font("Arial", 15F);
            this.cbProdukt.FormattingEnabled = true;
            this.cbProdukt.Location = new System.Drawing.Point(36, 53);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(292, 31);
            this.cbProdukt.TabIndex = 2;
            // 
            // dgvSkladProdukt
            // 
            this.dgvSkladProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladProdukt.Location = new System.Drawing.Point(36, 161);
            this.dgvSkladProdukt.Name = "dgvSkladProdukt";
            this.dgvSkladProdukt.Size = new System.Drawing.Size(572, 319);
            this.dgvSkladProdukt.TabIndex = 7;
            // 
            // dgvCzynnosciProdukcyjne
            // 
            this.dgvCzynnosciProdukcyjne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzynnosciProdukcyjne.Location = new System.Drawing.Point(660, 161);
            this.dgvCzynnosciProdukcyjne.Name = "dgvCzynnosciProdukcyjne";
            this.dgvCzynnosciProdukcyjne.Size = new System.Drawing.Size(572, 319);
            this.dgvCzynnosciProdukcyjne.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(50, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Całkowity koszt wyprodukowania produktu";
            // 
            // txtWybrany
            // 
            this.txtWybrany.Enabled = false;
            this.txtWybrany.Font = new System.Drawing.Font("Arial", 15F);
            this.txtWybrany.Location = new System.Drawing.Point(438, 538);
            this.txtWybrany.Name = "txtWybrany";
            this.txtWybrany.Size = new System.Drawing.Size(292, 30);
            this.txtWybrany.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(736, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "wynosi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(32, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Skład produktu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(659, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Czynności produkcyjne półproduktu:";
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGeneruj.Font = new System.Drawing.Font("Arial", 20F);
            this.btnGeneruj.Location = new System.Drawing.Point(379, 27);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(292, 57);
            this.btnGeneruj.TabIndex = 47;
            this.btnGeneruj.Text = "Generuj ";
            this.btnGeneruj.UseVisualStyleBackColor = false;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // FormKosztProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWybrany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCzynnosciProdukcyjne);
            this.Controls.Add(this.dgvSkladProdukt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProdukt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FormKosztProdukcja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koszty produkcji";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzynnosciProdukcyjne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.DataGridView dgvSkladProdukt;
        private System.Windows.Forms.DataGridView dgvCzynnosciProdukcyjne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWybrany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeneruj;
    }
}