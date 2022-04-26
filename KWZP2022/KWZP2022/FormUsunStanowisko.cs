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
    
    public partial class FormUsunStanowisko : Form
    {
        KWZPEntities db;
        public FormUsunStanowisko(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            dgvStanowisko.DataSource = db.v_Stanowisko_produkcyjne.ToList();
            dgvStanowisko.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvStanowisko.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult stanowiskoDeleteResult = MessageBox.Show("Czy na pewno chcesz usunąć stanowisko '" + this.dgvStanowisko.CurrentRow.Cells[1].Value.ToString() + "'?", "Question", MessageBoxButtons.YesNo);

            if (stanowiskoDeleteResult == DialogResult.Yes)
            {
                try
                {
                    int currentStanowiskoID = int.Parse(this.dgvStanowisko.CurrentRow.Cells[0].Value.ToString());
                    db.Stanowisko_produkcyjne.Remove(db.Stanowisko_produkcyjne.Where(s => s.ID_stanowisko_produkcyjne == currentStanowiskoID).First());
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie możesz usunąć stanowiska które jest powiązane z narzędziami lub maszyną");
                }

            }
        }
    }
}
