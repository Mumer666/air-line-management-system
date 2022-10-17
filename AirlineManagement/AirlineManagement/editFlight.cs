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
    public partial class editFlight : Form
    {
        private AddFlightBL previous;
        public editFlight(AddFlightBL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void editFlight_Load(object sender, EventArgs e)
        {
            textBox7.Text = previous.AirLine;
            textBox1.Text = previous.Departure;
            textBox2.Text = previous.Destination;
            textBox3.Text = previous.FlightCode;
            textBox4.Text = previous.Date.ToString();
            textBox5.Text = previous.Luggage.ToString();
            textBox6.Text = previous.Distance.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFlightBL updated = new AddFlightBL(textBox7.Text,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,int.Parse(textBox5.Text),int.Parse(textBox6.Text));
            AddFlightDL.editFlight(previous,updated);
            this.Close();
        }
    }
}
