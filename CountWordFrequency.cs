using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Dictionary<string, int> CountWordFrequency(string filePath)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                string lowerCaseWord = word.ToLower();

                if (wordFrequency.ContainsKey(lowerCaseWord))
                {
                    wordFrequency[lowerCaseWord]++;
                }
                else
                {
                    wordFrequency[lowerCaseWord] = 1;
                }
            }
        }

        return wordFrequency;
    }

    static void Main(string[] args)
    {
        string filePath = "sample.txt"; // Path to the text file

        Dictionary<string, int> wordFrequency = CountWordFrequency(filePath);

        Console.WriteLine("Word frequencies:");
        foreach (var entry in wordFrequency)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }
}
