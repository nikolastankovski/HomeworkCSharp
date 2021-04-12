using System;
using System.Collections.Generic;
using System.Text;
using Models.Enum;

namespace Models.Model
{
    public class Employee
    {
        public Employee(string name, string surname, Role role, double salary)
        {
            Name = name;
            Surname = surname;
            Role = role;
            Salary = salary;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
