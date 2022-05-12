using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KWZP2022
{
    public partial class FormHRDepartmentSalary : Form
    {
        KWZPEntities db;
        public FormHRDepartmentSalary(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cleanTextBox();
            showData();
        }
        private void cleanTextBox()
        {
            tbImie.Clear();
            tbNazwisko.Clear();
        }
        private void msgCleanShowData()
        {
            cleanTextBox();
            showData();
        }
        private void showData()
        {
            this.dgvSalary.DataSource = db.v_Wyplata_suma.ToList();
            dgvSalary.Columns["ID_pracownik"].Visible = false;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void enterName()
        {
            List<v_Wyplata_suma> workerList = db.v_Wyplata_suma.Where(a => a.Imię == tbImie.Text).ToList();
            if (workerList.Count() > 0)
            {
                this.dgvSalary.DataSource = workerList;
                this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterSurname()
        {
            List<v_Wyplata_suma> workerList = db.v_Wyplata_suma.Where(a => a.Nazwisko == tbNazwisko.Text).ToList();
            if (workerList.Count() > 0)
            {
                this.dgvSalary.DataSource = workerList;
                this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterMonth()
        {
            List<v_Wyplata_suma> workerList = db.v_Wyplata_suma.Where(a => a.Miesiac_wyplata.ToString() == tbMonth.Text).ToList();
            if (workerList.Count() > 0)
            {
                this.dgvSalary.DataSource = workerList;
                this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string choose = "";
            if (tbImie.Text.Length > 0)
                choose = "Name";
            if (tbNazwisko.Text.Length > 0)
                choose = "Surname";
            if (tbMonth.Text.Length > 0)
                choose = "Month";
            switch (choose)
            {
                case "Name":
                    enterName();
                    break;
                case "Surname":
                    enterSurname();
                    break;
                case "Month":
                    enterMonth();
                    break;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            cleanTextBox();
        }
        
        private void btnNewSalary_Click(object sender, EventArgs e)
        {
            FormHRDepartmentNewSalary formHRDepartmentNewSalary = new FormHRDepartmentNewSalary(db);
            formHRDepartmentNewSalary.ShowDialog();
        }
    }
}
