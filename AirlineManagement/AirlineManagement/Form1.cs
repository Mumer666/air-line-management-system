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
    public partial class Form1 : Form
    {
        //**************Global Variables for Passengers ******************************
        private AddFlightBL passengerFlight;
        private int numOfPassenger;
        private string cabin;
        int luggage;
        string seat;
        double bill;


        //Passenger Object
        private PassengerBL travelor;




        public Form1()
        {
            InitializeComponent();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SignIN s = new SignIN();
            s.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(passengerFlight == null)
            {
                MessageBox.Show("please select Flight");
            }
            else
            {
                tabControl1.SelectedTab = tabPage4;
                label16.Text = label16.Text +"  "+passengerFlight.AirLine;
                label17.Text = label17.Text +"  "+passengerFlight.Date;
                label18.Text = label18.Text +"  "+passengerFlight.Departure;
                label50.Text = label50.Text +"  "+passengerFlight.Destination;
                label19.Text = label19.Text +"  "+passengerFlight.Luggage;
                label20.Text = label20.Text + "  "+5000;
            }
            
        }


        private void button9_Click(object sender, EventArgs e)
        {
            numOfPassenger = int.Parse(numericUpDown1.Text);
            if(radioButton1.Checked == true)
            {
                cabin = "Bussiness";
            }
            else if(radioButton2.Checked == true)
            {
                cabin = "Economy";
            }
            luggage = int.Parse(textBox8.Text);

            if(radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("please select your cabin");
            }
            else 
            {
                tabControl1.SelectedTab = tabPage5;
                label24.Text = cabin;
                
            }
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            label41.Text = travelor.EmployeeName;
            label42.Text = travelor.Passport;
            label43.Text = travelor.Cnic.ToString();
            label46.Text = travelor.PassengerFlight.AirLine;
            label45.Text = travelor.PassengerFlight.Destination;
            label44.Text = travelor.PassengerFlight.Date;
            tabControl1.SelectedTab = tabPage7;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginDL.UserList.Clear();
            LoginDL.readData("data.txt");
            AddAirLineDL.AirLineList.Clear();
            AddAirLineDL.readData("AirLine.txt");
            AddFlightDL.FlightList.Clear();
            AddFlightDL.readData("flight.txt");
            PassengerDL.PassenegerList.Clear();
            PassengerDL.readData("passenger.txt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string departure = textBox6.Text;
            string destination = textBox7.Text;
            List<AddFlightBL> availableList = AddFlightDL.isFlightExists(departure, destination);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = availableList;
            dataGridView1.Refresh();
            MessageBox.Show("select your flight by clicking on your favourite flight");
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            passengerFlight = (AddFlightBL)dataGridView1.CurrentRow.DataBoundItem;
        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            this.button16.BackColor = Color.Yellow;
            label25.Text = "2D";
            seat = label25.Text;
        }

        private void button17_MouseClick(object sender, MouseEventArgs e)
        {
            this.button17.BackColor = Color.Yellow;
            label25.Text = "2C";
            seat = label25.Text;
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            this.button13.BackColor = Color.Yellow;
            label25.Text = "2B";
            seat = label25.Text;
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            this.button12.BackColor = Color.Yellow;
            label25.Text = "2A";
            seat = label25.Text;
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            this.button10.BackColor = Color.Yellow;
            label25.Text = "1A";
            seat = label25.Text;
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            this.button11.BackColor = Color.Yellow;
            label25.Text = "1B";
            seat = label25.Text;
        }

        private void button19_MouseClick(object sender, MouseEventArgs e)
        {
            this.button19.BackColor = Color.Yellow;
            label25.Text = "1C";
            seat = label25.Text;
        }

        private void button18_MouseClick(object sender, MouseEventArgs e)
        {
            this.button18.BackColor = Color.Yellow;
            label25.Text = "1D";
            seat = label25.Text;
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            this.button14.BackColor = Color.Yellow;
            label25.Text = "3A";
            seat = label25.Text;
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            this.button15.BackColor = Color.Yellow;
            label25.Text = "3B";
            seat = label25.Text;
        }

        private void button20_MouseClick(object sender, MouseEventArgs e)
        {
            this.button20.BackColor = Color.Yellow;
            label25.Text = "3C";
            seat = label25.Text;
        }

        private void button21_MouseClick(object sender, MouseEventArgs e)
        {
            this.button21.BackColor = Color.Yellow;
            label25.Text = "3D";
            seat = label25.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label26.Text = (numOfPassenger * 5000) + "  Rs";
            string name = textBox10.Text;
            string passport = textBox11.Text;
            long phoneNo = long.Parse(textBox12.Text);
            long CNIC = long.Parse(textBox9.Text);
            string ticketNo = "#JA" + passport;
            travelor = new PassengerBL(name,phoneNo,passport,CNIC,ticketNo);
            bill = numOfPassenger * 5000;
            travelor.PassengerFlight = passengerFlight;
            travelor.NumOfPassengers = numOfPassenger;
            travelor.Cabin = cabin;
            travelor.Seat = seat;
            travelor.Luggage = luggage;
            travelor.Bill = bill;

            PassengerDL.addInList(travelor);
            PassengerDL.writeData("passenger.txt",travelor);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ticket = textBox1.Text;
            PassengerBL pass;
            if (PassengerDL.returnPassenger(ticket) == null)
            {
                MessageBox.Show("not exists");
            }
            else
            {
                pass = PassengerDL.returnPassenger(ticket);
                textBox2.Text = pass.EmployeeName;
                textBox3.Text = pass.Passport;
                textBox4.Text = pass.PhoneNo.ToString();
                textBox5.Text = pass.Cnic.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PassengerDL.deletePassenger(textBox1.Text);
            PassengerDL.writeAllData("passenger.txt");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show("deleted");
        }
    }
}
