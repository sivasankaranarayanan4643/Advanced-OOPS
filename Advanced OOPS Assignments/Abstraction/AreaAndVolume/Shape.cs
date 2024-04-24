using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVolume
{
    public abstract class Shape
    {
        public abstract double Area{get;set;}
        public abstract double Volume { get; set; }
        public int Radius { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Page { get; set; }
        public abstract void CalculateArea();
        public abstract void CalculateVolume();
    }
}