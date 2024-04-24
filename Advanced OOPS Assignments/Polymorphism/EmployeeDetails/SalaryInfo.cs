using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class SalaryInfo:EmployeeInfo
    {
        public int NumberOfWorkingDays { get; set; }
        public SalaryInfo(string employeeID,string name,string fatherName,string gender,string mobileNumber,int numberOfWorkingDays):base(employeeID,name,fatherName,gender,mobileNumber)
        {
           
            NumberOfWorkingDays=numberOfWorkingDays;
        }
        public override void Display()
        {
            Console.WriteLine($"Salary: {NumberOfWorkingDays*500}");
        }
    }
}