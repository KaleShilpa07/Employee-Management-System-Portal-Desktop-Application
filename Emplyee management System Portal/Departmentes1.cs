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
    public partial class Departmentes1 : Form
    {
        DataFunctions con;
        public Departmentes1()
        {
            InitializeComponent();
            con = new DataFunctions();
            ShowDepartments();
        }

        private void EmpLBL_Click(object sender, EventArgs e)
        {
            Employees1 Emp = new Employees1();
            Emp.Show();
            this.Hide();
        }

        private void ShowDepartments()
        {
            string Query = "select* from DepartmentTable";
            DeptList.DataSource = con.GetData(Query);

        }
        private void AddDeptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeptNameTB.Text == "")
                {
                    MessageBox.Show("MissingData !!! ");

                }
                else
                {
                    string Dept = DeptNameTB.Text;
                    string InsertQuery = "insert into DepartmentTable values('{0}')";
                    InsertQuery = string.Format(InsertQuery, DeptNameTB.Text);
                    con.SetData(InsertQuery);
                    ShowDepartments();
                    MessageBox.Show(" Department Added Successfully...");
                    DeptNameTB.Text = "";
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }

        }
        int key = 0;
        private void DeptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeptNameTB.Text = DeptList.SelectedRows[0].Cells[1].Value.ToString();
            if (DeptNameTB.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(DeptList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeptNameTB.Text == "")
                {
                    MessageBox.Show("Please Insert All Records !!! ");

                }
                else
                {
                    string Dept = DeptNameTB.Text;
                    string InsertQuery = "Delete DepartmentTable where DeptId='{0}'";
                    InsertQuery = string.Format(InsertQuery, key);
                    con.SetData(InsertQuery);
                    ShowDepartments();
                    MessageBox.Show(" Department Deleted ...");
                    DeptNameTB.Text = "";
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
        }

        private void EditDeptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeptNameTB.Text == "")
                {
                    MessageBox.Show("MissingData !!! ");

                }
                else
                {
                    string Dept = DeptNameTB.Text;
                    string InsertQuery = "Update DepartmentTable set DeptName='{0}' where DeptId='{1}'";
                    InsertQuery = string.Format(InsertQuery, DeptNameTB.Text, key);
                    con.SetData(InsertQuery);
                    ShowDepartments();
                    MessageBox.Show(" Department Update Successfully...");
                    DeptNameTB.Text = "";
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
        }

        private void DeptLBL_Click(object sender, EventArgs e)
        {
            Departmentes1 dd = new Departmentes1();
            dd.Show();
            this.Hide();
        }

        private void SalaryLBL_Click(object sender, EventArgs e)
        {
            Salaries ss = new Salaries();
            ss.Show();

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
