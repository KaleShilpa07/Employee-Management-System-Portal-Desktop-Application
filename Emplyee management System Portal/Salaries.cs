using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emplyee_management_System_Portal
{
    public partial class Salaries : Form
    {
        DataFunctions CON;
        public Salaries()
        {
            InitializeComponent();
            CON = new DataFunctions();
            ShowSalaries();
            GetEmpName();
            GetSalary();
        }
        private void ShowSalaries()
        {
            string Query = "select* from SalaryTable";
            SalaryList.DataSource = CON.GetData(Query);

        }
        private void GetEmpName()
        {
            string Query = "select* from EmployeeTable";
            EmpCB.DisplayMember = CON.GetData(Query).Columns["EmpName"].ToString();
            EmpCB.ValueMember = CON.GetData(Query).Columns["EmpId"].ToString();
            EmpCB.DataSource = CON.GetData(Query);
        }
        int DispSal = 0;
        string period = "";
        private void GetSalary()
        {
            string Query = "select EmpSalary from EmployeeTable where EmpId={0}";
            Query = string.Format(Query, EmpCB.SelectedValue.ToString());
            foreach (DataRow dr in CON.GetData(Query).Rows)
            {
                DispSal = Convert.ToInt32(dr["EmpSalary"].ToString());
            }
            if (DayAttendTB.Text == "")
            {
                SalaryAmountTB.Text = " Rs " + (d * DispSal);

            }
            else if (Convert.ToInt32(DayAttendTB.Text) > 31)
            {
                MessageBox.Show("Day Not Allow Greater than 31");
            }
            else
            {
                d = Convert.ToInt32(DayAttendTB.Text);
                SalaryAmountTB.Text = " Rs " + (d * DispSal);
            }



            // MessageBox.Show("" + DispSal);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        int d = 1;
        private void AddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCB.SelectedIndex == -1 || DayAttendTB.Text == "" || periodDatetimepicker.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    period = periodDatetimepicker.Value.Date.Month.ToString() + "-" + periodDatetimepicker.Value.Date.Month.ToString();
                    int Amount = DispSal * Convert.ToInt32(DayAttendTB.Text);


                    int days = Convert.ToInt32(DayAttendTB.Text);

                    string InsertQuery = "insert into SalaryTable values({0},{1},'{2}',{3},'{4}')";
                    InsertQuery = string.Format(InsertQuery, EmpCB.SelectedValue.ToString(), days, period, Amount, DateTime.Today.Date);
                    CON.SetData(InsertQuery);
                    ShowSalaries();
                    MessageBox.Show(" Salary Paid Successfully...");
                    DayAttendTB.Text = "";

                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (SalaryAmountTB.Text == "" || EmpCB.SelectedIndex == -1 || DayAttendTB.Text == "")
                {
                    MessageBox.Show(" Please Insert All Records.. !!! ");

                }
                else
                {

                    int Empname = Convert.ToInt32(EmpCB.SelectedValue.ToString());
                    string DayAttend = DayAttendTB.Text;

                    string Periods = periodDatetimepicker.Value.ToString();
                    string SalaryAmount = Convert.ToInt32(SalaryAmountTB.Text).ToString();

                    string InsertQuery = "Update SalaryTable set Employee={0},Attendance='{1}',Period='{2}',Amount={3} where SalaryCode='{4}'";

                    InsertQuery = string.Format(InsertQuery, Empname, DayAttend, Periods, SalaryAmount, key);
                    CON.SetData(InsertQuery);
                    ShowSalaries();
                    MessageBox.Show("Update Successfully...");
                    EmpCB.SelectedIndex = -1;
                    DayAttendTB.Text = "";
                    SalaryAmountTB.Text = "";
                    //remaining changes(update SalaryAmountTB)
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
        }

        private void EmpCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void EmpLBL_Click(object sender, EventArgs e)
        {
            Employees1 Emp = new Employees1();
            Emp.Show();
            this.Hide();
        }
        int key = 0;
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (SalaryAmountTB.Text == "")
                {
                    MessageBox.Show("Please Insert All Records !!! ");

                }
                else
                {
                    string Dept = SalaryAmountTB.Text;
                    string InsertQuery = "Delete SalaryTable where SalaryCode='{0}'";
                    InsertQuery = string.Format(InsertQuery, key);
                    CON.SetData(InsertQuery);
                    ShowSalaries();
                    MessageBox.Show(" Record Deleted Success ...");
                    SalaryAmountTB.Text = "";
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
        }

        private void SalaryList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EmpCB.Text = SalaryList.SelectedRows[0].Cells[1].Value.ToString();
            DayAttendTB.Text = SalaryList.SelectedRows[0].Cells[2].Value.ToString();
            periodDatetimepicker.Text = SalaryList.SelectedRows[0].Cells[3].Value.ToString();

            SalaryAmountTB.Text = SalaryList.SelectedRows[0].Cells[4].Value.ToString();

            if (SalaryAmountTB.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(SalaryList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeptLBL_Click(object sender, EventArgs e)
        {
            Departmentes1 Emp = new Departmentes1();
            Emp.Show();
            this.Hide();
        }

        private void LogoutLBL_Click(object sender, EventArgs e)
        {
            Login1 ss = new Login1();
            ss.Show();

            this.Hide();
        }
        //remaing changes
        public void TextBoxFilter()
        {
           
            string InsertQuery = "Select * from SalaryTable where Employee = '"+ DayAttendTB.Text + "'";
            InsertQuery = string.Format(InsertQuery);
            CON.SetData(InsertQuery);
            ShowSalaries();
            
        }
        private void SearchBTN_Click(object sender, EventArgs e)
        {
            TextBoxFilter();


        }
    }
}
