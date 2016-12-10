/*
 * C# 6.0 and the .NET 4.6 Framework" by Andrew Troelsen & Philip Japikse
 * Pg 192 - Automatic Properties
 */
 
 using System;
 
 namespace AutomaticProperties
 {
	 class Program
	 {
		 static void Main(string[] args)
		 {
			 Console.WriteLine("Automatic Properties");
			 
			 // Create object
			 Car c = new Car();
			 c.PetName = "Frank";
			 c.Speed = 55;
			 c.Color = "Red";
			 
			 c.DisplayStats();
			 
			 Console.ReadLine();
		 }
	 }
	 
	 class Car
	 {
		 // Automatic properties
		 public string PetName {get; set; }
		 public int Speed {get; set; }
		 public string Color {get; set; }
		 
		 public void DisplayStats()
		 {
			 Console.WriteLine("Car Name: {0}", PetName);
			 Console.WriteLine("Speed: {0}", Speed);
			 Console.WriteLine("Color: {0}", Color);
		 }
	 }
 }