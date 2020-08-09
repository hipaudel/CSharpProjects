using System;
using System.Collections.Generic;
using System.Text;

namespace OopsImplementation
{
    public class Car:Vehicle
    {
        
        public Car(string color)
        {
            base.Color = color;
        }

        public  override string Drive()
        {
            return "Driving Car";
        }
    }
}
