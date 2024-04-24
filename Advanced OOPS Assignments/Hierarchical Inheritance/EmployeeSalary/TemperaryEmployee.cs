using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class TemperaryEmployee:SalaryInfo
    {
          private static int s_employeeID=4000;
        public string EmployeeID { get; }
        public string EmployeeType { get; set; }
        private double _dA=0.15/100;
        private double _hRA=0.13/100;
        private double _pF=0.1/100;
        public double TotalSalary { get; set; }
        public TemperaryEmployee(double basicSalary,int month,string employeeType):base(basicSalary,month)
        {
            s_employeeID++;
            EmployeeID="TEID"+s_employeeID;
            EmployeeType=employeeType;
            _dA*=basicSalary*Month;
            _hRA*=basicSalary*Month;
            _pF*=basicSalary*Month;
        }
        public void CalculateTotalSalary()
        {
            TotalSalary=(BasicSalary*Month)+_dA+_hRA-_pF;
        }
        public void ShowSalary()
        {
            Console.WriteLine($"Your salary  is {TotalSalary}");
        }
    }
}