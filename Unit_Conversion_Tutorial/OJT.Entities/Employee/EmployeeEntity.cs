using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT.Entities.Employee
{
    public class EmployeeEntity
    {

        public int employeeId { get; set; }

        public string name { get; set; }

        public long phNo { get; set; }

        public string email { get; set; }

        public string gender { get; set; }

        public string employeeType { get; set; }

        public DateTime dateOfBirth { get; set; }

        public string address { get; set; }

        public int townshipId { get; set; }

        public EmployeeEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.employeeId = 0;
            this.name = String.Empty;
            this.phNo = 0;
            this.email = String.Empty;
            this.gender = String.Empty;
            this.employeeType = String.Empty;
            this.dateOfBirth = DateTime.MinValue;
            this.address = String.Empty;
            this.townshipId = 0;
        }
    }
}
