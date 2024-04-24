using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class CircleCalculator:Calculation
    {
        public sealed override double Area(double radius)
        {
            double area=3.14*radius*radius;
            return area;
        }
    }
}