using System;
namespace ChocolateDistribution
{
    class Program
    {
        static void Main()
        {
            // Take user input for the number of chocolates
            Console.WriteLine("Enter the number of chocolates:");
            int numberOfChocolates = int.Parse(Console.ReadLine());

            // Take user input for the number of children
            Console.WriteLine("Enter the number of children:");
            int numberOfChildren = int.Parse(Console.ReadLine());

            // Calculate the number of chocolates each child gets and the remaining chocolates
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            // Display the result
            Console.WriteLine("Each child will get " + result[0] + " chocolates.");
            Console.WriteLine("The remaining chocolates are " + result[1] + ".");
        }

        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;
            return new int[] { quotient, remainder };
        }
    }
}
