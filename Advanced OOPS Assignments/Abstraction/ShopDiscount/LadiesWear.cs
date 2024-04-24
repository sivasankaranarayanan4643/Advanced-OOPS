using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDiscount
{
    public class LadiesWear:Dress
    {
        public override DressType DressType { get; set; }
        public override string DressName { get ; set; }
        public override int Price { get; set; }
        public override double TotalPrice { get ; set ; }

        public LadiesWear(string dressName,int price)
        {
            DressType=DressType.Ladieswear;
            DressName=dressName;
            Price=price;
        }
        public override void GetDressInfo()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("              Dress Info        ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Dress Type: {DressType}\nDress Name: {DressName}\nPrice: {Price}");
        }
        public override void DisplayInfo()
        {
            TotalPrice=Price-(Price*20/100);
            Console.WriteLine($"Your bill amount is {TotalPrice}");
        }
    }
}