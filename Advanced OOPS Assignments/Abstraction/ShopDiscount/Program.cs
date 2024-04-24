using System;
namespace ShopDiscount;
class Program 
{
    public static void Main(string[] args)
    {
        MensWear dress1=new MensWear("Blazzers",2000);
        dress1.GetDressInfo();
        dress1.DisplayInfo();
        LadiesWear dress2=new LadiesWear("sarees",3000);
        dress2.GetDressInfo();
        dress2.DisplayInfo();
    }
}