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
    public partial class AirLineManagement : Form
    {
        public AirLineManagement()
        {
            InitializeComponent();
        }

        private void dataBinding()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AddAirLineDL.AirLineList;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string airLineName = textBox1.Text;
            string model = textBox2.Text;
            string description = textBox3.Text;

            AddAirLineBL air = new AddAirLineBL(airLineName,model,description);
            AddAirLineDL.addInList(air);
            AddAirLineDL.writeAllData("AirLine.txt");
            dataBinding();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddAirLineBL air = (AddAirLineBL)dataGridView1.CurrentRow.DataBoundItem;
            if (e.ColumnIndex == 1)
            {
                AddAirLineDL.deleteAirLine(air);
                AddAirLineDL.writeAllData("AirLine.txt");
                dataBinding();
            }
            else if (e.ColumnIndex == 0)
            {
                editAirLine ea = new editAirLine(air);
                ea.ShowDialog();
                AddAirLineDL.writeAllData("AirLine.txt");
                dataBinding();
            }
        }

        private void AirLineManagement_Load(object sender, EventArgs e)
        {
            dataBinding();
        }
    }
}
