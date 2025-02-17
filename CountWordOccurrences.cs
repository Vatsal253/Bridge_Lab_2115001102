using System;
using System.IO;
class Program
{
    static int CountWordOccurrences(string filePath, string word)
    {
        int count = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string w in words)
                    {
                        if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        return count;
    }

    static void Main(string[] args)
    {
        string filePath = "example.txt";
        string word = "specific"; 

        int occurrences = CountWordOccurrences(filePath, word);

        Console.WriteLine("The word" +word " appears "+occurrences" times in the file.");
    }
}
