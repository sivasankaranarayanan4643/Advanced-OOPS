using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class SalaryInfo
    {
        public double BasicSalary { get; set; }
        public int Month { get; set; }
        public SalaryInfo(double basicSalary,int month)
        {
            BasicSalary=basicSalary;
            Month=month;
        }
    }
}