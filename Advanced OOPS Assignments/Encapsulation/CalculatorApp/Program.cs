using System;
namespace CalculatorApp;
class Program 
{
    public static void Main(string[] args)
    {
        CylinderVolume cylinder=new CylinderVolume(2.4,5.4);
        Console.WriteLine(cylinder.CalculateVolume());
        Console.WriteLine(cylinder.CalculateCircleArea());
    }
}