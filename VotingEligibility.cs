using System;

namespace VotingEligibility
{
    class Program
    {
        static void Main()
        {
            int[] ages = new int[10];

            // Taking user input for the ages of 10 students
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write("Enter the age of student " + (i + 1) + ":");
                ages[i] = int.Parse(Console.ReadLine());
            }

            // Checking voting eligibility
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid age for student " + (i + 1) + ".");
                }
                else if (ages[i] >= 18)
                {
                    Console.WriteLine("The student with the age " + ages[i] + " can vote.");
                }
                else
                {
                    Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
                }
            }
        }
    }
}
