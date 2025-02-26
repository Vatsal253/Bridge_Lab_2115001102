using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
namespace Data_Handling
{


    public class Student1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    public class Program3
    {
       /* public static void Main()
        {
            var csvFilePath = "Student.csv";
            int recordCount = 0;

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Student>();
                foreach (var record in records)
                {
                    recordCount++;
                }
            }

            Console.WriteLine($"Number of records (excluding header): {recordCount}");
        }*/
    }

}
