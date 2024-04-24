using System;
namespace EmployeeSalary;
class Program 
{
    public static void Main(string[] args)
    {
        PermanentEmployee employee1=new PermanentEmployee(20000,1,"permanent");
        employee1.CalculateTotalSalary();
        employee1.ShowSalary();
        TemperaryEmployee employee2=new TemperaryEmployee(25000,2,"Temperary");
        employee2.CalculateTotalSalary();
        employee2.ShowSalary();
    }
}