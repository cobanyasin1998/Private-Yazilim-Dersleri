using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method1
{
    public class EmployeeBuilder
    {
        private EmployeeM1 employee { get; set; }


        public EmployeeBuilder SetFullName(string fullName)
        {
            var arr = fullName.Split(' ');

            employee.FirstName = arr[0];
            employee.LastName = arr[1];
            return this;

        }
        public EmployeeBuilder SetEmailAdress(string emailAddress) { 
        
            employee.EmailAdress = emailAddress;
            return this;
        }

        public EmployeeBuilder SetUserName(string userName) {
            employee.UserName = userName;
            return this;
        }

        public EmployeeM1 BuildEmployee()
        {
            return employee;
        }

    }
}
