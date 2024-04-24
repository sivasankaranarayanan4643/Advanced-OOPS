using System;
namespace AnimalInfo;
class Program 
{
    public static void Main(string[] args)
    {
        Dog dog1=new Dog("Scooby","Kennel","Omnivores");
        Dog dog2=new Dog("Tiger","street","Omnivores");
        Duck duck1=new Duck("Hansika","pond","Omnivores");
        Duck duck2=new Duck("Regina","forest","Omnivores");
        dog1.DisplayInfo();
        dog2.DisplayInfo();
        duck1.DisplayInfo();
        duck2.DisplayInfo();
        
    }
}
