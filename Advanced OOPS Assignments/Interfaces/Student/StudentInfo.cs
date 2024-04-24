using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Student
{
    public class StudentInfo:IDisplayInfo
    {
        private static int s_studentID=1000;
        public string StudentID { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public StudentInfo(string name,string fatherName,string mobile)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
        }
        public void Display()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("         Student Details       ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Student ID: {StudentID}\nName: {Name}\nFather Name: {FatherName}\nMobile: {Mobile}");
        }

    }
}