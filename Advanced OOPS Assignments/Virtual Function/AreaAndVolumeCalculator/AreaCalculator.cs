using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVolumeCalculator
{
    public class AreaCalculator
    {
        public double Radius { get; set; }
        public AreaCalculator(double radius)
        {
            Radius=radius;
        }
        public virtual double Calculate()
        {
            double area=3.14*Radius*Radius;
            return area;
        }
        public virtual void Display()
        {
            Console.WriteLine($"The area for given radius is {Calculate()}");
        }
    }
}