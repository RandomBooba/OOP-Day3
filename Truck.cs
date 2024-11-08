using System;
using System.Reflection;

namespace OOP_Day3
{
    public class Truck : Vehicle
    {
        public override bool InspectionStatus()
        {
            return (DateTime.Now.Year - ProductionDate.Year > 1) &&
                   (DateTime.Now.Year - LastInspection.Year > 1);
        }
        public override string DisplayInfo()
        {
            return $"Truck: {Brand} {Model}";
        }
    }
}