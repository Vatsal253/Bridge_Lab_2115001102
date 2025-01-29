using System;
namespace LexicographicString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first string:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string string2 = Console.ReadLine();
            int cResult = CompareStrings(string1, string2);
            if (cResult < 0)
            {
                Console.WriteLine("\"" + string1 + "\" comes before \"" + string2 + "\" in lexicographical order.");
            }
            else if (cResult > 0)
            {
                Console.WriteLine("\"" + string1 + "\" comes after \"" + string2 + "\" in lexicographical order.");
            }
            else
            {
                Console.WriteLine("\"" + string1 + "\" is equal to \"" + string2 + "\" in lexicographical order.");
            }
        }

        static int CompareStrings(string str1, string str2)
        {
            int minLength = Math.Min(str1.Length, str2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (str1[i] < str2[i])
                {
                    return -1; 
                }
                else if (str1[i] > str2[i])
                {
                    return 1; 
                }
            }
            if (str1.Length < str2.Length)
            {
                return -1; 
            }
            else if (str1.Length > str2.Length)
            {
                return 1; 
            }
            return 0; 
        }
    }
}
