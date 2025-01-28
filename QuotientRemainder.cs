using System;
namespace QuotientRemainder
{
    class Program
    {
        static void Main()
        {
            // Take user input for the two numbers
            Console.WriteLine("Enter the first number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number (divisor):");
            int divisor = int.Parse(Console.ReadLine());

            // Calculate the quotient and remainder
            int[] result = FindRemainderAndQuotient(number, divisor);

            // Display the result
            Console.WriteLine("The quotient is " + result[0]);
            Console.WriteLine("The remainder is " + result[1]);
        }

        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;
            return new int[] { quotient, remainder };
        }
    }
}
