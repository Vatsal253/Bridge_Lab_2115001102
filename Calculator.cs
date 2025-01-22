using System;
namespace Calculator
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the first number: ");
			double number1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the second number: ");
			double number2 = Convert.ToDouble(Console.ReadLine());
			double add = number1 + number2;
			double sub = number1 - number2;
			double mul = number1 * number2;
			double div = number1 / number2;
			Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+ number1 + " and "+ number2+ " is "+ add + ","+ sub + "," + mul + "and "+div);
		}
	}
}