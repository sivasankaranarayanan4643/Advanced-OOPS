using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class EmployeeInfo:PersonalInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get;  }
        public EmployeeInfo(string name,string fatherName,string gender,string mobileNumber):base(name,fatherName,gender,mobileNumber)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
        }
        public EmployeeInfo(string employeeID,string name,string fatherName,string gender,string mobileNumber):base(name,fatherName,gender,mobileNumber)
        {
           
            EmployeeID=employeeID;
        }
        public override void Display()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("        Employee Info       ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Employee ID: {EmployeeID}\nName: {Name}\nFather Name:{FatherName}\nGender: {Gender}\nMobile Number: {MobileNumber}");
        }
    }
}