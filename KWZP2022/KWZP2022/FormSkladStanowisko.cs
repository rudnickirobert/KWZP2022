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
    public partial class FormSkladStanowisko : Form
    {
        KWZPEntities db;
        public FormSkladStanowisko(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            refreshScreen();
        }
        private void refreshScreen()
        {
            initDataGridViewStanowisko();
            initDataGridViewNarzedzie();
            initDataGridViewMaszyna();
            initDataGridViewSkladNarzedzie();
            initDataGridViewSkladMaszyna();
            txtStanowisko.Text = "";
            txtNarzedzie.Text = "";
            txtIlosc.Text = "";
            txtMaszyny.Text = "";
        }

        private void initDataGridViewStanowisko()
        {
            dgvStanowisko.DataSource = db.Slownik_stanowisko.ToList();
            dgvStanowisko.Columns["ID_nazwa_stanowiska"].Visible = false;
            dgvStanowisko.Columns["Stanowisko_produkcyjne"].Visible = false;
            this.dgvStanowisko.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewNarzedzie()
        {
            dgvNarzedzia.DataSource = db.v_Magazyn_narzedzia_nieuzywane_ID.ToList();
            dgvNarzedzia.Columns["ID_narzedzie"].Visible = false;
            this.dgvNarzedzia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewMaszyna()
        {
            dgvMaszyny.DataSource = db.v_Nr_seryjny_maszyna.ToList();
            dgvMaszyny.Columns["ID_maszyny"].Visible = false;
            this.dgvMaszyny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewSkladNarzedzie()
        {
            dgvSkladNarzedzia.DataSource = db.v_Sklad_stanowisko_produkcyjne_narzedzie_ID.ToList();
            dgvSkladNarzedzia.Columns["ID_sklad_stanowisko_produkcyjne_narzedzie"].Visible = false;
            this.dgvSkladNarzedzia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewSkladMaszyna()
        {
            dgvSkladMaszyny.DataSource = db.v_Sklad_stanowisko_produkcyjne_maszyna_ID.ToList();
            dgvSkladMaszyny.Columns["ID_sklad_stanowisko_produkcyjne_maszyna"].Visible = false;
            this.dgvSkladMaszyny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dgvStanowisko_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStanowisko.Text = this.dgvStanowisko.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvNarzedzia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNarzedzie.Text = this.dgvNarzedzia.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvMaszyny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaszyny.Text = this.dgvMaszyny.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodajStanowisko_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStanowisko.Text) || String.IsNullOrEmpty(txtNarzedzie.Text) || String.IsNullOrEmpty(txtIlosc.Text) || String.IsNullOrEmpty(txtMaszyny.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje.");
            }
            else
            {
                int ilosc = int.Parse(txtIlosc.Text);
                int iloscNarzedzi = int.Parse(this.dgvNarzedzia.CurrentRow.Cells[2].Value.ToString());
                if (iloscNarzedzi - ilosc < 0)
                {
                    MessageBox.Show("Niewystarczająca ilość narzędzi " + this.dgvNarzedzia.CurrentRow.Cells[1].Value.ToString() + " w magazynie");

                }
                else
                {
                    Stanowisko_produkcyjne stanowisko = new Stanowisko_produkcyjne();
                    stanowisko.ID_nazwa_stanowiska = int.Parse(this.dgvStanowisko.CurrentRow.Cells[0].Value.ToString());

                    Sklad_stanowisko_produkcyjne_narzedzie skladStanowisko = new Sklad_stanowisko_produkcyjne_narzedzie();
                    skladStanowisko.ID_stanowisko_produkcyjne = stanowisko.ID_stanowisko_produkcyjne;
                    skladStanowisko.ID_narzedzie = int.Parse(this.dgvNarzedzia.CurrentRow.Cells[0].Value.ToString());
                    skladStanowisko.Liczba = int.Parse(txtIlosc.Text);

                    Sklad_stanowisko_produkcyjne_maszyna skladMaszyna = new Sklad_stanowisko_produkcyjne_maszyna();
                    skladMaszyna.ID_stanowisko_produkcyjne = stanowisko.ID_stanowisko_produkcyjne;
                    skladMaszyna.ID_maszyna_nr = int.Parse(this.dgvMaszyny.CurrentRow.Cells[0].Value.ToString());

                    db.Stanowisko_produkcyjne.Add(stanowisko);
                    db.Sklad_stanowisko_produkcyjne_narzedzie.Add(skladStanowisko);
                    db.Sklad_stanowisko_produkcyjne_maszyna.Add(skladMaszyna);
                    db.SaveChanges();
                    refreshScreen();
                }
            }
        }

        private void btnDodajNarzedzie_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNarzedzie.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje.");
            }
            else
            {
                int ilosc = int.Parse(txtIlosc.Text);
                int iloscNarzedzi = int.Parse(this.dgvNarzedzia.CurrentRow.Cells[2].Value.ToString());
                if (iloscNarzedzi - ilosc < 0)
                {
                    MessageBox.Show("Niewystarczająca ilość narzędzi " + this.dgvNarzedzia.CurrentRow.Cells[1].Value.ToString() + " w magazynie");

                }
                else
                {
                    Sklad_stanowisko_produkcyjne_narzedzie skladStanowisko = new Sklad_stanowisko_produkcyjne_narzedzie();
                    skladStanowisko.ID_stanowisko_produkcyjne = int.Parse(this.dgvSkladNarzedzia.CurrentRow.Cells[1].Value.ToString());
                    skladStanowisko.ID_narzedzie = int.Parse(this.dgvNarzedzia.CurrentRow.Cells[0].Value.ToString());
                    skladStanowisko.Liczba = int.Parse(txtIlosc.Text);
                    db.Sklad_stanowisko_produkcyjne_narzedzie.Add(skladStanowisko);
                    db.SaveChanges();
                }
                refreshScreen();
            }
        }

        private void btnDodajMaszyne_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaszyny.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje.");
            }
            else
            {
                Sklad_stanowisko_produkcyjne_maszyna skladMaszyna = new Sklad_stanowisko_produkcyjne_maszyna();
                skladMaszyna.ID_stanowisko_produkcyjne = int.Parse(this.dgvSkladMaszyny.CurrentRow.Cells[1].Value.ToString());
                skladMaszyna.ID_maszyna_nr = int.Parse(this.dgvMaszyny.CurrentRow.Cells[0].Value.ToString());
                db.Sklad_stanowisko_produkcyjne_maszyna.Add(skladMaszyna);
                db.SaveChanges();
            }
            refreshScreen();
        }

        private void btnUsunNarzedzie_Click(object sender, EventArgs e)
        {
            DialogResult stanowiskoNarzedzieDelete = MessageBox.Show("Czy na pewno chcesz usunąć narzędzie '" + this.dgvSkladNarzedzia.CurrentRow.Cells[3].Value.ToString() + "'?", "Question", MessageBoxButtons.YesNo);

            if (stanowiskoNarzedzieDelete == DialogResult.Yes)
            {
                 int currentStanowiskoID = int.Parse(this.dgvSkladNarzedzia.CurrentRow.Cells[0].Value.ToString());
                 db.Sklad_stanowisko_produkcyjne_narzedzie.Remove(db.Sklad_stanowisko_produkcyjne_narzedzie.Where(narzedzie => narzedzie.ID_sklad_stanowisko_produkcyjne_narzedzie == currentStanowiskoID).First());
                 db.SaveChanges();
            }
            refreshScreen();
        }

        private void btnUsun2_Click(object sender, EventArgs e)
        {
            DialogResult stanowiskoMaszynaDelete = MessageBox.Show("Czy na pewno chcesz usunąć maszynę '" + this.dgvSkladMaszyny.CurrentRow.Cells[3].Value.ToString() + "'?", "Question", MessageBoxButtons.YesNo);

            if (stanowiskoMaszynaDelete == DialogResult.Yes)
            {
                int currentMaszynaID = int.Parse(this.dgvSkladMaszyny.CurrentRow.Cells[0].Value.ToString());
                db.Sklad_stanowisko_produkcyjne_maszyna.Remove(db.Sklad_stanowisko_produkcyjne_maszyna.Where(maszyna => maszyna.ID_sklad_stanowisko_produkcyjne_maszyna == currentMaszynaID).First());
                db.SaveChanges();
            }
            refreshScreen();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            FormUsunStanowisko usunStanowisko = new FormUsunStanowisko(db);
            usunStanowisko.ShowDialog();
        }
    }
}
