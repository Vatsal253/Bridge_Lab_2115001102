using System;
namespace MultiplicationTable
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int[] multiplicationTable = new int[10];

            // Storing the results of multiplication in the array
            for (int i = 1; i <= 10; i++)
            {
                multiplicationTable[i - 1] = number * i;
            }
				for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + multiplicationTable[i - 1]);
            }
        }
    }
}
