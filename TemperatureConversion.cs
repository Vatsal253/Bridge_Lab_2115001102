using System;
namespace TemperatureConversion 
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the temperature in celsius: ");
			double tempC = Convert.ToDouble(Console.ReadLine());
			double tempF = (tempC *9/5)+32;
			Console.WriteLine("The "+tempC+" Celsius is "+tempF+" Fahrenheit");
		}
	}
}