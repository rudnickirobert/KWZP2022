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
    public partial class FormResDepZamowienieNarzedzia : Form
    {
        KWZPEntities db;
        public FormResDepZamowienieNarzedzia(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbPracownik.DataSource = db.Pracownik.ToList();
            cmbPracownik.DisplayMember = "Nazwisko";
            cmbPracownik.ValueMember = "ID_pracownik";
            cmbDostawca.DataSource = db.Dostawca.ToList();
            cmbDostawca.DisplayMember = "Nazwa_dostawca";
            cmbDostawca.ValueMember = "ID_dostawca";
            cmbNarzedzie.DataSource = db.Narzedzie.ToList();
            cmbNarzedzie.DisplayMember = "Nazwa_narzedzie";
            cmbNarzedzie.ValueMember = "ID_narzedzie";
            cmbProducent.DataSource = db.Producent.ToList();
            cmbProducent.DisplayMember = "Nazwa_producenta";
            cmbProducent.ValueMember = "ID_producent";
            initDataGridView();
        }
        private void initDataGridView()
        {
            dgvZamowienieNarzedzia.DataSource = db.v_Zamowienia_narzedzia_w_trakcie.ToList();
            dgvZamowienieNarzedzia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
        private void btnDodajNarzedzie_Click(object sender, EventArgs e)
        {
            FormResDepNarzedzie narzedzieForm = new FormResDepNarzedzie(db);
            narzedzieForm.ShowDialog();
        }

        private void btnDodajZamowienie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCena.Text) || numSztuk.Value <= 0)
            {
                MessageBox.Show("Wprowadź poprawne dane!");
            }
            else
            {
                Zamowienie_narzedzie zamowienieNarzedzie = new Zamowienie_narzedzie();
                zamowienieNarzedzie.ID_pracownik = (int)cmbPracownik.SelectedValue;
                zamowienieNarzedzie.Data_zamowienia = System.DateTime.Now;
                zamowienieNarzedzie.ID_dostawca = (int)cmbDostawca.SelectedValue;
                db.Zamowienie_narzedzie.Add(zamowienieNarzedzie);
                db.SaveChanges();
                int zamowienieID = zamowienieNarzedzie.ID_zamowienie_narzedzie;
                Szczegoly_zamowienie_narzedzie szZamowienieNarzedzie = new Szczegoly_zamowienie_narzedzie();
                szZamowienieNarzedzie.ID_zamowienie_narzedzie = zamowienieID;
                szZamowienieNarzedzie.ID_narzedzie = (int)cmbNarzedzie.SelectedValue;
                szZamowienieNarzedzie.ID_producent = (int)cmbProducent.SelectedValue;
                szZamowienieNarzedzie.Sztuk = (int)numSztuk.Value;
                szZamowienieNarzedzie.Cena = Convert.ToDecimal(txtCena.Text);
                db.Szczegoly_zamowienie_narzedzie.Add(szZamowienieNarzedzie);
                db.SaveChanges();
                Stan_realizacji_zamowienie_narzedzie stRealizacjaNarzedzie = new Stan_realizacji_zamowienie_narzedzie();
                stRealizacjaNarzedzie.ID_zamowienie_narzedzie = zamowienieID;
                stRealizacjaNarzedzie.ID_status_zamowienie = 1;
                stRealizacjaNarzedzie.Data_stan = System.DateTime.Now;
                stRealizacjaNarzedzie.ID_pracownik = (int)cmbPracownik.SelectedValue;
                db.Stan_realizacji_zamowienie_narzedzie.Add(stRealizacjaNarzedzie);
                db.SaveChanges();
                initDataGridView();
                MessageBox.Show("Poprawnie dodano zamówienie do bazy danych");
            }
        }
    }
}