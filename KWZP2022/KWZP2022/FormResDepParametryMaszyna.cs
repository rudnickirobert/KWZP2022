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
    public partial class FormResDepParametryMaszyna : Form
    {
        KWZPEntities db;
        public FormResDepParametryMaszyna(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
            cmbMaszyna.DataSource = db.Maszyna.ToList();
            cmbMaszyna.DisplayMember = "Nazwa_maszyna";
            cmbMaszyna.ValueMember = "ID_maszyna";
            cmbParametr.DataSource = db.v_Rodzaj_parametr.ToList();
            cmbParametr.DisplayMember = "Parametr";
            cmbParametr.ValueMember = "ID_rodzaj_parametr";
        }
        private void initDataGridView()
        {
            dgvParametrMaszyna.DataSource = db.v_Parametry_maszyna.ToList();
            dgvParametrMaszyna.Columns[0].Visible = false;
            dgvParametrMaszyna.Columns[1].Visible = false;
            dgvParametrMaszyna.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvParametrMaszyna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtZakresGora.Text == null || txtZakresDol.Text == null || Convert.ToDecimal(txtZakresGora.Text) < Convert.ToDecimal(txtZakresDol.Text))
                {
                    MessageBox.Show("Wpisz poprawny zakres", "Błąd", MessageBoxButtons.OK);
                }
                else
                {
                    Parametr_maszyna parametrMaszyna = new Parametr_maszyna();
                    parametrMaszyna.ID_maszyna = (int)cmbMaszyna.SelectedValue;
                    parametrMaszyna.ID_rodzaj_parametr = (int)cmbParametr.SelectedValue;
                    parametrMaszyna.Zakres_gora = Convert.ToDecimal(txtZakresGora.Text);
                    parametrMaszyna.Zakres_dol = Convert.ToDecimal(txtZakresDol.Text);
                    db.Parametr_maszyna.Add(parametrMaszyna);
                    db.SaveChanges();
                    initDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Powtórzono parametr", "Błąd", MessageBoxButtons.OK);
            }
        }

        private void btnWczytajParametr_Click(object sender, EventArgs e)
        {
            string maszyna = cmbMaszyna.SelectedValue.ToString();
            int maszynaID = int.Parse(maszyna);
            System.Linq.IQueryable vParametrMaszyna = db.v_Parametry_maszyna.Where(x => x.ID_maszyna == maszynaID);
            int vParametrMaszynaInt = vParametrMaszyna.Cast<v_Parametry_maszyna>().Where(x => x.ID_maszyna > 0).Count();
            if (vParametrMaszynaInt > 0)
            {
                dgvParametrMaszyna.DataSource = vParametrMaszyna.Cast<v_Parametry_maszyna>().ToList();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć parametr: " + this.dgvParametrMaszyna.CurrentRow.Cells[3].Value + "?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string current_parametr = this.dgvParametrMaszyna.CurrentRow.Cells[1].Value.ToString();
                int daneINT = int.Parse(current_parametr);
                Parametr_maszyna parametrMaszyna = db.Parametr_maszyna.Single(a => a.ID_rodzaj_parametr == daneINT);
                this.db.Parametr_maszyna.Remove(parametrMaszyna);
                db.SaveChanges();
                initDataGridView();
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvParametrMaszyna.CurrentRow.Cells[0].Value != null)
                {
                    if (txtZakresGora.Text == null || txtZakresDol.Text == null || Convert.ToDecimal(txtZakresGora.Text) < Convert.ToDecimal(txtZakresDol.Text))
                    {
                        MessageBox.Show("Wpisz poprawny zakres", "Błąd", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int daneParametrMaszyna = int.Parse(this.dgvParametrMaszyna.CurrentRow.Cells[1].Value.ToString());
                        Parametr_maszyna daneParametrMaszynaID = this.db.Parametr_maszyna.Single(a => a.ID_rodzaj_parametr == daneParametrMaszyna);
                        daneParametrMaszynaID.ID_rodzaj_parametr = (int)cmbParametr.SelectedValue;
                        daneParametrMaszynaID.ID_maszyna = (int)cmbMaszyna.SelectedValue;
                        daneParametrMaszynaID.Zakres_gora = Convert.ToDecimal(txtZakresGora.Text);
                        daneParametrMaszynaID.Zakres_dol = Convert.ToDecimal(txtZakresDol.Text);
                        db.SaveChanges();
                        initDataGridView();
                        MessageBox.Show("Zapisano zmiany!", "Informacja", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Powtórzono parametr", "Błąd", MessageBoxButtons.OK);
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
