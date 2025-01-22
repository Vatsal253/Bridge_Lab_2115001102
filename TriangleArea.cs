using System;
namespace TriangleArea
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the height in centimeters: ");
			double cmHeight = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the base in centimeters: ");
			double cmBase = Convert.ToDouble(Console.ReadLine());
			double cmArea = 1.0/2.0 * cmBase * cmHeight;
			double inchArea = cmArea / 6.4516;
			Console.WriteLine("The Area in square centimeters is "+ cmArea +"and Area in square inches is "+ inchArea);
		}
	}
}