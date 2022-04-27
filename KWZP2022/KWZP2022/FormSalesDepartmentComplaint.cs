using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2022
{
    public partial class FormSalesDepartmentComplaint : Form
    {
        KWZPEntities db;
        public FormSalesDepartmentComplaint(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showData()
        {
            this.dgvComplaint.DataSource = this.db.v_Reklamacja.ToList();
            this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplaint.Columns["ID_produkt"].Visible = false;
        }
        private void cleanBox()
        {
            textBoxNoComplaint.Clear();
            textBoxNoSale.Clear();
            cbAcceptComplaintYes.Checked = false;
            cbAcceptComplaintNO.Checked = false;
            cbDateComplaint.Checked = false;
            dtpDateComplaint.Value = DateTime.Now;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            cleanBox();
        }
        private void msgBox()
        {
            MessageBox.Show("Wprowadzono złe dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choice = "";
            if (textBoxNoSale.Text.Length > 0)
                choice = "NoSale";
            if (textBoxNoComplaint.Text.Length > 0)
                choice = "NoComplaint";
            if (cbDateComplaint.Checked == true)
                choice = "DateComplaint";
            if (cbAcceptComplaintYes.Checked == true && cbAcceptComplaintNO.Checked == false)
                choice = "ComplaintAccept";
            if (cbAcceptComplaintYes.Checked == false && cbAcceptComplaintNO.Checked == true)
                choice = "ComplaintNo";
            switch (choice)
            {
                case "NoSale":
                    try
                    {
                        int noSale = int.Parse(textBoxNoSale.Text);
                        List<v_Reklamacja> searchComplaintByNoSale = this.db.v_Reklamacja.Where(a => a.Numer_sprzedaży == noSale).ToList();
                        if (searchComplaintByNoSale.Count() > 0)
                        {
                            this.dgvComplaint.DataSource = searchComplaintByNoSale;
                            this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                            cleanBox();
                        }
                        else
                        {
                            MessageBox.Show($"W bazie nie widnieje reklamacja o nr sprzedaży: {textBoxNoSale.Text}","Błąd", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            cleanBox();
                        }
                    }
                    catch (Exception)
                    {
                        msgBox();
                        cleanBox();
                    }
                    break;
                case "NoComplaint":
                    try
                    {
                        int noComplaint = int.Parse(textBoxNoComplaint.Text);
                        List<v_Reklamacja> searchComplaintByNoComplaint = this.db.v_Reklamacja.Where(a => a.Numer_reklamacji == noComplaint).ToList();
                        if (searchComplaintByNoComplaint.Count() > 0)
                        {
                            this.dgvComplaint.DataSource = searchComplaintByNoComplaint;
                            this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                            cleanBox();
                        }
                        else
                        {
                            MessageBox.Show($"W bazie nie widnieje reklamacja o nr reklamacji: {textBoxNoComplaint.Text}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cleanBox();
                        }
                    }
                    catch (Exception)
                    {
                        msgBox();
                        cleanBox();
                    }
                    break;
                case "DateComplaint":
                    this.dgvComplaint.DataSource = this.db.v_Reklamacja.Where(a => DbFunctions.TruncateTime(a.Data_reklamacji) == dtpDateComplaint.Value.Date).ToList();
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanBox();
                    break;
                case "ComplaintAccept":
                    this.dgvComplaint.DataSource = this.db.v_Reklamacja.Where(a => a.Akceptacja == true).ToList();
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanBox();
                    break;
                case "ComplaintNo":
                    this.dgvComplaint.DataSource = this.db.v_Reklamacja.Where(a => a.Akceptacja == false).ToList();
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    cleanBox();
                    break;
                default:
                    msgBox();
                    break;
            }
        }

        private void btnAddReturn_Click(object sender, EventArgs e)
        {
            FormSalesDepartmentComplaintAdd formSalesDepartmentComplaintAdd = new FormSalesDepartmentComplaintAdd(db);
            formSalesDepartmentComplaintAdd.ShowDialog();
        }
    }
}
