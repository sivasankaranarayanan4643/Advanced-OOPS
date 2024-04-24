using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public interface IBalance
    {
        public double WalletBalance { get; }
        public void WalletRecharge(double amount);
    }
}