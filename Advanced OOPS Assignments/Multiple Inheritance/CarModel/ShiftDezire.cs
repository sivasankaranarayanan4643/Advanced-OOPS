using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public class ShiftDezire:Car,IBrand
    {
        private static int s_makingID=1000;
        public string MakingID { get;  }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public ShiftDezire(string fuelType,int numberOfSeats,string color,int tankCapacity,double numberOfKmDriven,string engineNumber,string chasisNumber):base(fuelType,numberOfSeats,color,tankCapacity,numberOfKmDriven)
        {
            s_makingID++;
            MakingID="SDID"+s_makingID;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            ModelName="ShiftDezire";
            BrandName="Suzuki";
        }
        public void ShowDetails()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("           Car Info         ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Brand Name:{BrandName}\nModel Name:{ModelName}\nMaking ID: {MakingID}\nEngine Number: {EngineNumber}\nChasis Number: {ChasisNumber}\nFuel Type{FuelType}\nColor: {Color}\nTank Capacity: {TankCapacity}\nNumber of KM Driven: {NumberOfKmDriven}");
        }
    }
}