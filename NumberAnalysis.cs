using System;
namespace NumberAnalysis
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

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsPositive(numbers[i]))
                {
                    Console.WriteLine("Number " + numbers[i] + " is positive.");
                    if (IsEven(numbers[i]))
                    {
                        Console.WriteLine("Number " + numbers[i] + " is even.");
                    }
                    else
                    {
                        Console.WriteLine("Number " + numbers[i] + " is odd.");
                    }
                }
                else
                {
                    Console.WriteLine("Number " + numbers[i] + " is negative.");
                }
            }

            int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);
            if (comparisonResult == 1)
            {
                Console.WriteLine("The first element is greater than the last element.");
            }
            else if (comparisonResult == 0)
            {
                Console.WriteLine("The first element is equal to the last element.");
            }
            else
            {
                Console.WriteLine("The first element is less than the last element.");
            }
        }

        static bool IsPositive(int number)
        {
            return number >= 0;
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static int Compare(int number1, int number2)
        {
            if (number1 > number2)
            {
                return 1;
            }
            else if (number1 == number2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
