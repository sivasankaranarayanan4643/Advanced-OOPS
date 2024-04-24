using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVolume
{
    public class Cubes:Shape
    {
        public override double Area { get; set ; }
        public override double Volume { get;  set; }
        public Cubes(int page)
        {
            Page=page;
        }
        public override void CalculateArea()
        {
            Area=6*Page*Page;
        }
        public override void CalculateVolume()
        {
            Volume=Page*Page*Page;
        }
    }
}