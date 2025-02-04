using System;
namespace LibraryManagement
{
	class Book
	{
		public static string LibraryName {get; set;} 		
		public readonly string ISBN;
		public string Title {get; set;}
		private string Author {get; set;}

		public Book(string title,string author,string isbn)
		{
			this.Title = title;
			this.Author = author;
			this.ISBN = isbn;
		}
		public static void DisplayLibraryName()
		{
			Console.WriteLine("The name of library is : "+LibraryName);
		}
		public void SetAuthor(string author)
		{
			this.Author = author;
		}
		public string GetAuthor()
		{
			return this.Author;
		}
		public void DisplayDetails()
		{
			if(this is Book)
			{
				Console.WriteLine("Book Details:");
				Console.WriteLine("Library Name: "+LibraryName);
				Console.WriteLine("Title: "+Title);
				Console.WriteLine("Author: "+Author);
				Console.WriteLine("ISBN Number: "+ISBN);
			}
			else
			{
				Console.WriteLine("The object is not a valid object");
			}
		}
	}
	
	class Program
	{
		static void Main()
		{
			Book.LibraryName = "Christopher Library";
			Book book1 = new Book("A song of ice and fire","George R. R. Martion","937-124-826-432");
			Book book2 = new Book("The Blue Umbrella","Abhinn Ahlawatt","959-973-338-200");
			book1.DisplayDetails();
			book2.DisplayDetails();
		}
	}
}	
		
		