using System;
using System.Collections.Generic;
using System.Collections;
class Patient
{
    public string Name { get; set; }
    public int Severity { get; set; }

    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }

    public override string ToString()
    {
        return Name + " (Severity: " + Severity + ")";
    }
}

class Program
{
    static void Main(string[] args)
    {
        PriorityQueue<Patient, int> triageQueue = new PriorityQueue<Patient, int>();
        triageQueue.Enqueue(new Patient("Alice", 2), 2);
        triageQueue.Enqueue(new Patient("Bob", 5), 5);
        triageQueue.Enqueue(new Patient("Charlie", 1), 1);
        triageQueue.Enqueue(new Patient("Dave", 4), 4);
        triageQueue.Enqueue(new Patient("Eve", 3), 3);

        Console.WriteLine("Patients are being treated in the order of severity:");
        while (triageQueue.Count > 0)
        {
            Patient patient = triageQueue.Dequeue();
            Console.WriteLine("Treating patient: " + patient);
        }
    }
}
