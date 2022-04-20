namespace KWZP2022
{
    partial class Parametr_polproduktForm
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
            this.dgvPolprodukt_parametry = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazwaPolprodukt_parametr = new System.Windows.Forms.TextBox();
            this.cBParametr_polprodukt = new System.Windows.Forms.ComboBox();
            this.rodzajparametrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kWZPDataSet = new KWZP2022.KWZPDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZakres_dolny_Polprodukt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZakre_gorny_polprodukt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBJednostka = new System.Windows.Forms.ComboBox();
            this.jednostkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kWZPDataSet3 = new KWZP2022.KWZPDataSet3();
            this.rodzaj_parametrTableAdapter = new KWZP2022.KWZPDataSetTableAdapters.Rodzaj_parametrTableAdapter();
            this.rodzajparametrBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rodzajparametrBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.jednostkaTableAdapter = new KWZP2022.KWZPDataSet3TableAdapters.JednostkaTableAdapter();
            this.dgvPolprodukt = new System.Windows.Forms.DataGridView();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt_parametry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajparametrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kWZPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jednostkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kWZPDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajparametrBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajparametrBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPolprodukt_parametry
            // 
            this.dgvPolprodukt_parametry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolprodukt_parametry.Location = new System.Drawing.Point(583, 110);
            this.dgvPolprodukt_parametry.Name = "dgvPolprodukt_parametry";
            this.dgvPolprodukt_parametry.Size = new System.Drawing.Size(659, 359);
            this.dgvPolprodukt_parametry.TabIndex = 0;
            this.dgvPolprodukt_parametry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolprodukt_parametry_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(107, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Półprodukt:";
            // 
            // txtNazwaPolprodukt_parametr
            // 
            this.txtNazwaPolprodukt_parametr.Enabled = false;
            this.txtNazwaPolprodukt_parametr.Font = new System.Drawing.Font("Arial", 20F);
            this.txtNazwaPolprodukt_parametr.Location = new System.Drawing.Point(113, 68);
            this.txtNazwaPolprodukt_parametr.Name = "txtNazwaPolprodukt_parametr";
            this.txtNazwaPolprodukt_parametr.Size = new System.Drawing.Size(334, 38);
            this.txtNazwaPolprodukt_parametr.TabIndex = 14;
            this.txtNazwaPolprodukt_parametr.TextChanged += new System.EventHandler(this.txtNazwaPolprodukt_parametr_TextChanged);
            // 
            // cBParametr_polprodukt
            // 
            this.cBParametr_polprodukt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cBParametr_polprodukt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rodzajparametrBindingSource, "Nazwa_rodzaj_parametr", true));
            this.cBParametr_polprodukt.DataSource = this.rodzajparametrBindingSource;
            this.cBParametr_polprodukt.DisplayMember = "Nazwa_rodzaj_parametr";
            this.cBParametr_polprodukt.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.cBParametr_polprodukt.FormattingEnabled = true;
            this.cBParametr_polprodukt.Location = new System.Drawing.Point(113, 143);
            this.cBParametr_polprodukt.Name = "cBParametr_polprodukt";
            this.cBParametr_polprodukt.Size = new System.Drawing.Size(330, 39);
            this.cBParametr_polprodukt.TabIndex = 16;
            
            // 
            // rodzajparametrBindingSource
            // 
            this.rodzajparametrBindingSource.DataMember = "Rodzaj_parametr";
            this.rodzajparametrBindingSource.DataSource = this.kWZPDataSet;
            // 
            // kWZPDataSet
            // 
            this.kWZPDataSet.DataSetName = "KWZPDataSet";
            this.kWZPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(116, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Parametr półproduktu:";
            // 
            // txtZakres_dolny_Polprodukt
            // 
            this.txtZakres_dolny_Polprodukt.Font = new System.Drawing.Font("Arial", 20F);
            this.txtZakres_dolny_Polprodukt.Location = new System.Drawing.Point(113, 226);
            this.txtZakres_dolny_Polprodukt.Name = "txtZakres_dolny_Polprodukt";
            this.txtZakres_dolny_Polprodukt.Size = new System.Drawing.Size(334, 38);
            this.txtZakres_dolny_Polprodukt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20F);
            this.label3.Location = new System.Drawing.Point(107, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Zakres dolny:";
            // 
            // txtZakre_gorny_polprodukt
            // 
            this.txtZakre_gorny_polprodukt.Font = new System.Drawing.Font("Arial", 20F);
            this.txtZakre_gorny_polprodukt.Location = new System.Drawing.Point(113, 300);
            this.txtZakre_gorny_polprodukt.Name = "txtZakre_gorny_polprodukt";
            this.txtZakre_gorny_polprodukt.Size = new System.Drawing.Size(334, 38);
            this.txtZakre_gorny_polprodukt.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20F);
            this.label4.Location = new System.Drawing.Point(107, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Zakres górny:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 20F);
            this.label5.Location = new System.Drawing.Point(116, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Jednostka:";
            // 
            // cBJednostka
            // 
            this.cBJednostka.DataSource = this.jednostkaBindingSource;
            this.cBJednostka.DisplayMember = "Skrot";
            this.cBJednostka.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBJednostka.FormattingEnabled = true;
            this.cBJednostka.Location = new System.Drawing.Point(113, 371);
            this.cBJednostka.Name = "cBJednostka";
            this.cBJednostka.Size = new System.Drawing.Size(334, 39);
            this.cBJednostka.TabIndex = 22;
            
            // 
            // jednostkaBindingSource
            // 
            this.jednostkaBindingSource.DataMember = "Jednostka";
            this.jednostkaBindingSource.DataSource = this.kWZPDataSet3;
            // 
            // kWZPDataSet3
            // 
            this.kWZPDataSet3.DataSetName = "KWZPDataSet3";
            this.kWZPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rodzaj_parametrTableAdapter
            // 
            this.rodzaj_parametrTableAdapter.ClearBeforeFill = true;
            // 
            // rodzajparametrBindingSource1
            // 
            this.rodzajparametrBindingSource1.DataMember = "Rodzaj_parametr";
            this.rodzajparametrBindingSource1.DataSource = this.kWZPDataSet;
            // 
            // rodzajparametrBindingSource2
            // 
            this.rodzajparametrBindingSource2.DataMember = "Rodzaj_parametr";
            this.rodzajparametrBindingSource2.DataSource = this.kWZPDataSet;
            // 
            // jednostkaTableAdapter
            // 
            this.jednostkaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPolprodukt
            // 
            this.dgvPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolprodukt.Location = new System.Drawing.Point(583, 505);
            this.dgvPolprodukt.Name = "dgvPolprodukt";
            this.dgvPolprodukt.Size = new System.Drawing.Size(659, 183);
            this.dgvPolprodukt.TabIndex = 24;
            this.dgvPolprodukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolprodukt_CellContentClick);
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(113, 522);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 28;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(113, 579);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 27;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(113, 635);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 26;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(113, 464);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 25;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Parametr_polproduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2022.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPolprodukt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBJednostka);
            this.Controls.Add(this.txtZakre_gorny_polprodukt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZakres_dolny_Polprodukt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBParametr_polprodukt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwaPolprodukt_parametr);
            this.Controls.Add(this.dgvPolprodukt_parametry);
            this.Name = "Parametr_polproduktForm";
            this.Text = "Parametr_polproduktForm";
            this.Load += new System.EventHandler(this.Parametr_polproduktForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt_parametry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajparametrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kWZPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jednostkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kWZPDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajparametrBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajparametrBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolprodukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolprodukt_parametry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazwaPolprodukt_parametr;
        private System.Windows.Forms.ComboBox cBParametr_polprodukt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZakres_dolny_Polprodukt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZakre_gorny_polprodukt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBJednostka;
        private KWZPDataSet kWZPDataSet;
        private System.Windows.Forms.BindingSource rodzajparametrBindingSource;
        private KWZPDataSetTableAdapters.Rodzaj_parametrTableAdapter rodzaj_parametrTableAdapter;
        private System.Windows.Forms.BindingSource rodzajparametrBindingSource1;
        private System.Windows.Forms.BindingSource rodzajparametrBindingSource2;
        private KWZPDataSet3 kWZPDataSet3;
        private System.Windows.Forms.BindingSource jednostkaBindingSource;
        private KWZPDataSet3TableAdapters.JednostkaTableAdapter jednostkaTableAdapter;
        private System.Windows.Forms.DataGridView dgvPolprodukt;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodaj;
    }
}