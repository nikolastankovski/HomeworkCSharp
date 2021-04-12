using System;
using System.Collections.Generic;
using System.Text;
using Models.Enum;

namespace Models.Model
{
    public class CEO : Employee
    {
        public CEO(string name, string surname, Employee[] employees, int shares)
            : base(name, surname, Role.CEO, 10000)
        {
            Employees = employees;
            Shares = shares;
        }

        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public void AddSharesPrice(double newSharesPrice)
        {
            SharesPrice = newSharesPrice;
        }
        public void PrintEmployees()
        {
            Console.WriteLine("");
            Console.WriteLine("Employees: ");
            foreach(Employee x in Employees)
            {
                Console.WriteLine($"Name: {x.Name}, Surname: {x.Surname}, Role: {x.Role} ");
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
