using System;
namespace TemperatureConversion2
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the temperature in Fahrenheit: ");
			double tempF = Convert.ToDouble(Console.ReadLine());
			double tempC = (tempF -32)*5/9;
			Console.WriteLine("The "+tempF+" Fahrenheit is "+tempC+" Celsius");
		}
	}
}