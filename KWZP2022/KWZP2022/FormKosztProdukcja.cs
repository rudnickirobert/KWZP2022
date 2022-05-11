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
    public partial class FormKosztProdukcja : Form
    {
        KWZPEntities db;
        public FormKosztProdukcja(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initComboboxZamowienie();

        }

        private void initComboboxZamowienie()
        {
            cbZamowienie.DataSource = db.v_Zamowienie_produkcja.ToList();
            cbZamowienie.ValueMember = "ID";
            cbZamowienie.DisplayMember = "Klient";
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            int zamowienieID = int.Parse(cbZamowienie.SelectedValue.ToString());
            dgvProcesProdukt.DataSource = 0;         
            List<v_Proces_wytwarzanie_produkt_koszt> procesProdukt = db.v_Proces_wytwarzanie_produkt_koszt.Where(a => a.ID_zamowienie == zamowienieID).ToList();

            if (procesProdukt.Count() > 0)
            {
                dgvProcesProdukt.DataSource = procesProdukt;
                dgvProcesProdukt.Columns["ID_zamowienie"].Visible = false;
                dgvProcesProdukt.Columns["ID_stanowisko"].Visible = false;
                dgvProcesProdukt.Columns["Data_rozpoczęcia"].Visible = false;
                dgvProcesProdukt.Columns["Data_zakończenia"].Visible = false;
                dgvProcesProdukt.Columns["Czynność_produkcyjna"].Visible = false;
                dgvProcesProdukt.Columns["Czas_pracy"].HeaderText = "Czas [min]";
                dgvProcesProdukt.Columns["Koszt_roboczogodziny_stanowiska__PLN_"].HeaderText = "Koszt roboczogodziny [PLN]";
                dgvProcesProdukt.Columns["Koszt_procesu"].HeaderText = "Koszt procesu [PLN]";
                this.dgvProcesProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }

            dgvProcesPolprodukt.DataSource = 0;
            List<v_Proces_wytwarzanie_polprodukt_koszt> procesPolprodukt = db.v_Proces_wytwarzanie_polprodukt_koszt.Where(a => a.ID_zamowienie == zamowienieID).ToList();
            if (procesProdukt.Count() > 0)
            {
                dgvProcesPolprodukt.DataSource = procesPolprodukt;
                dgvProcesPolprodukt.Columns["ID_zamowienie"].Visible = false;
                dgvProcesPolprodukt.Columns["ID_stanowisko"].Visible = false;
                dgvProcesPolprodukt.Columns["Data_rozpoczęcia"].Visible = false;
                dgvProcesPolprodukt.Columns["Data_zakończenia"].Visible = false;
                dgvProcesPolprodukt.Columns["Czas_pracy"].HeaderText = "Czas [min]";
                dgvProcesPolprodukt.Columns["Koszt_roboczogodziny_stanowiska__PLN_"].HeaderText = "Koszt roboczogodziny [PLN]";
                dgvProcesPolprodukt.Columns["Koszt_procesu"].HeaderText = "Koszt procesu [PLN]";
                this.dgvProcesPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            decimal polproduktSum = 0;
            decimal produktSum = 0;

            if (dgvProcesPolprodukt.DataSource != null)
            {
                polproduktSum = dgvProcesPolprodukt.Rows.Cast<DataGridViewRow>()
                    .Sum(n => Convert.ToDecimal(n.Cells[8].Value));
            }

            if (dgvProcesProdukt.DataSource != null)
            {
                produktSum = dgvProcesProdukt.Rows.Cast<DataGridViewRow>()
                    .Sum(t => Convert.ToDecimal(t.Cells[8].Value));
            }

            decimal finalSum = polproduktSum + produktSum;
            lblKoszt.Text = finalSum.ToString() + " " + "PLN";
        }
    }
}
