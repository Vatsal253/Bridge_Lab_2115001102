using System;
namespace StudentVoteChecker
{
    public class StudentVoteChecker
    {
        // Method to check if a student can vote
        public bool CanStudentVote(int age)
        {
            if (age < 0)
            {
                return false; 
            }
            return age >= 18;
        }
    }

    class Program
    {
        static void Main()
        {
            StudentVoteChecker voteChecker = new StudentVoteChecker();

            int[] studentAges = new int[10];

            for (int i = 0; i < studentAges.Length; i++)
            {
                Console.WriteLine("Enter the age of student " + (i + 1) + ":");
                studentAges[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < studentAges.Length; i++)
            {
                bool canVote = voteChecker.CanStudentVote(studentAges[i]);
                if (canVote)
                {
                    Console.WriteLine("Student " + (i + 1) + " can vote.");
                }
                else
                {
                    Console.WriteLine("Student " + (i + 1) + " cannot vote.");
                }
            }
        }
    }
}
