using System;

namespace ConsoleApp
{
    interface IEmployee
    {
        string Contact { get; set; }
        DateTime? HiredDate { get; set; }
        string Name { get; set; }
        Salary Salary { get; set; }
        string Title { get; set; }
    }
}