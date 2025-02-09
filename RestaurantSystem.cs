using System;
namespace RestaurantSystem
{
    interface Worker
    {
        void PerformDuties();
    }

    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
        }
    }

    class Chef : Person, Worker
    {
        public Chef(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Cooking and preparing dishes.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Chef");
        }
    }

    class Waiter : Person, Worker
    {
        public Waiter(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Serving food and attending to customers.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Waiter");
        }
    }

    class Program
    {
        static void Main()
        {
            Worker chef = new Chef("Sanjeev", 001);
            Worker waiter = new Waiter("Abhinn", 002);
            chef.PerformDuties();
			Console.WriteLine();
            Person personChef = (Person)chef;			
            Person personWaiter = (Person)waiter;			
            personChef.DisplayInfo();
			chef.PerformDuties();
            Console.WriteLine();
            personWaiter.DisplayInfo();
			waiter.PerformDuties();
        }		
    }
}
