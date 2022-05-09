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
            this.txtCzas = new System.Windows.Forms.TextBox();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbSzacowanyCzas = new System.Windows.Forms.ComboBox();
            this.cbCzynnoscProdukcyjna = new System.Windows.Forms.ComboBox();
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.btnDodajPrcoes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtbDataStart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtbDataStart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCzas
            // 
            this.txtCzas.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCzas.Location = new System.Drawing.Point(90, 154);
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.Size = new System.Drawing.Size(152, 30);
            this.txtCzas.TabIndex = 73;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddActivity.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAddActivity.Location = new System.Drawing.Point(879, 54);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(334, 37);
            this.btnAddActivity.TabIndex = 72;
            this.btnAddActivity.Text = "Dodaj czynność";
            this.btnAddActivity.UseVisualStyleBackColor = false;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReset.Font = new System.Drawing.Font("Arial", 15F);
            this.btnReset.Location = new System.Drawing.Point(682, 142);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(334, 37);
            this.btnReset.TabIndex = 71;
            this.btnReset.Text = "Odśwież";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbSzacowanyCzas
            // 
            this.cbSzacowanyCzas.FormattingEnabled = true;
            this.cbSzacowanyCzas.Location = new System.Drawing.Point(90, 154);
            this.cbSzacowanyCzas.Margin = new System.Windows.Forms.Padding(2);
            this.cbSzacowanyCzas.Name = "cbSzacowanyCzas";
            this.cbSzacowanyCzas.Size = new System.Drawing.Size(152, 21);
            this.cbSzacowanyCzas.TabIndex = 70;
            // 
            // cbCzynnoscProdukcyjna
            // 
            this.cbCzynnoscProdukcyjna.FormattingEnabled = true;
            this.cbCzynnoscProdukcyjna.Location = new System.Drawing.Point(90, 93);
            this.cbCzynnoscProdukcyjna.Margin = new System.Windows.Forms.Padding(2);
            this.cbCzynnoscProdukcyjna.Name = "cbCzynnoscProdukcyjna";
            this.cbCzynnoscProdukcyjna.Size = new System.Drawing.Size(152, 21);
            this.cbCzynnoscProdukcyjna.TabIndex = 69;
            // 
            // cbProdukt
            // 
            this.cbProdukt.FormattingEnabled = true;
            this.cbProdukt.Location = new System.Drawing.Point(90, 32);
            this.cbProdukt.Margin = new System.Windows.Forms.Padding(2);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(152, 21);
            this.cbProdukt.TabIndex = 68;
            // 
            // btnDodajPrcoes
            // 
            this.btnDodajPrcoes.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodajPrcoes.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodajPrcoes.Location = new System.Drawing.Point(477, 54);
            this.btnDodajPrcoes.Name = "btnDodajPrcoes";
            this.btnDodajPrcoes.Size = new System.Drawing.Size(334, 37);
            this.btnDodajPrcoes.TabIndex = 67;
            this.btnDodajPrcoes.Text = "Dodaj nowy proces";
            this.btnDodajPrcoes.UseVisualStyleBackColor = false;
            this.btnDodajPrcoes.Click += new System.EventHandler(this.btnDodajPrcoes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(86, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "Szacowany czas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(86, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Czynność produkcyjna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(86, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 64;
            this.label1.Text = "Produkt";
            // 
            // dtbDataStart
            // 
            this.dtbDataStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbDataStart.Location = new System.Drawing.Point(11, 198);
            this.dtbDataStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtbDataStart.Name = "dtbDataStart";
            this.dtbDataStart.RowTemplate.Height = 24;
            this.dtbDataStart.Size = new System.Drawing.Size(1242, 506);
            this.dtbDataStart.TabIndex = 63;
            // 
            // FormSetupProductionProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbSzacowanyCzas);
            this.Controls.Add(this.cbCzynnoscProdukcyjna);
            this.Controls.Add(this.cbProdukt);
            this.Controls.Add(this.btnDodajPrcoes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtbDataStart);
            this.Name = "FormSetupProductionProduct";
            this.Text = "Proces produkt czynnosc";
            ((System.ComponentModel.ISupportInitialize)(this.dtbDataStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbSzacowanyCzas;
        private System.Windows.Forms.ComboBox cbCzynnoscProdukcyjna;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.Button btnDodajPrcoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtbDataStart;
    }
}