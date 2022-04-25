using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2022
{
    public partial class FormResDepServicesAdd : Form
    {
        KWZPEntities db;
        public FormResDepServicesAdd(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbObsluga.DataSource = db.Rodzaj_obsluga.ToList();
            cmbObsluga.DisplayMember = "Nazwa_rodzaj_obsluga";
            cmbObsluga.ValueMember = "ID_rodzaj_obsluga";
            cmbStanowisko.DataSource = db.v_Stanowisko_produkcyjne.ToList();
            cmbStanowisko.DisplayMember = "Nazwa_stanowiska";
            cmbStanowisko.ValueMember = "ID";
            btnDodajWymiana.Visible = true;
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvTrwajaceObslugi.DataSource = db.v_Obslugi_w_trakcie.ToList();
            dgvTrwajaceObslugi.Columns[4].Visible = false;
            dgvTrwajaceObslugi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void btnPrzypiszPracownika_Click(object sender, EventArgs e)
        {
            Obsluga obsluga = new Obsluga();
            obsluga.ID_rodzaj_obsluga = (int)cmbObsluga.SelectedValue;
            obsluga.ID_stanowisko_produkcyjne = (int)cmbStanowisko.SelectedValue;
            obsluga.Data_od = dtpDataOd.Value;
            obsluga.Uwagi = txtUwagi.Text;
            db.Obsluga.Add(obsluga);
            db.SaveChanges();
            FormResDepServicesWorkers pracownikForm = new FormResDepServicesWorkers(db);
            pracownikForm.ShowDialog();
            initDataGridView();
        }
        private void cmbObsluga_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbObsluga.Text != "Wymiana czesci")
            {
                btnDodajWymiana.Visible = false;
            }
            else
            {
                btnDodajWymiana.Visible = true;
            }
        }
        private void btnDodajWymiana_Click(object sender, EventArgs e)
        {
            FormResDepServicesExchanged wymianaForm = new FormResDepServicesExchanged(db);
            wymianaForm.ShowDialog();
        }
    }
}
