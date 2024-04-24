using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVolume
{
    public class Cylinders:Shape
    {
        public override double Area { get; set ; }
        public override double Volume { get;  set; }
        public Cylinders(int radius,int height)
        {
            Radius=radius;
            Height=height;
        }
        public override void CalculateArea()
        {
            Area=2*Math.PI*Radius*(Radius+Height);
        }
        public override void CalculateVolume()
        {
            Volume=Math.PI*Radius*2*Height;
        }
    }
}