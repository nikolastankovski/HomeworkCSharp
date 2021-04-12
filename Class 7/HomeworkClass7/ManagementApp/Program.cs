using System;
using Models.Model;

namespace ManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales[] sales = new Sales[]
            {
                new Sales("Nikola", "Nikolovski")
            };
            Manager[] managers = new Manager[]
            {
                new Manager("Petko", "Petkovski"),
                new Manager("Filip", "Filipovski")
            };
            Contractor[] contractors = new Contractor[]
            {
                new Contractor("Martin", "Martinovski"),
                new Contractor("Stefan", "Stefanovski")
            };

            var company = (managers, contractors, sales);

            Employee[] employees = new Employee[0];
          
            foreach (Manager manager in managers)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[^1] = manager;
            }
            foreach(Sales salesPerson in sales)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[^1] = salesPerson;
            }
            foreach(Contractor contractor in contractors)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[^1] = contractor;
            }

            CEO ceo = new CEO("John", "Wick", employees, 50);
            ceo.AddSharesPrice(100);

            Console.WriteLine("CEO: ");
            ceo.PrintInfo();
            Console.WriteLine($"Salary of CEO: {ceo.GetSalary()}$");
            ceo.PrintEmployees();
        }
    }
}

