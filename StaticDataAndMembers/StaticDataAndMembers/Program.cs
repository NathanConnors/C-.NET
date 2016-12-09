/*
 * C# 6.0 and the .NET 4.6 Framework" by Andrew Troelsen & Philip Japikse.
 * Pg 167 - Defining Static Field Data.
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

            // Instantiate object.
            SavingsAccount s1 = new SavingsAccount(50);
            
            // Print the current interest rate.
            Console.WriteLine("Interest rate is: {0}", SavingsAccount.GetInterestRate());

            // Try to change the interest rate via property.
            SavingsAccount.SetInterestRate(0.08);

            // Proves change worked.
            Console.WriteLine("Interest rate is: {0}", SavingsAccount.GetInterestRate());

            // When new object is made it resets interest rate.
            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine("Interest rate is: {0}", SavingsAccount.GetInterestRate());

            Console.ReadLine();

        }
    }
}
