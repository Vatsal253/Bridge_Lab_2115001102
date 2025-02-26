using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace Data_Handling
{
    class Program13
    {
        /*static void Main()
        {
            string connectionString = "your_connection_string";
            string csvFilePath = "employees.csv";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        using (var writer = new StreamWriter(csvFilePath))
                        {
                            // Write CSV headers
                            writer.WriteLine("Employee ID,Name,Department,Salary");

                            // Write records to CSV
                            while (reader.Read())
                            {
                                writer.WriteLine($"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}");
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"CSV report generated at: {csvFilePath}");
        }*/
    }
    
}
