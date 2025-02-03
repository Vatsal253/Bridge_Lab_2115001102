using System;
namespace EmployeeRecords
{
    class Employee
    {
        public int EmployeeID { get; set; }
        protected string Department { get; set; }
        private double Salary { get; set; }
        public Employee(int employeeID, string department, double salary)
        {
            EmployeeID = employeeID;
            Department = department;
            Salary = salary;
        }
        public double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double salary)
        {
            if (salary >= 0)
            {
                Salary = salary;
            }
            else
            {
                Console.WriteLine("Invalid salary. Please enter a non-negative value.");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Salary: " + Salary);
        }
    }
    class Manager : Employee
    {
        public string ManagerLevel { get; set; }
        public Manager(int employeeID, string department, double salary, string managerLevel)
            : base(employeeID, department, salary)
        {
            ManagerLevel = managerLevel;
        }
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Manager Level: " + ManagerLevel);
        }
    }
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee(110, "IT", 500000.0);
            employee.DisplayDetails();
            employee.SetSalary(550000.0);
            Console.WriteLine("Updated Salary: " + employee.GetSalary());
            Manager manager = new Manager(119, "HR", 700000.0, "Senior Manager");
            manager.DisplayDetails();
        }
    }
}
