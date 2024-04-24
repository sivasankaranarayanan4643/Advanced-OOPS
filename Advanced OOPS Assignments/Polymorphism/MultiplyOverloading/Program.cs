using System;
namespace MultiplyOverloading;
class Program 
{
    public static void Main(string[] args)
    {

        Multiply(2,3);
        Multiply(2);
        Multiply(2,3,4);
        Multiply(2.4,3.5);
        Multiply(2.3,3.3,4.6);



    }
        static void Multiply(int a)
        {
            Console.WriteLine(a*a);
        }
        static void Multiply(int a,int b)
        {
            Console.WriteLine(a*b);
        }
        static void Multiply(double a,double b)
        {
            Console.WriteLine(a*b);
        }
        static void Multiply(int a,int b,int c)
        {
            Console.WriteLine(a*b*c);
        }
        static void Multiply(double a,double b,double c)
        {
            Console.WriteLine(a*b*c);
        }
}