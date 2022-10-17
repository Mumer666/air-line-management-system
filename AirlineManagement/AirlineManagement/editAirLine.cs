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
    public partial class editAirLine : Form
    {
        private AddAirLineBL previous;
        public editAirLine(AddAirLineBL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void editAirLine_Load(object sender, EventArgs e)
        {
            textBox1.Text = previous.AirLineName;
            textBox2.Text = previous.Model;
            textBox3.Text = previous.Description;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAirLineBL updated = new AddAirLineBL(textBox1.Text, textBox2.Text, textBox3.Text);
            AddAirLineDL.editAirLine(previous, updated);
            this.Close();
        }
    }
}
