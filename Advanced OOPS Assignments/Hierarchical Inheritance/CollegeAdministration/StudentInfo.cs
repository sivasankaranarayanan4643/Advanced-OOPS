using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentID=2000;
        public string StudentID { get; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }
        public StudentInfo(string name, string fatherName,DateTime dob,string phone,Gender gender, string mail,string degree,string department, int semester):base(name,fatherName,dob,phone,gender,mail)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
         public void ShowDetails()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                Student Details         ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Student ID: {StudentID}\nName: {Name}\nFather Name:{FatherName}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nPhone: {Phone}\nGender: {Gender}\nMail: {Mail}\nDegree: {Degree}\nDepartment: {Department}\nSemester: {Semester}");
        }
    }
}