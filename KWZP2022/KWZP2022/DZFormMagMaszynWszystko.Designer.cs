
namespace KWZP2022
{
    partial class DZFormMagMaszynWszystko
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DZFormMagMaszynWszystko));
            this.dgvMaszynyWszystko = new System.Windows.Forms.DataGridView();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.kWZPDataSet = new KWZP2022.KWZPDataSet();
            this.vMagazynmaszynwszystkoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_Magazyn_maszyn_wszystkoTableAdapter = new KWZP2022.KWZPDataSetTableAdapters.v_Magazyn_maszyn_wszystkoTableAdapter();
            this.nazwaMaszynyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbaSztukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszynyWszystko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kWZPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMagazynmaszynwszystkoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaszynyWszystko
            // 
            this.dgvMaszynyWszystko.AutoGenerateColumns = false;
            this.dgvMaszynyWszystko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszynyWszystko.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaMaszynyDataGridViewTextBoxColumn,
            this.liczbaSztukDataGridViewTextBoxColumn});
            this.dgvMaszynyWszystko.DataSource = this.vMagazynmaszynwszystkoBindingSource;
            this.dgvMaszynyWszystko.Location = new System.Drawing.Point(205, 82);
            this.dgvMaszynyWszystko.Name = "dgvMaszynyWszystko";
            this.dgvMaszynyWszystko.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaszynyWszystko.Size = new System.Drawing.Size(243, 185);
            this.dgvMaszynyWszystko.TabIndex = 99;
            this.dgvMaszynyWszystko.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaszynyWszystko_CellContentClick);
            this.dgvMaszynyWszystko.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaszynyWszystko_CellDoubleClick);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(161, 317);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 100;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // kWZPDataSet
            // 
            this.kWZPDataSet.DataSetName = "KWZPDataSet";
            this.kWZPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vMagazynmaszynwszystkoBindingSource
            // 
            this.vMagazynmaszynwszystkoBindingSource.DataMember = "v_Magazyn_maszyn_wszystko";
            this.vMagazynmaszynwszystkoBindingSource.DataSource = this.kWZPDataSet;
            // 
            // v_Magazyn_maszyn_wszystkoTableAdapter
            // 
            this.v_Magazyn_maszyn_wszystkoTableAdapter.ClearBeforeFill = true;
            // 
            // nazwaMaszynyDataGridViewTextBoxColumn
            // 
            this.nazwaMaszynyDataGridViewTextBoxColumn.DataPropertyName = "Nazwa maszyny";
            this.nazwaMaszynyDataGridViewTextBoxColumn.HeaderText = "Nazwa maszyny";
            this.nazwaMaszynyDataGridViewTextBoxColumn.Name = "nazwaMaszynyDataGridViewTextBoxColumn";
            // 
            // liczbaSztukDataGridViewTextBoxColumn
            // 
            this.liczbaSztukDataGridViewTextBoxColumn.DataPropertyName = "Liczba sztuk";
            this.liczbaSztukDataGridViewTextBoxColumn.HeaderText = "Liczba sztuk";
            this.liczbaSztukDataGridViewTextBoxColumn.Name = "liczbaSztukDataGridViewTextBoxColumn";
            // 
            // DZFormMagMaszynWszystko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(792, 496);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dgvMaszynyWszystko);
            this.Name = "DZFormMagMaszynWszystko";
            this.Text = "DZFormMagMaszynWszystko";
            this.Load += new System.EventHandler(this.DZFormMagMaszynWszystko_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszynyWszystko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kWZPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMagazynmaszynwszystkoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaszynyWszystko;
        private System.Windows.Forms.Button btnOdswiez;
        private KWZPDataSet kWZPDataSet;
        private System.Windows.Forms.BindingSource vMagazynmaszynwszystkoBindingSource;
        private KWZPDataSetTableAdapters.v_Magazyn_maszyn_wszystkoTableAdapter v_Magazyn_maszyn_wszystkoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaMaszynyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbaSztukDataGridViewTextBoxColumn;
    }
}