using System;
namespace FootballTeam
{
    class Program
    {
        static void Main()
        {
            // Create an array to store the heights of 11 players
            int[] heights = GenerateRandomHeights(11);

            // Find the sum of all the elements in the array
            int sum = FindSum(heights);

            // Find the mean height of the players
            double meanHeight = FindMeanHeight(sum, heights.Length);

            // Find the shortest height of the players
            int shortestHeight = FindShortestHeight(heights);

            // Find the tallest height of the players
            int tallestHeight = FindTallestHeight(heights);

            // Display the results
            Console.WriteLine("Heights of the players:");
            foreach (int height in heights)
            {
                Console.WriteLine(height + " cm");
            }
            Console.WriteLine("Mean height: " + meanHeight + " cm");
            Console.WriteLine("Shortest height: " + shortestHeight + " cm");
            Console.WriteLine("Tallest height: " + tallestHeight + " cm");
        }

        public static int[] GenerateRandomHeights(int size)
        {
            Random random = new Random();
            int[] heights = new int[size];

            for (int i = 0; i < size; i++)
            {
                heights[i] = random.Next(150, 251); // Generate a random height between 150 and 250 cm
            }

            return heights;
        }

        public static int FindSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static double FindMeanHeight(int sum, int count)
        {
            return (double)sum / count;
        }

        public static int FindShortestHeight(int[] heights)
        {
            int shortest = heights[0];
            foreach (int height in heights)
            {
                if (height < shortest)
                {
                    shortest = height;
                }
            }
            return shortest;
        }

        public static int FindTallestHeight(int[] heights)
        {
            int tallest = heights[0];
            foreach (int height in heights)
            {
                if (height > tallest)
                {
                    tallest = height;
                }
            }
            return tallest;
        }
    }
}
