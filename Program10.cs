using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
namespace Data_Handling
{
    public class Student3
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Student2
    {
        public int ID { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
    }

    public class MergedStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
    }

    public class Program10
    {
       /* public static void Main()
        {
            var students1FilePath = "Student.csv";
            var students2FilePath = "Student2.csv";
            var mergedCsvFilePath = "merged_students.csv";
            var students1 = new List<Student1>();
            var students2 = new List<Student2>();

            // Read the first CSV file
            using (var reader = new StreamReader(students1FilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                students1 = csv.GetRecords<Student1>().ToList();
            }
            using (var reader = new StreamReader(students2FilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                students2 = csv.GetRecords<Student2>().ToList();
            }
            var mergedStudents = (from s1 in students1
                                  join s2 in students2 on s1.ID equals s2.ID
                                  select new MergedStudent
                                  {
                                      ID = s1.ID,
                                      Name = s1.Name,
                                      Age = s1.Age,
                                      Marks = s2.Marks,
                                      Grade = s2.Grade
                                  }).ToList();

            using (var writer = new StreamWriter(mergedCsvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(mergedStudents);
            }

            Console.WriteLine("Merged CSV file created successfully!");
        }*/
    }

}
