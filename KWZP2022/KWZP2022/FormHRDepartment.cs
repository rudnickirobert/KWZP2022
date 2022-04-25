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
    public partial class FormHRDepartment : Form
    {
        KWZPEntities db;
        public FormHRDepartment(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            cleanTextBox();
        }

        private void cleanTextBox()
        {
            tbImie.Clear();
            tbNazwisko.Clear();
            tbStanowisko.Clear();
        }

        private void msgCleanShowData()
        {
            cleanTextBox();
            showData();
        }

        private void showData()
        {
            this.dgvWorker.DataSource = db.v_Umowa.ToList();
            dgvWorker.Columns["ID"].Visible = false;
            dgvWorker.Columns["Wymiar_pracy"].Visible = false;
            dgvWorker.Columns["Podstawa_wynagrodzenia"].Visible = false;
            this.dgvWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            cleanTextBox();
        }

        
        private void enterSurname()
        {
            System.Linq.IQueryable vWorkerName = db.v_Umowa.Where(a => a.Imię == tbImie.Text);
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
            System.Linq.IQueryable vWorkerSurname = db.v_Umowa.Where(a => a.Nazwisko == tbNazwisko.Text);
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
            System.Linq.IQueryable vWorkerPosition = db.v_Umowa.Where(a => a.Nazwa_stanowiska == tbStanowisko.Text);
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
            System.Linq.IQueryable vWorkerDepartment = db.v_Umowa.Where(a => a.Nazwa_działu == tbDzial.Text);
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
            if (tbImie.Text.Length > 0)
                choose = "Surname";
            if (tbNazwisko.Text.Length > 0)
                choose = "Name";
            if (tbStanowisko.Text.Length > 0)
                choose = "Position";
            if (tbDzial.Text.Length > 0)
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
            FormHRDepartmentNewWorker formHRDepartmentNewWorker = new FormHRDepartmentNewWorker(db);
            formHRDepartmentNewWorker.ShowDialog();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            FormHRDepartmentWorkerContract formHRDepartmentWorkerContract = new FormHRDepartmentWorkerContract(db);
            formHRDepartmentWorkerContract.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHRDepartmentWorkerSalary formHRDepartmentWorkerSalary = new FormHRDepartmentWorkerSalary(db);
            formHRDepartmentWorkerSalary.ShowDialog();
        }
    }
}
