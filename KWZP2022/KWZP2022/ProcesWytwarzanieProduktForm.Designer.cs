namespace KWZP2022
{
    partial class ProcesWytwarzanieProduktForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesWytwarzanieProduktForm));
            this.dgvProcesWytwarzanieProdukt = new System.Windows.Forms.DataGridView();
            this.btnDodajProcesProdukt = new System.Windows.Forms.Button();
            this.txtbNazwaProduktu = new System.Windows.Forms.TextBox();
            this.txtbCzynnoscProdukcyjna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesWytwarzanieProdukt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcesWytwarzanieProdukt
            // 
            this.dgvProcesWytwarzanieProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesWytwarzanieProdukt.Location = new System.Drawing.Point(405, 2);
            this.dgvProcesWytwarzanieProdukt.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProcesWytwarzanieProdukt.Name = "dgvProcesWytwarzanieProdukt";
            this.dgvProcesWytwarzanieProdukt.RowHeadersWidth = 51;
            this.dgvProcesWytwarzanieProdukt.RowTemplate.Height = 24;
            this.dgvProcesWytwarzanieProdukt.Size = new System.Drawing.Size(652, 559);
            this.dgvProcesWytwarzanieProdukt.TabIndex = 2;
            this.dgvProcesWytwarzanieProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesWytwarzanieProdukt_CellContentClick);
            // 
            // btnDodajProcesProdukt
            // 
            this.btnDodajProcesProdukt.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodajProcesProdukt.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajProcesProdukt.Location = new System.Drawing.Point(9, 224);
            this.btnDodajProcesProdukt.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajProcesProdukt.Name = "btnDodajProcesProdukt";
            this.btnDodajProcesProdukt.Size = new System.Drawing.Size(334, 37);
            this.btnDodajProcesProdukt.TabIndex = 3;
            this.btnDodajProcesProdukt.Text = "Dodaj";
            this.btnDodajProcesProdukt.UseVisualStyleBackColor = false;
            this.btnDodajProcesProdukt.Click += new System.EventHandler(this.btnDodajProcesProdukt_Click);
            // 
            // txtbNazwaProduktu
            // 
            this.txtbNazwaProduktu.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbNazwaProduktu.Location = new System.Drawing.Point(9, 81);
            this.txtbNazwaProduktu.Margin = new System.Windows.Forms.Padding(2);
            this.txtbNazwaProduktu.Name = "txtbNazwaProduktu";
            this.txtbNazwaProduktu.Size = new System.Drawing.Size(334, 38);
            this.txtbNazwaProduktu.TabIndex = 6;
            // 
            // txtbCzynnoscProdukcyjna
            // 
            this.txtbCzynnoscProdukcyjna.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbCzynnoscProdukcyjna.Location = new System.Drawing.Point(10, 161);
            this.txtbCzynnoscProdukcyjna.Margin = new System.Windows.Forms.Padding(2);
            this.txtbCzynnoscProdukcyjna.Name = "txtbCzynnoscProdukcyjna";
            this.txtbCzynnoscProdukcyjna.Size = new System.Drawing.Size(334, 38);
            this.txtbCzynnoscProdukcyjna.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(4, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Czynnosc produkcyjna:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nazwa produktu:";
            // 
            // ProcesWytwarzanieProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbCzynnoscProdukcyjna);
            this.Controls.Add(this.txtbNazwaProduktu);
            this.Controls.Add(this.btnDodajProcesProdukt);
            this.Controls.Add(this.dgvProcesWytwarzanieProdukt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProcesWytwarzanieProduktForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesWytwarzanieProdukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProcesWytwarzanieProdukt;
        private System.Windows.Forms.Button btnDodajProcesProdukt;
        private System.Windows.Forms.TextBox txtbNazwaProduktu;
        private System.Windows.Forms.TextBox txtbCzynnoscProdukcyjna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}