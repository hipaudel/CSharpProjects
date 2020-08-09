using System;
using System.Collections.Generic;
using System.Text;

namespace OopsImplementation
{
    class Bus:Vehicle
    {
        //Here Bus class is inherited and it reuses the Vehicle Color properties.
        public Bus(string color)
        {
            base.Color = color;
        }
        public override string Drive()
        {
            return "Driving Bus";
        }
    }
}
