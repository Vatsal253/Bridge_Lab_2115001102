using System;
namespace MostFrequent
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            char mostFrequentChar = '\0';
            int maxCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char cChar = input[i];
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == cChar)
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    mostFrequentChar = cChar;
                    maxCount = count;
                }
            }
            Console.WriteLine("Most Frequent Character: " + mostFrequentChar);
        }
    }
}
