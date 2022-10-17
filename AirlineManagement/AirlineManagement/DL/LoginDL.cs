using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineManagement.BL;

namespace AirlineManagement.DL
{
    class LoginDL
    {
        private static List<LoginBL> userList = new List<LoginBL>();

        public static void addInList(LoginBL u1)
        {
            userList.Add(u1);
        }

        public static List<LoginBL> UserList { get => userList; set => userList = value; }

        public static LoginBL isUserExists(LoginBL user)
        {
            for(int i=0;i<userList.Count;i++)
            {
                if(userList[i].EmployeeID == user.EmployeeID && userList[i].EmployeeName == user.EmployeeName && userList[i].Password == user.Password)
                {
                    return userList[i];
                }
            }
            return null;
        }

        public static void deleteUser(LoginBL u)
        {
            for (int i= 0;i < userList.Count;i++)
            {
                if(userList[i].EmployeeID == u.EmployeeID && userList[i].EmployeeName == u.EmployeeName && userList[i].Password == u.Password)
                {
                    userList.RemoveAt(i);
                }
            }

        }

        public static void editUser(LoginBL previous , LoginBL updated)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].EmployeeID == previous.EmployeeID && userList[i].EmployeeName == previous.EmployeeName && userList[i].Password == previous.Password)
                {
                    userList[i].EmployeeID = updated.EmployeeID;
                    userList[i].EmployeeName = updated.EmployeeName;
                    userList[i].Password = updated.Password;
                    userList[i].PhoneNo = updated.PhoneNo;
                }
            }

        }

        public static void writeData(string path , LoginBL user)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(user.EmployeeID+","+user.EmployeeName+","+user.Password+","+user.PhoneNo);
            writer.Flush();
            writer.Close();
        }

        public static void writeALLData(string path)
        {
            StreamWriter writer = new StreamWriter(path, false);
            foreach (LoginBL user in userList)
            {
                writer.WriteLine(user.EmployeeID + "," + user.EmployeeName + "," + user.Password + "," + user.PhoneNo);
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
                    string employeeID = data[0];
                    string employeeName = data[1];
                    string password = data[2];
                    long phoneNo = long.Parse(data[3]);

                    LoginBL user = new LoginBL(employeeID,employeeName,password,phoneNo);
                    userList.Add(user);
                }
                reader.Close();
                return true;
            }
            return false;
        }

    }
}
