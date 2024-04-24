using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaOfShapes
{
    public class Rectangle : Dimension
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle(double length,double height)
        {
            Length=length;
            Height=height;
        }
        public override void Calculate()
        {
            Area=Length*Height;
        }
        public override void DisplayArea()
        {
            Console.WriteLine($"The area of rectangle is {Area}");
        }
    }
}