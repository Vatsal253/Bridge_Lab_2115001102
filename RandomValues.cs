using System;
namespace RandomValues
{
    class Program
    {
        static void Main()
        {
            // Generate an array of five 4-digit random values
            int[] randomValues = Generate4DigitRandomArray(5);

            // Find the average, min, and max values
            double[] results = FindAverageMinMax(randomValues);

            Console.WriteLine("Random values:");
            foreach (int value in randomValues)
            {
                Console.WriteLine(value);
            }

            // Display the average, min, and max values
            Console.WriteLine("Average value: " + results[0]);
            Console.WriteLine("Minimum value: " + results[1]);
            Console.WriteLine("Maximum value: " + results[2]);
        }

        public static int[] Generate4DigitRandomArray(int size)
        {
            Random random = new Random();
            int[] randomArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(1000, 10000); // Generate a 4-digit random number
            }

            return randomArray;
        }

        public static double[] FindAverageMinMax(int[] numbers)
        {
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            foreach (int number in numbers)
            {
                sum += number;
                min = Math.Min(min, number);
                max = Math.Max(max, number);
            }

            double average = (double)sum / numbers.Length;
            return new double[] { average, min, max };
        }
    }
}
