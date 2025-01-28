using System;
namespace LeapYearChecker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a year (>= 1582):");
            int year = int.Parse(Console.ReadLine());

            if (year < 1582)
            {
                Console.WriteLine("The program only works for years >= 1582.");
                return;
            }

            bool isLeapYear = IsLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine("The year " + year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine("The year " + year + " is not a Leap Year.");
            }
        }

        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
