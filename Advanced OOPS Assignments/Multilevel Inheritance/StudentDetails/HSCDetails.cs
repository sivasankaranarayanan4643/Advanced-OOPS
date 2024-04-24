using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class HSCDetails:StudentInfo
    {
        private static int _marksheetNumber=100;
        public string MarksheetNumber { get; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public HSCDetails(string registerNumber,int standard,string branch,int academicYear,string name,string fatherName,string phone,string mail,DateTime dob,Gender gender):base(registerNumber,standard,branch,academicYear,name,fatherName,phone,mail,dob,gender)
        {
            _marksheetNumber++;
            MarksheetNumber="MSID"+_marksheetNumber;
        }
        public void GetMarks()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                Get Marks                 ");
            Console.WriteLine("------------------------------------------");

            Console.Write("Enter student's Physics mark: ");
            Physics=int.Parse(Console.ReadLine());
            Console.Write("Enter student's chemistry mark: ");
            Chemistry=int.Parse(Console.ReadLine());
            Console.Write("Enter student's maths mark: ");
            Maths=int.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Percentage=(double)Total/3;
        }
        public void  ShowMarksheet()
        {
             Console.WriteLine("---------------------------------------");
            Console.WriteLine("           Marksheet         ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Marksheet Number: {MarksheetNumber}\nRegister Number: {RegisterNumber}\nName: {Name}\nStandard: {Standard}\nBranch: {Branch}\nAcademic Year: {AcademicYear}\nPhysics Mark: {Physics}\nChemistry Mark: {Chemistry}\nMaths Mark: {Maths}\nTotal: {Total}\nPercentage: {Percentage}");
        }
    }
}