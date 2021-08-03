using System;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int wheels;
            Console.WriteLine("Enter a number of wheels:");
            while (!int.TryParse((Console.ReadLine()), out wheels))
            {
                Console.WriteLine("Try again:");
            }
            var vehicle1 = VehicleFactory.GetVehicle(wheels);
            Console.WriteLine($"{vehicle1} has been created");
        }
    }
}
