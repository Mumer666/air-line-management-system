using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement
{
    public class AddAirLineBL
    {
        private string airLineName;
        private string model;
        private string description;

        public AddAirLineBL(string airLineName , string model , string description)
        {
            this.airLineName = airLineName;
            this.model = model;
            this.description = description;
        }

        public string AirLineName { get => airLineName; set => airLineName = value; }
        public string Model { get => model; set => model = value; }
        public string Description { get => description; set => description = value; }
    }
}
