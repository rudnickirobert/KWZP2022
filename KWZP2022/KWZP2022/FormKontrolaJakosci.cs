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
    public partial class FormKontrolaJakosci : Form
    {
        KWZPEntities db;
        public FormKontrolaJakosci(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridViewNazwa();
            initComboboxPracownik();
            initComboboxRodzajKontrola();
            initDataGridViewKontrolaJakosciParametr();
        }

        private void refreshScreen()
        {
            initDataGridViewNazwa();
            initComboboxPracownik();
            initComboboxRodzajKontrola();
            initDataGridViewKontrolaJakosciParametr();
        }

        private void initDataGridViewNazwa()
        {
            dgvvKontrolaJakosciKolejka.DataSource = db.v_Kontrola_jakosci_kolejka.ToList();
            this.dgvvKontrolaJakosciKolejka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvvKontrolaJakosciKolejka.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }               

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {

            string produktID = this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[1].Value.ToString();
            int produktIDint = int.Parse(produktID);

            System.Linq.IQueryable vProdukt = db.v_Parametry_produkt.Where(a => a.ID_produkt == produktIDint);
            int vProduktIdInt = vProdukt.Cast<v_Parametry_produkt>().Where(a => a.ID_produkt > 0).Count();
            if (vProduktIdInt > 0)
            {
                dgvvParametrProdukt.DataSource = vProdukt.Cast<v_Parametry_produkt>().ToList();
                this.dgvvParametrProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dgvvParametrProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtParametrProdukt.Text = this.dgvvParametrProdukt.CurrentRow.Cells[3].Value.ToString();
        }

        private void initComboboxPracownik()
        {
            cBPracownik.DataSource = db.v_Pracownik_produkcja.ToList();
            cBPracownik.ValueMember = "ID_pracownik";
            cBPracownik.DisplayMember = "Pracownik";
        }
        private void initComboboxRodzajKontrola()
        {
            cBRodzajKontrola.DataSource = db.v_Rodzaj_kontrola.ToList();
            cBRodzajKontrola.ValueMember = "ID";
            cBRodzajKontrola.DisplayMember = "Rodzaj_kontroli";
        }
        private void initDataGridViewKontrolaJakosciParametr()
        {
            dgvvKontrolaProdukt.DataSource = db.v_Kontrola_jakosci_produkt.ToList();
            this.dgvvKontrolaProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvvKontrolaProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Kontrola_jakosci_produkt kontrolaProdukt = new Kontrola_jakosci_produkt();
            kontrolaProdukt.ID_wytwarzanie = int.Parse(this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[0].Value.ToString());
            //int numRows = dgvvKontrolaJakosciKolejka.Rows.Count;
            kontrolaProdukt.ID_pracownik = int.Parse(cBPracownik.SelectedValue.ToString());
            kontrolaProdukt.ID_rodzaj_kontrola = int.Parse(cBRodzajKontrola.SelectedValue.ToString());
            kontrolaProdukt.Data_od = dTPDataOd.Value.Date + dTPCzasOd.Value.TimeOfDay;
            kontrolaProdukt.Data_do = dTPDataDo.Value.Date + dTPCzasDo.Value.TimeOfDay;
            kontrolaProdukt.Uwagi = txtUwagi.Text;            
            db.Kontrola_jakosci_produkt.Add(kontrolaProdukt);
            db.SaveChanges();

            Kontrola_parametr kontrolaParametr = new Kontrola_parametr();
            int numRows = dgvvKontrolaProdukt.Rows.Count;
            kontrolaParametr.ID_kontrola_jakosci_produkt = int.Parse(this.dgvvKontrolaProdukt.Rows[numRows - 1].Cells[0].Value.ToString());
            kontrolaParametr.ID_parametr_produkt = int.Parse(this.dgvvParametrProdukt.CurrentRow.Cells[0].Value.ToString());
            kontrolaParametr.Wartosc = decimal.Parse(txtWartosc.Text);
            db.Kontrola_parametr.Add(kontrolaParametr);
            db.SaveChanges();
            MessageBox.Show("Poprawnie przeprowadzono kontrole");
            refreshScreen();
        }

        private void dgvvKontrolaJakosciKolejka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwa.Text = this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
