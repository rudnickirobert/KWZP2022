namespace KWZP2022
{
    partial class FormSetupProductionByproduct
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
            this.cbCzynnoscProdukcyjna = new System.Windows.Forms.ComboBox();
            this.cbPolprodukt = new System.Windows.Forms.ComboBox();
            this.btnDodajProces = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDataStart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataStart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCzas
            // 
            this.txtCzas.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCzas.Location = new System.Drawing.Point(60, 148);
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.Size = new System.Drawing.Size(151, 30);
            this.txtCzas.TabIndex = 69;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddActivity.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAddActivity.Location = new System.Drawing.Point(919, 55);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(334, 37);
            this.btnAddActivity.TabIndex = 68;
            this.btnAddActivity.Text = "Dodaj czynność";
            this.btnAddActivity.UseVisualStyleBackColor = false;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReset.Font = new System.Drawing.Font("Arial", 15F);
            this.btnReset.Location = new System.Drawing.Point(651, 127);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(334, 37);
            this.btnReset.TabIndex = 67;
            this.btnReset.Text = "Odśwież";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbCzynnoscProdukcyjna
            // 
            this.cbCzynnoscProdukcyjna.FormattingEnabled = true;
            this.cbCzynnoscProdukcyjna.Location = new System.Drawing.Point(59, 93);
            this.cbCzynnoscProdukcyjna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCzynnoscProdukcyjna.Name = "cbCzynnoscProdukcyjna";
            this.cbCzynnoscProdukcyjna.Size = new System.Drawing.Size(152, 21);
            this.cbCzynnoscProdukcyjna.TabIndex = 66;
            // 
            // cbPolprodukt
            // 
            this.cbPolprodukt.FormattingEnabled = true;
            this.cbPolprodukt.Location = new System.Drawing.Point(59, 37);
            this.cbPolprodukt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPolprodukt.Name = "cbPolprodukt";
            this.cbPolprodukt.Size = new System.Drawing.Size(152, 21);
            this.cbPolprodukt.TabIndex = 65;
            // 
            // btnDodajProces
            // 
            this.btnDodajProces.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodajProces.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodajProces.Location = new System.Drawing.Point(419, 55);
            this.btnDodajProces.Name = "btnDodajProces";
            this.btnDodajProces.Size = new System.Drawing.Size(334, 37);
            this.btnDodajProces.TabIndex = 64;
            this.btnDodajProces.Text = "Dodaj nowy proces";
            this.btnDodajProces.UseVisualStyleBackColor = false;
            this.btnDodajProces.Click += new System.EventHandler(this.btnDodajProces_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(56, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "Szacowany czas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "Czynność produkcyjna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Półprodukt";
            // 
            // dgvDataStart
            // 
            this.dgvDataStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataStart.Location = new System.Drawing.Point(11, 194);
            this.dgvDataStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDataStart.Name = "dgvDataStart";
            this.dgvDataStart.RowTemplate.Height = 24;
            this.dgvDataStart.Size = new System.Drawing.Size(1242, 502);
            this.dgvDataStart.TabIndex = 60;
            this.dgvDataStart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataStart_CellClick);
            // 
            // FormSetupProductionByproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbCzynnoscProdukcyjna);
            this.Controls.Add(this.cbPolprodukt);
            this.Controls.Add(this.btnDodajProces);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDataStart);
            this.Name = "FormSetupProductionByproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProcesPolproduktCzynnosc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbCzynnoscProdukcyjna;
        private System.Windows.Forms.ComboBox cbPolprodukt;
        private System.Windows.Forms.Button btnDodajProces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDataStart;
    }
}