using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        // Instance-level data.
        public double currBalance;

        /*
         * A static data member means that the data
         * is shared between instances. This means
         * that .04 is shared between object 1, 2, and 3
         */

        // A static point of data.
        public static double currInterestRate;

        public SavingsAccount(double balance)
        {
            currInterestRate = 0.04;
            currBalance = balance;
        }

        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }

        public static double GetInterestRate()
        { return currInterestRate; }
    }
}
