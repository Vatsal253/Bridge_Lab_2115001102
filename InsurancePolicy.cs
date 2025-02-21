using System;
using System.Collections.Generic;
public class InsurancePolicy : IComparable<InsurancePolicy>
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public InsurancePolicy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public int CompareTo(InsurancePolicy other)
    {
        return ExpiryDate.CompareTo(other.ExpiryDate);
    }

    public override bool Equals(object obj)
    {
        if (obj is InsurancePolicy other)
        {
            return PolicyNumber == other.PolicyNumber;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public override string ToString()
    {
        return $"PolicyNumber: {PolicyNumber}, CoverageType: {CoverageType}, ExpiryDate: {ExpiryDate.ToShortDateString()}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        HashSet<InsurancePolicy> uniquePolicies = new HashSet<InsurancePolicy>();
        SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>();
        Dictionary<string, InsurancePolicy> policyLookup = new Dictionary<string, InsurancePolicy>();
        AddPolicy(uniquePolicies, sortedPolicies, policyLookup, new InsurancePolicy("P123", "Health", DateTime.Now.AddDays(10)));
        AddPolicy(uniquePolicies, sortedPolicies, policyLookup, new InsurancePolicy("P124", "Car", DateTime.Now.AddDays(20)));
        AddPolicy(uniquePolicies, sortedPolicies, policyLookup, new InsurancePolicy("P125", "Home", DateTime.Now.AddDays(5)));
        AddPolicy(uniquePolicies, sortedPolicies, policyLookup, new InsurancePolicy("P126", "Life", DateTime.Now.AddDays(40)));
        AddPolicy(uniquePolicies, sortedPolicies, policyLookup, new InsurancePolicy("P127", "Travel", DateTime.Now.AddDays(30)));

        Console.WriteLine("All Unique Policies:");
        DisplayPolicies(uniquePolicies);

        Console.WriteLine("\nPolicies Expiring Soon (within the next 30 days):");
        DisplayPolicies(GetExpiringSoonPolicies(sortedPolicies, 30));

        Console.WriteLine("\nPolicies with 'Health' Coverage Type:");
        DisplayPolicies(GetPoliciesByCoverageType(uniquePolicies, "Health"));

        Console.WriteLine("\nDuplicate Policies:");
        DisplayPolicies(GetDuplicatePolicies(uniquePolicies));
    }
    static void AddPolicy(HashSet<InsurancePolicy> uniquePolicies, SortedSet<InsurancePolicy> sortedPolicies,
                          Dictionary<string, InsurancePolicy> policyLookup, InsurancePolicy policy)
    {
        if (uniquePolicies.Add(policy))
        {
            sortedPolicies.Add(policy);
            policyLookup[policy.PolicyNumber] = policy;
        }
    }
    static void DisplayPolicies(IEnumerable<InsurancePolicy> policies)
    {
        foreach (var policy in policies)
        {
            Console.WriteLine(policy);
        }
    }
    static IEnumerable<InsurancePolicy> GetExpiringSoonPolicies(SortedSet<InsurancePolicy> sortedPolicies, int days)
    {
        DateTime now = DateTime.Now;
        DateTime threshold = now.AddDays(days);
        foreach (var policy in sortedPolicies)
        {
            if (policy.ExpiryDate <= threshold)
            {
                yield return policy;
            }
        }
    }
    static IEnumerable<InsurancePolicy> GetPoliciesByCoverageType(HashSet<InsurancePolicy> uniquePolicies, string coverageType)
    {
        foreach (var policy in uniquePolicies)
        {
            if (policy.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase))
            {
                yield return policy;
            }
        }
    }
    static IEnumerable<InsurancePolicy> GetDuplicatePolicies(HashSet<InsurancePolicy> uniquePolicies)
    {
        var policyCounts = new Dictionary<string, int>();
        foreach (var policy in uniquePolicies)
        {
            if (!policyCounts.ContainsKey(policy.PolicyNumber))
            {
                policyCounts[policy.PolicyNumber] = 0;
            }
            policyCounts[policy.PolicyNumber]++;
        }

        foreach (var policy in uniquePolicies)
        {
            if (policyCounts[policy.PolicyNumber] > 1)
            {
                yield return policy;
            }
        }
    }
}
