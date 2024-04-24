using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public class Car
    {
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public int TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }
        public Car(string fuelType,int numberOfSeats,string color,int tankCapacity,double numberOfKmDriven)
        {
            FuelType=fuelType;
            NumberOfSeats=numberOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;
        }
        public void CalculateMilege()
        {
            Console.WriteLine($"Milage: {(double)NumberOfKmDriven/TankCapacity}");
        }
    }
}