using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method2
{
    public class ExternalEmployeeBuilder : EmployeBuilder2
    {
        public override void SetEmailAdress(string emailAdress)
        {
            throw new NotImplementedException();
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
