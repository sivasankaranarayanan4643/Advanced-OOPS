using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interest
{
    public abstract class Bank
    {
        public abstract double GetInterestInfo(double amount);
    }
}