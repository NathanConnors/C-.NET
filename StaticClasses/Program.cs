/*
 * C# 6.0 and the .NET 4.6 Framework" by Andrew Troelsen & Philip Japikse
 * Pg 173 - Static Classes
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Import static members of Console and DateTime.
using static System.Console;
using static System.DateTime;
 
 namespace StaticClasses
 {
	 class Program
	 {
		 static void Main(string[] args)
		 {
			 // You can still access the static class
			 // without creating an object.
			 TimeUtilClass.PrintDate();
			 TimeUtilClass.PrintTime();
			 
			 // This will not compile when class is static!
			 //TimeUtilClass sc = new TimeUtilClass();
			 
			 Console.ReadLine();
		 }
	 }
	 
	 // Static classes can only
	 // contain static members!
	 static class TimeUtilClass
	{
		public static void PrintTime()
		{ WriteLine(Now.ToShortTimeString()); }
		
		public static void PrintDate()
		{ WriteLine(Today.ToShortDateString()); }
	}
 }