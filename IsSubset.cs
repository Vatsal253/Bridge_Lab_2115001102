using System;
using System.Collections.Generic;
class Program
{
    static bool IsSubset<T>(HashSet<T> set1, HashSet<T> set2)
    {
        return set1.IsSubsetOf(set2);
    }

    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5 };

        bool result = IsSubset(set1, set2);

        Console.WriteLine("Is set1 a subset of set2? " + result);
    }
}
