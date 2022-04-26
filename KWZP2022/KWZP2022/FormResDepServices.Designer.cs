namespace KWZP2022
{
    partial class FormResDepServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResDepServices));
            this.dgvCompletedServices = new System.Windows.Forms.DataGridView();
            this.dgvOngoingServices = new System.Windows.Forms.DataGridView();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnCloseService = new System.Windows.Forms.Button();
            this.lblObslugi = new System.Windows.Forms.Label();
            this.btnPrzypiszPracownika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOngoingServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompletedServices
            // 
            this.dgvCompletedServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCompletedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletedServices.Location = new System.Drawing.Point(12, 211);
            this.dgvCompletedServices.Name = "dgvCompletedServices";
            this.dgvCompletedServices.Size = new System.Drawing.Size(500, 464);
            this.dgvCompletedServices.TabIndex = 0;
            // 
            // dgvOngoingServices
            // 
            this.dgvOngoingServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvOngoingServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOngoingServices.Location = new System.Drawing.Point(574, 211);
            this.dgvOngoingServices.Name = "dgvOngoingServices";
            this.dgvOngoingServices.Size = new System.Drawing.Size(466, 464);
            this.dgvOngoingServices.TabIndex = 1;
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddService.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddService.Location = new System.Drawing.Point(12, 100);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(283, 65);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Dodaj nową obsługę";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnCloseService
            // 
            this.btnCloseService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCloseService.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCloseService.Location = new System.Drawing.Point(574, 100);
            this.btnCloseService.Name = "btnCloseService";
            this.btnCloseService.Size = new System.Drawing.Size(256, 65);
            this.btnCloseService.TabIndex = 3;
            this.btnCloseService.Text = "Zakończ obsługę";
            this.btnCloseService.UseVisualStyleBackColor = false;
            this.btnCloseService.Click += new System.EventHandler(this.btnCloseService_Click);
            // 
            // lblObslugi
            // 
            this.lblObslugi.AutoSize = true;
            this.lblObslugi.BackColor = System.Drawing.Color.Transparent;
            this.lblObslugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObslugi.Location = new System.Drawing.Point(37, 9);
            this.lblObslugi.Name = "lblObslugi";
            this.lblObslugi.Size = new System.Drawing.Size(852, 67);
            this.lblObslugi.TabIndex = 4;
            this.lblObslugi.Text = "Zakończone i trwające obsługi";
            // 
            // btnPrzypiszPracownika
            // 
            this.btnPrzypiszPracownika.BackColor = System.Drawing.Color.Yellow;
            this.btnPrzypiszPracownika.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzypiszPracownika.Location = new System.Drawing.Point(1046, 211);
            this.btnPrzypiszPracownika.Name = "btnPrzypiszPracownika";
            this.btnPrzypiszPracownika.Size = new System.Drawing.Size(216, 71);
            this.btnPrzypiszPracownika.TabIndex = 77;
            this.btnPrzypiszPracownika.Text = "Przypisz Pracowników";
            this.btnPrzypiszPracownika.UseVisualStyleBackColor = false;
            this.btnPrzypiszPracownika.Click += new System.EventHandler(this.btnPrzypiszPracownika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 78;
            this.label1.Text = "Zakończone obsługi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(570, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 79;
            this.label2.Text = "Trwające obsługi:";
            // 
            // FormResDepServices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1274, 711);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrzypiszPracownika);
            this.Controls.Add(this.lblObslugi);
            this.Controls.Add(this.btnCloseService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.dgvOngoingServices);
            this.Controls.Add(this.dgvCompletedServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResDepServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Obsługi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOngoingServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompletedServices;
        private System.Windows.Forms.DataGridView dgvOngoingServices;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnCloseService;
        private System.Windows.Forms.Label lblObslugi;
        private System.Windows.Forms.Button btnPrzypiszPracownika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}