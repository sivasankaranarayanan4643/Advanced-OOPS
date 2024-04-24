using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class Teacher : PersonalInfo
    {
        private static int s_teacherID=1000;
        public string TeacherID { get;}
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; } 

        public Teacher(string name, string fatherName,DateTime dob,string phone,Gender gender, string mail,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,dob,phone,gender,mail)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        public void ShowDetails()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                Teacher Details         ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Teacher ID: {TeacherID}\nName: {Name}\nFather Name:{FatherName}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nDepartment: {Department}\nSubject Teaching: {SubjectTeaching}\nQualification: {Qualification}\nYear of Experience: {YearOfExperience}\nDate of Joining:{DateOfJoining.ToString("dd/MM/yyyy")}\nPhone: {Phone}\nGender: {Gender}\nMail: {Mail}");
        }
    }
}