using System;
namespace PalindromeChecker
{
    class Program
    {
        static void Main()
        {
            string input = GetInput();
            bool isPalindrome = CheckPalindrome(input);
            DisplayResult(input, isPalindrome);
        }

        static string GetInput()
        {
            Console.WriteLine("Enter a string:");
            return Console.ReadLine();
        }

        static bool CheckPalindrome(string str)
        {
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static void DisplayResult(string str, bool isPalindrome)
        {
            if (isPalindrome)
            {
                Console.WriteLine(str+" is a palindrome.");
            }
            else
            {
                Console.WriteLine(str+" is not a palindrome.");
            }
        }
    }
}
