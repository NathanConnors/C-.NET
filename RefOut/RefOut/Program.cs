/*
 * C# 6.0 and the .NET 4.6 Framework" by Andrew Troelsen & Philip Japikse
 * Pg 111 - Ref & Out Operators
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        // swaps strings, uses 'ref' keyword.
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        static void Main(string[] args)
        {
            // reference operator, passing data by ref.
            Console.WriteLine("Reference Methods");
            string s1 = "Nathan";
            string s2 = "Connors";

            Console.WriteLine("Before: {0} {1} ", s1, s2);
            // requires 'ref' to be in parameter here as well
            // because the method indicates a ref requirement.
            SwapStrings(ref s1, ref s2);
            Console.WriteLine("After: {0} {1} ", s1, s2);

            Console.ReadLine();
        }
    }
}
