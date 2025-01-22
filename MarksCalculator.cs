using System;
namespace MarksCalculator
	{
	class Program
	{
	static void Main()
	{
		int mathsMarks = 94;
		int physicsMarks = 95;
		int chemistryMarks = 96;
		int totalMarks = mathsMarks + physicsMarks + chemistryMarks;
		int totalSubjects = 3;
		double averageMarks = (double)totalMarks/totalSubjects;
		Console.WriteLine("Sam's average mark in PCM is "+averageMarks);
	}
	}
	}