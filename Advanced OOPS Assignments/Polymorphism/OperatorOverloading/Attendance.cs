using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Attendance
    {
        public int Month { get; set; }
        public int LeavesTaken { get; set; }
        public int PermissionTaken { get; set; }
        public Attendance(int month,int leavesTaken,int permissionTaken)
        {
            Month=month;
            LeavesTaken=leavesTaken;
            PermissionTaken=permissionTaken;
        }
        public static Attendance operator+ (Attendance a,Attendance b)
        {
            Attendance person=new Attendance(0,0,0);
            person.Month=a.Month+b.Month;
            person.LeavesTaken=a.LeavesTaken+b.LeavesTaken;
            person.PermissionTaken=a.PermissionTaken+b.PermissionTaken;
            return person;
        }
        public void CalculateSalary()
        {
            int totalDays=(Month*30)-LeavesTaken;
             Console.WriteLine($"Total Working Days:{Month*30}");
            Console.WriteLine($"Number of Leave Taken: {LeavesTaken}");

            Console.WriteLine($"Total Salary: {totalDays*500}");
        }
    }
}