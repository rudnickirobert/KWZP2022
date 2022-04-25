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
            this.dgvComplaint.Columns["Numer_reklamacji"].Visible = false;
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
            MessageBox.Show("Wprowadzono złe dane!", "Błąd", MessageBoxButtons.OK);
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
                        System.Linq.IQueryable numberSale = this.db.v_Reklamacja.Where(a => a.Numer_sprzedaży == noSale);
                        this.dgvComplaint.DataSource = numberSale.Cast<v_Reklamacja>().ToList();
                        this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        cleanBox();
                    }
                    catch (Exception)
                    {
                        msgBox();
                    }
                    break;
                case "NoComplaint":
                    int noComplaint = int.Parse(textBoxNoComplaint.Text);
                    System.Linq.IQueryable numberComplaint = this.db.v_Reklamacja.Where(a => a.Numer_reklamacji == noComplaint);
                    this.dgvComplaint.DataSource = numberComplaint.Cast<v_Reklamacja>().ToList();
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                    cleanBox();
                    break;
                case "DateComplaint":
                    System.Linq.IQueryable dateComplaint = this.db.v_Reklamacja.Where(a => DbFunctions.TruncateTime(a.Data_reklamacji) == dtpDateComplaint.Value.Date);
                    this.dgvComplaint.DataSource = dateComplaint.Cast<v_Reklamacja>().ToList();
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                    cleanBox();
                    break;
                case "ComplaintAccept":
                    bool acceptComplaintBOOL = true;
                    System.Linq.IQueryable complaintAccepted = this.db.v_Reklamacja.Where(a => a.Akceptacja == acceptComplaintBOOL);
                    this.dgvComplaint.DataSource = complaintAccepted.Cast<v_Reklamacja>().ToList();
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                    cleanBox();
                    break;
                case "ComplaintNo":
                    bool notAcceptComplaintBOOL = false;
                    System.Linq.IQueryable complaintNotAccepted = this.db.v_Reklamacja.Where(a => a.Akceptacja == notAcceptComplaintBOOL);
                    this.dgvComplaint.DataSource = complaintNotAccepted.Cast<v_Reklamacja>().ToList();
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
