using System;
namespace Factorial2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                int factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine("Factorial of " + number + " is " + factorial);
            }
            else
            {
                Console.WriteLine("The number " + number + " is not a positive integer");
            }
        }
    }
}
