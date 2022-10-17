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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void dataBinding()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LoginDL.UserList;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string employeeID = textBox1.Text;
            string employeeName = textBox2.Text;
            string password = textBox3.Text;
            long phoneNo = long.Parse(textBox4.Text);

            LoginBL user = new LoginBL(employeeID,employeeName,password,phoneNo);
            LoginDL.addInList(user);
            LoginDL.writeData("data.txt",user);
            MessageBox.Show("successfully inserted");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dataBinding();

        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            dataBinding();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoginBL user = (LoginBL)dataGridView1.CurrentRow.DataBoundItem;
            if(e.ColumnIndex == 1)
            {
                LoginDL.deleteUser(user);
                LoginDL.writeALLData("data.txt");
                dataBinding();
            }
            else if(e.ColumnIndex == 0)
            {
                editEmployee ee = new editEmployee(user);
                ee.ShowDialog();
                LoginDL.writeALLData("data.txt");
                dataBinding();
            }
        }
    }
}
