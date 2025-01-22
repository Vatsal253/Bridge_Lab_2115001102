using System;
namespace DistanceConverter2
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the distance in feet: ");
			double feet = Convert.ToDouble(Console.ReadLine());
			double yard = feet / 3.0;
			double mile = yard / 1760.0;
			Console.WriteLine("Your Distance in yards is "+yard+" while in feet is "+feet+" and miles is "+mile);
		}
	}
}