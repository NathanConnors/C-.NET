﻿/*
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
            Console.WriteLine("***** Fun with Class Types *****");

            //Motorcycle object instantiation
            Motorcycle mc = new Motorcycle(7);
            Motorcycle mc2 = new Motorcycle("Sarah");
            Motorcycle mc3 = new Motorcycle();

            // Motorcyle object functions.
            //mc.SetDriverName("George");
            //mc.PopAWheely();
            //mc2.PopAWheely();

            // Default Constructor
            Car myCar = new Car();
            myCar.PrintState();

            // Non-Default Constructor - 1 Parameter
            Car myCar2 = new Car("Harry");
            myCar2.PrintState();

            // Non-Default Constructr - 2 Parameters
            Car myCar3 = new Car("Sally", 40);
            myCar3.PrintState();

            

            Console.ReadLine();
        }
    }
}
