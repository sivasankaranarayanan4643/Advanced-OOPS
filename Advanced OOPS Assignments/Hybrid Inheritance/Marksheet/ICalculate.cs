using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marksheet
{
    public interface ICalculate
    {
        public int ProjectMark { get; set; }
        public void CalculateUG();
    }
}