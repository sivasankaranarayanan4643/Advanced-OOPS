using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class Syncfusion:FreeLancer
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; }
        public string WorkLocation { get; set; }
        public Syncfusion(string name,string fatherName,string gender,string qualification,string role,int noOfWorkingDays,string workLocation):base(name,fatherName,gender,qualification,role,noOfWorkingDays)
        {
            
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            WorkLocation=workLocation;
        }
        public override void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
        }
        public override void Display()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("      Employee Details      ");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Employee ID: {EmployeeID}\nName: {Name}\nFather Name: {FatherName}\nGender: {Gender}\nQualification: {Qualification}\nRole :{Role}\nWork Location: {WorkLocation}\nNo Of Working Days: {NoOfWorkingDays}\nSalary Amount: {SalaryAmount}");
        }
    }
}