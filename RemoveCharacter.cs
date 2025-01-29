using System;
namespace RemoveCharacter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the character to remove:");
            char charRemove = Console.ReadLine()[0];
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != charRemove)
                {
                    result += input[i];
                }
            }
            Console.WriteLine("New string: " + result);
        }
    }
}
