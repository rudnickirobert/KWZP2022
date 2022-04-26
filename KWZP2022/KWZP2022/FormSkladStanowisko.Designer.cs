namespace KWZP2022
{
    partial class FormSkladStanowisko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSkladStanowisko));
            this.dgvStanowisko = new System.Windows.Forms.DataGridView();
            this.dgvNarzedzia = new System.Windows.Forms.DataGridView();
            this.dgvMaszyny = new System.Windows.Forms.DataGridView();
            this.dgvSkladNarzedzia = new System.Windows.Forms.DataGridView();
            this.dgvSkladMaszyny = new System.Windows.Forms.DataGridView();
            this.txtStanowisko = new System.Windows.Forms.TextBox();
            this.txtNarzedzie = new System.Windows.Forms.TextBox();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.txtMaszyny = new System.Windows.Forms.TextBox();
            this.btnDodajStanowisko = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodajNarzedzie = new System.Windows.Forms.Button();
            this.btnUsunNarzedzie = new System.Windows.Forms.Button();
            this.btnDodajMaszyne = new System.Windows.Forms.Button();
            this.btnUsun2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanowisko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladNarzedzia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladMaszyny)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanowisko
            // 
            this.dgvStanowisko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanowisko.Location = new System.Drawing.Point(53, 107);
            this.dgvStanowisko.Name = "dgvStanowisko";
            this.dgvStanowisko.RowHeadersWidth = 51;
            this.dgvStanowisko.RowTemplate.Height = 24;
            this.dgvStanowisko.Size = new System.Drawing.Size(315, 202);
            this.dgvStanowisko.TabIndex = 0;
            this.dgvStanowisko.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStanowisko_CellContentClick);
            // 
            // dgvNarzedzia
            // 
            this.dgvNarzedzia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarzedzia.Location = new System.Drawing.Point(374, 107);
            this.dgvNarzedzia.Name = "dgvNarzedzia";
            this.dgvNarzedzia.RowHeadersWidth = 51;
            this.dgvNarzedzia.RowTemplate.Height = 24;
            this.dgvNarzedzia.Size = new System.Drawing.Size(311, 202);
            this.dgvNarzedzia.TabIndex = 1;
            this.dgvNarzedzia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarzedzia_CellContentClick);
            // 
            // dgvMaszyny
            // 
            this.dgvMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszyny.Location = new System.Drawing.Point(691, 107);
            this.dgvMaszyny.Name = "dgvMaszyny";
            this.dgvMaszyny.RowHeadersWidth = 51;
            this.dgvMaszyny.RowTemplate.Height = 24;
            this.dgvMaszyny.Size = new System.Drawing.Size(340, 202);
            this.dgvMaszyny.TabIndex = 2;
            this.dgvMaszyny.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaszyny_CellContentClick);
            // 
            // dgvSkladNarzedzia
            // 
            this.dgvSkladNarzedzia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladNarzedzia.Location = new System.Drawing.Point(53, 368);
            this.dgvSkladNarzedzia.Name = "dgvSkladNarzedzia";
            this.dgvSkladNarzedzia.RowHeadersWidth = 51;
            this.dgvSkladNarzedzia.RowTemplate.Height = 24;
            this.dgvSkladNarzedzia.Size = new System.Drawing.Size(488, 175);
            this.dgvSkladNarzedzia.TabIndex = 3;
            // 
            // dgvSkladMaszyny
            // 
            this.dgvSkladMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladMaszyny.Location = new System.Drawing.Point(547, 368);
            this.dgvSkladMaszyny.Name = "dgvSkladMaszyny";
            this.dgvSkladMaszyny.RowHeadersWidth = 51;
            this.dgvSkladMaszyny.RowTemplate.Height = 24;
            this.dgvSkladMaszyny.Size = new System.Drawing.Size(484, 175);
            this.dgvSkladMaszyny.TabIndex = 4;
            // 
            // txtStanowisko
            // 
            this.txtStanowisko.Location = new System.Drawing.Point(53, 79);
            this.txtStanowisko.Name = "txtStanowisko";
            this.txtStanowisko.Size = new System.Drawing.Size(315, 22);
            this.txtStanowisko.TabIndex = 5;
            // 
            // txtNarzedzie
            // 
            this.txtNarzedzie.Location = new System.Drawing.Point(374, 79);
            this.txtNarzedzie.Name = "txtNarzedzie";
            this.txtNarzedzie.Size = new System.Drawing.Size(167, 22);
            this.txtNarzedzie.TabIndex = 6;
            // 
            // txtIlosc
            // 
            this.txtIlosc.Location = new System.Drawing.Point(547, 79);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(138, 22);
            this.txtIlosc.TabIndex = 7;
            // 
            // txtMaszyny
            // 
            this.txtMaszyny.Location = new System.Drawing.Point(691, 79);
            this.txtMaszyny.Name = "txtMaszyny";
            this.txtMaszyny.Size = new System.Drawing.Size(340, 22);
            this.txtMaszyny.TabIndex = 8;
            // 
            // btnDodajStanowisko
            // 
            this.btnDodajStanowisko.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajStanowisko.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStanowisko.Location = new System.Drawing.Point(53, 317);
            this.btnDodajStanowisko.Name = "btnDodajStanowisko";
            this.btnDodajStanowisko.Size = new System.Drawing.Size(180, 45);
            this.btnDodajStanowisko.TabIndex = 9;
            this.btnDodajStanowisko.Text = "Dodaj Stanowisko";
            this.btnDodajStanowisko.UseVisualStyleBackColor = false;
            this.btnDodajStanowisko.Click += new System.EventHandler(this.btnDodajStanowisko_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(239, 319);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(174, 41);
            this.btnUsun.TabIndex = 10;
            this.btnUsun.Text = "Usuń stanowisko";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodajNarzedzie
            // 
            this.btnDodajNarzedzie.Location = new System.Drawing.Point(199, 549);
            this.btnDodajNarzedzie.Name = "btnDodajNarzedzie";
            this.btnDodajNarzedzie.Size = new System.Drawing.Size(160, 44);
            this.btnDodajNarzedzie.TabIndex = 11;
            this.btnDodajNarzedzie.Text = "Dodaj narzędzie do stanowiska";
            this.btnDodajNarzedzie.UseVisualStyleBackColor = true;
            this.btnDodajNarzedzie.Click += new System.EventHandler(this.btnDodajNarzedzie_Click);
            // 
            // btnUsunNarzedzie
            // 
            this.btnUsunNarzedzie.Location = new System.Drawing.Point(365, 549);
            this.btnUsunNarzedzie.Name = "btnUsunNarzedzie";
            this.btnUsunNarzedzie.Size = new System.Drawing.Size(176, 44);
            this.btnUsunNarzedzie.TabIndex = 12;
            this.btnUsunNarzedzie.Text = "Usuń narzędzie na stanowisku";
            this.btnUsunNarzedzie.UseVisualStyleBackColor = true;
            this.btnUsunNarzedzie.Click += new System.EventHandler(this.btnUsunNarzedzie_Click);
            // 
            // btnDodajMaszyne
            // 
            this.btnDodajMaszyne.Location = new System.Drawing.Point(547, 549);
            this.btnDodajMaszyne.Name = "btnDodajMaszyne";
            this.btnDodajMaszyne.Size = new System.Drawing.Size(170, 44);
            this.btnDodajMaszyne.TabIndex = 13;
            this.btnDodajMaszyne.Text = "Dodaj maszynę do stanowiska";
            this.btnDodajMaszyne.UseVisualStyleBackColor = true;
            this.btnDodajMaszyne.Click += new System.EventHandler(this.btnDodajMaszyne_Click);
            // 
            // btnUsun2
            // 
            this.btnUsun2.Location = new System.Drawing.Point(723, 549);
            this.btnUsun2.Name = "btnUsun2";
            this.btnUsun2.Size = new System.Drawing.Size(161, 44);
            this.btnUsun2.TabIndex = 14;
            this.btnUsun2.Text = "Usuń narzędzie na stanowisku";
            this.btnUsun2.UseVisualStyleBackColor = true;
            this.btnUsun2.Click += new System.EventHandler(this.btnUsun2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Wybierz rodzaj stanowiska";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(370, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Wybierz narzędzie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(543, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ilość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(687, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Wybierz dostępną maszynę";
            // 
            // FormSkladStanowisko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1085, 614);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsun2);
            this.Controls.Add(this.btnDodajMaszyne);
            this.Controls.Add(this.btnUsunNarzedzie);
            this.Controls.Add(this.btnDodajNarzedzie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodajStanowisko);
            this.Controls.Add(this.txtMaszyny);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.txtNarzedzie);
            this.Controls.Add(this.txtStanowisko);
            this.Controls.Add(this.dgvSkladMaszyny);
            this.Controls.Add(this.dgvSkladNarzedzia);
            this.Controls.Add(this.dgvMaszyny);
            this.Controls.Add(this.dgvNarzedzia);
            this.Controls.Add(this.dgvStanowisko);
            this.Name = "FormSkladStanowisko";
            this.Text = "Dodawanie stanowiska";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanowisko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladNarzedzia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladMaszyny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStanowisko;
        private System.Windows.Forms.DataGridView dgvNarzedzia;
        private System.Windows.Forms.DataGridView dgvMaszyny;
        private System.Windows.Forms.DataGridView dgvSkladNarzedzia;
        private System.Windows.Forms.DataGridView dgvSkladMaszyny;
        private System.Windows.Forms.TextBox txtStanowisko;
        private System.Windows.Forms.TextBox txtNarzedzie;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.TextBox txtMaszyny;
        private System.Windows.Forms.Button btnDodajStanowisko;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodajNarzedzie;
        private System.Windows.Forms.Button btnUsunNarzedzie;
        private System.Windows.Forms.Button btnDodajMaszyne;
        private System.Windows.Forms.Button btnUsun2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}