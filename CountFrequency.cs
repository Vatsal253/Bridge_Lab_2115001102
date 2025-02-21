using System;
using System.Collections.Generic;
class Program
{
    static Dictionary<string, int> CountFrequency(List<string> list)
    {
        Dictionary<string, int> frequencyDict = new Dictionary<string, int>();

        foreach (string item in list)
        {
            if (frequencyDict.ContainsKey(item))
            {
                frequencyDict[item]++;
            }
            else
            {
                frequencyDict[item] = 1;
            }
        }

        return frequencyDict;
    }

    static void Main(string[] args)
    {
        List<string> list = new List<string> { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> frequencyDict = CountFrequency(list);

        Console.WriteLine("Element frequencies:");
        foreach (var entry in frequencyDict)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }
}
