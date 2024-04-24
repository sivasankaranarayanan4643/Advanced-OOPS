using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public partial class StudentInfo
    {
        public int CalculateTotal()
        {
            int total=Physics+Chemistry+Maths;
            return total;
        }
        public double CalculatePercentage()
        {
            double percentage=(double)CalculateTotal()/3;
            return percentage;
        }
        public void Display()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("             Student Details          ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Student ID: {StudentID}\nGender: {Gender}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nMobile: {Mobile}\nPhysics: {Physics}\nChemistry: {Chemistry}\nMaths: {Maths}");
        }
    }
}