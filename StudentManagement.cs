using System;
namespace StudentManagement
{
	class Student
	{
		public static string UniversityName {get; set;}
		private static int totalStudents = 0;
		public string Name {get; set;}
		public readonly int RollNumber;
		private string Grade {get; set;}
	
		public Student(int rollnumber , string name , string grade)
		{
			this.RollNumber = rollnumber;
			this.Name = name;
			this.Grade = grade;
			totalStudents++;
		}
		public static void GetTotalStudents()
		{
			Console.WriteLine("The total number of students are: "+totalStudents);
		}
		public static void DisplayUniversityName()
		{
			Console.WriteLine("University Name: "+UniversityName);
		}
		public void SetGrade(string grade)
		{
			this.Grade = grade;
		}
		public string GetGrade()
		{
			return this.Grade;
		}
		public void DisplayDetails()
		{
			if(this is Student)
			{
				Console.WriteLine("Student Name: "+Name);
				Console.WriteLine("Roll Number: "+RollNumber);
				Console.WriteLine("Grade: "+Grade);
			}
			else
			{
				Console.WriteLine("Invalid Input");
			}
		}
	}
	public class Program
	{
		static void Main()
		{
			Student.UniversityName = "GLA University";
			Student.DisplayUniversityName();
			Student student1 = new Student( 2115001102, "Vatsal" , "A+");
			Student student2 = new Student( 2115100002,"Abhinn", "C");
			student1.DisplayDetails();
			Student.DisplayUniversityName();
			student2.DisplayDetails();
			Student.GetTotalStudents();
		}
	}
}
		