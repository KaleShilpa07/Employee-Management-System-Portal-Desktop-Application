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
    public partial class Employees1 : Form
    {
        DataFunctions con;
        public Employees1()
        {
            InitializeComponent();
            con = new DataFunctions();
            showEmployees();
            GetDeptName();
        }
        private void showEmployees()
        {
            string Query = "select* from EmployeeTable";
            EmpList.DataSource = con.GetData(Query);

        }
        private void ListDeptName() { }
        private void GetDeptName()
        {
            string Query = "select* from DepartmentTable";
            EmpDeptCB.DisplayMember = con.GetData(Query).Columns["DeptName"].ToString();
            EmpDeptCB.ValueMember = con.GetData(Query).Columns["DeptId"].ToString();
            EmpDeptCB.DataSource = con.GetData(Query);
        }

        int key = 0;
        private void EmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTB.Text = EmpList.SelectedRows[0].Cells[1].Value.ToString();

            //Remaining  Null reference issue 
            EmpGenCB.Text = EmpList.SelectedRows[0].Cells[2].Value.ToString();
            EmpDeptCB.SelectedValue = EmpList.SelectedRows[0].Cells[3].Value.ToString();
            DOBPicker.Text = EmpList.SelectedRows[0].Cells[4].Value.ToString();
            JoinDatePicker.Text = EmpList.SelectedRows[0].Cells[5].Value.ToString();
            EmpDailySalaryTB.Text = EmpList.SelectedRows[0].Cells[6].Value.ToString();
            if (EmpNameTB.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(EmpList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EmpLBL_Click(object sender, EventArgs e)
        {
            Employees1 employees1 = new Employees1();
            employees1.Show();
            this.Hide();
        }

        private void DeptLBL_Click(object sender, EventArgs e)
        {
            Departmentes1 dd = new Departmentes1();
            dd.Show();
            this.Hide();

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("MissingData !!! ");

                }
                else
                {

                    string InsertQuery = "Delete EmployeeTable where EmpId='{0}'";
                    InsertQuery = string.Format(InsertQuery, key);
                    con.SetData(InsertQuery);
                    showEmployees();
                    MessageBox.Show(" Employee Deleted ...");

                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
        }
        private void EmpAddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTB.Text == "" || EmpGenCB.SelectedIndex == -1 || EmpDeptCB.SelectedIndex == -1 || EmpDailySalaryTB.Text == "")
                {
                    MessageBox.Show("MissingData !!! ");

                }
                else
                {
                    string Name = EmpNameTB.Text;
                    string Gender = EmpGenCB.SelectedItem.ToString();
                    int Deptnm = Convert.ToInt32(EmpDeptCB.SelectedValue.ToString());
                    string dob = DOBPicker.Value.ToString();
                    string joindate = JoinDatePicker.Value.ToString();
                    string salary = Convert.ToInt32(EmpDailySalaryTB.Text).ToString();

                    //string Dept = EmpNameTB.Text;
                    string InsertQuery = "insert into EmployeeTable values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    InsertQuery = string.Format(InsertQuery, Name, Gender, Deptnm, dob, joindate, salary);
                    con.SetData(InsertQuery);
                    showEmployees();
                    MessageBox.Show(" Employee Added Successfully...");
                    EmpNameTB.Text = "";
                    EmpDailySalaryTB.Text = "";
                    EmpGenCB.SelectedIndex = -1;
                    EmpDeptCB.SelectedIndex = -1;


                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }

        }

        private void EmpEditBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTB.Text == "" || EmpGenCB.SelectedIndex == -1 || EmpDeptCB.SelectedIndex == -1 || EmpDailySalaryTB.Text == "")
                {
                    MessageBox.Show(" Please Insert All Records.. !!! ");

                }
                else
                {
                    string Name = EmpNameTB.Text;
                    string Gender = EmpGenCB.SelectedItem.ToString();
                    int Deptnm = Convert.ToInt32(EmpDeptCB.SelectedValue.ToString());
                    string dob = DOBPicker.Value.ToString();
                    string joindate = JoinDatePicker.Value.ToString();
                    string salary = Convert.ToInt32(EmpDailySalaryTB.Text).ToString();

                    string InsertQuery = "Update EmployeeTable set EmpName='{0}',EmpGender='{1}',EmpDept={2},EmpDOB='{3}',EmpJoinDate='{4}',EmpSalary={5} where EmpId='{6}'";
                    InsertQuery = string.Format(InsertQuery, Name, Gender, Deptnm, dob, joindate, salary, key);
                    con.SetData(InsertQuery);
                    showEmployees();
                    MessageBox.Show("Update Successfully...");
                    EmpNameTB.Text = "";
                    EmpDailySalaryTB.Text = "";
                    EmpGenCB.SelectedIndex = -1;
                    EmpDeptCB.SelectedIndex = -1;
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
        }

        private void SalaryLBL_Click(object sender, EventArgs e)
        {
            Salaries Emp = new Salaries();
            Emp.Show();
            this.Hide();
        }

        private void LogoutLBL_Click(object sender, EventArgs e)
        {
            Login1 ss = new Login1();
            ss.Show();

            this.Hide();
        }
    }
}
