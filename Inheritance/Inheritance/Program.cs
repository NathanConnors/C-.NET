/*
 * C# 6.0 and the .NET 4.6 Framework" by Andrew Troelsen & Philip Japikse
 * Pg 205 - Inheritance
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Practice");
            // make a car object and set max speed.
            Car myCar = new Car();

            // set the current speed, and print it.
            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);

            // make minivan object
            MiniVan mini = new MiniVan();
            mini.Speed = 10;
            Console.WriteLine("My van is going {0} MPH", mini.Speed);
            Console.ReadLine();

        }
    }
}
