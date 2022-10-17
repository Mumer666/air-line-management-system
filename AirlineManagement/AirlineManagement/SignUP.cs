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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string employeeID = textBox1.Text;
            string employeeName = textBox2.Text;
            string password = textBox3.Text;
            long phoneNo = long.Parse(textBox4.Text);

            LoginBL user = new LoginBL(employeeID,employeeName,password,phoneNo);
            LoginDL.addInList(user);
            LoginDL.writeData("data.txt", user);
            MessageBox.Show("successfully registered");
            this.Close();
        }
    }
}
