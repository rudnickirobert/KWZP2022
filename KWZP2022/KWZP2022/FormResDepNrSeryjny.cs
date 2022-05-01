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
    public partial class FormResDepNrSeryjny : Form
    {
        KWZPEntities db;
        public FormResDepNrSeryjny(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            this.db = new KWZPEntities();
            dgvNumerSeryjny.DataSource = db.v_Maszyny_numery_nieprzypisane_zero.ToList();
            dgvNumerSeryjny.Columns[0].Visible = false;
            dgvNumerSeryjny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvNumerSeryjny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodajNumer_Click(object sender, EventArgs e)
        {
            if (mtxtNumerSeryjny.MaskFull)
            {
                try
                {
                    Nr_seryjny numerSeryjny = new Nr_seryjny();
                    numerSeryjny.Nr_seryjny1 = mtxtNumerSeryjny.Text;
                    db.Nr_seryjny.Add(numerSeryjny);
                    db.SaveChanges();
                    Maszyna_nr_seryjny maszynaNumer = new Maszyna_nr_seryjny();
                    maszynaNumer.ID_maszyna = (int)dgvNumerSeryjny.CurrentRow.Cells[0].Value;
                    maszynaNumer.ID_nr_seryjny = numerSeryjny.ID_nr_seryjny;
                    db.Maszyna_nr_seryjny.Add(maszynaNumer);
                    db.SaveChanges();
                    initDataGridView();
                    MessageBox.Show("Poprawnie przypisano numer seryjny");
                }
                catch
                {
                    MessageBox.Show("Wprowadź poprawne dane!");
                }
            }
            else
            {
                MessageBox.Show("Wprowadź pełny numer seryjny");
            }
        }
    }
}
