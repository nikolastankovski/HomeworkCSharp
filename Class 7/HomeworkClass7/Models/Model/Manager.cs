using System;
using System.Collections.Generic;
using System.Text;
using Models.Enum;

namespace Models.Model
{
    public class Manager : Employee
    {
        public Manager(string name, string surname, Department department = Department.Management) 
            : base(name, surname, Role.Manager, 1500) { }

        private double Bonus { get; set; }
        private Department Department { get; set; }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }

        public Department GetDepartment()
        {
            return Department;
        }
    }
}
