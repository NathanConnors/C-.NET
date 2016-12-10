/*
 * C# 6.0 and the .NET 4.6 Framework" by Andrew Troelsen & Philip Japikse
 * Pg 173 - Static Classes
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 namespace StaticClasses
 {
	 class Program
	 {
		 static void Main(string[] args)
		 {
			 StaticClass sc = new StaticClass();
		 }
	 }
	 
	 class StaticClass
	{
		public StaticClass()
		{
			Console.WriteLine("New Object!");
		}
	}
 }