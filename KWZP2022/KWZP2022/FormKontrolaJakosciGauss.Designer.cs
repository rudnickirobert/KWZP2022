namespace KWZP2022
{
    partial class FormKontrolaJakosciGauss
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPDataDo = new System.Windows.Forms.DateTimePicker();
            this.dTPDataOd = new System.Windows.Forms.DateTimePicker();
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.cbParametr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Wybierz produkt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(19, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Wybierz parametr:";
            // 
            // dTPDataDo
            // 
            this.dTPDataDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dTPDataDo.Location = new System.Drawing.Point(24, 353);
            this.dTPDataDo.Name = "dTPDataDo";
            this.dTPDataDo.Size = new System.Drawing.Size(202, 26);
            this.dTPDataDo.TabIndex = 71;
            // 
            // dTPDataOd
            // 
            this.dTPDataOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dTPDataOd.Location = new System.Drawing.Point(24, 276);
            this.dTPDataOd.Name = "dTPDataOd";
            this.dTPDataOd.Size = new System.Drawing.Size(202, 26);
            this.dTPDataOd.TabIndex = 70;
            // 
            // cbProdukt
            // 
            this.cbProdukt.Font = new System.Drawing.Font("Arial", 12F);
            this.cbProdukt.FormattingEnabled = true;
            this.cbProdukt.Location = new System.Drawing.Point(24, 51);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(349, 26);
            this.cbProdukt.TabIndex = 72;
            this.cbProdukt.SelectedIndexChanged += new System.EventHandler(this.cbProdukt_SelectedIndexChanged);
            // 
            // cbParametr
            // 
            this.cbParametr.Font = new System.Drawing.Font("Arial", 12F);
            this.cbParametr.FormattingEnabled = true;
            this.cbParametr.Location = new System.Drawing.Point(24, 153);
            this.cbParametr.Name = "cbParametr";
            this.cbParametr.Size = new System.Drawing.Size(349, 26);
            this.cbParametr.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(19, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "Okres do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.Location = new System.Drawing.Point(19, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Okres od:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(24, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 53);
            this.button1.TabIndex = 76;
            this.button1.Text = "Generuj rozkład Gaussa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormKontrolaJakosciGauss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbParametr);
            this.Controls.Add(this.cbProdukt);
            this.Controls.Add(this.dTPDataDo);
            this.Controls.Add(this.dTPDataOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKontrolaJakosciGauss";
            this.Text = "FormKontrolaJakosciGauss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPDataDo;
        private System.Windows.Forms.DateTimePicker dTPDataOd;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.ComboBox cbParametr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}