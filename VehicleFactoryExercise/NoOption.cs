using System;
namespace VehicleFactoryExercise
{
    public class NoOption : IVehicle
    {
        public NoOption()
        {
        }

        public void Drive()
        {
            Console.WriteLine($"Sorry we dont have this kind of vehicles ");
        }
    }
}
