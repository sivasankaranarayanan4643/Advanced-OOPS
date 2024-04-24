using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaOfShapes
{
    public class Sphere: Dimension
    {
         public double Radius { get; set; }
        

        public Sphere(double radius)
        {
           Radius=radius;
        }
        public override void Calculate()
        {
            Area=4*3.14*Radius*Radius;
        }
        public override void DisplayArea()
        {
            Console.WriteLine($"The area of Sphere is {Area}");
        }
    }
}