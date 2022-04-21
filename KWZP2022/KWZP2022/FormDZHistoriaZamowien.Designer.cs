
namespace KWZP2022
{
    partial class FormDZHistoriaZamowien
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
            this.dgv_Historia_Zam = new System.Windows.Forms.DataGridView();
            this.lab_Nazwa = new System.Windows.Forms.Label();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historia_Zam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Historia_Zam
            // 
            this.dgv_Historia_Zam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Historia_Zam.Location = new System.Drawing.Point(32, 112);
            this.dgv_Historia_Zam.Name = "dgv_Historia_Zam";
            this.dgv_Historia_Zam.Size = new System.Drawing.Size(756, 326);
            this.dgv_Historia_Zam.TabIndex = 0;
            // 
            // lab_Nazwa
            // 
            this.lab_Nazwa.AutoSize = true;
            this.lab_Nazwa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lab_Nazwa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_Nazwa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_Nazwa.Location = new System.Drawing.Point(28, 85);
            this.lab_Nazwa.Name = "lab_Nazwa";
            this.lab_Nazwa.Size = new System.Drawing.Size(186, 24);
            this.lab_Nazwa.TabIndex = 2;
            this.lab_Nazwa.Text = "Historia zamówień:";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Refresh.Location = new System.Drawing.Point(32, 21);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(102, 36);
            this.Btn_Refresh.TabIndex = 4;
            this.Btn_Refresh.Text = "Odśwież";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // FormDZHistoriaZamowien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.lab_Nazwa);
            this.Controls.Add(this.dgv_Historia_Zam);
            this.Name = "FormDZHistoriaZamowien";
            this.Text = "Historia Zamowień";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historia_Zam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Historia_Zam;
        private System.Windows.Forms.Label lab_Nazwa;
        private System.Windows.Forms.Button Btn_Refresh;
    }
}