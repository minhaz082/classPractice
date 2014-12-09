using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSalaryCalculatorApp
{
    class Salary
    {
        public string empName;
        public double basicAmount;
        public double houseRent;
        public double medicalAllowance;

        public double CalculateSalary()
        {
            double houseRentPercentage = (basicAmount*houseRent)/100;
            double medicalPercentage = (basicAmount * medicalAllowance) / 100;
            return basicAmount + houseRentPercentage + medicalPercentage;
        }

    }
}
