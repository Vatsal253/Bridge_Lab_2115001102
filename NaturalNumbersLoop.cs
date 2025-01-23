using System;
namespace NaturalNumbersLoop
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a natural number: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                int sum = 0;

                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }

                int formulaSum = number * (number + 1) / 2;

                Console.WriteLine("Sum using for loop: " + sum);
                Console.WriteLine("Sum using formula: " + formulaSum);
            }
            else
            {
                Console.WriteLine("The number " + number + " is not a natural number");
            }
        }
    }
}
