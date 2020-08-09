using System;

namespace OopsImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("White"); // Polymorphically creates car object not vehicle
            Vehicle bus = new Bus("Black"); // Polymorphically creates bus object not vehicle

            //Here car and bus objects are encapulsated.

            Console.WriteLine($"{car.Drive()} color is {car.Color}");
            Console.WriteLine($"{bus.Drive()} color is {bus.Color}");



            Console.ReadLine();
            
        }
    }
}
