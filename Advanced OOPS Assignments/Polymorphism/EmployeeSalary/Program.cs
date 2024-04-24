using System;
namespace EmployeeSalary;
class Program 
{
    public static void Main(string[] args)
    {
        FreeLancer tempEmployee=new FreeLancer("siva","dharmalingam","male","B.E","Software Engineer",25);
        tempEmployee.CalculateSalary();
        tempEmployee.Display();
        Syncfusion Employee=new Syncfusion("siva","dharmalingam","male","B.E","Software Engineer",25,"chennai");
        Employee.CalculateSalary();
        Employee.Display();
    }
}