using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public class EmployeeInfo
    {
        private static int s_employeeID=2000;
        public string EmployeeID { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        
        public EmployeeInfo(string name,string fatherName)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Name=name;
            FatherName=fatherName;
            
        }
        public void Display()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("         Employee Details       ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Employee ID: {EmployeeID}\nName: {Name}\nFather Name: {FatherName}");
        }
    }
}