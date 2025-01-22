using System;
namespace DistanceConverter
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the distance in kilometers: ");
			double km = Convert.ToDouble(Console.ReadLine());
			double convertFactor = 1.6;
			double miles = km / convertFactor;
			Console.WriteLine("The total miles is "+miles +" mile for the given "+ km+" km");
		}
	}
}