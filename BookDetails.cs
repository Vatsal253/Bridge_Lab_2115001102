using System;
namespace BookDetails
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

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
            Book obj = new Book();
            obj.Title = "Bridge to Terabithia ";
            obj.Author = "Katherine Paterson" ;
            obj.Price = 1691.00;
            obj.DisplayDetails();
        }
    }
}
