using System;
namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            char[] charArray = new char[input.Length];
            int index = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                charArray[index++] = input[i];
            }
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed string: " + reversedString);
        }
    }
}
