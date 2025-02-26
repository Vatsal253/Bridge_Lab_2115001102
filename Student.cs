using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
namespace Data_Handling
{

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    public class Program4
    {
    /*    public static void Main()
        {
            var csvFilePath = "Student.csv";
            var qualifyingStudents = new List<Student>();

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Student>();
                foreach (var record in records)
                {
                    if (record.Marks > 80)
                    {
                        qualifyingStudents.Add(record);
                    }
                }
            }

            Console.WriteLine("Students who scored more than 80 marks:");
            foreach (var student in qualifyingStudents)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}, Marks: {student.Marks}");
            }
        }*/
    }

}
