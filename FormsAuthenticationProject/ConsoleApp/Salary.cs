using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Salary
    {
        public double MonthlySalary { get; set; }

        public double CalculateBonus()
        {
            return MonthlySalary * 0.10;
        }
    }
}
