namespace KWZP2022
{
    partial class FormHRDepartmentWorkerSalary
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
            this.dgvsalary = new System.Windows.Forms.DataGridView();
            this.tbyear = new System.Windows.Forms.TextBox();
            this.tbmonth = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsalary
            // 
            this.dgvsalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalary.Location = new System.Drawing.Point(21, 133);
            this.dgvsalary.Name = "dgvsalary";
            this.dgvsalary.RowHeadersWidth = 51;
            this.dgvsalary.RowTemplate.Height = 24;
            this.dgvsalary.Size = new System.Drawing.Size(751, 346);
            this.dgvsalary.TabIndex = 0;
            // 
            // tbyear
            // 
            this.tbyear.Location = new System.Drawing.Point(66, 62);
            this.tbyear.Name = "tbyear";
            this.tbyear.Size = new System.Drawing.Size(100, 22);
            this.tbyear.TabIndex = 1;
            // 
            // tbmonth
            // 
            this.tbmonth.Location = new System.Drawing.Point(266, 62);
            this.tbmonth.Name = "tbmonth";
            this.tbmonth.Size = new System.Drawing.Size(100, 22);
            this.tbmonth.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(624, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormHRDepartmentWorkerSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbmonth);
            this.Controls.Add(this.tbyear);
            this.Controls.Add(this.dgvsalary);
            this.Name = "FormHRDepartmentWorkerSalary";
            this.Text = "Wynagrodzenie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsalary;
        private System.Windows.Forms.TextBox tbyear;
        private System.Windows.Forms.TextBox tbmonth;
        private System.Windows.Forms.Button btnSearch;
    }
}