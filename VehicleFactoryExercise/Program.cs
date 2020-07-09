using System;

namespace VehicleFactoryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to USA Vehicles, How many wheels do you want in your vehicel");
            var wheelsCount = int.Parse(Console.ReadLine());


            IVehicle newVehicle = VehicleFactory.GetVehicle(wheelsCount);
            newVehicle.Drive();
        }
    }
}
