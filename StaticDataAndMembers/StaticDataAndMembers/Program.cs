/*
 * C# 6.0 and the .NET 4.6 Framework" by Andrew Troelsen & Philip Japikse
 * Pg 167 - Defining Static Field Data
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static data member with objects practice");

            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);

            // Print the current interest rate.
            Console.WriteLine("Interest rate is: {0}", SavingsAccount.GetInterestRate());

            // Make new object, this does NOT 'reset' the interest rate.
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest rate is: {0}", SavingsAccount.GetInterestRate());

            Console.ReadLine();

        }
    }
}
