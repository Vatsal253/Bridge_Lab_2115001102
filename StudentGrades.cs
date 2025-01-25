using System;
namespace StudentGrades
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of students:");
            int numberOfStudents = int.Parse(Console.ReadLine());

            int[,] marks = new int[numberOfStudents, 3];
            double[] percentages = new double[numberOfStudents];
            string[] grades = new string[numberOfStudents];
            string[] remarks = new string[numberOfStudents];

            // Taking input for marks of students in physics, chemistry, and maths
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Enter the marks of student " + (i + 1) + " in Physics:");
                marks[i, 0] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the marks of student " + (i + 1) + " in Chemistry:");
                marks[i, 1] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the marks of student " + (i + 1) + " in Maths:");
                marks[i, 2] = int.Parse(Console.ReadLine());

                if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
                {
                    Console.WriteLine("Invalid input. Please enter positive values.");
                    i--;
                }
            }

            // Calculating percentages, grades, and remarks
            for (int i = 0; i < numberOfStudents; i++)
            {
                int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
                percentages[i] = (double)totalMarks / 3;

                if (percentages[i] >= 80)
                {
                    grades[i] = "A";
                    remarks[i] = "Level 4, above agency-normalized standards";
                }
                else if (percentages[i] >= 70)
                {
                    grades[i] = "B";
                    remarks[i] = "Level 3, at agency-normalized standards ";
                }
                else if (percentages[i] >= 60)
                {
                    grades[i] = "C";
                    remarks[i] = "Level 2, below,but approaching agency-normalized standards";
                }
                else if (percentages[i] >= 50)
                {
                    grades[i] = "D";
                    remarks[i] = "Level 1, well below agency-normalized standards";
                }
                else if(percentages[i] >=40)
                {
                    grades[i] = "E";
                    remarks[i] = "Level 1, too below agency-normalized standards";
                }
				else
				{
					grades[i] = "R";
					remarks[i] = "Remedial Standards";
				}
            }

            // Displaying the results
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ":");
                Console.WriteLine("Physics: " + marks[i, 0]);
                Console.WriteLine("Chemistry: " + marks[i, 1]);
                Console.WriteLine("Maths: " + marks[i, 2]);
                Console.WriteLine("Percentage: " + percentages[i] + "%");
                Console.WriteLine("Grade: " + grades[i]);
                Console.WriteLine("Remarks: " + remarks[i]);
                Console.WriteLine();
            }
        }
    }
}
