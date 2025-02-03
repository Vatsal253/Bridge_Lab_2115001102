using System;
namespace EmployeeDetails
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
        }
    }
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.Name = "Vatsal";
            emp.Id = 1102;
            emp.Salary = 100000.00;
            emp.DisplayDetails();
        }
    }
}
