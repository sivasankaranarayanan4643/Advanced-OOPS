using System;
namespace Square;
class Program 
{
    public static void Main(string[] args)
    {
        Calculate(2);
        Calculate(2.14F);
        Calculate(2.1487890876789);
        Calculate(214878909L);
        
    }
    static void Calculate(int a)
    {
        Console.WriteLine(a*a);
    }
    static void Calculate(float a)
    {
        Console.WriteLine(a*a);
    }
    static void Calculate(double a)
    {
        Console.WriteLine(a*a);
    }
    static void Calculate(long a)
    {
        Console.WriteLine(a*a);
    }
}