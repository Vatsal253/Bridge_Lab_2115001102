using System;
namespace LongestWord
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            string longestWord = "";
            int longestLength = 0;
            string[] words = IntoWords(sentence);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestLength)
                {
                    longestWord = words[i];
                    longestLength = words[i].Length;
                }
            }
            Console.WriteLine("The longest word is: " + longestWord);
        }

        static string[] IntoWords(string sentence)
        {
            string[] words = new string[sentence.Length];
            int wIndex = 0;
            string currentWord = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    if (currentWord != "")
                    {
                        words[wIndex++] = currentWord;
                        currentWord = "";
                    }
                }
                else
                {
                    currentWord += sentence[i];
                }
            }
            if (currentWord != "")
            {
                words[wIndex++] = currentWord;
            }
            string[] result = new string[wIndex];
            for (int i = 0; i < wIndex; i++)
            {
                result[i] = words[i];
            }
				return result;
        }
    }
}
