using System;
namespace Employee;
class Program 
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee= new EmployeeInfo("siva",Gender.Male,new DateTime(2001,12,19),"6369765310");
        employee.Display();
        employee.Update("Sivasankaranarayanan",employee.Gender,employee.DOB,employee.Mobile);
        employee.Display();
    }
}