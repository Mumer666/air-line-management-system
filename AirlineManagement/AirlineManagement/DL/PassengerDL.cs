using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineManagement.BL;

namespace AirlineManagement.DL
{
    class PassengerDL
    {
        private static List<PassengerBL> passenegerList = new List<PassengerBL>();

        internal static List<PassengerBL> PassenegerList { get => passenegerList; set => passenegerList = value; }

        public static void addInList(PassengerBL pass)
        {
            passenegerList.Add(pass);
        }

        public static PassengerBL returnPassenger(string ticketNo)
        {
            foreach(PassengerBL pass in PassenegerList)
            {
                if(pass.TicketNo == ticketNo)
                {
                    return pass;
                }    
            }
            return null;
        }

        public static void deletePassenger(string ticketNo)
        {
            for (int i= 0;i < PassenegerList.Count;i++)
            {
                if (PassenegerList[i].TicketNo == ticketNo)
                {
                    PassenegerList.RemoveAt(i);
                }
            }
        }
        public static void writeAllData(string path)
        {
            StreamWriter writer = new StreamWriter(path, false);
            foreach (PassengerBL pass in PassenegerList)
            {
                writer.WriteLine(pass.PassengerFlight.FlightCode + "+" + pass.EmployeeName + "+" + pass.Passport + "+" + pass.PhoneNo + "+" + pass.Cnic + "+" + pass.TicketNo + "+" + pass.NumOfPassengers + "+" + pass.Cabin + "+" + pass.Seat + "+" + pass.Luggage + "+" + pass.Bill);
            }
            writer.Flush();
            writer.Close();
        }
        public static void writeData(string path , PassengerBL pass)
        {
            StreamWriter writer = new StreamWriter(path,true);
            writer.WriteLine(pass.PassengerFlight.FlightCode+"+"+pass.EmployeeName+"+"+pass.Passport+"+"+pass.PhoneNo+"+"+pass.Cnic+"+"+pass.TicketNo+"+"+pass.NumOfPassengers+"+"+pass.Cabin+"+"+ pass.Seat + "+"+pass.Luggage + "+"+pass.Bill);
            writer.Flush();
            writer.Close();
        }

        public static bool readData(string path)
        {
            if(File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                string record;
                while((record = reader.ReadLine()) != null)
                {
                    string[] data = record.Split('+');
                    AddFlightBL flight = AddFlightDL.returnFlight(data[0]);
                    string name = data[1];
                    string passport = data[2];
                    long phoneNo = long.Parse(data[3]);
                    long cnic = long.Parse(data[4]);
                    string ticketNo = data[5];
                    int numOfPassenger = int.Parse(data[6]);
                    string cabin = data[7];
                    string seat = data[8];
                    int luggage = int.Parse(data[9]);
                    double bill = double.Parse(data[10]);

                    PassengerBL pass = new PassengerBL(name, phoneNo, passport, cnic, ticketNo); 
                    pass.PassengerFlight = flight;
                    pass.NumOfPassengers = numOfPassenger;
                    pass.Cabin = cabin;
                    pass.Seat = seat;
                    pass.Luggage = luggage;
                    pass.Bill = bill;
                    passenegerList.Add(pass);
                }
                reader.Close();
                return true;

            }
            return false;
        }
    }
}
