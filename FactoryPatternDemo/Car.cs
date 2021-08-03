using System;
namespace FactoryPatternDemo
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void drive()
        {
            throw new NotImplementedException();
        }
    }
}
