﻿using System;
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
        public static double currInterestRate = 0.04;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
    }
}
