using System;
namespace BookDetails2
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
 
		public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Price = 0.0;
            IsAvailable = true;
        }
        public Book(string title, string author, double price, bool isAvailable)
        {
            Title = title;
            Author = author;
            Price = price;
            IsAvailable = isAvailable;
        }
        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"You have successfully borrowed \"{Title}\" by {Author}.");
            }
            else
            {
                Console.WriteLine($"Sorry, \"{Title}\" by {Author} is currently unavailable.");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Availability: " + (IsAvailable ? "Available" : "Unavailable"));
        }
    }
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Some Book", "Vatsal Jain", 2300, true);
            book1.DisplayDetails();
            book1.BorrowBook();
            book1.DisplayDetails();
            book1.BorrowBook();
        }
    }
}
