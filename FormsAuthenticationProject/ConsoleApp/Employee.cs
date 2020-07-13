using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Contact { get; set; }
        public DateTime? HiredDate { get; set; }

        public Salary Salary { get; set; }
    }
}
