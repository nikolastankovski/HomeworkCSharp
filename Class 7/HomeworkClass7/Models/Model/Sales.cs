using System;
using System.Collections.Generic;
using System.Text;
using Models.Enum;

namespace Models.Model
{
    public class Sales : Employee
    {
        public Sales(string name, string surname): base(name, surname, Role.Sales, 500) {}

        private double SuccessSaleRevenue { get; set; }

        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue += revenue;
        }

        public override double GetSalary()
        {
            if(SuccessSaleRevenue <= 2000)            
                return Salary += 500;           
            else if(SuccessSaleRevenue <= 5000)            
                return Salary += 1000;            
            else          
                return Salary += 1500;
        }
    }
}
