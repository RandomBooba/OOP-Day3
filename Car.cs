using System;
using System.Reflection;

namespace OOP_Day3
{
    public class Car : Vehicle
    {
        public override bool InspectionStatus()
        {
            return (DateTime.Now.Year - ProductionDate.Year > 4) &&
                   (DateTime.Now.Year - LastInspection.Year > 2);
        }
        public override string DisplayInfo()
        {
            return $"Car: {Brand} {Model}";
        }
    }
}