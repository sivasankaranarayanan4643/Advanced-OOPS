using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkCalculator
{
    public class Calculator
    {
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Mark4 { get; set; }
        public int Mark5 { get; set; }
        public int Mark6 { get; set; }
        public Calculator(int mark1,int mark2,int mark3,int mark4,int mark5,int mark6)
        {
            Mark1=mark1;
            Mark2=mark2;
            Mark3=mark3;
            Mark4=mark4;
            Mark5=mark5;
            Mark6=mark6;
        }
        public static Calculator operator+(Calculator a,Calculator b)
        {
            Calculator sem=new Calculator(0,0,0,0,0,0);
            sem.Mark1=a.Mark1+b.Mark1;
            sem.Mark2=a.Mark2+b.Mark2;
            sem.Mark3=a.Mark3+b.Mark3;
            sem.Mark4=a.Mark4+b.Mark4;
            sem.Mark5=a.Mark5+b.Mark5;
            sem.Mark6=a.Mark6+b.Mark6;
            return sem;
        }
        public void CalculateMark()
        {
            int totalMark=Mark1+Mark2+Mark3+Mark4+Mark5+Mark6;
            Console.WriteLine($"Total Mark: {totalMark}");
            Console.WriteLine($"Percentage : {totalMark/24}");
        }
    }
}