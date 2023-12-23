using BuilderPattern.Method1;
using BuilderPattern.Method2;
using System;
using System.Text;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sb = new StringBuilder();

            sb.Append("Yasin");
            sb.Append(" ");
            sb.Append("Çoban");

            var fullName = sb.ToString();


            var eb = new EndPointBuilder("https://localhost");

            eb.Append("api").Append("v1").Append("user").AppendParam("id", "5");

            var url = eb.Build();


            var empBuilder = new EmployeeBuilder();

            var employee = empBuilder
                .SetFullName(fullName)
                .SetUserName("yasin.coban")
                .SetEmailAdress("cobanyasin1998@gmail.com")
                .BuildEmployee();

            IEmploeeBuilder2 internalEmpBuilder = new InternalEmployeeBuilder();

            internalEmpBuilder.SetFullName(fullName);

            internalEmpBuilder.SetEmailAdress("cobanyasin1988@gmail.com");

            EmployeeM2 emp = internalEmpBuilder.BuildEmployee();

            var emp2 = GenerateEmployee(fullName, "cobanyasin1988@gmail.com",0);

             EmployeeM2 GenerateEmployee(string fullName, string emailAdress, int empType)
            {
                IEmploeeBuilder2 empBuilder;

                if (empType == 0)
                {
                    empBuilder = new InternalEmployeeBuilder();
                }
                else
                {
                    empBuilder = new ExternalEmployeeBuilder();

                }
                empBuilder.SetFullName(fullName);
                empBuilder.SetEmailAdress(emailAdress);

                return empBuilder.BuildEmployee();
            }
        }
        
    }
}
