using System;
namespace AreaAndVolume;
class Program 
{
    public static void Main(string[] args)
    {
        Cylinders cylinder=new Cylinders(34,23);
        cylinder.CalculateArea();
        cylinder.CalculateVolume();
        Console.WriteLine($"The area of the cylinder is {cylinder.Area}");
        Console.WriteLine($"The volume of the cylinder is {cylinder.Volume}");
        Cubes cube=new Cubes(12);
        cube.CalculateArea();
        cube.CalculateVolume();
        Console.WriteLine($"The area of the cube is {cube.Area}");
        Console.WriteLine($"The volume of the cube is {cube.Volume}");
    }
}