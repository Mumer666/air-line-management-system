using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineManagement.BL;
namespace AirlineManagement.DL
{
    class AddFlightDL
    {
        private static List<AddFlightBL> flightList = new List<AddFlightBL>();

        public static List<AddFlightBL> FlightList { get => flightList; set => flightList = value; }

        public static void addInList(AddFlightBL flight)
        {
            flightList.Add(flight);
        }

        public static AddFlightBL returnFlight(string code)
        {
            foreach (AddFlightBL flights in FlightList)
            {
                if (flights.FlightCode == code)
                {
                    return flights;
                }
            }
            return null;
        }
        public static List<AddFlightBL> isFlightExists(string departure , string destination)
        {
            List<AddFlightBL> availableFlights = new List<AddFlightBL>();
            foreach(AddFlightBL flights in FlightList)
            {
                if(flights.Departure == departure && flights.Destination == destination)
                {
                    availableFlights.Add(flights);
                }
            }
            return availableFlights;
        }

        public static void deleteFlight(AddFlightBL flight)
        {
            for (int i = 0; i < flightList.Count; i++)
            {
                if (flightList[i].Departure == flight.Departure && flightList[i].Destination == flight.Destination && flightList[i].FlightCode == flight.FlightCode)
                {
                    flightList.RemoveAt(i);
                }
            }

        }

        public static void editFlight(AddFlightBL previous, AddFlightBL updated)
        {
            for (int i = 0; i < flightList.Count; i++)
            {
                if (flightList[i].Departure == previous.Departure && flightList[i].Destination == previous.Destination && flightList[i].FlightCode == previous.FlightCode)
                {
                    flightList[i].Departure = updated.Departure;
                    flightList[i].Destination = updated.Destination;
                    flightList[i].FlightCode = updated.FlightCode;
                    flightList[i].Date = updated.Date;
                    flightList[i].Luggage = updated.Luggage;
                    flightList[i].Distance = updated.Distance;
                }
            }

        }
        public static void writeAllData(string path)
        {
            StreamWriter writer = new StreamWriter(path, false);
            foreach (AddFlightBL flight in flightList)
            {
                writer.WriteLine(flight.AirLine+"+"+flight.Departure + "+" + flight.Destination + "+" + flight.FlightCode+"+"+flight.Date+"+"+flight.Luggage+"+"+flight.Distance);
            }
            writer.Flush();
            writer.Close();
        }

        public static bool readData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                string record;
                while ((record = reader.ReadLine()) != null)
                {
                    string[] data = record.Split('+');
                    string airLine = data[0];
                    string departure = data[1];
                    string destination = data[2];
                    string flightCode = data[3];
                    string date = data[4];
                    int luggage = int.Parse(data[5]);
                    int distance = int.Parse(data[6]);

                    AddFlightBL flight = new AddFlightBL(airLine,departure,destination,flightCode,date,luggage,distance);
                    flightList.Add(flight);
                }
                reader.Close();
                return true;
            }
            return false;
        }
    }
}
