using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method2
{
    public interface IEmploeeBuilder2
    {
        EmployeeM2 BuildEmployee();
        void SetFullName(string fullName);
        void SetEmailAdress(string emailAdress);
        void SetUserName(string userName);
    }
    public abstract class EmployeBuilder2: IEmploeeBuilder2
    {
        protected EmployeeM2 Employee { get; set; }

        public EmployeBuilder2()
        {
            Employee = new EmployeeM2();
        }

        public abstract void SetFullName(string fullName);
        public abstract void SetEmailAdress(string emailAdress);
        public abstract void SetUserName(string userName);
        public EmployeeM2 BuildEmployee() => Employee;
    }
}
