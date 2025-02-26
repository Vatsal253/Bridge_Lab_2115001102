using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

public class Program
{
  /*  public static void Main()
    {
        var csvFilePath = "Student.csv";
        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Student>();
            foreach (var record in records)
            {
                Console.WriteLine($"ID: {record.ID}, Name: {record.Name}, Age: {record.Age}, Marks: {record.Marks}");
            }
        }
    }*/
}
