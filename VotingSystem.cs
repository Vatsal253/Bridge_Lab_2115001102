using System;
using System.Collections.Generic;
public class VotingSystem
{
    private Dictionary<string, int> voteCounts = new Dictionary<string, int>();
    private SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>();
    private List<string> voteOrder = new List<string>();
    public void CastVote(string candidate)
    {
        if (voteCounts.ContainsKey(candidate))
        {
            voteCounts[candidate]++;
        }
        else
        {
            voteCounts[candidate] = 1;
        }
        voteOrder.Add(candidate);
    }
    public void DisplayUniqueVotes()
    {
        Console.WriteLine("Unique Votes:");
        foreach (var kvp in voteCounts)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
    }
    public void DisplayResultsInOrder()
    {
        sortedResults = new SortedDictionary<string, int>(voteCounts);

        Console.WriteLine("Results in Order:");
        foreach (var kvp in sortedResults)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
    }
    public void DisplayVoteOrder()
    {
        Console.WriteLine("Order of Votes:");
        foreach (var candidate in voteOrder)
        {
            Console.WriteLine(candidate);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        VotingSystem votingSystem = new VotingSystem();
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Charlie");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");
        votingSystem.DisplayUniqueVotes();
        votingSystem.DisplayResultsInOrder();
        votingSystem.DisplayVoteOrder();
    }
}
