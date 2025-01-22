using System;
namespace SquareSide
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the perimeter of square: ");
			double sqPerimeter = Convert.ToDouble(Console.ReadLine());
			double sqSide = sqPerimeter / 4.0;
			Console.WriteLine("The length of the side is "+ sqSide +" whose perimeter is "+sqPerimeter);
		}
	}
}