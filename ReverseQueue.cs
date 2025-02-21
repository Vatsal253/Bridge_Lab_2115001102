using System;
using System.Collections.Generic;
class Program
{
    static Queue<T> ReverseQueue<T>(Queue<T> queue)
    {
        if (queue.Count == 0)
        {
            return queue;
        }
        T front = queue.Dequeue();
        queue = ReverseQueue(queue);
        queue.Enqueue(front);

        return queue;
    }

    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
        Queue<int> reversedQueue = ReverseQueue(queue);

        Console.WriteLine("Original Queue: " + string.Join(", ", new[] { 1, 2, 3, 4, 5 }));
        Console.WriteLine("Reversed Queue: " + string.Join(", ", reversedQueue));
    }
}
