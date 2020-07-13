using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> eList = new List<IEmployee>();

            Employee e1 = new Employee
            {
                Name = "hari",
                Title = "Engineer",
                Contact = "6412260923",
                HiredDate = DateTime.UtcNow,
                Salary = new Salary { MonthlySalary = 10000 }
                
                
            };
            Employee e2 = new Employee
            {
                Name = "Alisha",
                Title = null,
                Contact = "4696428797",
                HiredDate = null,
                Salary = new Salary { MonthlySalary = 12000 }
            };
            eList.Add(e1);
            eList.Add(e2);

            foreach (Employee e in eList)
            {
                Console.WriteLine($" Name:{e.Name}, Title:{e.Title}, Contact:{e.Contact}, HireDate:{e.HiredDate},Bonus:{e.Salary.CalculateBonus()}");
            }         
            Console.ReadLine();
        }
    }
}
