using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method2
{
    public class InternalEmployeeBuilder : EmployeBuilder2
    {
        public override void SetEmailAdress(string emailAdress)
        {
            var arr = emailAdress.Split('@');

            Employee.EmailAdress = arr[0] + "@company.com.tr";

        }

        public override void SetFullName(string fullName)
        {
            throw new NotImplementedException();
        }

        public override void SetUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
