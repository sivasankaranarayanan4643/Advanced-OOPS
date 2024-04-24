using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class PermanentEmployee : SalaryInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; }
        public string EmployeeType { get; set; }
        private double _dA=0.2/100;
        private double _hRA=0.18/100;
        private double _pF=0.1/100;
        public double TotalSalary { get; set; }
        public PermanentEmployee(double basicSalary,int month,string employeeType):base(basicSalary,month)
        {
            s_employeeID++;
            EmployeeID="PEID"+s_employeeID;
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