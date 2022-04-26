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
            this.dgvWorker.Location = new System.Drawing.Point(9, 347);
            this.dgvWorker.Margin = new System.Windows.Forms.Padding(2);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.RowHeadersWidth = 51;
            this.dgvWorker.RowTemplate.Height = 24;
            this.dgvWorker.Size = new System.Drawing.Size(1246, 330);
            this.dgvWorker.TabIndex = 58;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAddnew.Location = new System.Drawing.Point(697, 35);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(151, 24);
            this.btnAddnew.TabIndex = 57;
            this.btnAddnew.Text = "Nowa umowa";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(454, 125);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 24);
            this.btnRefresh.TabIndex = 56;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSearch.Location = new System.Drawing.Point(454, 35);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 24);
            this.btnSearch.TabIndex = 55;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbStanowiskoU
            // 
            this.tbStanowiskoU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbStanowiskoU.Location = new System.Drawing.Point(176, 303);
            this.tbStanowiskoU.Margin = new System.Windows.Forms.Padding(2);
            this.tbStanowiskoU.Name = "tbStanowiskoU";
            this.tbStanowiskoU.Size = new System.Drawing.Size(152, 26);
            this.tbStanowiskoU.TabIndex = 54;
            // 
            // tbDzialU
            // 
            this.tbDzialU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbDzialU.Location = new System.Drawing.Point(176, 222);
            this.tbDzialU.Margin = new System.Windows.Forms.Padding(2);
            this.tbDzialU.Name = "tbDzialU";
            this.tbDzialU.Size = new System.Drawing.Size(152, 26);
            this.tbDzialU.TabIndex = 53;
            // 
            // tbNazwiskoU
            // 
            this.tbNazwiskoU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbNazwiskoU.Location = new System.Drawing.Point(176, 129);
            this.tbNazwiskoU.Margin = new System.Windows.Forms.Padding(2);
            this.tbNazwiskoU.Name = "tbNazwiskoU";
            this.tbNazwiskoU.Size = new System.Drawing.Size(152, 26);
            this.tbNazwiskoU.TabIndex = 52;
            // 
            // tbImieU
            // 
            this.tbImieU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbImieU.Location = new System.Drawing.Point(176, 34);
            this.tbImieU.Margin = new System.Windows.Forms.Padding(2);
            this.tbImieU.Name = "tbImieU";
            this.tbImieU.Size = new System.Drawing.Size(152, 26);
            this.tbImieU.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(66, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Stanowisko";
            // 
            // lblDzial
            // 
            this.lblDzial.AutoSize = true;
            this.lblDzial.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblDzial.Location = new System.Drawing.Point(66, 224);
            this.lblDzial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDzial.Name = "lblDzial";
            this.lblDzial.Size = new System.Drawing.Size(42, 20);
            this.lblDzial.TabIndex = 49;
            this.lblDzial.Text = "Dział:";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNazwisko.Location = new System.Drawing.Point(66, 129);
            this.lblNazwisko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(70, 20);
            this.lblNazwisko.TabIndex = 48;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblImie.Location = new System.Drawing.Point(66, 39);
            this.lblImie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(38, 20);
            this.lblImie.TabIndex = 47;
            this.lblImie.Text = "Imię:";
            // 
            // FormHRDepartmentWorkerContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
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
            this.Text = "FormHRDepartmentWorkerContract";
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