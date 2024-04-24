using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marksheet
{
    public class StudentMarksheet:TheoryExamMarks,ICalculate
    {
        private static int s_marksheetNumber=3000;
        public string MarksheetNumber { get;  }
        public DateTime DateOfIssue { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public int ProjectMark { get; set; }
        public StudentMarksheet(string registerNumber,string name,string fatherName,string phone,DateTime dob,Gender gender,int[] sem1,int[] sem2,int[] sem3,int[] sem4,int projectMark,DateTime dateOfIssue) :base(registerNumber,name,fatherName,phone,dob,gender,sem1,sem2,sem3,sem4)
        {
            s_marksheetNumber++;
            MarksheetNumber="MID"+s_marksheetNumber;
            DateOfIssue=dateOfIssue;
            ProjectMark=projectMark;
        }
        public void CalculateUG()
        {
            foreach(int marks in Sem1)
            {
                Total+=marks;
            }
            foreach(int marks in Sem2)
            {
                Total+=marks;
            }
            foreach(int marks in Sem3)
            {
                Total+=marks;
            }
            foreach(int marks in Sem4)
            {
                Total+=marks;
            }
            Percentage=Total/24;
        }
        public void ShowUGMarksheet()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("             Marksheet           ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Marksheet Number: {MarksheetNumber}\nRegister Number: {RegisterNumber}\nName: {Name}\nFather Name: {FatherName}\nDate of Issue: {DateOfIssue.ToString("dd/MM/yyyy")}\nTotal: {Total}\nPercentage: {Percentage}");

        }
    }
}