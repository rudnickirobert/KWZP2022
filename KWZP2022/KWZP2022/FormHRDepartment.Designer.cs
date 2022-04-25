
namespace KWZP2022
{
    partial class FormHRDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRDepartment));
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblImie.Location = new System.Drawing.Point(66, 63);
            this.lblImie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(38, 20);
            this.lblImie.TabIndex = 7;
            this.lblImie.Text = "Imię:";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNazwisko.Location = new System.Drawing.Point(66, 154);
            this.lblNazwisko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(70, 20);
            this.lblNazwisko.TabIndex = 8;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // lblDzial
            // 
            this.lblDzial.AutoSize = true;
            this.lblDzial.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblDzial.Location = new System.Drawing.Point(66, 249);
            this.lblDzial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDzial.Name = "lblDzial";
            this.lblDzial.Size = new System.Drawing.Size(42, 20);
            this.lblDzial.TabIndex = 9;
            this.lblDzial.Text = "Dział:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(66, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stanowisko";
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbImie.Location = new System.Drawing.Point(176, 58);
            this.tbImie.Margin = new System.Windows.Forms.Padding(2);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(152, 26);
            this.tbImie.TabIndex = 11;
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbNazwisko.Location = new System.Drawing.Point(176, 154);
            this.tbNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(152, 26);
            this.tbNazwisko.TabIndex = 12;
            // 
            // tbDzial
            // 
            this.tbDzial.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbDzial.Location = new System.Drawing.Point(176, 246);
            this.tbDzial.Margin = new System.Windows.Forms.Padding(2);
            this.tbDzial.Name = "tbDzial";
            this.tbDzial.Size = new System.Drawing.Size(152, 26);
            this.tbDzial.TabIndex = 13;
            // 
            // tbStanowisko
            // 
            this.tbStanowisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbStanowisko.Location = new System.Drawing.Point(176, 327);
            this.tbStanowisko.Margin = new System.Windows.Forms.Padding(2);
            this.tbStanowisko.Name = "tbStanowisko";
            this.tbStanowisko.Size = new System.Drawing.Size(152, 26);
            this.tbStanowisko.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSearch.Location = new System.Drawing.Point(454, 59);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 24);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(454, 150);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 24);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAddnew.Location = new System.Drawing.Point(697, 59);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(151, 24);
            this.btnAddnew.TabIndex = 17;
            this.btnAddnew.Text = "Nowy pracownik";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnChangedata
            // 
            this.btnChangedata.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnChangedata.Location = new System.Drawing.Point(697, 152);
            this.btnChangedata.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangedata.Name = "btnChangedata";
            this.btnChangedata.Size = new System.Drawing.Size(151, 24);
            this.btnChangedata.TabIndex = 18;
            this.btnChangedata.Text = "Zmień dane";
            this.btnChangedata.UseVisualStyleBackColor = true;
            // 
            // btnContract
            // 
            this.btnContract.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnContract.Location = new System.Drawing.Point(697, 245);
            this.btnContract.Margin = new System.Windows.Forms.Padding(2);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(151, 24);
            this.btnContract.TabIndex = 19;
            this.btnContract.Text = "Umowa";
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // dgvWorker
            // 
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Location = new System.Drawing.Point(9, 282);
            this.dgvWorker.Margin = new System.Windows.Forms.Padding(2);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.RowHeadersWidth = 51;
            this.dgvWorker.RowTemplate.Height = 24;
            this.dgvWorker.Size = new System.Drawing.Size(1246, 334);
            this.dgvWorker.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1083, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHRDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.button1);
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
            this.Name = "FormHRDepartment";
            this.Text = "Pracownik";
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
        private System.Windows.Forms.Button button1;
    }
}