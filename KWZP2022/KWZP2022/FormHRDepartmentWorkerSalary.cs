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
    public partial class FormHRDepartmentWorkerSalary : Form
    {
        KWZPEntities db;
        public FormHRDepartmentWorkerSalary(KWZPEntities db)
        {
            InitializeComponent();
            this.db = db;
            cleanTextBox();
            showData();
        }
        private void msgCleanShowData()
        {            
            cleanTextBox();
            showData();
        }
        private void cleanTextBox()
        {
            tbyear.Clear();
            tbmonth.Clear();
        }
            private void showData()
        {

            this.dgvsalary.DataSource = this.db.v_Koszt_godziny_pracy.ToList();
            this.dgvsalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbyear.Text.Length > 0)
                choose = "Rok";
            if (tbmonth.Text.Length > 0)
                choose = "Miesiac";

            switch (choose)
            {
                case "Rok":
                    wprowadzrok();
                    break;
                case "Miesiac":
                    wprowadzmiesiac();
                    break;               
            }
        }
        private void wprowadzmiesiac()
        {
            System.Linq.IQueryable miesiac = db.v_Koszt_godziny_pracy.Where(a => a.Miesiąc.ToString() == tbmonth.Text);
            int miesiacInt = miesiac.Cast<v_Koszt_godziny_pracy>().Count();
            if (miesiacInt > 0)
            {
                this.dgvsalary.DataSource = miesiac.Cast<v_Koszt_godziny_pracy>().ToList();
                this.dgvsalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData();
            }
        }
        private void wprowadzrok()
        {
            //System.Linq.IQueryable rok = db.v_Koszt_godziny_pracy.Where(a => a.rok.ToString() == tbyear.Text);
            //int rokInt = rok.Cast<v_Koszt_godziny_pracy>().Count();
            //if (rokInt > 0)
            //{
            //    this.dgvsalary.DataSource = rok.Cast<v_Koszt_godziny_pracy>().ToList();
            //    this.dgvsalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //    cleanTextBox();
            //}
            //else
            //{
            //    msgCleanShowData();
            //}
        }
    }
}
