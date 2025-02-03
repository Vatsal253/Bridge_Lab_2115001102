using System;
namespace PersonDetails
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Address = "Unknown";
        }
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
            Address = other.Address;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Person Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Vatsal", 30, "Gla university");
            person1.DisplayDetails();
            Person person2 = new Person(person1);
            person2.DisplayDetails();
        }
    }
}
