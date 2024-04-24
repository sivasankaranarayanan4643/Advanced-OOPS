using System;
namespace OperatorOverloading;
class Program 
{
    public static void Main(string[] args)
    {
        Attendance month1=new Attendance(3,5,2);
        Attendance month2=new Attendance(3,5,2);
        Attendance month3=new Attendance(3,5,2);
        Attendance twoMonth=month1+month2;
        Attendance totalMonth=twoMonth+month3;
        totalMonth.CalculateSalary();
    }
}