using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interest
{
    public class IDBI:Bank
    {
        public override double GetInterestInfo(double amount)
        {
            double interest=amount*7.5/100;
            return interest;
        }
    }
}