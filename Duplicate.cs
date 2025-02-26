using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Data_Handling
{
    class Program12
    {
      /*  static void Main()
        {
            string csvFilePath = "Student.csv";
            var recordsById = new Dictionary<string, List<string>>();

            using (var reader = new StreamReader(csvFilePath))
            {
                string line;
                var header = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    var columns = line.Split(',');
                    var id = columns[0];

                    if (!recordsById.ContainsKey(id))
                    {
                        recordsById[id] = new List<string>();
                    }

                    recordsById[id].Add(line);
                }
            }
            Console.WriteLine("Duplicate records:");
            foreach (var kvp in recordsById.Where(kvp => kvp.Value.Count > 1))
            {
                foreach (var record in kvp.Value)
                {
                    Console.WriteLine(record);
                }
            }
        }*/
    }
}
