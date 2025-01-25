using System;
namespace Friends
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Amar", "Akbar", "Anthony" };
            int[] ages = new int[3];
            int[] heights = new int[3];

            // Taking user input for ages and heights
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the age of " + names[i] + ":");
                ages[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height of " + names[i] + " (in cm):");
                heights[i] = int.Parse(Console.ReadLine());
            }

            // Finding the youngest friend
            int youngestAge = ages[0];
            string youngestFriend = names[0];
            for (int i = 1; i < 3; i++)
            {
                if (ages[i] < youngestAge)
                {
                    youngestAge = ages[i];
                    youngestFriend = names[i];
                }
            }

            // Finding the tallest friend
            int tallestHeight = heights[0];
            string tallestFriend = names[0];
            for (int i = 1; i < 3; i++)
            {
                if (heights[i] > tallestHeight)
                {
                    tallestHeight = heights[i];
                    tallestFriend = names[i];
                }
            }

            // Displaying the results
            Console.WriteLine("The youngest friend is " + youngestFriend + " with age " + youngestAge + ".");
            Console.WriteLine("The tallest friend is " + tallestFriend + " with height " + tallestHeight + " cm.");
        }
    }
}
