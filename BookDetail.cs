using System;
namespace BookDetail
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Price = 0.0;
        }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Price: " + Price);
        }
    }
    class Program
    {
        static void Main()
        {
            Book defaultBook = new Book();
            defaultBook.DisplayDetails();
            Book parameterizedBook = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99);
            parameterizedBook.DisplayDetails();
        }
    }
}
