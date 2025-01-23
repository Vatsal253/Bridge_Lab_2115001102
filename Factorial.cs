using System;

namespace Factorial
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
                int i = 1;

                while (i <= number)
                {
                    factorial *= i;
                    i++;
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
