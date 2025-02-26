using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace Data_Handling
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    public class Program2
    {
     /*   public static void Main()
        {
            var employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Abhinn", Department = "HR", Salary = 50000 },
            new Employee { ID = 2, Name = "Bobby", Department = "Finance", Salary = 60000 },
            new Employee { ID = 3, Name = "Charles", Department = "IT", Salary = 700000 },
            new Employee { ID = 4, Name = "Ross", Department = "Marketing", Salary = 55000 },
            new Employee { ID = 5, Name = "King", Department = "Operations", Salary = 65000 }
        };

            var csvFilePath = "employees.csv";
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(employees);
            }

            Console.WriteLine("CSV file created and records written successfully!");
        }*/
    }

}
