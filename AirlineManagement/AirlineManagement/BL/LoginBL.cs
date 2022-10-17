using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement.BL
{
    public class LoginBL : personBL
    {
        private string employeeID;
        private string password;

        public LoginBL(string employeeID, string employeeName, string password, long phoneNo) : base(employeeName , phoneNo)
        {
            this.employeeID = employeeID;
            this.password = password;
        }

        public LoginBL(string employeeID, string employeeName, string password) : base(employeeName)
        {
            this.employeeID = employeeID;
            this.password = password;
        }

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        
        public string Password { get => password; set => password = value; }
       
    }
}
