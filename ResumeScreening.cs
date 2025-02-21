using System;
using System.Collections.Generic;
public abstract class JobRole
{
    public string Title { get; set; }
    public string RequiredSkills { get; set; }

    protected JobRole(string title, string requiredSkills)
    {
        Title = title;
        RequiredSkills = requiredSkills;
    }

    public abstract void DisplayInfo();
}
public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer(string title, string requiredSkills) 
        : base(title, requiredSkills) { }

    public override void DisplayInfo()
    {
        Console.WriteLine("Software Engineer - Title: " + Title + ", Required Skills: " + RequiredSkills);
    }
}
public class DataScientist : JobRole
{
    public DataScientist(string title, string requiredSkills) 
        : base(title, requiredSkills) { }

    public override void DisplayInfo()
    {
        Console.WriteLine("Data Scientist - Title: " + Title + ", Required Skills: " + RequiredSkills);
    }
}
public class Resume<T> where T : JobRole
{
    public string CandidateName { get; set; }
    public string Skills { get; set; }
    public T JobRole { get; set; }

    public Resume(string candidateName, string skills, T jobRole)
    {
        CandidateName = candidateName;
        Skills = skills;
        JobRole = jobRole;
    }

    public void DisplayResume()
    {
        Console.WriteLine("Candidate Name: " + CandidateName);
        Console.WriteLine("Skills: " + Skills);
        JobRole.DisplayInfo();
    }
}
public class ResumeScreeningSystem
{
    private List<Resume<JobRole>> resumes = new List<Resume<JobRole>>();
    public void AddResume(Resume<JobRole> resume)
    {
        resumes.Add(resume);
        Console.WriteLine(resume.CandidateName + "'s resume added to the screening system.");
    }
    public void DisplayAllResumes()
    {
        Console.WriteLine("All Resumes:");
        foreach (var resume in resumes)
        {
            resume.DisplayResume();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SoftwareEngineer softwareEngineer = new SoftwareEngineer("Software Engineer", "C#, .NET, SQL");
        DataScientist dataScientist = new DataScientist("Data Scientist", "Python, R, Machine Learning");
        Resume<SoftwareEngineer> resume1 = new Resume<SoftwareEngineer>("Alice Johnson", "C#, .NET, SQL", softwareEngineer);
        Resume<DataScientist> resume2 = new Resume<DataScientist>("Bob Smith", "Python, R, Machine Learning", dataScientist);
        ResumeScreeningSystem screeningSystem = new ResumeScreeningSystem();
        screeningSystem.AddResume(resume1);
        screeningSystem.AddResume(resume2);
        screeningSystem.DisplayAllResumes();
    }
}
