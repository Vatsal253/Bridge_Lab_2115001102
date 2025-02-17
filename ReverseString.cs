using System;
using System.Text;
class Program
{
    static string ReverseString(string input)
    {
        StringBuilder reversed = new StringBuilder(input.Length);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }
    static void Main(string[] args)
    {
        string input = "hello";
        string reversed = ReverseString(input);

        Console.WriteLine("Original string: " + input);
        Console.WriteLine("Reversed string: " + reversed);
    }
}
