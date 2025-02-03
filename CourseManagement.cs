using System;
namespace CourseManagement
{
    class Course
    {
        public string CourseName { get; set; }
        public int Duration { get; set; } 
        public double Fee { get; set; }

        public static string InstituteName { get; private set; } = "Default Institute";
        public Course(string courseName, int duration, double fee)
        {
            CourseName = courseName;
            Duration = duration;
            Fee = fee;
        }
        public void DisplayCourseDetails()
        {
            Console.WriteLine("Course Details:");
            Console.WriteLine("Institute Name: " + InstituteName);
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Duration: " + Duration + " weeks");
            Console.WriteLine("Fee: " + Fee);
        }
        public static void UpdateInstituteName(string newInstituteName)
        {
            InstituteName = newInstituteName;
        }
    }

    class Program
    {
        static void Main()
        {
            Course.UpdateInstituteName("GLA University");
            Course course1 = new Course("C# Programming", 6,10,000);
            Course course2 = new Course("Web Development", 12, 12,000);
            course1.DisplayCourseDetails();
            course2.DisplayCourseDetails();
        }
    }
}
