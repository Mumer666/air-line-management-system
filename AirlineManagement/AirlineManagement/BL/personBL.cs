using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement.BL
{
    public class personBL
    {
        protected string employeeName;
        protected long phoneNo;

        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public long PhoneNo { get => phoneNo; set => phoneNo = value; }

        public personBL(string employeeName , long phoneNo)
        {
            this.employeeName = employeeName;
            this.phoneNo = phoneNo;
        }

        public personBL(string employeeName)
        {
            this.employeeName = employeeName;
        }
    }
}
