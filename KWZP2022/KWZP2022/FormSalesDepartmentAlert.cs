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
    public partial class FormSalesDepartmentAlert : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentAlert(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
        }
        private void showData()
        {
            this.db = new KWZPEntities();
            this.dgvAlert.DataSource = this.db.v_Alert_handel_marketing.ToList();
            this.dgvAlert.Columns[1].Visible = false;
            this.dgvAlert.Columns[2].Visible = false;
            this.dgvAlert.Columns[0].HeaderText = "Nr Alert";
            this.dgvAlert.Columns[3].HeaderText = "Czy odczytano?";
            this.dgvAlert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void textBoxData()
        {
            if(this.dgvAlert.CurrentRow != null)
            {
                textBoxContents.Text = this.dgvAlert.CurrentRow.Cells[2].Value.ToString();
            }
        }
        private void dgvAlert_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxData();
        }
        private void btnReaded_Click(object sender, EventArgs e)
        {
            if(this.dgvAlert.CurrentRow != null)
            {
                int selectedAlertFromDgv = int.Parse(this.dgvAlert.CurrentRow.Cells[0].Value.ToString());
                Alert selectAlert = this.db.Alert.Single(a => a.ID_alert == selectedAlertFromDgv);
                selectAlert.Czy_odczytano = true;
                this.db.SaveChanges();
                showData();
            }
            else
            {
                MessageBox.Show("Zaznacz alert, który chcesz oznaczyć jako przeczytany","Uwaga",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvAlert_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvAlert.CurrentRow != null)
            {
                int selectedAlertFromDgv = int.Parse(this.dgvAlert.CurrentRow.Cells[0].Value.ToString());
                DialogResult unreadAlert = MessageBox.Show($"Czy chcesz ustawić status alertu: {selectedAlertFromDgv}, jako nieprzeczytane?", "Pytanie?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (unreadAlert == DialogResult.Yes)
                {
                    Alert selectAlert = this.db.Alert.Single(a => a.ID_alert == selectedAlertFromDgv);
                    selectAlert.Czy_odczytano = false;
                    this.db.SaveChanges();
                    showData();
                }
            }
        }
    }
}
