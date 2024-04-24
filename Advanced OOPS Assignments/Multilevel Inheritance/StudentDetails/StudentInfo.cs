using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class StudentInfo :PersonalInfo
    {
        private static int _registerNumber=1000;
        public string RegisterNumber { get; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }
        public void GetStudentInfo()
        {
            Console.Write("Enter the Standard of the student: ");
            Standard=int.Parse(Console.ReadLine());
            Console.Write("Enter Student Branch Name: ");
            Branch=Console.ReadLine();
            Console.Write("Enter Student's Academic Year: ");
            AcademicYear=int.Parse(Console.ReadLine());
        }

        public StudentInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender):base(name,fatherName,phone,mail,dob,gender)
        {
            _registerNumber++;
            RegisterNumber="SID"+_registerNumber;
           
        }
        public StudentInfo(string registerNumber,int standard,string branch,int academicYear,string name,string fatherName,string phone,string mail,DateTime dob,Gender gender):base(name,fatherName,phone,mail,dob,gender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;           
        }
        public void ShowInfo()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("           Student Details         ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Register Number: {RegisterNumber}\nName: {Name}\nFather Name: {FatherName}\nPhone: {Phone}\nMail: {Mail}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nGender: {Gender}\nStandard: {Standard}\nBranch: {Branch}\nAcademic Year: {AcademicYear}");
        }
    }
}