using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineManagement.DL;
using AirlineManagement.BL;

namespace AirlineManagement
{
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataBinding()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AddFlightDL.FlightList;
            dataGridView1.Refresh();
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {
            dataBinding();
            comboBox1.Items.Clear();
            foreach (AddAirLineBL air in AddAirLineDL.AirLineList)
            {
                comboBox1.Items.Add(air.AirLineName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string airLine = comboBox1.Text;
            string departure = textBox1.Text;
            string destination = textBox2.Text;
            string flightCode = textBox3.Text;
            string date = dateTimePicker1.Text;
            int luggage = int.Parse(textBox4.Text);
            int distance = int.Parse(textBox5.Text);

            AddFlightBL flight = new AddFlightBL(airLine,departure,destination,flightCode,date,luggage,distance);
            AddFlightDL.addInList(flight);
            AddFlightDL.writeAllData("flight.txt");
            dataBinding();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddFlightBL flight = (AddFlightBL)dataGridView1.CurrentRow.DataBoundItem;
            if (e.ColumnIndex == 1)
            {
                AddFlightDL.deleteFlight(flight);
                AddFlightDL.writeAllData("flight.txt");
                dataBinding();
            }
            else if (e.ColumnIndex == 0)
            {
                editFlight ef = new editFlight(flight);
                ef.ShowDialog();
                AddFlightDL.writeAllData("flight.txt");
                dataBinding();
            }
        }
    }
}
