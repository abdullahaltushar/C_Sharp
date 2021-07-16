using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    class Salary
    {
        public double basicSalary;
        public double houseRentPercentage;
        public double medicalAllownacePercentage;



        public double TotalCalculatesalary()
        {
            double housrentAmout = basicSalary * houseRentPercentage / 100;
            double medicalallownceAmount = basicSalary * medicalAllownacePercentage / 100;
            double TotalSalary = basicSalary + housrentAmout + medicalallownceAmount;
            return TotalSalary;
        }
    }
}
