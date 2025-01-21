using System;
	class distance
	{
	static void Main()
	{
	Console.WriteLine("Enter the distance in kilometers: ");
	double kilometer = Convert.ToDouble(Console.ReadLine());
	double miles = kilometer*0.621371;
	Console.WriteLine("The distance in miles is: "+miles);
	}
	}
	