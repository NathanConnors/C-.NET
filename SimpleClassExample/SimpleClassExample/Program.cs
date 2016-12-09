/*
 * C# 6.0 and the .NET 4.6 Framework" by Andrew Troelsen & Philip Japikse
 * Pg 151 - Understanding Encapsulation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            // Allocate and configure a Car object.
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            // Speed up the car a few times and print new state.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Console.ReadLine();
        }
    }
}
