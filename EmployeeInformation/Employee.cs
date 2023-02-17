using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{

    public class Employee
    {
        public int Employeeid { get; set; }
        public string name { get; set; }

        public double BasicPay { get; set; }
        public double HRA { get; set; }
        public double Otherallowance { get; set; }
    }
    
        public class EmployeeDetails
        {
        public double GrossSalary(Employee employee)
        {
            double grosssalary = employee.BasicPay + employee.HRA + employee.Otherallowance;
            return grosssalary;
        }
            public double NetAmount(Employee employee)
            {
                double grosssalary = GrossSalary(employee);
                double Netamount = grosssalary - 1800;
                return Netamount;
            }
            public double Tax(Employee employee)
            {
                double tax = 0;
                double Gross = GrossSalary((Employee)employee);
                if (Gross > 500000 && Gross<1000000)
                {
                    tax = (Gross - 500000) * 0.1;
                    Console.WriteLine("Tax :+tax");
                }
                else if (Gross > 100000)
                {
                    tax = Gross - (500000 * 0.12);
                    Console.WriteLine("Tax :+tax");

                }
                else
                {
                Console.WriteLine("your grosssalary is below 500000, so No tax will be applied");
                
                }
                return tax;
            }

        }
}

