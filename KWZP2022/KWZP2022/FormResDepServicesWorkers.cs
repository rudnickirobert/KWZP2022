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
    public partial class FormResDepServicesWorkers : Form
    {
        KWZPEntities db;
        Obsluga wybranaObslugaDGV;
        public FormResDepServicesWorkers(KWZPEntities db, Obsluga wybranaObslugaDGV)
        {
            InitializeComponent();
            this.db = db;
            this.wybranaObslugaDGV = wybranaObslugaDGV;
            cmbPracownik.DataSource = db.v_Pracownik_obslugi.ToList();
            cmbPracownik.DisplayMember = "Pracownik";
            cmbPracownik.ValueMember = "ID_pracownik";
            initDataGridView();
        }
        private void initDataGridView()
        {
            int wyborObslugi = wybranaObslugaDGV.ID_obsluga;
            List<v_Obsluga_pracownik> pracownikObsluga = db.v_Obsluga_pracownik.Where(a => a.ID_obsluga == wyborObslugi).ToList();
            dgvObsluga.DataSource = pracownikObsluga;
            dgvObsluga.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvObsluga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvObsluga.Columns[1].Visible = false;
            dgvObsluga.Columns[2].Visible = false;
        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            Obsluga obsluga = this.db.Obsluga.Single(service => service.ID_obsluga == wybranaObslugaDGV.ID_obsluga);
            Pracownik pracownik = this.db.Pracownik.Single(employee => employee.ID_pracownik == (int)cmbPracownik.SelectedValue);
            obsluga.Pracownik.Add(pracownik);
            db.SaveChanges();
            initDataGridView();
            MessageBox.Show("Poprawnie dodano pracownika do obsługi");
        }

        private void btnUsunPracownika_Click(object sender, EventArgs e)
        {
            Obsluga obsluga = this.db.Obsluga.Single(service => service.ID_obsluga == wybranaObslugaDGV.ID_obsluga);
            int wybranyPracownik = int.Parse(dgvObsluga.CurrentRow.Cells[1].Value.ToString());
            Pracownik pracownik = this.db.Pracownik.Single(employee => employee.ID_pracownik == wybranyPracownik);
            obsluga.Pracownik.Remove(pracownik);
            db.SaveChanges();
            initDataGridView();
            MessageBox.Show("Usunięto pracownika z obsługi");
        }
    }
}
