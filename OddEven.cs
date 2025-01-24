using System;
namespace OddEven
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a natural number:");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Error: Please enter a natural number greater than 0.");
                return;
            }

            int[] oddNumbers = new int[number / 2 + 1];
            int[] evenNumbers = new int[number / 2 + 1];
            int oddIndex = 0;
            int evenIndex = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    oddNumbers[oddIndex] = i;
                    oddIndex++;
                }
            }

            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.WriteLine(oddNumbers[i]);
            }

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }
        }
    }
}
