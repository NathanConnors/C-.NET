/*
 * C# 6.0 and the .NET 4.6 Framework" by Andrew Troelsen & Philip Japikse
 * Pg 111 - Ref, Out, Params Operators
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

        // return average of variable amount of doubles.
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;

            for (int i = 0; i < values.Length; i++)
                sum += values[i];

            return(sum / values.Length);
        }

        // output parameters
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        // returning multiple output parameters
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Nate";
            c = true;
        }

        static void Main(string[] args)
        {
            // reference operator, passing data by ref.
            Console.WriteLine("'ref' operator:");
            string s1 = "Nathan";
            string s2 = "Connors";

            Console.WriteLine("Before: {0} {1} ", s1, s2);
            // requires 'ref' to be in parameter here as well
            // because the method indicates a ref requirement.
            SwapStrings(ref s1, ref s2);
            Console.WriteLine("After: {0} {1} ", s1, s2);


            // params operator use.
            Console.WriteLine();
            Console.WriteLine("'params' operator:");

            // pass an array of doubles, also works
            // if you pass doubles manually.
            double[] data = { 4.0, 3.2, 5.7 };
            double average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);

            // output parameters use.
            Console.WriteLine();
            Console.WriteLine("'out' operator:");
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("Answer is: {0}", ans);

            // multiple output parameters
            Console.WriteLine("Multiple outputparameters");
            int i; string str; bool b;

            FillTheseValues(out i, out str, out b);

            Console.WriteLine("Int: {0}, String: {1}, Bool: {2}", i, str, b);

            Console.ReadLine();
        }
    }
}
