﻿using System;
namespace VehicleFactoryExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

         public void Drive()
        {
            Console.WriteLine("Building a new Car");
        }
    }
}
