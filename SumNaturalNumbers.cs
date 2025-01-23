using System;

namespace SumNaturalNumbers
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
                int i = 1;

                while (i <= number)
                {
                    sum += i;
                    i++;
                }

                int formulaSum = number * (number + 1) / 2;

                Console.WriteLine("Sum using while loop: " + sum);
                Console.WriteLine("Sum using formula: " + formulaSum);
            }
            else
            {
                Console.WriteLine("The number " + number + " is not a natural number");
            }
        }
    }
}
