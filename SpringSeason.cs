using System;
namespace SpringSeason
{
    class Program
    {
        static void Main()
        {
            // Take user input for month and day
            Console.WriteLine("Enter the month (1-12):");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the day (1-31):");
            int day = int.Parse(Console.ReadLine());

            // Check if it's Spring season
            bool isSpring = IsSpringSeason(month, day);

            if (isSpring)
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }

        static bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            {
                return true;
            }
            return false;
        }
    }
}
