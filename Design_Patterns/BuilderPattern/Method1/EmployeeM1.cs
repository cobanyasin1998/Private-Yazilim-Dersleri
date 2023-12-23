using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method1
{
    public class EmployeeM1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string UserName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({UserName})";
        }

    }
}
