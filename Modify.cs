using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
namespace Data_Handling
{


    public class Employee4
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    public class Program6
    {
        /*public static void Main()
        {
            var csvFilePath = "employees.csv";
            var updatedCsvFilePath = "updated_employees.csv";
            var employees = new List<Employee>();

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                employees = csv.GetRecords<Employee>().ToList();
                foreach (var employee in employees)
                {
                    if (employee.Department == "IT")
                    {
                        employee.Salary *= 1.10m; 
                    }
                }
            }

            using (var writer = new StreamWriter(updatedCsvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(employees);
            }

            Console.WriteLine("Salaries updated and saved to new CSV file successfully!");
        }*/
    }

}
