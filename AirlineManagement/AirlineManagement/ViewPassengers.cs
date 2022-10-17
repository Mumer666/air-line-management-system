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
namespace AirlineManagement
{
    public partial class ViewPassengers : Form
    {
        public ViewPassengers()
        {
            InitializeComponent();
        }

        private void ViewPassengers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PassengerDL.PassenegerList;
            dataGridView1.Refresh();
        }
    }
}
