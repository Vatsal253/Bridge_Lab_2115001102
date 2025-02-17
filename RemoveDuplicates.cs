using System;
using System.Text;
class Program
{
    static string RemoveDuplicates(string input)
    {
        StringBuilder result = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                result.Append(c);
                seen.Add(c);
            }
        }

        return result.ToString();
    }
    static void Main(string[] args)
    {
        string input = "hello";
        string result = RemoveDuplicates(input);

        Console.WriteLine("Original string: " + input);
        Console.WriteLine("String without duplicates: " + result);
    }
}
