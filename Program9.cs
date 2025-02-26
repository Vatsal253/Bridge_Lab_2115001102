using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
namespace Data_Handling
{
    public class Student7
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}";
        }
    }

    public class Program
    {
       /* public static void Main()
        {
            var csvFilePath = "Student.csv";
            var students = new List<Student>();
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                students = csv.GetRecords<Student>().ToList();
            }
            Console.WriteLine("Student records:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }*/
    }
}

    


