﻿namespace KWZP2022
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
            this.btnNieobecnosci = new System.Windows.Forms.Button();
            this.dgvWorker = new System.Windows.Forms.DataGridView();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnChangedata = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbPositionSelected = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNieobecnosci
            // 
            this.btnNieobecnosci.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnNieobecnosci.Location = new System.Drawing.Point(1271, 94);
            this.btnNieobecnosci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNieobecnosci.Name = "btnNieobecnosci";
            this.btnNieobecnosci.Size = new System.Drawing.Size(201, 30);
            this.btnNieobecnosci.TabIndex = 50;
            this.btnNieobecnosci.Text = " Nieobecności";
            this.btnNieobecnosci.UseVisualStyleBackColor = true;
            this.btnNieobecnosci.Click += new System.EventHandler(this.btnNieobecnosci_Click);
            // 
            // dgvWorker
            // 
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Location = new System.Drawing.Point(9, 269);
            this.dgvWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.RowHeadersWidth = 51;
            this.dgvWorker.RowTemplate.Height = 24;
            this.dgvWorker.Size = new System.Drawing.Size(1661, 592);
            this.dgvWorker.TabIndex = 49;
            // 
            // btnContract
            // 
            this.btnContract.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnContract.Location = new System.Drawing.Point(1271, 151);
            this.btnContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(201, 30);
            this.btnContract.TabIndex = 48;
            this.btnContract.Text = "Umowa";
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnChangedata
            // 
            this.btnChangedata.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnChangedata.Location = new System.Drawing.Point(929, 151);
            this.btnChangedata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangedata.Name = "btnChangedata";
            this.btnChangedata.Size = new System.Drawing.Size(201, 30);
            this.btnChangedata.TabIndex = 47;
            this.btnChangedata.Text = "Zmień dane";
            this.btnChangedata.UseVisualStyleBackColor = true;
            this.btnChangedata.Click += new System.EventHandler(this.btnChangedata_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAddnew.Location = new System.Drawing.Point(929, 95);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(201, 30);
            this.btnAddnew.TabIndex = 46;
            this.btnAddnew.Text = "Nowy pracownik";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(605, 151);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(201, 30);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSearch.Location = new System.Drawing.Point(605, 95);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(201, 30);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbNazwisko.Location = new System.Drawing.Point(235, 149);
            this.tbNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(201, 26);
            this.tbNazwisko.TabIndex = 41;
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbImie.Location = new System.Drawing.Point(235, 94);
            this.tbImie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(201, 26);
            this.tbImie.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(88, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Stanowisko";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNazwisko.Location = new System.Drawing.Point(88, 149);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(70, 20);
            this.lblNazwisko.TabIndex = 37;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.BackColor = System.Drawing.Color.Transparent;
            this.lblImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblImie.Location = new System.Drawing.Point(88, 100);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(38, 20);
            this.lblImie.TabIndex = 36;
            this.lblImie.Text = "Imię:";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(235, 205);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(201, 24);
            this.cbPosition.TabIndex = 51;
            // 
            // cbPositionSelected
            // 
            this.cbPositionSelected.AutoSize = true;
            this.cbPositionSelected.Location = new System.Drawing.Point(458, 209);
            this.cbPositionSelected.Name = "cbPositionSelected";
            this.cbPositionSelected.Size = new System.Drawing.Size(15, 14);
            this.cbPositionSelected.TabIndex = 52;
            this.cbPositionSelected.UseVisualStyleBackColor = true;
            // 
            // FormHRDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1685, 875);
            this.Controls.Add(this.cbPositionSelected);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.btnNieobecnosci);
            this.Controls.Add(this.dgvWorker);
            this.Controls.Add(this.btnContract);
            this.Controls.Add(this.btnChangedata);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHRDepartment";
            this.Text = "Pracownicy i umowy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNieobecnosci;
        private System.Windows.Forms.DataGridView dgvWorker;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnChangedata;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.CheckBox cbPositionSelected;
    }
}