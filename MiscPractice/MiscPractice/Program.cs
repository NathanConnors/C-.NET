/*
 * Misc. Practice Project
 * Jagged Arrays
 * Multidimensional Array
 * Boxing + Unboxing
 * Pointers
 * Dynamic Type
 * 'is' + 'as' operators
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jagged array example.
            // differs from multidimensional array because
            // it does not require 'square' lengths.
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[2] { 1, 2 };
            jaggedArr[1] = new int[5] { 1, 4, 5, 7, 1 };
            jaggedArr[2] = new int[3] { 5, 8, 1 };

            for(int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for(int k = 0; k < jaggedArr[i].Length; k++)
                {
                    Console.Write("{0} ", jaggedArr[i][k]);
                }
                Console.WriteLine();
            }

            // Multidimensional array example.
            // Array specifies 4 arrays with 2 in each.
            int[,] multiArr = new int[4, 2] 
            { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 }, 
                { 7, 8 }
            };

            // A similar array with string elements.
            string[,] stringArr = new string[3, 2] 
            { 
                { "one", "two" },
                { "three", "four" },                                  
                { "five", "six" }
            };

            // Array printing in order.
            foreach (int i in multiArr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
