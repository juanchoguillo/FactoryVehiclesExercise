﻿using System;
namespace VehicleFactoryExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle");
        }

    }
}
