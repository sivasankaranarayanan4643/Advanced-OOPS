using System;
namespace AreaAndVolumeCalculator;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Radius: ");
        double radius=double.Parse(Console.ReadLine());
        Console.Write("Enter the Height: ");
        double height=double.Parse(Console.ReadLine());
        AreaCalculator area=new AreaCalculator(radius);
        area.Display();
        VolumeCalculator volume= new VolumeCalculator(radius,height);
        volume.Display();


    }
}