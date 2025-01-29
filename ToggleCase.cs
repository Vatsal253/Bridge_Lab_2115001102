using System;
namespace ToggleCase
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                char oChar = input[i];
                if (oChar >= 'A' && oChar <= 'Z')
                {
                    result += (char)(oChar + 32);
                }
                else if (oChar >= 'a' && oChar <= 'z')
                {
                    result += (char)(oChar - 32);
                }
                else
                {
                    result += oChar;
                }
            }
            Console.WriteLine("Modified string: " + result);
        }
    }
}
