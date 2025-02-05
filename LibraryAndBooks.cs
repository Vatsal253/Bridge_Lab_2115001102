using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibraryAndBooks
{
    internal class Book2
    {
        //Attributes
        public string title;
        public string author;

        //Constructor
        public Book2(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        //Display book details
        public void DisplayBook()
        {
            Console.WriteLine("The title of the book is " + title);
            Console.WriteLine("The author of the book is " + author);
        }
    }
    internal class Library1
    {
        public string LibraryName;
        private List<Book2> books;
        private int length;

        //Constructor
        public Library1(string LibraryName)
        {
            this.LibraryName = LibraryName;
            books = new List<Book2>();  //creation of list
        }

        //method to add books to the library
        public void addBooks(Book2 book)
        {
            books.Add(book);
            Console.WriteLine(book + "has been added to" + LibraryName + "library!");
            length++;
        }

        //displaying the books in a library
        public void displayBooks()
        {
            Console.WriteLine("The book in the " + LibraryName + " Library are ");
            for (int i = 0; i < length; i++)
            {
                books[i].DisplayBook();
            }
        }
    }

    class program22
    {
        public static void Main(String[] args)
        {
            Library1 library1 = new Library1("Knowledge"); // creating an instance of the Library1 class
            Library1 library2 = new Library1("Wisdom");  // creating second instance of the Library1 class

            Book2 book1 = new Book2("The tale of a bird", "Abhinn");
            Book2 book2 = new Book2("Fight for Freedom", "Rajat");

            library1.addBooks(book1); 
            library2.addBooks(book2);

            library1.displayBooks();
            library2.displayBooks();
        }
    }
}