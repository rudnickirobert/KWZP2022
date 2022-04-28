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
            this.tbNazwiskoU = new System.Windows.Forms.TextBox();
            this.tbImieU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbPositionFind = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorker
            // 
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Location = new System.Drawing.Point(12, 223);
            this.dgvWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.RowHeadersWidth = 51;
            this.dgvWorker.RowTemplate.Height = 24;
            this.dgvWorker.Size = new System.Drawing.Size(1661, 610);
            this.dgvWorker.TabIndex = 58;
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.Red;
            this.btnAddnew.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.btnAddnew.Location = new System.Drawing.Point(929, 43);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(201, 30);
            this.btnAddnew.TabIndex = 57;
            this.btnAddnew.Text = "Nowa umowa";
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Yellow;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.btnRefresh.Location = new System.Drawing.Point(605, 154);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(201, 30);
            this.btnRefresh.TabIndex = 56;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Cyan;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.btnSearch.Location = new System.Drawing.Point(605, 43);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(201, 30);
            this.btnSearch.TabIndex = 55;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbNazwiskoU
            // 
            this.tbNazwiskoU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbNazwiskoU.Location = new System.Drawing.Point(235, 102);
            this.tbNazwiskoU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNazwiskoU.Name = "tbNazwiskoU";
            this.tbNazwiskoU.Size = new System.Drawing.Size(201, 26);
            this.tbNazwiskoU.TabIndex = 52;
            // 
            // tbImieU
            // 
            this.tbImieU.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbImieU.Location = new System.Drawing.Point(235, 47);
            this.tbImieU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbImieU.Name = "tbImieU";
            this.tbImieU.Size = new System.Drawing.Size(201, 26);
            this.tbImieU.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(88, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Stanowisko";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNazwisko.Location = new System.Drawing.Point(88, 102);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(70, 20);
            this.lblNazwisko.TabIndex = 48;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.BackColor = System.Drawing.Color.Transparent;
            this.lblImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblImie.Location = new System.Drawing.Point(88, 53);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(38, 20);
            this.lblImie.TabIndex = 47;
            this.lblImie.Text = "Imię:";
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Arial", 12F);
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(235, 160);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(201, 26);
            this.cbPosition.TabIndex = 59;
            // 
            // cbPositionFind
            // 
            this.cbPositionFind.AutoSize = true;
            this.cbPositionFind.Location = new System.Drawing.Point(462, 161);
            this.cbPositionFind.Name = "cbPositionFind";
            this.cbPositionFind.Size = new System.Drawing.Size(15, 14);
            this.cbPositionFind.TabIndex = 60;
            this.cbPositionFind.UseVisualStyleBackColor = true;
            // 
            // FormHRDepartmentWorkerContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1685, 875);
            this.Controls.Add(this.cbPositionFind);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.dgvWorker);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbNazwiskoU);
            this.Controls.Add(this.tbImieU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHRDepartmentWorkerContract";
            this.Text = "Umowy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorker;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbNazwiskoU;
        private System.Windows.Forms.TextBox tbImieU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.CheckBox cbPositionFind;
    }
}