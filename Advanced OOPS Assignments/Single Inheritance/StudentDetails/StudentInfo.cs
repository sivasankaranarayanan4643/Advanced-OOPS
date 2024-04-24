using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_registerNumber=1000;//static field
        //properties
        public string RegisterNumber { get;  }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }
        //Constructor
        public StudentInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,int standard,string branch,int academicYear):base(name,fatherName,phone,mail,dob,gender)
        {
            //Auto Incrementation
            s_registerNumber++;

            RegisterNumber="SF"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }
         //Method
        public void ShowStudentInfo()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("           Student Details         ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Register Number: {RegisterNumber}\nName: {Name}\nFather Name: {FatherName}\nPhone: {Phone}\nMail: {Mail}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nGender: {Gender}\nStandard: {Standard}\nBranch: {Branch}\nAcademic Year: {AcademicYear}");
        }
    }
}