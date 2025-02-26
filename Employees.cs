using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace Data_Handling
{
    
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    public class Program5
    {
    /*    public static void Main()
        {
            var csvFilePath = "employees.csv";
            var searchName = "Abhinn";
            Employee foundEmployee = null;

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Employee>();
                foreach (var record in records)
                {
                    if (record.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        foundEmployee = record;
                        break;
                    }
                }
            }

            if (foundEmployee != null)
            {
                Console.WriteLine($"Employee found - Department: {foundEmployee.Department}, Salary: {foundEmployee.Salary}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }*/
    }

}
