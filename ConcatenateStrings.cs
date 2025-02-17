using System;
using System.Text;
class Program
{
    static string ConcatenateStrings(string[] strings)
    {
        StringBuilder concatenated = new StringBuilder();

        foreach (string str in strings)
        {
            concatenated.Append(str);
        }

        return concatenated.ToString();
    }
    static void Main(string[] args)
    {
        string[] strings = { "Hello", " ", "world", "!", " How", " are", " you", "?" };
        string result = ConcatenateStrings(strings);

        Console.WriteLine("Concatenated string: " + result);
    }
}
