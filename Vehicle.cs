using System;

namespace OOP_Day3
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }
        public abstract bool InspectionStatus();
        public virtual string DisplayInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Production Date: {ProductionDate.ToShortDateString()}";
        }
    }
}