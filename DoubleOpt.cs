using System;
namespace DoubleOpt
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the first number: ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the second number: ");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the third number: ");
			double c = Convert.ToDouble(Console.ReadLine());
			double result1 = a+b*c;
			double result2 = a*b+c;
			double result3 = c+a/b;
			double result4 = a%b+c;
			Console.WriteLine("The results of Int Operations are "+result1+","+result2+","+result3+" and "+result4);
		}
	}
}