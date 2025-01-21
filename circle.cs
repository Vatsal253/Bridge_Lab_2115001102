using System;
	class circle
	{
	static void Main()
	{
	Console.WriteLine("Enter the radius :");
	double radius = Convert.ToDouble(Console.ReadLine());
	double area = Math.PI* Math.Pow(radius,2);
	Console.WriteLine("The area of circle is: "+area);
	}
	}
	