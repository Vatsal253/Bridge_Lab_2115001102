using System;
using System.Collections.Generic;
class Program
{
    static List<T> RemoveDuplicates<T>(List<T> list)
    {
        HashSet<T> seen = new HashSet<T>();
        List<T> result = new List<T>();

        foreach (T item in list)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                result.Add(item);
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        List<int> list = new List<int> { 3, 1, 2, 2, 3, 4 };
        List<int> resultList = RemoveDuplicates(list);

        Console.WriteLine("Original List: " + string.Join(", ", list));
        Console.WriteLine("List without duplicates: " + string.Join(", ", resultList));
    }
}
