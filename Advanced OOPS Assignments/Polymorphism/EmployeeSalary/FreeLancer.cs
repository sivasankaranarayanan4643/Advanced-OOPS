using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class FreeLancer:PersonalDetails
    {
        public string Role { get; set; }
        public int SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }
        public FreeLancer(string name,string fatherName,string gender,string qualification,string role,int noOfWorkingDays):base(name,fatherName,gender,qualification)
        {
            Role=role;
            NoOfWorkingDays=noOfWorkingDays;
        }
        public virtual void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
        }
        public virtual void Display()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("      Employee Details      ");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Name: {Name}\nFather Name: {FatherName}\nGender: {Gender}\nQualification: {Qualification}\nRole :{Role}\nNo Of Working Days: {NoOfWorkingDays}\nSalary Amount: {SalaryAmount}");
        }
    }
}