using System;
namespace Student;
class Program 
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee= new EmployeeInfo("Siva","Dharmalingam");
        StudentInfo student=new StudentInfo("Sasi","Dharmalingam","6369765310");
        employee.Display();
        student.Display();
    }
}