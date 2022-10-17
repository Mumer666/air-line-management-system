using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineManagement.BL;
using AirlineManagement.DL;

namespace AirlineManagement
{
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string employeeID = textBox1.Text;
            string employeeName = textBox2.Text;
            string password = textBox3.Text;
            LoginBL user = new LoginBL(employeeID,employeeName,password);
            if(LoginDL.isUserExists(user) != null)
            {
                MessageBox.Show("welcome to Fly Jinnah");
                this.Close();
                EmployeeTasks et = new EmployeeTasks();
                et.Show();
            }
            else
            {
                MessageBox.Show("incorrect credentials");
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SignUP su = new SignUP();
            su.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked == true)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            if (this.checkBox1.Checked == false)
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }
    }
}
