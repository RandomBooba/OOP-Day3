﻿using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace OOP_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Car
            {
                Brand = "Toyota",
                Model = "Corolla",
                ProductionDate = new DateTime(2015, 5, 1),
                LastInspection = new DateTime(2020, 6, 1)
            };
            Vehicle myTruck = new Truck
            {
                Brand = "Volvo",
                Model = "FH",
                ProductionDate = new DateTime(2021, 1, 1),
                LastInspection = new DateTime(2022, 1, 1)
            };
            Console.WriteLine(myCar.DisplayInfo());
            Console.WriteLine($"Needs inspection: {myCar.InspectionStatus()}");
            Console.WriteLine(myTruck.DisplayInfo());
            Console.WriteLine($"Needs inspection: {myTruck.InspectionStatus()}");
        }
    }
}