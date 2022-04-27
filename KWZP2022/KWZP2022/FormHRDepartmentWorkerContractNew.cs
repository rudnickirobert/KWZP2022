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
    public partial class FormHRDepartmentWorkerContractNew : Form
    {
        KWZPEntities db;
        public FormHRDepartmentWorkerContractNew(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            Umowa umowa = new Umowa();
            checkBoxAddValue();
            showData();
        }
        private void showData()
        {
            this.dgvpracownik.DataSource = this.db.v_Umowa.ToList();
            this.dgvpracownik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtat.DataSource = this.db.v_Etat.ToList();
            this.dgvEtat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cleanTextBox()
        {
            tbSalary.Clear();
        }
        private void checkBoxAddValue()
        {
            cbWorker.DataSource = db.Pracownik.ToList();
            cbWorker.DisplayMember = "Nazwisko";
            cbWorker.ValueMember = "ID_pracownik";
            cbWorkingTime.DataSource = db.Wymiar_pracy.ToList();
            cbWorkingTime.DisplayMember = "Nazwa";
            cbWorkingTime.ValueMember = "ID_wymiar_pracy";
            cbRContractType.DataSource = db.Rodzaj_umowy.ToList();
            cbRContractType.DisplayMember = "Nazwa";
            cbRContractType.ValueMember = "ID_rodzaj_umowy";
            cbEtat.DataSource = db.Stanowisko.ToList();
            cbEtat.DisplayMember = "Nazwa_stanowiska";
            cbEtat.ValueMember = "ID_stanowisko";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddnewcontract_Click(object sender, EventArgs e)
        {
            if (tbSalary.Text.Length > 0)
            {
                Posada_pracownika posadaPracownika = new Posada_pracownika();
                posadaPracownika.Data_od = dWorkerFrom.Value;
                posadaPracownika.ID_etat = (int)cbEtat.SelectedValue;
                if (cbDateTo.Checked)
                {
                    posadaPracownika.Data_od = dWorkerTo.Value;
                }
                db.Posada_pracownika.Add(posadaPracownika);
                db.SaveChanges();
                Umowa umowa = new Umowa();
                umowa.ID_pracownik = (int)cbWorker.SelectedValue;
                umowa.ID_wymiar_pracy = (int)cbWorkingTime.SelectedValue;
                umowa.ID_rodzaj_umowy = (int)cbRContractType.SelectedValue;
                umowa.ID_posada_pracownika = (int)cbEtat.SelectedValue;
                umowa.Wynagrodzenie = Convert.ToInt32(tbSalary.Text);
                db.Umowa.Add(umowa); 
                db.SaveChanges();
                cleanTextBox();
                showData();
                MessageBox.Show("Wprowadzono nową umowę!", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nie wprowadzono danych.", "Błąd", MessageBoxButtons.OK);
            }
        }

    }
}
