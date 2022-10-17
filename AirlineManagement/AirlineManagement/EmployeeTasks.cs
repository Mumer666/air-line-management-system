using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagement
{
    public partial class EmployeeTasks : Form
    {
        public EmployeeTasks()
        {
            InitializeComponent();
        }

        private void EmployeeTasks_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.aboutPanel.Controls.Clear();
            EmployeeTasks et = new EmployeeTasks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.aboutPanel.Controls.Add(et.aboutPanel);
            et.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.aboutPanel.Controls.Clear();
            ManageEmployee me = new ManageEmployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.aboutPanel.Controls.Add(me);
            me.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.aboutPanel.Controls.Clear();
            AirLineManagement am = new AirLineManagement() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.aboutPanel.Controls.Add(am);
            am.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.aboutPanel.Controls.Clear();
            ManageFlights mf = new ManageFlights() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.aboutPanel.Controls.Add(mf);
            mf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.aboutPanel.Controls.Clear();
            ViewPassengers vp = new ViewPassengers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.aboutPanel.Controls.Add(vp);
            vp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.aboutPanel.Controls.Clear();
            ViewTransactions vt = new ViewTransactions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.aboutPanel.Controls.Add(vt);
            vt.Show();
        }
    }
}
