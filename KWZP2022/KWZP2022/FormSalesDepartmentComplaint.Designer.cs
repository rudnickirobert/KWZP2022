
namespace KWZP2022
{
    partial class FormSalesDepartmentComplaint
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
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.dgvComplaint = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBoxNoSale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNoComplaint = new System.Windows.Forms.TextBox();
            this.dtpDateComplaint = new System.Windows.Forms.DateTimePicker();
            this.cbDateComplaint = new System.Windows.Forms.CheckBox();
            this.cbAcceptComplaintYes = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbAcceptComplaintNO = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReturn.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAddReturn.Location = new System.Drawing.Point(321, 449);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(152, 30);
            this.btnAddReturn.TabIndex = 0;
            this.btnAddReturn.Text = "Dodaj Zwrot";
            this.btnAddReturn.UseVisualStyleBackColor = true;
            this.btnAddReturn.Click += new System.EventHandler(this.btnAddReturn_Click);
            // 
            // dgvComplaint
            // 
            this.dgvComplaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaint.Location = new System.Drawing.Point(12, 176);
            this.dgvComplaint.Name = "dgvComplaint";
            this.dgvComplaint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaint.Size = new System.Drawing.Size(770, 255);
            this.dgvComplaint.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial", 10F);
            this.btnClose.Location = new System.Drawing.Point(630, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBoxNoSale
            // 
            this.textBoxNoSale.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxNoSale.Location = new System.Drawing.Point(12, 42);
            this.textBoxNoSale.Name = "textBoxNoSale";
            this.textBoxNoSale.Size = new System.Drawing.Size(156, 23);
            this.textBoxNoSale.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numer sprzedaży:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numer reklamacji:";
            // 
            // textBoxNoComplaint
            // 
            this.textBoxNoComplaint.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxNoComplaint.Location = new System.Drawing.Point(12, 125);
            this.textBoxNoComplaint.Name = "textBoxNoComplaint";
            this.textBoxNoComplaint.Size = new System.Drawing.Size(156, 23);
            this.textBoxNoComplaint.TabIndex = 5;
            // 
            // dtpDateComplaint
            // 
            this.dtpDateComplaint.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpDateComplaint.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateComplaint.Location = new System.Drawing.Point(244, 42);
            this.dtpDateComplaint.Name = "dtpDateComplaint";
            this.dtpDateComplaint.Size = new System.Drawing.Size(111, 23);
            this.dtpDateComplaint.TabIndex = 7;
            // 
            // cbDateComplaint
            // 
            this.cbDateComplaint.AutoSize = true;
            this.cbDateComplaint.BackColor = System.Drawing.Color.Transparent;
            this.cbDateComplaint.Location = new System.Drawing.Point(371, 47);
            this.cbDateComplaint.Name = "cbDateComplaint";
            this.cbDateComplaint.Size = new System.Drawing.Size(15, 14);
            this.cbDateComplaint.TabIndex = 8;
            this.cbDateComplaint.UseVisualStyleBackColor = false;
            // 
            // cbAcceptComplaintYes
            // 
            this.cbAcceptComplaintYes.AutoSize = true;
            this.cbAcceptComplaintYes.BackColor = System.Drawing.Color.Transparent;
            this.cbAcceptComplaintYes.Font = new System.Drawing.Font("Arial", 10F);
            this.cbAcceptComplaintYes.Location = new System.Drawing.Point(244, 128);
            this.cbAcceptComplaintYes.Name = "cbAcceptComplaintYes";
            this.cbAcceptComplaintYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAcceptComplaintYes.Size = new System.Drawing.Size(52, 20);
            this.cbAcceptComplaintYes.TabIndex = 9;
            this.cbAcceptComplaintYes.Text = "TAK";
            this.cbAcceptComplaintYes.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSearch.Location = new System.Drawing.Point(483, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(660, 121);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 30);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbAcceptComplaintNO
            // 
            this.cbAcceptComplaintNO.AutoSize = true;
            this.cbAcceptComplaintNO.BackColor = System.Drawing.Color.Transparent;
            this.cbAcceptComplaintNO.Font = new System.Drawing.Font("Arial", 10F);
            this.cbAcceptComplaintNO.Location = new System.Drawing.Point(333, 128);
            this.cbAcceptComplaintNO.Name = "cbAcceptComplaintNO";
            this.cbAcceptComplaintNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAcceptComplaintNO.Size = new System.Drawing.Size(47, 20);
            this.cbAcceptComplaintNO.TabIndex = 12;
            this.cbAcceptComplaintNO.Text = "NIE";
            this.cbAcceptComplaintNO.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(241, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Czy akceptowano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(241, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data reklamacji:";
            // 
            // FormSalesDepartmentComplaint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background_small;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAcceptComplaintNO);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbAcceptComplaintYes);
            this.Controls.Add(this.cbDateComplaint);
            this.Controls.Add(this.dtpDateComplaint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNoComplaint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNoSale);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvComplaint);
            this.Controls.Add(this.btnAddReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSalesDepartmentComplaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reklamacja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddReturn;
        private System.Windows.Forms.DataGridView dgvComplaint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBoxNoSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNoComplaint;
        private System.Windows.Forms.DateTimePicker dtpDateComplaint;
        private System.Windows.Forms.CheckBox cbDateComplaint;
        private System.Windows.Forms.CheckBox cbAcceptComplaintYes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox cbAcceptComplaintNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}