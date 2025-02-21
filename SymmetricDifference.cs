using System;
using System.Collections.Generic;
class Program
{
    static HashSet<T> SymmetricDifference<T>(HashSet<T> set1, HashSet<T> set2)
    {
        HashSet<T> symmetricDifference = new HashSet<T>(set1);
        symmetricDifference.SymmetricExceptWith(set2);
        return symmetricDifference;
    }

    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> result = SymmetricDifference(set1, set2);

        Console.WriteLine("Symmetric Difference: " + string.Join(", ", result));
    }
}
