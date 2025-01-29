using System;
namespace Anagram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first string:");
            string string1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the second string:");
            string string2 = Console.ReadLine().ToLower();
            bool areAnagrams = AreAnagrams(string1, string2);
            if (areAnagrams)
            {
                Console.WriteLine("The strings are anagrams of each other.");
            }
            else
            {
                Console.WriteLine("The strings are not anagrams of each other.");
            }
        }

        static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            char[] charArray1 = new char[str1.Length];
            char[] charArray2 = new char[str2.Length];

            for (int i = 0; i < str1.Length; i++)
            {
                charArray1[i] = str1[i];
                charArray2[i] = str2[i];
            }
            for (int i = 0; i < charArray1.Length - 1; i++)
            {
                for (int j = i + 1; j < charArray1.Length; j++)
                {
                    if (charArray1[i] > charArray1[j])
                    {
                        char temp = charArray1[i];
                        charArray1[i] = charArray1[j];
                        charArray1[j] = temp;
                    }

                    if (charArray2[i] > charArray2[j])
                    {
                        char temp = charArray2[i];
                        charArray2[i] = charArray2[j];
                        charArray2[j] = temp;
                    }
                }
            }
            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
