using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    //error showing as we cannot inherit the sealed class
    //since  it is  sealed class the information cannot be accessed
    public class Hack:EmployeeInfo
    {
        public string StoreUserID { get; set; }
        public string StorePassword { get; set; }
        public void ShowKeyInfo()
        {
    //since  it is  sealed class the information cannot be accessed

        }
        public void GetUserInfo()
        {
    //since  it is  sealed class the information cannot be accessed

        }

    }
}