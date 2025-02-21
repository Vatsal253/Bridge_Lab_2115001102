using System;
using System.Collections.Generic;
class Program
{
    static bool AreSetsEqual<T>(HashSet<T> set1, HashSet<T> set2)
    {
        return set1.SetEquals(set2);
    }

    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

        bool result = AreSetsEqual(set1, set2);

        Console.WriteLine("Are the sets equal? " + result);
    }
}
