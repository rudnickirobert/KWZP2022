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
            comboBoxAddValue();
        }

        private void comboBoxAddValue()
        {
            cbPosition.DataSource = this.db.Stanowisko.ToList();
            cbPosition.ValueMember = "ID_stanowisko";
            cbPosition.DisplayMember = "Nazwa_stanowiska";
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
        }

        private void msgCleanShowData()
        {
            cleanTextBox();
            showData();
        }

        private void enterSurname()
        {
            List<v_Pracownik> workerList = db.v_Pracownik.Where(a => a.Nazwisko == tbNazwiskoU.Text).ToList();
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
        private void enterName()
        {
            List<v_Pracownik> workerList = db.v_Pracownik.Where(a => a.Imię == tbImieU.Text).ToList();
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
            List<v_Umowa> workerList = db.v_Umowa.Where(a => a.Nazwa_stanowiska == cbPosition.Text).ToList();
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
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK);
            showData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbImieU.Text.Length > 0)
                choose = "Name";
            if (tbNazwiskoU.Text.Length > 0)
                choose = "Surname";
            if (cbPositionFind.Checked)
                choose = "Position";

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
            FormHRDepartmentWorkerContractNew formHRDepartmentWorkerContractNew = new FormHRDepartmentWorkerContractNew(db);
            formHRDepartmentWorkerContractNew.ShowDialog();
        }
    }
}
