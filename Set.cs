using System;
using System.Collections.Generic;
class Program
{
    static HashSet<T> Union<T>(HashSet<T> set1, HashSet<T> set2)
    {
        HashSet<T> unionSet = new HashSet<T>(set1);
        unionSet.UnionWith(set2);
        return unionSet;
    }

    static HashSet<T> Intersection<T>(HashSet<T> set1, HashSet<T> set2)
    {
        HashSet<T> intersectionSet = new HashSet<T>(set1);
        intersectionSet.IntersectWith(set2);
        return intersectionSet;
    }

    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> unionSet = Union(set1, set2);
        HashSet<int> intersectionSet = Intersection(set1, set2);

        Console.WriteLine("Union: " + string.Join(", ", unionSet));
        Console.WriteLine("Intersection: " + string.Join(", ", intersectionSet));
    }
}
