using System;
namespace FactoryPatternDemo
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheels)
        {
            if (wheels == 4)
            {
                return new Car();
            }
            else 
                return new Truck();
           

        }
    }
}
