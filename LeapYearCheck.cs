using System;
namespace LeapYearCheck
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the year: ");
			int year = int.Parse(Console.ReadLine());

            if (year >= 1582)
            {
				if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("The year is a Leap Year.");
                }
                else
                {
                    Console.WriteLine("The year is not a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine("The program only works for years >= 1582.");
			}
		}
	}
}