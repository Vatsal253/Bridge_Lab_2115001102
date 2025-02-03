using System;
namespace LibraryManagementSystem
{
    class Book
    {
        protected string Title { get; set; }
        private string Author { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public void SetAuthor(string author)
        {
            Author = author;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
        }
    }
    class EBook : Book
    {
        public string ISBN { get; set; }
        public EBook(string title, string author, string isbn)
            : base(title, author)
        {
            ISBN = isbn;
        }
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("ISBN: " + ISBN);
        }
    }
    class Program
    {
        static void Main()
        {
            Book book = new Book("Ek Novel", "Vatsal");
            book.DisplayDetails();
            book.SetAuthor("Jain");
            Console.WriteLine("Updated Author: " + book.GetAuthor());
            EBook ebook = new EBook("2023", "Rishu Jain", "687-454-663");
            ebook.DisplayDetails();
        }
    }
}
