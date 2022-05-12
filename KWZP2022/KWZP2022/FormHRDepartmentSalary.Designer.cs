namespace KWZP2022
{
    partial class FormHRDepartmentSalary
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRDepartmentSalary));
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.lblImie = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNewSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalary
            // 
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Location = new System.Drawing.Point(22, 275);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.Size = new System.Drawing.Size(1217, 390);
            this.dgvSalary.TabIndex = 0;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.BackColor = System.Drawing.Color.Transparent;
            this.lblImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblImie.Location = new System.Drawing.Point(97, 60);
            this.lblImie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(38, 20);
            this.lblImie.TabIndex = 37;
            this.lblImie.Text = "Imię:";
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbImie.Location = new System.Drawing.Point(179, 57);
            this.tbImie.Margin = new System.Windows.Forms.Padding(2);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(152, 26);
            this.tbImie.TabIndex = 41;
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNazwisko.Location = new System.Drawing.Point(97, 114);
            this.lblNazwisko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(70, 20);
            this.lblNazwisko.TabIndex = 42;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbNazwisko.Location = new System.Drawing.Point(179, 108);
            this.tbNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(152, 26);
            this.tbNazwisko.TabIndex = 43;
            // 
            // tbMonth
            // 
            this.tbMonth.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbMonth.Location = new System.Drawing.Point(179, 159);
            this.tbMonth.Margin = new System.Windows.Forms.Padding(2);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(152, 26);
            this.tbMonth.TabIndex = 44;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblMonth.Location = new System.Drawing.Point(97, 162);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(83, 20);
            this.lblMonth.TabIndex = 45;
            this.lblMonth.Text = "Nr miesiąca:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSearch.Location = new System.Drawing.Point(351, 57);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 25);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(351, 111);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 24);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNewSalary
            // 
            this.btnNewSalary.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnNewSalary.Location = new System.Drawing.Point(602, 105);
            this.btnNewSalary.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewSalary.Name = "btnNewSalary";
            this.btnNewSalary.Size = new System.Drawing.Size(151, 33);
            this.btnNewSalary.TabIndex = 48;
            this.btnNewSalary.Text = "Dodaj wypłatę";
            this.btnNewSalary.UseVisualStyleBackColor = true;
            this.btnNewSalary.Click += new System.EventHandler(this.btnNewSalary_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // FormHRDepartmentSalary
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewSalary);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.dgvSalary);
            this.DoubleBuffered = true;
            this.Name = "FormHRDepartmentSalary";
            this.Text = "Pasek płacowy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNewSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
