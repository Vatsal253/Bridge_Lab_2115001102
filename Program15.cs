using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using CsvHelper;
namespace Data_Handling
{
    class Program
    {
        static void Main()
        {
            string csvFilePath = "employees_encrypted.csv";
            string encryptionKey = "your_encryption_key"; // Ensure this is a secure key

            // Sample employee data
            var employees = new List<Employee>
        {
            new Employee { EmployeeID = 1, Name = "John Doe", Department = "HR", Salary = 50000, Email = "john.doe@example.com" },
            new Employee { EmployeeID = 2, Name = "Jane Smith", Department = "IT", Salary = 60000, Email = "jane.smith@example.com" }
        };

            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<Employee>();
                csv.NextRecord();

                foreach (var employee in employees)
                {
                    employee.Salary = Encrypt(employee.Salary.ToString(), encryptionKey);
                    employee.Email = Encrypt(employee.Email, encryptionKey);
                    csv.WriteRecord(employee);
                    csv.NextRecord();
                }
            }

            Console.WriteLine($"Encrypted CSV file generated at: {csvFilePath}");
        }

        static string Encrypt(string plainText, string key)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Salary { get; set; }
        public string Email { get; set; }
    }

}
