using System;
namespace Friends
{
    class Program
    {
        static void Main()
        {
            // Define arrays to store ages and heights of the three friends
            int[] ages = new int[3];
            double[] heights = new double[3];

            Console.WriteLine("Enter the age of Amar:");
            ages[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of Amar (in cm):");
            heights[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the age of Akbar:");
            ages[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of Akbar (in cm):");
            heights[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the age of Anthony:");
            ages[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of Anthony (in cm):");
            heights[2] = double.Parse(Console.ReadLine());

            // Find the youngest friend
            string youngestFriend = FindYoungestFriend(ages);
            // Find the tallest friend
            string tallestFriend = FindTallestFriend(heights);

            Console.WriteLine("The youngest friend is: " + youngestFriend);
            Console.WriteLine("The tallest friend is: " + tallestFriend);
        }

        static string FindYoungestFriend(int[] ages)
        {
            int minAge = ages[0];
            int index = 0;

            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < minAge)
                {
                    minAge = ages[i];
                    index = i;
                }
            }

            switch (index)
            {
                case 0: return "Amar";
                case 1: return "Akbar";
                case 2: return "Anthony";
                default: return "Unknown";
            }
        }

        static string FindTallestFriend(double[] heights)
        {
            double maxHeight = heights[0];
            int index = 0;

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > maxHeight)
                {
                    maxHeight = heights[i];
                    index = i;
                }
            }

            switch (index)
            {
                case 0: return "Amar";
                case 1: return "Akbar";
                case 2: return "Anthony";
                default: return "Unknown";
            }
        }
    }
}
