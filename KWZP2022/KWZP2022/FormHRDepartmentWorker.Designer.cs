
namespace KWZP2022
{
    partial class FormHRDepartmentWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRDepartmentWorker));
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblDzial = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbDzial = new System.Windows.Forms.TextBox();
            this.tbStanowisko = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnChangedata = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.dgvWorker = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblImie.Location = new System.Drawing.Point(88, 78);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(47, 24);
            this.lblImie.TabIndex = 7;
            this.lblImie.Text = "Imię:";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNazwisko.Location = new System.Drawing.Point(88, 189);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(85, 24);
            this.lblNazwisko.TabIndex = 8;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // lblDzial
            // 
            this.lblDzial.AutoSize = true;
            this.lblDzial.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblDzial.Location = new System.Drawing.Point(88, 306);
            this.lblDzial.Name = "lblDzial";
            this.lblDzial.Size = new System.Drawing.Size(50, 24);
            this.lblDzial.TabIndex = 9;
            this.lblDzial.Text = "Dział:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(88, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stanowisko";
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbImie.Location = new System.Drawing.Point(234, 72);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(201, 30);
            this.tbImie.TabIndex = 11;
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbNazwisko.Location = new System.Drawing.Point(234, 189);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(201, 30);
            this.tbNazwisko.TabIndex = 12;
            // 
            // tbDzial
            // 
            this.tbDzial.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbDzial.Location = new System.Drawing.Point(234, 303);
            this.tbDzial.Name = "tbDzial";
            this.tbDzial.Size = new System.Drawing.Size(201, 30);
            this.tbDzial.TabIndex = 13;
            // 
            // tbStanowisko
            // 
            this.tbStanowisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbStanowisko.Location = new System.Drawing.Point(234, 403);
            this.tbStanowisko.Name = "tbStanowisko";
            this.tbStanowisko.Size = new System.Drawing.Size(201, 30);
            this.tbStanowisko.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSearch.Location = new System.Drawing.Point(606, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(201, 30);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(606, 184);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(201, 30);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAddnew.Location = new System.Drawing.Point(929, 73);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(201, 30);
            this.btnAddnew.TabIndex = 17;
            this.btnAddnew.Text = "Nowy pracownik";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnChangedata
            // 
            this.btnChangedata.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnChangedata.Location = new System.Drawing.Point(929, 187);
            this.btnChangedata.Name = "btnChangedata";
            this.btnChangedata.Size = new System.Drawing.Size(201, 30);
            this.btnChangedata.TabIndex = 18;
            this.btnChangedata.Text = "Zmień dane";
            this.btnChangedata.UseVisualStyleBackColor = true;
            this.btnChangedata.Click += new System.EventHandler(this.btnChangedata_Click);
            // 
            // btnContract
            // 
            this.btnContract.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnContract.Location = new System.Drawing.Point(929, 301);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(201, 30);
            this.btnContract.TabIndex = 19;
            this.btnContract.Text = "Umowa";
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // dgvWorker
            // 
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Location = new System.Drawing.Point(12, 457);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.RowHeadersWidth = 51;
            this.dgvWorker.RowTemplate.Height = 24;
            this.dgvWorker.Size = new System.Drawing.Size(1661, 406);
            this.dgvWorker.TabIndex = 20;
            // 
            // FormHRDepartmentWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 875);
            this.Controls.Add(this.dgvWorker);
            this.Controls.Add(this.btnContract);
            this.Controls.Add(this.btnChangedata);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbStanowisko);
            this.Controls.Add(this.tbDzial);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDzial);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHRDepartmentWorker";
            this.Text = "Dział zasobów ludzkich";

            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblDzial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbDzial;
        private System.Windows.Forms.TextBox tbStanowisko;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnChangedata;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.DataGridView dgvWorker;
    }
}