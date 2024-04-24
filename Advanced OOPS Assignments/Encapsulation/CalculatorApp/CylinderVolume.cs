using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume:CircleArea
    {
        private double _height=0;
        public double  Height { get;  }
        internal double Volume;
        public CylinderVolume(double radius,double height):base(radius)
        {
            _height=height;
            Height=_height;
        }
        public double CalculateVolume()
        {
            Volume=CalculateCircleArea()*Height;
            return Volume;
        }

    }
}