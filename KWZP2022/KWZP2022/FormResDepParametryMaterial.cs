﻿using System;
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
    public partial class FormResDepParametryMaterial : Form
    {
        KWZPEntities db;
        public FormResDepParametryMaterial(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
            cmbMaterial.DataSource = db.Material.ToList();
            cmbMaterial.DisplayMember = "Nazwa_material";
            cmbMaterial.ValueMember = "ID_material";
            cmbParametr.DataSource = db.v_Rodzaj_parametr.ToList();
            cmbParametr.DisplayMember = "Parametr";
            cmbParametr.ValueMember = "ID_rodzaj_parametr";
        }
        private void initDataGridView()
        {
            dgvParametrMaterial.DataSource = db.v_Parametry_material.ToList();
            dgvParametrMaterial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvParametrMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Parametr_material parametrMaterial = new Parametr_material();
            parametrMaterial.ID_material = (int)cmbMaterial.SelectedValue;
            parametrMaterial.ID_rodzaj_parametr = (int)cmbParametr.SelectedValue;
            parametrMaterial.Zakres_gora = Convert.ToDecimal(txtZakresGora.Text);
            parametrMaterial.Zakres_dol = Convert.ToDecimal(txtZakresDol.Text);
            db.Parametr_material.Add(parametrMaterial);
            db.SaveChanges();
            initDataGridView();
        }
        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            string material = cmbMaterial.SelectedValue.ToString();
            int materialID = int.Parse(material);
            System.Linq.IQueryable vParametrMaterial = db.v_Parametry_material.Where(x => x.ID_material == materialID);
            int vParametrMaterialInt = vParametrMaterial.Cast<v_Parametry_material>().Where(x => x.ID_material > 0).Count();
            if (vParametrMaterialInt > 0)
            {
                dgvParametrMaterial.DataSource = vParametrMaterial.Cast<v_Parametry_material>().ToList();
            }
        }
        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć parametr: " + this.dgvParametrMaterial.CurrentRow.Cells[3].Value + "?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string current_parametr = this.dgvParametrMaterial.CurrentRow.Cells[1].Value.ToString();
                int daneINT = int.Parse(current_parametr);
                Parametr_material parametrMaterial = db.Parametr_material.Single(a => a.ID_rodzaj_parametr == daneINT);
                this.db.Parametr_material.Remove(parametrMaterial);
                db.SaveChanges();
                initDataGridView();
            }
        }
        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (this.dgvParametrMaterial.CurrentRow.Cells[0].Value != null)
            {
                int daneParametrMaterial = int.Parse(this.dgvParametrMaterial.CurrentRow.Cells[1].Value.ToString());
                Parametr_material daneParametrMaterialID = this.db.Parametr_material.Single(a => a.ID_rodzaj_parametr == daneParametrMaterial);
                daneParametrMaterialID.ID_rodzaj_parametr = (int)cmbParametr.SelectedValue;
                daneParametrMaterialID.ID_material=(int)cmbMaterial.SelectedValue;
                daneParametrMaterialID.Zakres_gora = Convert.ToDecimal (txtZakresGora.Text);
                daneParametrMaterialID.Zakres_dol = Convert.ToDecimal(txtZakresDol.Text);
                db.SaveChanges();
                initDataGridView();
                MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nie zaznaczono maszyny!", "Błąd", MessageBoxButtons.OK);
            }
        }
        private void txtZakresDol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = txtZakresDol.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 &&
                        dotIndex < txtZakresDol.SelectionStart &&
                        txtZakresDol.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                    e.Handled = e.KeyChar != '.' ||
                    dotIndex != -1 ||
                    txtZakresDol.Text.Length == 0 ||
                    txtZakresDol.SelectionStart + 2 < txtZakresDol.Text.Length;
            }
        }
        private void txtZakresGora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = txtZakresGora.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 &&
                        dotIndex < txtZakresGora.SelectionStart &&
                        txtZakresGora.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                    e.Handled = e.KeyChar != '.' ||
                    dotIndex != -1 ||
                    txtZakresGora.Text.Length == 0 ||
                    txtZakresGora.SelectionStart + 2 < txtZakresGora.Text.Length;
            }
        }
    }
}

