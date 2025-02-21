using System;
using System.Collections.Generic;
class Program
{
    static List<T> RotateList<T>(List<T> list, int positions)
    {
        int n = list.Count;
        List<T> rotatedList = new List<T>(new T[n]);

        for (int i = 0; i < n; i++)
        {
            rotatedList[(i + n - positions) % n] = list[i];
        }

        return rotatedList;
    }

    static void Main(string[] args)
    {
        List<int> list = new List<int> { 10, 20, 30, 40, 50 };
        int rotateBy = 2;

        List<int> rotatedList = RotateList(list, rotateBy);

        Console.WriteLine("Original List: " + string.Join(", ", list));
        Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
    }
}
