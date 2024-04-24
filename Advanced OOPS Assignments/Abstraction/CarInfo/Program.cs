using System;
namespace CarInfo;
class Program 
{
    public static void Main(string[] args)
    {
        MaruthiSwift car1=new MaruthiSwift();
        car1.GetEngineType(EngineType.Petrol);
        car1.GetNoOfSeats(4);
        car1.GetPrice(600000);
        car1.GetCarType(CarType.Hatchback);
        car1.DisplayCarDetail();
        SuzukiCiaz car2=new SuzukiCiaz();
        car2.GetEngineType(EngineType.Diesel);
        car2.GetNoOfSeats(6);
        car2.GetPrice(500000);
        car2.GetCarType(CarType.Sedan);
        car2.DisplayCarDetail();
    }
}