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
    public partial class editEmployee : Form
    {
        private LoginBL previous;
        public editEmployee(LoginBL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void editEmployee_Load(object sender, EventArgs e)
        {
            textBox1.Text = previous.EmployeeID;
            textBox2.Text = previous.EmployeeName;
            textBox3.Text = previous.Password;
            textBox4.Text = previous.PhoneNo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginBL updated = new LoginBL(textBox1.Text, textBox2.Text, textBox3.Text, long.Parse(textBox4.Text));
            LoginDL.editUser(previous ,updated);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
