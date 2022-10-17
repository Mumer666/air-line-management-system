using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement.BL
{
    class PassengerBL : personBL
    {
        private AddFlightBL passengerFlight;
        private string passport;
        private long cnic;
        private string ticketNo;
        private int numOfPassengers;
        private string cabin;
        private string seat;
        private int luggage;
        private double bill;


        public PassengerBL(string name , long phoneNo , string passport , long cnic , string ticketNo) :base(name,phoneNo)
        {
            this.Passport = passport;
            this.TicketNo = ticketNo;
            this.Cnic = cnic;
        }

        public AddFlightBL PassengerFlight { get => passengerFlight; set => passengerFlight = value; }
        public string Passport { get => passport; set => passport = value; }
        public long Cnic { get => cnic; set => cnic = value; }
        public string TicketNo { get => ticketNo; set => ticketNo = value; }
        public int NumOfPassengers { get => numOfPassengers; set => numOfPassengers = value; }
        public string Cabin { get => cabin; set => cabin = value; }
        public string Seat { get => seat; set => seat = value; }
        public int Luggage { get => luggage; set => luggage = value; }
        public double Bill { get => bill; set => bill = value; }
    }
}
