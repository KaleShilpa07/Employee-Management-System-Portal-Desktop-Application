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
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            UseNameTB.Text = "";
            PasswordTB.Text = "";
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if (UseNameTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Missing Data...");
            }
            else if (UseNameTB.Text == "NTS" || PasswordTB.Text == "NTS")
            {
                Employees1 obj = new Employees1();
                obj.Show();
                this.Show();

            }
            else
            {
                MessageBox.Show(" Wrong UserName And Password..");
                UseNameTB.Text = "";
                PasswordTB.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
