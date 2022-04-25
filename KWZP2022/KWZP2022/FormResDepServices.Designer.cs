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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOngoingServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompletedServices
            // 
            this.dgvCompletedServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCompletedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletedServices.Location = new System.Drawing.Point(12, 241);
            this.dgvCompletedServices.Name = "dgvCompletedServices";
            this.dgvCompletedServices.Size = new System.Drawing.Size(619, 419);
            this.dgvCompletedServices.TabIndex = 0;
            // 
            // dgvOngoingServices
            // 
            this.dgvOngoingServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvOngoingServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOngoingServices.Location = new System.Drawing.Point(643, 241);
            this.dgvOngoingServices.Name = "dgvOngoingServices";
            this.dgvOngoingServices.Size = new System.Drawing.Size(619, 419);
            this.dgvOngoingServices.TabIndex = 1;
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddService.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddService.Location = new System.Drawing.Point(98, 100);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(443, 120);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Dodaj nową obsługę";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnCloseService
            // 
            this.btnCloseService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCloseService.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCloseService.Location = new System.Drawing.Point(743, 100);
            this.btnCloseService.Name = "btnCloseService";
            this.btnCloseService.Size = new System.Drawing.Size(443, 120);
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
            // FormResDepServices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1274, 711);
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
    }
}