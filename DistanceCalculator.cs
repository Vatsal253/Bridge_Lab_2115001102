using System;
namespace DistanceCalculator
	{
	class Program
	{
	static void Main()
	{
		double kilometers = 10.8;
		double conversion = 1.6;
		double miles = kilometers*conversion;
		Console.WriteLine("The distance "+kilometers+" km in miles is "+miles);
	}
	}
	}