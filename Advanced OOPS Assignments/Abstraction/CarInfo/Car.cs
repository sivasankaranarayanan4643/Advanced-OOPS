using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CarInfo
{
    public enum EngineType{Petrol,Diesel,CNG}
    public enum CarType{Hatchback,Sedan,SUV}
    public abstract class Car
    {
        private int _wheels=4;
        private int _doors=4;
        public EngineType EngineType { get; set; }
        public int NoOfSeats { get; set; }
        public int Price { get; set; }
        public CarType CarType { get; set; }
        public void ShowWheels()
        {
            Console.WriteLine($"No. of wheels={_wheels}");
        }
        public void ShowDoors()
        {
            Console.WriteLine($"No. of doors={_doors}");
        }
        public abstract void GetEngineType(EngineType engineType);
        public abstract void GetNoOfSeats(int seats);
        public abstract void GetPrice(int price);
        public abstract void GetCarType(CarType carType);
        public abstract void DisplayCarDetail();

    }
}