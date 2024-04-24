using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVolumeCalculator
{
    public class VolumeCalculator:AreaCalculator
    {
        public double Height { get; set; }
        public VolumeCalculator(double radius,double height):base(radius)
        {
            Height=height;
        }
        public override double Calculate()
        {
            double volume=3.14*Radius*Radius*Height;
            return volume;
        }
        public override void Display()
        {
            Console.WriteLine($"The volume for given Radius and Height {this.Calculate()}");
        }
    }
}