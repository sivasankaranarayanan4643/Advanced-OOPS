using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalID=300;
        public string PrincipalID { get; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public PrincipalInfo(string name, string fatherName,DateTime dob,string phone, Gender gender, string mail,string qulaification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,dob,phone,gender,mail)
        {
            s_principalID++;
            PrincipalID="PID"+s_principalID;
            Qualification=qulaification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
         public void ShowDetails()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                Principal Details         ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Principal ID: {PrincipalID}\nName: {Name}\nFather Name:{FatherName}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nQualification: {Qualification}\nYear of Experience: {YearOfExperience}\nDate of Joining:{DateOfJoining.ToString("dd/MM/yyyy")}\nPhone: {Phone}\nGender: {Gender}\nMail: {Mail}");
        }
    }
}