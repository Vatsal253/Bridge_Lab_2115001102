using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

namespace Data_Handling
{
    
    class Program14
    {
        /*static void Main()
        {
            string jsonFilePath = "students.json";
            string csvFilePath = "students.csv";

            var jsonData = File.ReadAllText(jsonFilePath);

            var students = JsonConvert.DeserializeObject<List<Student>>(jsonData);
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(students);
            }

            Console.WriteLine($"CSV file generated at: {csvFilePath}");
        }*/
    }
    public class Student8
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }
    }

}
