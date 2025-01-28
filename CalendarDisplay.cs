using System;
namespace CalendarDisplay
{
    class Program
    {
        static void Main()
        {
            // Take user input for month and year
            Console.WriteLine("Enter the month (1-12):");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());

            // Display the calendar
            DisplayCalendar(month, year);
        }

        static void DisplayCalendar(int month, int year)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Check for leap year
            if (IsLeapYear(year))
            {
                daysInMonth[1] = 29;
            }

            // Get the first day of the month
            int firstDay = GetFirstDayOfMonth(month, year);

            // Display the month and year
            Console.WriteLine("\n" + months[month - 1] + " " + year);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            // Print leading spaces
            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }

            // Print the days of the month
            for (int day = 1; day <= daysInMonth[month - 1]; day++)
            {
                Console.Write("{0,3} ", day);
                if ((day + firstDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static int GetFirstDayOfMonth(int month, int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            return (1 + x + (31 * m) / 12) % 7;
        }
    }
}
