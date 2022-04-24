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
    public partial class FormHRDepartmentWorkerContract : Form
    {
        KWZPEntities db;
        public FormHRDepartmentWorkerContract(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cleanTextBox();
            showData();
        }
        private void showData()
        {      
            this.dgvWorker.DataSource = db.v_Umowa.ToList();
            this.dgvWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cleanTextBox()
        {
            tbImieU.Clear();
            tbNazwiskoU.Clear();
            tbStanowiskoU.Clear();
        }

        private void msgCleanShowData()
        {
            cleanTextBox();
            showData();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            cleanTextBox();
        }
        private void enterSurname()
        {
            System.Linq.IQueryable vWorkerName = db.v_Umowa.Where(a => a.Imię == tbImieU.Text);
            int vWorkerNameInt = vWorkerName.Cast<v_Umowa>().Count();
            if (vWorkerNameInt > 0)
            {
                this.dgvWorker.DataSource = vWorkerName.Cast<v_Umowa>().ToList();
                this.dgvWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterName()
        {
            System.Linq.IQueryable vWorkerSurname = db.v_Umowa.Where(a => a.Nazwisko == tbNazwiskoU.Text);
            int vWorkerSurnameInt = vWorkerSurname.Cast<v_Umowa>().Count();
            if (vWorkerSurnameInt > 0)
            {
                this.dgvWorker.DataSource = vWorkerSurname.Cast<v_Umowa>().ToList();
                this.dgvWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterPosition()
        {
            System.Linq.IQueryable vWorkerPosition = db.v_Umowa.Where(a => a.Nazwa_stanowiska == tbStanowiskoU.Text);
            int vWorkerPositionInt = vWorkerPosition.Cast<v_Umowa>().Count();
            if (vWorkerPositionInt > 0)
            {
                this.dgvWorker.DataSource = vWorkerPosition.Cast<v_Umowa>().ToList();
                this.dgvWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterDepartment()
        {
            System.Linq.IQueryable vWorkerDepartment = db.v_Umowa.Where(a => a.Nazwa_działu == tbDzialU.Text);
            int vWorkerDepartmentInt = vWorkerDepartment.Cast<v_Umowa>().Count();
            if (vWorkerDepartmentInt > 0)
            {
                this.dgvWorker.DataSource = vWorkerDepartment.Cast<v_Umowa>().ToList();
                this.dgvWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK);
            showData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbImieU.Text.Length > 0)
                choose = "Surname";
            if (tbNazwiskoU.Text.Length > 0)
                choose = "Name";
            if (tbStanowiskoU.Text.Length > 0)
                choose = "Position";
            if (tbDzialU.Text.Length > 0)
                choose = "Department";
            switch (choose)
            {
                case "Name":
                    enterName();
                    break;
                case "Surname":
                    enterSurname();
                    break;
                case "Position":
                    enterPosition();
                    break;
                case "Department":
                    enterDepartment();
                    break;
            }
        }

         private void btnAddnew_Click(object sender, EventArgs e)
         {
             FormHRDepartmentWorkerContractNew formHRDepartmentWorkerContractNew = new FormHRDepartmentWorkerContractNew(db);
             formHRDepartmentWorkerContractNew.ShowDialog();
         }

        private void FormHRDepartmentWorkerContract_Load(object sender, EventArgs e)
        {

        }

    }
}
