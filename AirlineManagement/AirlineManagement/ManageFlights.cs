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
    public partial class ManageFlights : Form
    {
        public ManageFlights()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.flightPanel.Controls.Clear();
            AddFlight af = new AddFlight() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.flightPanel.Controls.Add(af);
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delayFlights df = new delayFlights();
            df.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this functionality is currently unavailable");
        }
    }
}
