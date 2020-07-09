using System;
namespace VehicleFactoryExercise
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelsCount)
        {
            switch (wheelsCount)
            {
                
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                default :
                    return new NoOption();
                    
            }
        }
    }
}
