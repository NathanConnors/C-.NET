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
			 
			 // Garage implementation
			 Garage g = new Garage();
			 
			 // Prints 1, set by default constructor
			 Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
			 
			 // Runs now, calls to default value set with default constructor
			 // which is still empty but does not cause runtime error
			 Console.WriteLine(g.MyAuto.PetName);
			 
			 
			 // Use previous car object as baseline for garage
			 Garage g2 = new Garage();
			 g2.MyAuto = c;
			 Console.WriteLine("Number of Cars: {0}", g2.NumberOfCars);
			 Console.WriteLine(g2.MyAuto.PetName);
			 
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
	 
	 class Garage
	 {
		 // The hidden int backing field is set to zero
		 public int NumberOfCars { get; set; }
		 
		 // The hidden Car backing field is set to null
		 public Car MyAuto { get; set; }
		 
		 // Constructor used to override default
		 public Garage()
		 {
			 MyAuto = new Car();
			 NumberOfCars = 1;
		 }
		 
		 public Garage(Car car, int number)
		 {
			 MyAuto = car;
			 NumberOfCars = number;
		 }
	 }
 }