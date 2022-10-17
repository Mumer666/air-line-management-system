using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement.BL
{
    public class AddFlightBL
    {
        private string airLine;
        private string departure;
        private string destination;
        private string flightCode;
        private string date;
        private int luggage;
        private int distance;

        public AddFlightBL(string airLine,string departure, string destination, string flightCode, string date, int luggage, int distance)
        {
            this.AirLine = airLine;
            this.departure = departure;
            this.destination = destination;
            this.flightCode = flightCode;
            this.date = date;
            this.luggage = luggage;
            this.distance = distance;
        }

        public string AirLine { get => airLine; set => airLine = value; }
        public string Departure { get => departure; set => departure = value; }
        public string Destination { get => destination; set => destination = value; }
        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string Date { get => date; set => date = value; }
        public int Luggage { get => luggage; set => luggage = value; }
        public int Distance { get => distance; set => distance = value; }
        
    }
}
