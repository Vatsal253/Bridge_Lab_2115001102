using System;
namespace NumberChecker
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];

            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + ":");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Checking each number
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine("The number " + numbers[i] + " is positive and even.");
                    }
                    else
                    {
                        Console.WriteLine("The number " + numbers[i] + " is positive and odd.");
                    }
                }
                else if (numbers[i] < 0)
                {
                    Console.WriteLine("The number " + numbers[i] + " is negative.");
                }
                else
                {
                    Console.WriteLine("The number " + numbers[i] + " is zero.");
                }
            }

            // Comparing the first and last elements of the array
            if (numbers[0] == numbers[numbers.Length - 1])
            {
                Console.WriteLine("The first and last elements are equal.");
            }
            else if (numbers[0] > numbers[numbers.Length - 1])
            {
                Console.WriteLine("The first element is greater than the last element.");
            }
            else
            {
                Console.WriteLine("The first element is less than the last element.");
            }
        }
    }
}
