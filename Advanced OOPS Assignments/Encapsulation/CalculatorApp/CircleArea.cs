using System;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected double _radius;
        public double Radius { get; set; }
        internal double Area {get; set;}
     
        public CircleArea(double radius)
        {
            Radius=radius;
        }
    
        public double CalculateCircleArea()
        {
            
            Area=PI*Radius*Radius;
            return Area;
        }

    }
}