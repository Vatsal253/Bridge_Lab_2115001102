using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<V, List<K>> InvertMap<K, V>(Dictionary<K, V> map)
    {
        Dictionary<V, List<K>> invertedMap = new Dictionary<V, List<K>>();

        foreach (var kvp in map)
        {
            if (!invertedMap.ContainsKey(kvp.Value))
            {
                invertedMap[kvp.Value] = new List<K>();
            }
            invertedMap[kvp.Value].Add(kvp.Key);
        }

        return invertedMap;
    }

    static void Main(string[] args)
    {
        Dictionary<string, int> map = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        Dictionary<int, List<string>> invertedMap = InvertMap(map);

        Console.WriteLine("Inverted Map:");
        foreach (var kvp in invertedMap)
        {
            Console.WriteLine(kvp.Key + ": [" + string.Join(", ", kvp.Value) + "]");
        }
    }
}
