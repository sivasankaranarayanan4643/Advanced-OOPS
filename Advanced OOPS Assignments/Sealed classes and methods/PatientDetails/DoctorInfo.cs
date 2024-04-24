using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientDetails
{
    public class DoctorInfo:PatientInfo//Error showing as it was not possible to inherit sealed class
    {
        private static int s_doctorID=1000;
        public string DoctorID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public void DisplayInfo()
        {
            
        }
    }
}