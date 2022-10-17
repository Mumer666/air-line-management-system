using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement.DL
{
    class AddAirLineDL
    {
        private static List<AddAirLineBL> airLineList = new List<AddAirLineBL>();

        public static List<AddAirLineBL> AirLineList { get => airLineList; set => airLineList = value; }

        public static void addInList(AddAirLineBL air)
        {
            airLineList.Add(air);
        }

        public static void deleteAirLine(AddAirLineBL air)
        {
            for (int i = 0; i < airLineList.Count; i++)
            {
                if (AirLineList[i].AirLineName == air.AirLineName && airLineList[i].Model == air.Model && airLineList[i].Description == air.Description)
                {
                    airLineList.RemoveAt(i);
                }
            }

        }

        public static void editAirLine(AddAirLineBL previous, AddAirLineBL updated)
        {
            for (int i = 0; i < airLineList.Count; i++)
            {
                if (airLineList[i].AirLineName == previous.AirLineName && AirLineList[i].Model == previous.Model )
                {
                    airLineList[i].AirLineName = updated.AirLineName;
                    airLineList[i].Model = updated.Model;
                    airLineList[i].Description = updated.Description;
                }
            }

        }
        public static void writeAllData(string path)
        {
            StreamWriter writer = new StreamWriter(path, false);
            foreach(AddAirLineBL air in AirLineList)
            {
                writer.WriteLine(air.AirLineName + "," + air.Model + "," + air.Description);
            }
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
                    string[] data = record.Split(',');
                    string airLineName = data[0];
                    string model = data[1];
                    string description = data[2];

                    AddAirLineBL air = new AddAirLineBL(airLineName,model,description);
                    airLineList.Add(air);
                }
                reader.Close();
                return true;
            }
            return false;
        }
    }
}
