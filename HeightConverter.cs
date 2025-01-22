using System;
namespace HeightConverter
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the height in centimeters: ");
			double cmHeight = Convert.ToDouble(Console.ReadLine());
			double inchHeight = cmHeight / 2.54;
			double footHeight = inchHeight / 12;
			Console.WriteLine("Your Height in cm is "+ cmHeight +" while in feet is "+ footHeight +" and inches is "+ inchHeight);
		}
	}
}


			