using System;
namespace UniversityManagementSystem
{
    class Student
    {
        public int RollNumber { get; set; }
        protected string Name { get; set; }
        private double CGPA { get; set; }
        public Student(int rollNumber, string name, double cgpa)
        {
            RollNumber = rollNumber;
            Name = name;
            CGPA = cgpa;
        }
        public double GetCGPA()
        {
            return CGPA;
        }
        public void SetCGPA(double cgpa)
        {
            if (cgpa >= 0.0 && cgpa <= 10.0)
            {
                CGPA = cgpa;
            }
            else
            {
                Console.WriteLine("Invalid CGPA. Please enter a value between 0.0 and 10.0.");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("CGPA: " + CGPA);
        }
    }
    class PostgraduateStudent : Student
    {
        public string ResearchTopic { get; set; }
        public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic)
            : base(rollNumber, name, cgpa)
        {
            ResearchTopic = researchTopic;
        }
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Research Topic: " + ResearchTopic);
        }
    }
    class Program
    {
        static void Main()
        {
            Student student = new Student(1102, "Vatsal", 8.0);
            student.DisplayDetails();
            student.SetCGPA(9.0);
            Console.WriteLine("Updated CGPA: " + student.GetCGPA());
            PostgraduateStudent pgStudent = new PostgraduateStudent(1103, "Koi", 9.2, "Data Science");
            pgStudent.DisplayDetails();
        }
    }
}
