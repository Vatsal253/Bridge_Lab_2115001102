using System;
	class power{
	static void Main(){
	Console.WriteLine("Enter the base number :");
	double baseNumber = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Enter the exponent number :");
	double exponentNumber = Convert.ToDouble(Console.ReadLine());
	double result = Math.Pow(baseNumber , exponentNumber);
	Console.WriteLine("The result is: "+result);
	}
	}