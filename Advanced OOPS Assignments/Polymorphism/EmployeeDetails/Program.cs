using System;
namespace EmployeeDetails;
class Program 
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("siva","dharmalingam","male","6369765310");
        employee.Display();
        SalaryInfo salary=new SalaryInfo(employee.EmployeeID,employee.Name,employee.FatherName,employee.Gender,employee.MobileNumber,25);
        salary.Display();
    }
}
