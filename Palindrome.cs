using System;
namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string inputLower = input.ToLower();
            bool isPalindrome = true;
            for (int i = 0; i < inputLower.Length / 2; i++)
            {
                if (inputLower[i] != inputLower[inputLower.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}
