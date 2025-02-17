using System;
class Program
{
    static string FindFirstSentenceContainingWord(string[] sentences, string word)
    {
        foreach (string sentence in sentences)
        {
            if (sentence.Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                return sentence;
            }
        }
        return null; // or return "No sentence contains the word."
    }
    static void Main(string[] args)
    {
        string[] sentences = {
            "The quick brown fox jumps over the lazy dog.",
            "Hello world!",
            "This is a test sentence.",
            "The weather is nice today.",
            "Have a great day!"
        };
        string word = "weather";

        string result = FindFirstSentenceContainingWord(sentences, word);

        if (result != null)
        {
            Console.WriteLine("The first sentence containing the word '" + word + "' is: " + result);
        }
        else
        {
            Console.WriteLine("No sentence contains the word '" + word + "'.");
        }
    }
}
