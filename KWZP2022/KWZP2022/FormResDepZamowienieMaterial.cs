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
    public partial class FormResDepZamowienieMaterial : Form
    {
        KWZPEntities db;
        public FormResDepZamowienieMaterial(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbPracownik.DataSource = db.Pracownik.ToList();
            cmbPracownik.DisplayMember = "Nazwisko";
            cmbPracownik.ValueMember = "ID_pracownik";
            cmbDostawca.DataSource = db.Dostawca.ToList();
            cmbDostawca.DisplayMember = "Nazwa_dostawca";
            cmbDostawca.ValueMember = "ID_dostawca";
            cmbMaterial.DataSource = db.Material.ToList();
            cmbMaterial.DisplayMember = "Nazwa_material";
            cmbMaterial.ValueMember = "ID_material";
            cmbProducent.DataSource= db.Producent.ToList();
            cmbProducent.DisplayMember = "Nazwa_producenta";
            cmbProducent.ValueMember = "ID_producent";
            initDataGridView();
        }
        private void btnDodajMaterial_Click(object sender, EventArgs e)
        {
            FormResDepMaterial materialForm = new FormResDepMaterial(db);
            materialForm.ShowDialog();
        }
        private void initDataGridView()
        {
            dgvZamowienieMaterial.DataSource = db.v_Zamowienia_materialy_w_trakcie.ToList();
            dgvZamowienieMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void txtCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))  
            {
                int dotIndex = txtCena.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))     
                {   
                    if (dotIndex != -1 &&  
                        dotIndex < txtCena.SelectionStart &&
                        txtCena.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else 
                    e.Handled = e.KeyChar != '.' ||
                    dotIndex != -1 ||
                    txtCena.Text.Length == 0 ||
                    txtCena.SelectionStart + 2 < txtCena.Text.Length;
            }
        }
        private void btnDodajZamowienie_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(txtCena.Text) || numWaga.Value <=0)
                {
                    MessageBox.Show("Wprowadź poprawne dane!");
                }
                else
                {
                    Zamowienie_material zamowienieMat = new Zamowienie_material();
                    zamowienieMat.ID_pracownik = (int)cmbPracownik.SelectedValue;
                    zamowienieMat.Data_zamowienia = System.DateTime.Now;
                    zamowienieMat.ID_dostawca = (int)cmbDostawca.SelectedValue;
                    db.Zamowienie_material.Add(zamowienieMat);
                    db.SaveChanges();
                    int zamowienieID = zamowienieMat.ID_zamowienie_material;
                    Szczegoly_zamowienie_material szZamowienieMat = new Szczegoly_zamowienie_material();
                    szZamowienieMat.ID_zamowienie_material = zamowienieID;
                    szZamowienieMat.ID_material = (int)cmbMaterial.SelectedValue;
                    szZamowienieMat.ID_producent = (int)cmbProducent.SelectedValue;
                    szZamowienieMat.Waga_g = (int)numWaga.Value;
                szZamowienieMat.Cena = Convert.ToDecimal(txtCena.Text);
                    db.Szczegoly_zamowienie_material.Add(szZamowienieMat);
                    db.SaveChanges();
                    Stan_realizacji_zamowienie_material stRealizacjaMat = new Stan_realizacji_zamowienie_material();
                    stRealizacjaMat.ID_zamowienie_material = zamowienieID;
                    stRealizacjaMat.ID_status_zamowienie = 1;
                    stRealizacjaMat.Data_stan = System.DateTime.Now;
                    stRealizacjaMat.ID_pracownik = (int)cmbPracownik.SelectedValue;
                    db.Stan_realizacji_zamowienie_material.Add(stRealizacjaMat);
                    db.SaveChanges();
                    initDataGridView();
                    MessageBox.Show("Poprawnie dodano zamówienie do bazy danych");
                }
        }
        private void btnDodajDostawca_Click(object sender, EventArgs e)
        {
            FormResDepDostawca dostawcaForm = new FormResDepDostawca(db);
            dostawcaForm.ShowDialog();
        }

        private void btnDodajProducenta_Click(object sender, EventArgs e)
        {
            FormResDepProducent producentForm = new FormResDepProducent(db);
            producentForm.ShowDialog();
        }
    }
}
