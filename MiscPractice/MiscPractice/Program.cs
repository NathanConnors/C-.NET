/*
 * Misc. Practice Project
 * Jagged Arrays
 * Multidimensional Array
 * Boxing + Unboxing
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
            /*
             * Jagged array example.
             * differs from multidimensional array because
             * it does not require 'square' lengths.
             */
            Console.WriteLine("Jagged Array Example");
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[2] { 1, 2 };
            jaggedArr[1] = new int[5] { 1, 4, 5, 7, 1 };
            jaggedArr[2] = new int[3] { 5, 8, 1 };

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for (int k = 0; k < jaggedArr[i].Length; k++)
                {
                    Console.Write("{0} ", jaggedArr[i][k]);
                }
                Console.WriteLine();
            }

            /*
             * Multidimensional array example.
             * Array specifies 4 arrays with 2 in each.
             */
            Console.WriteLine("\nMultidimensional Array Example");
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

            /* 
             * Boxing and unboxing example
             * useful for 'unified type system'
             * easy to use, remember this.
             */
            //Console.WriteLine("\Boxing + Unboxing Example");
            int x = 5;

            // Boxing the int
            object box = x;

            // Unboxing the int
            int y = (int)box;

            /*
             * Dynamic type example
             * A keyword used to declare variable when you do not
             * know value type
             */
            Console.WriteLine("\nDynamic Type Example");
            dynamic d = 2;
            d = 2.5;

            Console.WriteLine(d);

            /*
             * is operator example.
             * Tests if obj a certain class. 
             */
            Console.WriteLine("\n'is' Operator Example");
            UselessObj myObj = new UselessObj();

            if(myObj is UselessObj)
                Console.WriteLine("'is' operator is working!");
            else
                Console.WriteLine("'is' operator isn't working :(");

            // This test works, however VS
            // gives green underlines, so 
            // keep in mind there is a more
            // elegant solution
            double myInt = 1.1;
            if(myInt is int)
                Console.WriteLine("yea");
            else
                Console.WriteLine("no");

            /*
            * as operator example.
            * used as a type converter
            */

            Console.WriteLine("\nas Operator Example");
            object[] objArray = new object[6];
            objArray[0] = new ClassA();
            objArray[1] = new ClassB();
            objArray[2] = "hello";
            objArray[3] = 123;
            objArray[4] = 123.4;
            objArray[5] = null;

            for (int i = 0; i < objArray.Length; ++i)
            {
                string s = objArray[i] as string;
                Console.Write("{0}:", i);
                if (s != null)
                {
                    Console.WriteLine("'" + s + "'");
                }
                else
                {
                    Console.WriteLine("not a string");
                }
            }


        } // end main
    } // end class program

    class UselessObj
    {
        private int objInt;

        public UselessObj()
        {
            objInt = 5;
        }
    }

    // Empty classes
    class ClassA { }
    class ClassB { }
}
