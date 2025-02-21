using System;
using System.Collections.Generic;
class Program
{
    static T FindNthFromEnd<T>(LinkedList<T> list, int n)
    {
        if (n <= 0)
        {
            throw new ArgumentOutOfRangeException("n", "n should be greater than 0.");
        }

        LinkedListNode<T> mainPtr = list.First;
        LinkedListNode<T> refPtr = list.First;
        for (int i = 0; i < n; i++)
        {
            if (refPtr == null)
            {
                throw new ArgumentOutOfRangeException("n", "n is greater than the number of elements in the list.");
            }
            refPtr = refPtr.Next;
        }
        while (refPtr != null)
        {
            mainPtr = mainPtr.Next;
            refPtr = refPtr.Next;
        }

        if (mainPtr == null)
        {
            throw new InvalidOperationException("The list is empty.");
        }

        return mainPtr.Value;
    }

    static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>(new[] { 1, 2, 3, 4, 5 });
        int n = 2;

        try
        {
            int nthElement = FindNthFromEnd(list, n);
            Console.WriteLine("The " + n + "th element from the end is: " + nthElement);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
