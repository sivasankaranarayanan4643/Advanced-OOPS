using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class CylinderCalculator:Calculation
    {
        public override double Area(double radius)
        {
            throw new NotImplementedException();
        }
        public double Volume(double radius)
        {
            return 3.14*radius*radius;
        }
    }
}