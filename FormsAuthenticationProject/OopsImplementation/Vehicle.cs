using System;
using System.Collections.Generic;
using System.Text;

namespace OopsImplementation
{
    public class Vehicle
    {
        /* This is concept of Vehicle abstraction*/

       public string Color { get; set; }
       
       public virtual string Drive()
        {
            return "Driving Vehicle";
        }

       
    }
}
