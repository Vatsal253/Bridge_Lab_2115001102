using System;
	class temperature
	{
	static void Main()
	{
	Console.WriteLine("Enter the temperature in Celcius:");
	double celcius = Convert.ToDouble(Console.ReadLine());
	double farenheit = (celcius*9/5)+32;
	Console.WriteLine("The temperature in farenheit is: "+farenheit);
	}
	}
	