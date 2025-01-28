using System;
namespace NumberCheck
{
    class Program
    {
        static void Main()
        {
            // Take user input for the number
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int result = CheckNumber(number);

            if (result == 1)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (result == -1)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        static int CheckNumber(int number)
        {
            if (number > 0)
            {
                return 1;
            }
            else if (number < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
