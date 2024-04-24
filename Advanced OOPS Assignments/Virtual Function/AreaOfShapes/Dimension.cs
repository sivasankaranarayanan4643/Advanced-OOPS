using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaOfShapes
{
    public class Dimension
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }

      
        public virtual void Calculate()
        {
            Area=Value1*Value2;
        }
        public virtual void DisplayArea()
        {
            Console.WriteLine($"The Area is {Area}");
        }
    }
}