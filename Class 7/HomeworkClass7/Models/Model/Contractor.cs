using System;
using System.Collections.Generic;
using System.Text;
using Models.Enum;

namespace Models.Model
{
    public class Contractor : Employee
    {
        public Contractor(string name, string surname) : base(name, surname, Role.Other, 0) { }

        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Manager { get; set; }

        public override double GetSalary()
        {
            double workerSalary = WorkHours * PayPerHour;

            Salary = workerSalary;
            return workerSalary;
        }

        public Department CurrentPosition()
        {
            return Manager.GetDepartment();
        }
    }
}
