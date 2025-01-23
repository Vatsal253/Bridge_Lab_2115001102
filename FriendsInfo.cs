using System;

namespace FriendsInfo
{
    class Program
    {
        static void Main()
        {
            // Taking user input for ages and heights
            Console.WriteLine("Enter the age of Amar:");
            int ageAmar = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of Amar (in cm):");
            int heightAmar = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the age of Akbar:");
            int ageAkbar = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of Akbar (in cm):");
            int heightAkbar = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the age of Anthony:");
            int ageAnthony = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of Anthony (in cm):");
            int heightAnthony = int.Parse(Console.ReadLine());

            // Finding the youngest friend
            int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
            string youngestFriend;
            if (youngestAge == ageAmar)
            {
                youngestFriend = "Amar";
            }
            else if (youngestAge == ageAkbar)
            {
                youngestFriend = "Akbar";
            }
            else
            {
                youngestFriend = "Anthony";
            }
            Console.WriteLine("The youngest friend is " + youngestFriend + " with age " + youngestAge + ".");

            // Finding the tallest friend
            int tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
            string tallestFriend;
            if (tallestHeight == heightAmar)
            {
                tallestFriend = "Amar";
            }
            else if (tallestHeight == heightAkbar)
            {
                tallestFriend = "Akbar";
            }
            else
            {
                tallestFriend = "Anthony";
            }
            Console.WriteLine("The tallest friend is " + tallestFriend + " with height " + tallestHeight + " cm.");
        }
    }
}
