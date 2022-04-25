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
            cbPracownik.DataSource = db.Pracowniks.ToList();
            cbPracownik.DisplayMember = "Nazwisko";
            cbPracownik.ValueMember = "ID_pracownik";
            cbWymiarPracy.DataSource = db.Wymiar_pracy.ToList();
            cbWymiarPracy.DisplayMember = "Nazwa_dostawca";
            cbWymiarPracy.ValueMember = "Nazwa";
            cbRodzajUmowy.DataSource = db.Rodzaj_umowy.ToList();
            cbRodzajUmowy.DisplayMember = "Nazwa";
            cbRodzajUmowy.ValueMember = "ID_rodzaj_umowy";
            cbDzial.DataSource = db.Dzials.ToList();
            cbDzial.DisplayMember = "Nazwa_dzial";
            cbDzial.ValueMember = "ID_dzial";
            cbStanowisko.DataSource = db.Stanowiskoes.ToList();
            cbStanowisko.DisplayMember = "Nazwa_stanowiska";
            cbStanowisko.ValueMember = "ID_stanowisko";            
            showData();
        }
        private void showData()
        {
            this.dgvpracownik.DataSource = this.db.v_Umowa.ToList();
            this.dgvpracownik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cleanTextBox()
        {
            tbWynagrodzenie.Clear();            
        }
        private void btnAddnewcontract_Click(object sender, EventArgs e)
        {
            if (tbWynagrodzenie.Text.Length > 0 )
            {
                Umowa umowa = new Umowa();
                umowa.ID_pracownik = (int)cbPracownik.SelectedValue;
                umowa.ID_wymiar_pracy = (int)cbPracownik.SelectedValue;
                umowa.ID_rodzaj_umowy = (int)cbPracownik.SelectedValue;
                umowa.ID_posada_pracownika = (int)cbPracownik.SelectedValue;
                umowa.Wynagrodzenie = Convert.ToInt32(tbWynagrodzenie.Text);
                Etat etat = new Etat();
                etat.ID_dzial=(int)cbDzial.SelectedValue;
                etat.ID_stanowisko = (int)cbStanowisko.SelectedValue;
                Posada_pracownika posada_pracownika = new Posada_pracownika();                
                posada_pracownika.Data_od = dpracownikod.Value;
                if (checkBox1.Checked is true)
                {
                    posada_pracownika.Data_od = dpracownikdo.Value;
                }                
                db.Umowas.Add(umowa);
                db.Posada_pracownika.Add(posada_pracownika);
                db.Etats.Add(etat);                
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
