using System;
namespace FactoryPatternDemo
{
    public class Truck : IVehicle
    {
        public Truck()
        {
        }

        public void drive()
        {
            throw new NotImplementedException();
        }
    }
}
