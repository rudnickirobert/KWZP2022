﻿using System;
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

        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK);
            showData();
        }
        private void enterName()
        {
            List<v_Pracownik> workerList = db.v_Pracownik.Where(a => a.Imię == tbImie.Text).ToList();
            if (workerList.Count() > 0)
            {
                this.dgvWorker.DataSource = workerList;
                this.dgvWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void enterSurname()
        {
            List<v_Pracownik> workerList = db.v_Pracownik.Where(a => a.Nazwisko == tbNazwisko.Text).ToList();
            if (workerList.Count() > 0)
            {
                this.dgvWorker.DataSource = workerList;
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
            List<v_Umowa> workerList = db.v_Umowa.Where(a => a.Nazwa_stanowiska == tbStanowisko.Text).ToList();
            if (workerList.Count() > 0)
            {
                this.dgvWorker.DataSource = workerList;
                this.dgvWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
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
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            cleanTextBox();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            FormHRDepartmentNewWorker formHRDepartmentNewWorker = new FormHRDepartmentNewWorker(db);
            formHRDepartmentNewWorker.ShowDialog();
        }

        private void btnChangedata_Click(object sender, EventArgs e)
        {
            FormHRDepartmentWorkerModify formHRDepartmentWorkerModify = new FormHRDepartmentWorkerModify(db);
            formHRDepartmentWorkerModify.ShowDialog();
        }

        private void btnNieobecnosci_Click(object sender, EventArgs e)
        {
            FormHRDepartmentTimesheets formHRDepartmentTimesheets = new FormHRDepartmentTimesheets(db);
            formHRDepartmentTimesheets.ShowDialog();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            FormHRDepartmentWorkerContract formHRDepartmentWorkerContract = new FormHRDepartmentWorkerContract(db);
            formHRDepartmentWorkerContract.ShowDialog();
        }
    }
}