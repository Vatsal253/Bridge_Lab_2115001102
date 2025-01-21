using System;
	class Rectangle
	{
	static void Main()
	{
	Console.WriteLine("Enter the length :");
	double length = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Enter the width :");
	double width = Convert.ToDouble(Console.ReadLine());
	double perimeter = 2*(length + width);
	Console.WriteLine("The perimeter of rectangle is: "+perimeter);
	}
	}
