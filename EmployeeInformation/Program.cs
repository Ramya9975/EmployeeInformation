using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter the employee id:");
            employee.Employeeid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            employee.name = Console.ReadLine();
            Console.WriteLine("Enter the BasicPay:");
            employee.BasicPay = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter HRA:");
            employee.HRA = int.Parse(Console.ReadLine());
            Console.WriteLine("other allowance");
            employee.Otherallowance = int.Parse(Console.ReadLine());

            EmployeeDetails employee1 = new EmployeeDetails();
            double gross_salary = employee1.GrossSalary(employee);
            Console.WriteLine("Grosssalary : {0}", gross_salary);


            double netSalary = employee1.NetAmount(employee);
            Console.WriteLine("NetAmount:{0}", netSalary);

            double Tax = employee1.Tax(employee);
            Console.WriteLine("Tax:{0}", Tax);

            Console.ReadKey();
        }
    }
}





        