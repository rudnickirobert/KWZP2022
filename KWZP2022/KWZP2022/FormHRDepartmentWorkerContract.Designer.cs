namespace KWZP2022
{
    partial class FormHRDepartmentWorkerContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRDepartmentWorkerContract));
            this.dgvWorker = new System.Windows.Forms.DataGridView();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbStanowiskoU = new System.Windows.Forms.TextBox();
            this.tbDzialU = new System.Windows.Forms.TextBox();
            this.tbNazwiskoU = new System.Windows.Forms.TextBox();
            this.tbImieU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDzial = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorker
            // 
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Location = new System.Drawing.Point(12, 427);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.RowHeadersWidth = 51;
            this.dgvWorker.RowTemplate.Height = 24;
            this.dgvWorker.Size = new System.Drawing.Size(1661, 406);
            this.dgvWorker.TabIndex = 34;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAddnew.Location = new System.Drawing.Point(929, 43);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(201, 30);
            this.btnAddnew.TabIndex = 31;
            this.btnAddnew.Text = "Nowa umowa";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(606, 154);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(201, 30);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSearch.Location = new System.Drawing.Point(606, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(201, 30);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbStanowiskoU
            // 
            this.tbStanowiskoU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbStanowiskoU.Location = new System.Drawing.Point(234, 373);
            this.tbStanowiskoU.Name = "tbStanowiskoU";
            this.tbStanowiskoU.Size = new System.Drawing.Size(201, 30);
            this.tbStanowiskoU.TabIndex = 28;
            // 
            // tbDzialU
            // 
            this.tbDzialU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbDzialU.Location = new System.Drawing.Point(234, 273);
            this.tbDzialU.Name = "tbDzialU";
            this.tbDzialU.Size = new System.Drawing.Size(201, 30);
            this.tbDzialU.TabIndex = 27;
            // 
            // tbNazwiskoU
            // 
            this.tbNazwiskoU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbNazwiskoU.Location = new System.Drawing.Point(234, 159);
            this.tbNazwiskoU.Name = "tbNazwiskoU";
            this.tbNazwiskoU.Size = new System.Drawing.Size(201, 30);
            this.tbNazwiskoU.TabIndex = 26;
            // 
            // tbImieU
            // 
            this.tbImieU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbImieU.Location = new System.Drawing.Point(234, 42);
            this.tbImieU.Name = "tbImieU";
            this.tbImieU.Size = new System.Drawing.Size(201, 30);
            this.tbImieU.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(88, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stanowisko";
            // 
            // lblDzial
            // 
            this.lblDzial.AutoSize = true;
            this.lblDzial.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblDzial.Location = new System.Drawing.Point(88, 276);
            this.lblDzial.Name = "lblDzial";
            this.lblDzial.Size = new System.Drawing.Size(50, 24);
            this.lblDzial.TabIndex = 23;
            this.lblDzial.Text = "Dział:";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNazwisko.Location = new System.Drawing.Point(88, 159);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(85, 24);
            this.lblNazwisko.TabIndex = 22;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblImie.Location = new System.Drawing.Point(88, 48);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(47, 24);
            this.lblImie.TabIndex = 21;
            this.lblImie.Text = "Imię:";
            // 
            // FormHRDepartmentWorkerContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1685, 875);
            this.Controls.Add(this.dgvWorker);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbStanowiskoU);
            this.Controls.Add(this.tbDzialU);
            this.Controls.Add(this.tbNazwiskoU);
            this.Controls.Add(this.tbImieU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDzial);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Name = "FormHRDepartmentWorkerContract";
            this.Text = "Umowa";
            this.Load += new System.EventHandler(this.FormHRDepartmentWorkerContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorker;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbStanowiskoU;
        private System.Windows.Forms.TextBox tbDzialU;
        private System.Windows.Forms.TextBox tbNazwiskoU;
        private System.Windows.Forms.TextBox tbImieU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDzial;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblImie;
    }
}