
namespace KWZP2022
{
    partial class StartForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnMarketing = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj użyktowniku!";
            // 
            // btnMarketing
            // 
            this.btnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarketing.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMarketing.Location = new System.Drawing.Point(311, 261);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(291, 95);
            this.btnMarketing.TabIndex = 1;
            this.btnMarketing.Text = "Marketing i handel";
            this.btnMarketing.UseVisualStyleBackColor = true;
            // 
            // btnProduction
            // 
            this.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProduction.Location = new System.Drawing.Point(311, 386);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProduction.Size = new System.Drawing.Size(291, 95);
            this.btnProduction.TabIndex = 2;
            this.btnProduction.Text = "Produkcja";
            this.btnProduction.UseVisualStyleBackColor = true;
            // 
            // btnHR
            // 
            this.btnHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHR.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHR.Location = new System.Drawing.Point(658, 261);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(244, 95);
            this.btnHR.TabIndex = 3;
            this.btnHR.Text = "Kadry i przygotowanie produkcji";
            this.btnHR.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(658, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 95);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zasoby i dostawy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(1132, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnMarketing);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMarketing;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button button1;
    }
}

