using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
namespace Data_Handling
{
    public class Employee5
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    public class Program7
    {
        /*public static void Main()
        {
            var csvFilePath = "employees.csv";
            var employees = new List<Employee>();

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                employees = csv.GetRecords<Employee>().ToList();
            }
            var topPaidEmployees = employees.OrderByDescending(emp => emp.Salary).Take(5).ToList();

            Console.WriteLine("Top 5 highest-paid employees:");
            foreach (var employee in topPaidEmployees)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
            }
        }*/
    }

}
