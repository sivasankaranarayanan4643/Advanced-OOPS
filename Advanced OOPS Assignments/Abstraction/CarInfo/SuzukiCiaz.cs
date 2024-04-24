using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo
{
    public class SuzukiCiaz:Car
    {
        
        public override void GetEngineType(EngineType engineType)
        {
            EngineType=engineType;
        }
        public override void GetNoOfSeats(int seats)
        {
            NoOfSeats=seats;
        }
        public override void GetPrice(int price)
        {
           Price=price;
        }
        public override void GetCarType(CarType carType)
        {
            CarType=carType;
        }
        public override void DisplayCarDetail()
        {
           Console.WriteLine("----------------------------------------");
           Console.WriteLine("                Car Details           ");
           Console.WriteLine("----------------------------------------");
           Console.WriteLine($"Car type: {CarType}\nEngine type: {EngineType}\nNo. of seats: {NoOfSeats}\nPrice: Rs.{Price}");           
        }
    }
}