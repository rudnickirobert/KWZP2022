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
    public partial class Ewidencja_czasForm : Form
    {
        KWZPEntities db;
        public Ewidencja_czasForm(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showDataPracownik();
            showDataMaszyna();
        }

        private void showDataPracownik()
        {
            var dataPracownik = from v_tygodniowe_rozliczenie_pracy_produkcja in db.v_Tygodniowe_rozliczenie_pracy_produkcja
                select new
                    {
                        v_tygodniowe_rozliczenie_pracy_produkcja.Pracownik,
                        v_tygodniowe_rozliczenie_pracy_produkcja.Czas_pracy__h_
                    };
            this.dgvCzasPracownik.DataSource = dataPracownik.ToList();
            this.dgvCzasPracownik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showDataMaszyna()
        {
            var dataMaszyna = from v_tygodniowe_rozliczenie_pracy_maszyna in db.v_Tygodniowe_rozliczenie_pracy_maszyna_calosc
                select new
                    {
                        v_tygodniowe_rozliczenie_pracy_maszyna.Maszyna,
                        v_tygodniowe_rozliczenie_pracy_maszyna.Nr_seryjny_maszyny,
                        v_tygodniowe_rozliczenie_pracy_maszyna.Czas_pracy__h_
                };
            this.dgvCzasMaszyna.DataSource = dataMaszyna.ToList();
            this.dgvCzasMaszyna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
